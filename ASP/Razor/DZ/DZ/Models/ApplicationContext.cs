namespace DZ.Models
{
    using Azure;
    using Microsoft.EntityFrameworkCore;

    namespace RazorPagesApp.Models
    {
        public class ApplicationContext : DbContext
        {
            public DbSet<News> News { get; set; } = null!;
            public DbSet<Comment> Comments { get; set; }
            public ApplicationContext(DbContextOptions<ApplicationContext> options)
                : base(options)
            {
                Database.EnsureCreated();   // создаем базу данных при первом обращении
            }
        }
    }
}
