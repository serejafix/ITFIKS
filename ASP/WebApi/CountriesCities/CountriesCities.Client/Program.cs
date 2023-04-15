using CountriesCities.Client;
using CountriesCities.Client.HttpRepositories;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
// Опциональный HttpClient
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});

builder.Services.AddHttpClient("CitiesAPI", client =>
{
    client.BaseAddress = new Uri("https://localhost:7242/api/");
});

// Typed HttpClient
builder.Services.AddHttpClient<ICountryHttpRepository, CountryHttpRepository>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7242/api/");
});

builder.Services.AddScoped<ICityHttpRepository, CityHttpRepository>();

await builder.Build().RunAsync();
