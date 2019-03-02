using Microsoft.EntityFrameworkCore;

namespace Teexy.DAL
{
	public class RepositoryContextFactory
	{
		public RepositoryContext CreateDbContext(string connectionString)
		{
			var optionsBuilder = new DbContextOptionsBuilder<RepositoryContext>();
			optionsBuilder.UseMySql(connectionString);

			var context = new RepositoryContext(optionsBuilder.Options);
			return context;
		}

		public RepositoryContext CreateDbContext()
		{
			var context = new RepositoryContext();
			return context;
		}
	}
}
