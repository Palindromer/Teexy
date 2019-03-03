using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Teexy.Models;

namespace Teexy.DAL
{
	public class UserRepository : BaseRepository
	{


		public UserRepository(RepositoryContextFactory contextFactory)
			: base(contextFactory)
		{
		}

		public async Task<IEnumerable<User>> GetAll()
		{
			var result = await RepositoryContext.Users.ToListAsync();
			return result;
		}

		public async Task<User> Get(string id)
		{
			return await RepositoryContext.Users.FindAsync(id);
		}

		public async Task Create(User item)
		{
			RepositoryContext.Users.Add(item);
			await RepositoryContext.SaveChangesAsync();
		}

		public async Task Update(User item)
		{
			RepositoryContext.Entry(item).State = EntityState.Modified;
			await RepositoryContext.SaveChangesAsync();
		}

		public async Task Delete(int id)
		{
			User user = RepositoryContext.Users.Find(id);
			if (user != null)
				RepositoryContext.Users.Remove(user);
			await RepositoryContext.SaveChangesAsync();
		}
	}

}
