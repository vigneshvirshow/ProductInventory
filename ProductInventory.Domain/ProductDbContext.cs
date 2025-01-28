using Microsoft.EntityFrameworkCore;
using ProductInventory.Domain.Entities;
using System.Reflection.Emit;

namespace ProductInventory.Domain
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
            .HasKey(p => p.Id);

            modelBuilder.Entity<Product>()
            .HasOne(p => p.Variant)
            .WithMany()
            .HasForeignKey(p => p.VariantId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
            .HasOne(p => p.User)
            .WithMany()
            .HasForeignKey(p => p.CreatedUser)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Variant>()
            .HasOne(p => p.SubVariant)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Variant> Variants { get; set; }
        public DbSet<SubVariant> SubVariants { get; set; }
    }
}
