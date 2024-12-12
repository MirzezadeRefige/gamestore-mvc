using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
string? ConnectionStrings = builder.Configuration.GetConnectionString("MSSql");
builder.Services.AddDbContext<gameStoreDbContext>(option => option.UseSqlServer(ConnectionStrings));
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.UseRouting();
app.UseStaticFiles();


app.UseEndpoints(endpoints =>
{
	endpoints.MapControllerRoute(
	  name: "areas",
	  pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
	);
});
app.MapControllerRoute(
  name: "deafult",
  pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
