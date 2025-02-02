﻿using GroceryStore.Data;
using GroceryStore.Repository.IRepository;

namespace GroceryStore.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private GroceryDbContext _db;
        public ICategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }
        public IShoppingCartRepository ShoppingCart { get; private set; }

        public IApplicationUserRepository ApplicationUser { get; private set; }
        public IOrderHeaderRepository OrderHeader { get; private set; }

        public IOrderDetailRepository OrderDetail { get; private set; }
        public UnitOfWork(GroceryDbContext db) 
        {
            _db = db;
            ApplicationUser = new ApplicationUserRepository(_db);
            ShoppingCart = new ShoppingCartRepository(_db);
            Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);
            OrderHeader = new OrderHeaderRepository(_db);
            OrderDetail = new OrderDetailRepository(_db);
        }
   

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
