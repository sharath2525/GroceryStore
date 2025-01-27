using GroceryStore.Models;
using Microsoft.EntityFrameworkCore;

namespace GroceryStore.Data
{
    public class GroceryDbContext : DbContext
    {
        public GroceryDbContext(DbContextOptions<GroceryDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        //public object Categories { get; internal set; }

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
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    ProductName = "Banana",
                    Description = "Our fresh bananas are a delicious and nutritious choice for any time of the day. These bananas are hand-picked at peak ripeness to ensure maximum flavor and sweetness. ",
                    ImageUrl = "https://cdn.zeptonow.com/production/tr:w-400,ar-3000-3000,pr-true,f-auto,q-80/cms/product_variant/5a22eec9-fbe7-4ba2-b603-d0f6e1217a98.jpeg",
                    Price = 60,
                    Quantity = "100",
                    CategoryId = 1
                },
                new Product
                {
                    ProductId = 2,
                    ProductName = "Tomato",
                    Description = "Our fresh tomatoes are juicy, flavorful, and perfect for enhancing any dish with their rich taste and nutritional benefits.",
                    ImageUrl = "https://cdn.zeptonow.com/production/tr:w-400,ar-3000-3000,pr-true,f-auto,q-80/cms/product_variant/270711b9-d545-44a6-a984-98e0fae2cd55.jpeg",
                    Price = 40,
                    Quantity = "75",
                    CategoryId = 2
                }
                );
        }
    }
}
