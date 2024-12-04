using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreWeb.Models;

namespace StoreWeb.Controllers
{
    public class ProductController : Controller
    {
        private readonly RepositoryContext _context; //
        public ProductController(RepositoryContext context) //
        {
        _context = context; // Hepsi birlikte Dependency Injection'ı olulşturur. DI
        }

        /* 
        // Dependency Injection olmasaydı:
        **********************************
        var context = new RepositoryContext()
        (
        new DbContextOptionsBuilder<RepositoryContext>()
        .UseSqlite("Data Source = ...")
        .Options); 
        **********************************
        // Kodlarını yazıp RepositoryContext'i oluşturup, işmizi bir hayli uzatmış olacaktık.
        // Bu Dependency Injection sayesinde, RepositoryContext'i oluşturup, işimizi kolaylaştırmış olduk.
        */

        public IActionResult Index()
        {
            var model = _context.Products.ToList();
            return View(model);
        }

        public ActionResult<Product> Get(int id)
        {
            Product? product = _context.Products.Find(id);
            // Product? product = _context.Products.FirstOrDefault(p => p.ProductId == id);

            if (product == null)
            {
                return NotFound("Product not found");
            }
            return View(product);
        }
    }
}