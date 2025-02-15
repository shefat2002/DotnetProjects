using Microsoft.AspNetCore.Mvc;
using SimpleCRUDApp.Data;
using SimpleCRUDApp.Models;

namespace SimpleCRUDApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Product> products = _context.Products.ToList();
            return View(products);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
