using GroceryStore.Models;

namespace GroceryStore.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        IEnumerable<Category> GetAll();
        void Update(Category obj);
     
      
    }
}
