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
        public object Categories { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Fruit",
                    DisplayOrder = 1
                },
                new Category
                {
                    Id = 2,
                    Name = "Vegetable",
                    DisplayOrder = 2
                },
                new Category
                {
                    Id = 3,
                    Name = "Meat",
                    DisplayOrder = 3
                }
            );
        }
    }
}
