namespace Teexy.DAL
{
	public abstract class BaseRepository
	{
		protected string ConnectionString { get; }

		protected RepositoryContextFactory ContextFactory { get; }

		protected RepositoryContext RepositoryContext { get; }

		public BaseRepository(RepositoryContextFactory contextFactory)
		{
			ContextFactory = contextFactory;
			RepositoryContext = contextFactory.CreateDbContext();
		}
	}
}
