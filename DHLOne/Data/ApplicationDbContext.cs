﻿using DHLOne.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DHLOne.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 

        }

        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Configure the primary key for IdentityUserLogin<string>
            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.HasKey(login => new { login.LoginProvider, login.ProviderKey });
            });

            modelBuilder.Entity<Item>().HasData(
                new Item { itemId = 1, itemName = "Hammer", itemDescription = "To hit things into the wall" },
                new Item { itemId = 2, itemName = "Phone", itemDescription = "To call somebody" },
                new Item { itemId = 3, itemName = "Cup", itemDescription = "To hold water in place" }
                );
        }
    }
}
