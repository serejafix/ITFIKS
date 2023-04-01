using Azure.Storage.Blobs;
using AzureDZ2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<BlobContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BlobContext") 
    ?? throw new InvalidOperationException("Connection string 'BlobContext' not found.")));

builder.Services.AddScoped<BlobServiceClient>(factory =>
{
    string primaryConnectionString = builder.Configuration.GetSection("Azure:PrimaryConnectionString").Value;
    return new BlobServiceClient(primaryConnectionString);
});
// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
