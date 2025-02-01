using GroceryStore.Models;

namespace GroceryStore.Repository.IRepository
{
    public interface IShoppingCartRepository : IRepository<ShoppingCart>
    {
        void Update(ShoppingCart obj);
     
      
    }
}
