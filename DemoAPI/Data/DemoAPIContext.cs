using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoAPI.Models;

namespace DemoAPI.Data
{
    public class DemoAPIContext : DbContext
    {
        public DemoAPIContext (DbContextOptions<DemoAPIContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, Name = "Zoutjes" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, Name = "Fruit" });

            modelBuilder.Entity<Product>().HasData(new Product { Id = 1, CategoryId = 1, Description = "Lekkere chips", Price = 2, Name = "Zoute chips" });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 2, CategoryId = 1, Description = "Goed voor de dorst", Price = 2, Name = "Zoute pinda's" });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 3, CategoryId = 1, Description = "Wie houdt er niet van", Price = 1.50, Name = "Paprika chips" });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 4, CategoryId = 1, Description = "Gezond en lekker!", Price = 1.25, Name = "Cashewnoten" });


            modelBuilder.Entity<Product>().HasData(new Product { Id = 5, CategoryId = 2, Description = "Boordevol vitamine C", Price = 1.75, Name = "Appels" });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 6, CategoryId = 2, Description = "Helpen ook om goed te slapen", Price = 2, Name = "Bananen" });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 7, CategoryId = 2, Description = "Hier kan je wijn van maken", Price = 2.50, Name = "Druiven" });
            modelBuilder.Entity<Product>().HasData(new Product { Id = 8, CategoryId = 2, Description = "Deze smaken lekker", Price = 2.25, Name = "Kersen" });
        }

        public DbSet<DemoAPI.Models.Product> Product { get; set; }

        public DbSet<DemoAPI.Models.Category> Category { get; set; }
    }
}
