namespace GameStore_DAL.Models
{
	public class TrendingGames
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string ImageUrl { get; set; }
		public string Category { get; set; }
		public int CostPrice { get; set; }
		public int SellPrice { get; set; }
	}
}
