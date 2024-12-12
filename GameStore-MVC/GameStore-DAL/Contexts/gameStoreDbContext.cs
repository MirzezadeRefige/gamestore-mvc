using GameStore_DAL.Models;
using Microsoft.EntityFrameworkCore;

public class gameStoreDbContext : DbContext
{
	public DbSet<TrendingGames> TrendingGames { get; set; }
	public gameStoreDbContext(DbContextOptions options) : base(options)
	{
	}
}