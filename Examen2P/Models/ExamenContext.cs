using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Examen2P.Models
{
    public class ExamenContext : DbContext
    {
        public ExamenContext() { }

        public ExamenContext(DbContextOptions<ExamenContext> options) : base(options) { }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Category> categoryInit = new List<Category>
    {
        new Category { Id = 1, Gama = "Baja" },
        new Category { Id = 2, Gama = "Media Baja" },
        new Category { Id = 3, Gama = "Media" },
        new Category { Id = 4, Gama = "Media Alta" },
        new Category { Id = 5, Gama = "Alta" }
    };

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.ToTable("Category");
                entity.Property(c => c.Id).HasColumnName("Id").ValueGeneratedOnAdd();
                entity.Property(c => c.Gama);
                entity.HasData(categoryInit);
            });

            // Seed products
            List<Product> productInit = new List<Product>
    {
        new Product { Id = 1, CategoryId = 1, Name = "Xtreme Entry", Description = "PC Gamer de entrada", Components = "Intel Core i3, 8GB RAM, 256GB SSD, GTX 1050", Price = 12000, Image = "a" , CreatedAt = DateTime.Now},
        new Product { Id = 2, CategoryId = 2, Name = "Mid Range Warrior", Description = "PC Gamer de gama media baja", Components = "AMD Ryzen 5, 16GB RAM, 512GB SSD, GTX 1660", Price = 18000 , Image = "a", CreatedAt = DateTime.Now},
        new Product { Id = 3, CategoryId = 3, Name = "Gamer Pro", Description = "PC Gamer de gama media", Components = "Intel Core i5, 16GB RAM, 1TB SSD, RTX 2060", Price = 25000 , Image = "a", CreatedAt = DateTime.Now},
        new Product { Id = 4, CategoryId = 4, Name = "Elite Gaming", Description = "PC Gamer de gama media alta", Components = "AMD Ryzen 7, 32GB RAM, 1TB SSD, RTX 2070", Price = 32000 , Image = "a", CreatedAt = DateTime.Now},
        new Product { Id = 5, CategoryId = 5, Name = "Ultimate Beast", Description = "PC Gamer de gama alta", Components = "Intel Core i7, 32GB RAM, 2TB SSD, RTX 2080 Ti", Price = 45000 , Image = "a", CreatedAt = DateTime.Now},
        new Product { Id = 6, CategoryId = 1, Name = "Starter Pack", Description = "PC Gamer de entrada", Components = "AMD Ryzen 3, 8GB RAM, 256GB SSD, RX 550", Price = 11000 , Image = "a", CreatedAt = DateTime.Now},
        new Product { Id = 7, CategoryId = 2, Name = "Budget Pro", Description = "PC Gamer de gama media baja", Components = "Intel Core i3, 16GB RAM, 512GB SSD, GTX 1650", Price = 16000 , Image = "a", CreatedAt = DateTime.Now},
        new Product { Id = 8, CategoryId = 3, Name = "Performance Master", Description = "PC Gamer de gama media", Components = "AMD Ryzen 5, 16GB RAM, 1TB SSD, RTX 3050", Price = 23000 , Image = "a", CreatedAt = DateTime.Now},
        new Product { Id = 9, CategoryId = 4, Name = "High End Fighter", Description = "PC Gamer de gama media alta", Components = "Intel Core i5, 32GB RAM, 1TB SSD, RTX 3070", Price = 35000 , Image = "a", CreatedAt = DateTime.Now},
        new Product { Id = 10, CategoryId = 5, Name = "Godlike Power", Description = "PC Gamer de gama alta", Components = "AMD Ryzen 9, 64GB RAM, 2TB SSD, RTX 3090", Price = 50000 , Image = "a", CreatedAt = DateTime.Now}
    };

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.ToTable("Product");
                entity.Property(p => p.Id).HasColumnName("Id").ValueGeneratedOnAdd();
                entity.Property(p => p.Name);
                entity.Property(p => p.Description);
                entity.Property(p => p.Components);
                entity.Property(p => p.Price);
                entity.Property(p => p.Image);
                entity.HasOne(p => p.Category).WithMany(c => c.Products).HasForeignKey(p => p.CategoryId);
                entity.HasData(productInit);
            });
        }

        public DbSet<Category> Category {  get; set; }
        public DbSet<Product> Product {  get; set; }
    }
}
