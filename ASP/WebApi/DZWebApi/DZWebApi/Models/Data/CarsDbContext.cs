using Microsoft.EntityFrameworkCore;
using System;

namespace DZWebApi.Models.Data
{
    public class CarsDbContext : DbContext
    {
        public CarsDbContext(DbContextOptions<CarsDbContext> options) : base(options)
        { Database.EnsureCreated(); }

        public DbSet<Car> Cars { get; set; }
    }
}
