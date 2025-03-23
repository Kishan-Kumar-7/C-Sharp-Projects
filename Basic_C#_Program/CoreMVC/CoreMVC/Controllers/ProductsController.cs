using Microsoft.AspNetCore.Mvc;

namespace CoreMVC.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
