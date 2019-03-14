namespace Teexy.DAL
{
	public abstract class BaseRepository
	{
		protected string ConnectionString { get; }

		protected TeexyContextFactory ContextFactory { get; }

		protected TeexyContext DbContext { get; }

		public BaseRepository(TeexyContextFactory contextFactory)
		{
			ContextFactory = contextFactory;
			DbContext = contextFactory.CreateDbContext();
		}
	}
}
