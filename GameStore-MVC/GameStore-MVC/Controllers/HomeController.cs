using GameStore_DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStore_MVC.Controllers
{
	public class HomeController : Controller
	{
		private readonly gameStoreDbContext _context;

        public HomeController(gameStoreDbContext context)
        {
			_context = context;
        }

        public IActionResult Index()
		{
			var trendingGames = _context.TrendingGames.ToList();


            return View(trendingGames);
		}
	}
}
