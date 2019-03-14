using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Teexy.Models;

namespace Teexy.DAL
{
	public class UserRepository : BaseRepository
	{


		public UserRepository(TeexyContextFactory contextFactory)
			: base(contextFactory)
		{
		}

		public async Task<IEnumerable<User>> GetAll()
		{
			var result = await DbContext.Users.ToListAsync();
			return result;
		}

		public async Task<User> Get(string id)
		{
			return await DbContext.Users.FindAsync(id);
		}

		public async Task Create(User item)
		{
			DbContext.Users.Add(item);
			await DbContext.SaveChangesAsync();
		}

		public async Task Update(User item)
		{
			DbContext.Entry(item).State = EntityState.Modified;
			await DbContext.SaveChangesAsync();
		}

		public async Task Delete(int id)
		{
			User user = DbContext.Users.Find(id);
			if (user != null)
				DbContext.Users.Remove(user);
			await DbContext.SaveChangesAsync();
		}
	}

}
