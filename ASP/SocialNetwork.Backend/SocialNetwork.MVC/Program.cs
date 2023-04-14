using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.MVC.AutoMapperProfiles;
using SocialNetwork.MVC.Data;
using SocialNetwork.MVC.Data.EntityModels;
using SocialNetwork.MVC.Interfaces;
using SocialNetwork.MVC.Repositories;
using SocialNetwork.MVC.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMapper(
    typeof(UserProfile));
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddControllersWithViews();



string connection = builder.Configuration.GetConnectionString("SocialNetworkContext");
builder.Services.AddDbContext<SocailNetworkDbContext>(options =>
{
    options.UseSqlServer(connection);
});

builder.Services.AddIdentity<User,IdentityRole>()
    .AddEntityFrameworkStores<SocailNetworkDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
//using (IServiceScope scope = app.Services.CreateScope())
//{
//    IServiceProvider service = scope.ServiceProvider;
//    await DbInitializer.Initialize(service);
//}
app.UseRouting();

app.UseAuthorization();
app.UseAuthentication();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
