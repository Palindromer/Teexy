namespace Teexy.DAL
{
	public interface IRepositoryContextFactory
	{
		RepositoryContext CreateDbContext(string connectionString);
	}
}
