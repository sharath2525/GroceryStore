using GroceryStore.Data;
using GroceryStore.Repository.IRepository;

namespace GroceryStore.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private GroceryDbContext _db;
        public ICategoryRepository Category { get; private set; }
        public UnitOfWork(GroceryDbContext db) 
        {
            _db = db;
            Category = new CategoryRepository(_db);
        }
   

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
