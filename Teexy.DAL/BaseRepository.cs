using System;

namespace Teexy.DAL
{
	public abstract class BaseRepository
	{
		protected TeexyContext Context { get; }

		public BaseRepository(TeexyContext dbContext)
		{
			Context = dbContext;
		}
	}
}
