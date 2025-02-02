using GroceryStore.Models;

namespace GroceryStore.Repository.IRepository
{
    public interface IOrderHeaderRepository : IRepository<OrderHeader>
    {
    
        void Update(OrderHeader obj);
     
      
    }
}
