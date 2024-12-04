using Microsoft.AspNetCore.Mvc;

namespace StoreWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}