using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=TARIK-PC;database=CargoDb;integrated security=true;");
		}

		public DbSet<City> City { get; set; }
		public DbSet<District> District { get; set; }
		public DbSet<Order> Order { get; set; }
		public DbSet<Size> Size { get; set; }
		public DbSet<Stage> Stage { get; set; }
		public DbSet<Status> Status { get; set; }
		public DbSet<Comment> Comment { get; set; }
		public DbSet<Contact> Contact { get; set; }
		public DbSet<ExceptionLog> ExceptionLog { get; set; }
	}
}
