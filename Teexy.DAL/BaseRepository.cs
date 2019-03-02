namespace Teexy.DAL
{
	public abstract class BaseRepository
	{
		protected string ConnectionString { get; }

		protected RepositoryContextFactory ContextFactory { get; }

		public BaseRepository(RepositoryContextFactory contextFactory)
		{
			ContextFactory = contextFactory;
		}
	}
}
