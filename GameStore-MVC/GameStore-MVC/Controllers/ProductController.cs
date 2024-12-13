using GameStore_DAL.Migrations;
using GameStore_DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GameStore_MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly gameStoreDbContext _context;

        public ProductController(gameStoreDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int id)
        {
            var game = _context.TrendingGames
                .FirstOrDefault(x => x.Id == id);
            if (game is null)
            {
                return NotFound();
            }
           
                return View(game);
            
            
        }
    }
}
