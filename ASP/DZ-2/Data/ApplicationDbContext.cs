using DZ_2.Models.Cinema;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Films> Films { get; set; }
        public DbSet<Sessions> Sessions { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        internal Task GetFilmsByTitle(string v)
        {
            throw new NotImplementedException();
        }
    }
}
