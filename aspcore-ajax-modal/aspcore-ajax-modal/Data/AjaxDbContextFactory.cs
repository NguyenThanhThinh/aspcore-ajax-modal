using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace aspcore_ajax_modal.Data
{
	public class AjaxDbContextFactory : IDesignTimeDbContextFactory<AjaxDbContext>
	{
		AjaxDbContext IDesignTimeDbContextFactory<AjaxDbContext>.CreateDbContext(string[] args)
		{
			IConfigurationRoot configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();

			var connectionString = configuration.GetConnectionString("ajax-modal-demo");

			var optionsBuilder = new DbContextOptionsBuilder<AjaxDbContext>();
			optionsBuilder.UseSqlServer(connectionString);

			return new AjaxDbContext(optionsBuilder.Options);
		}
	}
}
