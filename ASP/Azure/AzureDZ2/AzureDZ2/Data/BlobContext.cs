using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AzureDZ2.Models;

    public class BlobContext : DbContext
    {
        public BlobContext (DbContextOptions<BlobContext> options)
            : base(options)
        {
        Database.EnsureCreated();
        }

        public DbSet<Blob> Blobs { get; set; } = default!;
    }
