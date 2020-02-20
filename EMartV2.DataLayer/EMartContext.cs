using EMartV2.Models.ProductModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMartV2.DataLayer
{
    public class EMartContext : DbContext
    {
        public EMartContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Product>().HasKey(pf => pf.Id);
            builder.Entity<Product>().Property(pf => pf.Name).HasMaxLength(100);
        }

        public DbSet<Product> Products { get; set; }
    }
}
