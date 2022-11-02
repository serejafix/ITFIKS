using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Lan_DBStreetsFromIndex
{
    public partial class ModelDBStrets : DbContext
    {
        public ModelDBStrets()
            : base("name=ModelDBStrets")
        {
        }

        public virtual DbSet<Index> Indexes { get; set; }
        public virtual DbSet<Street> Streets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Index>()
                .HasMany(e => e.Streets)
                .WithRequired(e => e.Index)
                .WillCascadeOnDelete(false);
        }
    }
}
