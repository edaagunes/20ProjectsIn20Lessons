using ApiProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiProject.Context
{
	public class WeatherContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=DESKTOP-3OD251U\\SQLEXPRESS;initial catalog=Db6Project20;integrated security=true");
		}
		public DbSet<City> Cities { get; set; }
	}
}
