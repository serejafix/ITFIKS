using Microsoft.EntityFrameworkCore;

namespace TestingEnum.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { Database.EnsureCreated(); }

        public DbSet<MainTest> mainTests { get; set; }

    }
}
