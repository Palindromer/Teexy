using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Teexy.Models;

namespace Teexy.DAL
{
	public class UserRepository : BaseRepository
	{


		public UserRepository(TeexyContext teexyContext) : base(teexyContext)
		{
		}

		public async Task<IEnumerable<User>> GetAll()
		{
			var result = await Context.Users.ToListAsync();
			return result;
		}

		public async Task<User> Get(string id)
		{
			return await Context.Users.FindAsync(id);
		}

		public async Task Create(User item)
		{
			Context.Users.Add(item);
			await Context.SaveChangesAsync();
		}

		public async Task Update(User item)
		{
			Context.Entry(item).State = EntityState.Modified;
			await Context.SaveChangesAsync();
		}

		public async Task Delete(int id)
		{
			User user = Context.Users.Find(id);
			if (user != null)
				Context.Users.Remove(user);
			await Context.SaveChangesAsync();
		}
	}

}
