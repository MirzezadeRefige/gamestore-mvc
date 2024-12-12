using Microsoft.EntityFrameworkCore;

public class gameStoreDbContext : DbContext
{
	public gameStoreDbContext(DbContextOptions options) : base(options)
	{
	}
}