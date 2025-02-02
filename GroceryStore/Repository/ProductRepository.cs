using GroceryStore.Data;
using GroceryStore.Models;
using GroceryStore.Repository.IRepository;
using System.Linq.Expressions;

namespace GroceryStore.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private GroceryDbContext _db;
        public ProductRepository(GroceryDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(u => u.ProductId == obj.ProductId);
            if (objFromDb != null)
            {
                objFromDb.ProductName = obj.ProductName;
                objFromDb.Price = obj.Price;
                objFromDb.Quantity = obj.Quantity;
                objFromDb.Description = obj.Description;
                objFromDb.CategoryId = obj.CategoryId;
                if (obj.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }

            }
        }
    }
}