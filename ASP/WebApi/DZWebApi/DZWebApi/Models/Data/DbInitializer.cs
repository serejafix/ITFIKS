namespace DZWebApi.Models.Data
{
    public static class DbInitializer
    {
        public static void Initialize(CarsDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Cars.Any())
            {
                return;
            }
            var cars = new Car[]
            {
            new Car{Name="bmw",Model="S",DataCreate=DateTime.Now,Color="green",Price= 20.100},
            new Car{Name="mercedec",Model="S",DataCreate=DateTime.Now,Color="yellow",Price= 20.100},
            new Car{Name="gazel",Model="S",DataCreate=DateTime.Now,Color="red",Price= 20.100},
            new Car{Name="rafik",Model="S",DataCreate=DateTime.Now,Color="white",Price= 30.100},
            new Car{Name="bmw",Model="S",DataCreate=DateTime.Now,Color="green",Price= 40.100},
            new Car{Name="bmw",Model="S",DataCreate=DateTime.Now,Color="green",Price= 50.100},
            new Car{Name="bmw",Model="S",DataCreate=DateTime.Now,Color="green",Price= 40.100},
            new Car{Name="bmw",Model="S",DataCreate=DateTime.Now,Color="green",Price= 50.100}
            };
            foreach (var car in cars)
            {
                context.Cars.Add(car);
            }
            context.SaveChanges();
        }
    }
}
