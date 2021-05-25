using aspcore_ajax_modal.Models;
using Microsoft.EntityFrameworkCore;

namespace aspcore_ajax_modal.Data
{
	public class AjaxDbContext : DbContext
	{
		public AjaxDbContext(DbContextOptions<AjaxDbContext> options) : base(options)
		{
		}
		public DbSet<Product> Products { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderDetail> OrderDetails { get; set; }
	}
}
