using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcTask.DataAccsessLayer;

namespace MvcTask.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _context.Products.Take(4).ToListAsync();
            return View(products);
        }
        public async Task<IActionResult> LoadProduct()
        {
            var products = await _context.Products.Include(x => x.Category).Skip(4).Take(8).ToListAsync();

            return PartialView("ProductPartial", products);
        }
    }
}
