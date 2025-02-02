using GroceryStore.Data;
using GroceryStore.Models;
using GroceryStore.Repository.IRepository;
using System.Linq.Expressions;

namespace GroceryStore.Repository
{
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        private GroceryDbContext _db;
        public OrderDetailRepository(GroceryDbContext db) : base(db)
        {
            _db = db;
        }

   

        public void Update(OrderDetail obj)
        {
            _db.OrderDetails.Update(obj);
        }

    }
}
