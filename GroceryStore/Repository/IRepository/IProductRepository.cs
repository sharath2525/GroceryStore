using GroceryStore.Models;

namespace GroceryStore.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        //object GetAll(string includeProperties);

        //object GetAll(string includeProperties);
        void Update(Product obj);
    }
}