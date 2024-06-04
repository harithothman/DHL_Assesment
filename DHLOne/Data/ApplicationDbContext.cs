using DHLOne.Models;
using Microsoft.EntityFrameworkCore;

namespace DHLOne.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 

        }

        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(
                new Item { itemId = 1, itemName = "Hammer", itemDescription = "To hit things into the wall" },
                new Item { itemId = 2, itemName = "Phone", itemDescription = "To call somebody" },
                new Item { itemId = 3, itemName = "Cup", itemDescription = "To hold water in place" }
                );
        }
    }
}
