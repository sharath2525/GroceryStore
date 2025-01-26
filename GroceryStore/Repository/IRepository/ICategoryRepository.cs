using GroceryStore.Models;

namespace GroceryStore.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category obj);
     
      
    }
}
