using GroceryStore.Data;
using GroceryStore.Models;
using GroceryStore.Repository.IRepository;
using System.Linq.Expressions;

namespace GroceryStore.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private GroceryDbContext _db;
        public CategoryRepository(GroceryDbContext db) : base(db)
        {
            _db = db;
        }

   

        public void Update(Category obj)
        {
            _db.Category.Update(obj);
        }


        
    }
}
