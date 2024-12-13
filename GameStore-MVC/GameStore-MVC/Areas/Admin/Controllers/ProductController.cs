using Microsoft.AspNetCore.Mvc;

namespace GameStore_MVC.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
