using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.Extensions.Configuration.FileExtensions;

namespace Teexy.DAL
{
	public class TeexyContextFactory : IDesignTimeDbContextFactory<TeexyContext>
	{

		/*public TeexyContext CreateDbContext(string connectionString)
		{
			var optionsBuilder = new DbContextOptionsBuilder<TeexyContext>();
			optionsBuilder.UseMySql(connectionString);

			var context = new TeexyContext(optionsBuilder.Options);
			return context;
		}*/

		public TeexyContext CreateDbContext()
		{
			return CreateDbContext(new string[0]);
		}

		public TeexyContext CreateDbContext(string[] args)
		{
			return CreateDbContext("DefaultConnection");
		}

		public TeexyContext CreateDbContext(string connectionStringName)
		{
			var configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();

			var builder = new DbContextOptionsBuilder<TeexyContext>();

			var connectionString = configuration.GetConnectionString(connectionStringName);

			builder.UseMySql(connectionString);

			return new TeexyContext(builder.Options);
		}
	}
}
