using CountriesCities.API.AutoMapperProfiles;
using CountriesCities.API.Data;
using CountriesCities.API.Interfaces;
using CountriesCities.API.Repositories;
using CountriesCities.API.Services;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(policy =>
{
    policy.AddPolicy("BlazorClientPolicy", opt => opt
            // .AllowAnyOrigin()
            .WithOrigins("https://localhost:7214") // ваш https на клиенте!!!
        .AllowAnyHeader()
        .AllowAnyMethod());
});

builder.Services.AddScoped<ICityService, CityService>();
builder.Services.AddScoped<ICityRepository, CityRepository>();

builder.Services.AddScoped<ICountryService, CountryService>();
builder.Services.AddScoped<ICountryRepository, CountryRepository>();

builder.Services.AddAutoMapper(
    typeof(CityProfile),
    typeof(CountryProfile));
builder.Services.AddControllers()
                .AddJsonOptions(options =>
                {
                    //options.JsonSerializerOptions.ReferenceHandler
                    //= ReferenceHandler.IgnoreCycles;
                });
builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseSqlServer(
        builder.Configuration
        .GetConnectionString("DefaultConnection") ??
        throw new InvalidOperationException("Connection string 'DefaultConnection' not found.")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
using (IServiceScope scope = app.Services.CreateScope())
{
    IServiceProvider services = scope.ServiceProvider;
    await DbInitializer.Initialize(services);
}

app.UseHttpsRedirection();
app.UseCors("BlazorClientPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
