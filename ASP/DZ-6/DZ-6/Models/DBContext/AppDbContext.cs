using Microsoft.EntityFrameworkCore;

namespace DZ_6.Models.DBContext
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { Database.EnsureCreated(); }
        public DbSet<Book> Books { get; set; }

        public DbSet<DZ_6.ViewModel.BookViewModel> BookViewModel { get; set; }

    }
}
