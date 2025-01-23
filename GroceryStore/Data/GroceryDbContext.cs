using GroceryStore.Models;
using Microsoft.EntityFrameworkCore;

namespace GroceryStore.Data
{
    public class GroceryDbContext : DbContext
    {
        public GroceryDbContext(DbContextOptions<GroceryDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Category { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Fruit",
                    DisplayOrder = 1
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Vegetable",
                    DisplayOrder = 2
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Meat",
                    DisplayOrder = 3
                }
            );
        }
    }
}
