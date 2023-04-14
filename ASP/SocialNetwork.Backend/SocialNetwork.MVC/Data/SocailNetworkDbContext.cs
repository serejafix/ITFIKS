using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SocialNetwork.MVC.Data.EntityModels;
using System.Reflection.Metadata;

namespace SocialNetwork.MVC.Data
{
    public class SocailNetworkDbContext : IdentityDbContext<User>
    {
        public SocailNetworkDbContext(DbContextOptions<SocailNetworkDbContext> options)
            : base(options) { Database.EnsureCreated(); }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Like> Likes { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>()
        //        .Property(b => b.RegistrationDate)
        //        .HasDefaultValueSql("getdate()");
        //}
    }
}
