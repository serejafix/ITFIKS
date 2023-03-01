using Microsoft.EntityFrameworkCore;
using DZ_5.ViewModels;

namespace DZ_5.Models
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { Database.EnsureCreated(); } 
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Tag> Tag { get; set; }
        //public DbSet<DZ_5.ViewModels.BookViewModel> BookViewModel { get; set; }
    }
}
