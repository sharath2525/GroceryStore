using GroceryStore.Models;

namespace GroceryStore.Repository.IRepository
{
    public interface IOrderDetailRepository : IRepository<OrderDetail>
    {

        void Update(OrderDetail obj);
     
      
    }
}
