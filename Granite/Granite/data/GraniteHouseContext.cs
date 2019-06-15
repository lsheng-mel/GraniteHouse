using System;
using Granite.Models;
using Microsoft.EntityFrameworkCore;

namespace Granite.data
{
    public class GraniteHouseContext : DbContext
    {
        public GraniteHouseContext(DbContextOptions<GraniteHouseContext> options) : base(options)
        {
        }

        public DbSet<ProductType> ProductTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductType>().ToTable("ProductType");
        }
    }
}
