﻿using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories 
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
            .HasData(
                new Product() { Id = 1, ProductName = "Computer", Price = 27_000 },
                new Product() { Id = 2, ProductName = "Keyboard", Price = 1_500 },
                new Product() { Id = 3, ProductName = "Mouse", Price = 1_000 },
                new Product() { Id = 4, ProductName = "Monitor", Price = 5_000 },
                new Product() { Id = 5, ProductName = "Deck", Price = 2_000 }
            );
        }
    }

}


