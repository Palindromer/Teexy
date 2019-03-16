using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teexy.Models;

namespace Teexy.DAL
{
	public abstract class EFGenericRepository<TEntity>
		: EFGenericRepository<TEntity, int>
		where TEntity : class, IEntity<int>
	{
		public EFGenericRepository(TeexyContext context)
			: base(context)
		{ }
	}

	public abstract class EFGenericRepository<TEntity, IdType> : BaseRepository where TEntity : class, IEntity<IdType>
	{
		private DbSet<TEntity> _dbSet;

		public EFGenericRepository(TeexyContext context)
			: base(context)
		{
			_dbSet = context.Set<TEntity>();
		}

		public async Task<List<TEntity>> GetAll()
		{
			return await _dbSet.AsNoTracking().ToListAsync();
		}

		public List<TEntity> Get(Func<TEntity, bool> predicate)
		{
			return _dbSet.AsNoTracking().Where(predicate).ToList();
		}

		public async Task<TEntity> FindById(int id)
		{
			return await _dbSet.FindAsync(id);
		}

		public TEntity FirstOrDefault(Func<TEntity, bool> predicate)
		{
			return _dbSet.FirstOrDefault(predicate);
		}

		public async Task<IdType> Create(TEntity item)
		{
			await _dbSet.AddAsync(item);
			await Context.SaveChangesAsync();
			return item.Id;
		}
		public async Task Update(TEntity item)
		{
			Context.Entry(item).State = EntityState.Modified;
			await Context.SaveChangesAsync();
		}
		public async Task Remove(TEntity item)
		{
			_dbSet.Remove(item);
			await Context.SaveChangesAsync();
		}
	}
}
