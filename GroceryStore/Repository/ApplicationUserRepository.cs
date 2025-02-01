using GroceryStore.Data;
using GroceryStore.Models;
using GroceryStore.Repository.IRepository;
using System.Linq.Expressions;

namespace GroceryStore.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private GroceryDbContext _db;
        public ApplicationUserRepository(GroceryDbContext db) : base(db)
        {
            _db = db;
        }

   
    }
}
