using GameStore_DAL.Migrations;
using GameStore_DAL.Models;

namespace GameStore_MVC.ViewModels
{
    public class TrendingGameVM
    {
        public List<TrendingGames> TrendingGames { get; set; }  
    }
}
