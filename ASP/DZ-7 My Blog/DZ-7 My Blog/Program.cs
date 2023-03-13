using Blog.Authorization;
using Blog.Models;
using Blog.Services.EmailService;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddTransient<IEmailService, EmailService>();
builder.Services.AddIdentity<User, IdentityRole>((IdentityOptions options) =>
{
    options.User.RequireUniqueEmail= true;
    options.Password.RequiredLength = 1;
    options.Password.RequireNonAlphanumeric= false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireDigit = false;
}).AddEntityFrameworkStores<AppDbContext>()
  .AddDefaultTokenProviders();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy(
       MyPolicies.PostWriterAndAboveAccess,
       policy => policy.RequireAssertion(context =>
       {
           return context.User.HasClaim(
           claim => claim.Type == MyClaims.SuperAdmin ||
           claim.Type == MyClaims.Admin ||
           claim.Type == MyClaims.PostsWriter);
       }));
    options.AddPolicy(
       MyPolicies.AdminAccessOnly,
       policy => policy.RequireAssertion(context =>
       {
           return context.User.HasClaim(
           claim => claim.Type == MyClaims.SuperAdmin ||
           claim.Type == MyClaims.Admin);
       }));
    options.AddPolicy(
      MyPolicies.SuperAdminAccessOnly,
      policy => policy.RequireAssertion(context =>
      {
          return context.User.HasClaim(
          claim => claim.Type == MyClaims.SuperAdmin);
      }));
});
   

var app = builder.Build();

using (IServiceScope scope = app.Services.CreateScope())
{
    IServiceProvider serviceProvider = scope.ServiceProvider;
    await Seed.Initialize(
        serviceProvider,
        app.Environment,
        app.Configuration);
}
    // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
    }

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
