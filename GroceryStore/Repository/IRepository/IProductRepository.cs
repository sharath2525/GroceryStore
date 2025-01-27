using GroceryStore.Models;

namespace GroceryStore.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);
    }
}