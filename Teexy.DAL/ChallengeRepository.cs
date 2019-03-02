using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teexy.Models;

namespace Teexy.DAL
{
	public class ChallengeRepository : BaseRepository
	{
		public ChallengeRepository(string connectionString, IRepositoryContextFactory contextFactory)
			: base(connectionString, contextFactory)
		{
		}


		public async Task<List<Challenge>> GetChallenges()
		{
			using (var context = ContextFactory.CreateDbContext(ConnectionString))
			{
				var result = await context.Challenges.ToListAsync();
				return result;
			}
		}

		public async Task<Challenge> GetChallenge(int challengeId)
		{
			using (var context = ContextFactory.CreateDbContext(ConnectionString))
			{
				var result = await context.Challenges.SingleOrDefaultAsync(ch => ch.Id == challengeId);
				return result;
			}
		}
	}
}
