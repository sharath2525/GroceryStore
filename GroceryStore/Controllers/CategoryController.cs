using GroceryStore.Data;
using GroceryStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace GroceryStore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly GroceryDbContext _db;
        public CategoryController(GroceryDbContext db )
        {
            _db = db;

        }
        public IActionResult Index()
        {
             List<Category> objCategoryList = _db.Category.ToList();
            return View(objCategoryList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            _db.Category.Add(obj);
            _db.SaveChanges();
             return View();
        }



    }
}
