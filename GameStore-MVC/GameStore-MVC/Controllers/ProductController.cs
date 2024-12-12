using Microsoft.AspNetCore.Mvc;

namespace GameStore_MVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
