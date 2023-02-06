using DZ_3.Services;
using DZ_3.Task2;

var builder = WebApplication.CreateBuilder(args);

//---------------------------------Task 1---------------------------------

//builder.Services.AddTransient<IDrink, Water>();
//builder.Services.AddTransient<IDrink, Coca_Cola>();
//builder.Services.AddTransient<IDrink, Tarhun>();

//---------------------------------Task 2---------------------------------

//builder.Services.AddTransient<IWeapon, FireBall>();
//builder.Services.AddTransient<Warrior>();



var app = builder.Build();

//app.UseMiddleware();
app.Run(async context => {
    var response = context.Response;

    //---------------------------------Task 1---------------------------------

    //response.Headers.ContentLanguage = "ru-Ru";
    //response.Headers.ContentType = "text/plain; charset=utf-8";
    //var drinkService = app.Services.GetService<IDrink>();
    //await response.WriteAsync($"{drinkService?.GetDrink()}");
    //---------------------------------Task 2---------------------------------

    //var Warrior = context.RequestServices.GetService<Warrior>();
    //response.ContentType = "text/html;charset=utf-8";
    //await response.WriteAsync($"<h2>{Warrior?.Print()}</h2>");
});

app.Run();
