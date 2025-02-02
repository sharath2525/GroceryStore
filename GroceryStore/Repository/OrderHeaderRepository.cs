using GroceryStore.Data;
using GroceryStore.Models;
using GroceryStore.Repository.IRepository;
using System.Linq.Expressions;

namespace GroceryStore.Repository
{
    public class OrderHeaderRepository : Repository<OrderHeader>, IOrderHeaderRepository
    {
        private GroceryDbContext _db;
        public OrderHeaderRepository(GroceryDbContext db) : base(db)
        {
            _db = db;
        }

   

        public void Update(OrderHeader obj)
        {
            _db.OrderHeaders.Update(obj);
        }

    }
}
