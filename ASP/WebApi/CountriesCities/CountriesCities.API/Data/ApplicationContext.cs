using CountriesCities.API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CountriesCities.API.Data
{
        public class ApplicationContext : DbContext
        {
            public ApplicationContext(DbContextOptions<ApplicationContext> options)
                : base(options)
            { }

            public DbSet<Country> Countries => Set<Country>();
            public DbSet<City> Cities => Set<City>();
        }
}
