using Microsoft.EntityFrameworkCore;

namespace Teexy.DAL
{
	public class RepositoryContextFactory : IRepositoryContextFactory
	{
		public RepositoryContext CreateDbContext(string connectionString)
		{
			var optionsBuilder = new DbContextOptionsBuilder<RepositoryContext>();
			//optionsBuilder.UseMySql(connectionString);

			var context = new RepositoryContext(optionsBuilder.Options);
			context.Database.EnsureCreated();
			return context;
		}
	}
}
