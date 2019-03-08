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
		public ChallengeRepository(RepositoryContextFactory contextFactory)
			: base(contextFactory)
		{
		}


		public async Task<List<Challenge>> GetAll()
		{
			using (var context = ContextFactory.CreateDbContext())
			{
				var result = await context.Challenges
					.Include(ch => ch.Descriptions)
					.ToListAsync();
				return result;
			}
		}

		public async Task<Challenge> Get(int challengeId)
		{
			using (var context = ContextFactory.CreateDbContext())
			{
				var result = await context.Challenges
					.Include(ch => ch.Descriptions)
					.SingleOrDefaultAsync(ch => ch.Id == challengeId);
				return result;
			}
		}

		public async Task Save(Challenge challenge)
		{
			using (var context = ContextFactory.CreateDbContext(ConnectionString))
			{
				var result = await context.Challenges.AddAsync(challenge);
				await context.SaveChangesAsync();
			}
		}

		public async Task<List<UserChallenge>> GetProofs(int challengeId)
		{
			var proofs = await RepositoryContext.UserChallenges
				.Where(uch => uch.Challenge.Id == challengeId)
				.Include(uch => uch.User)
				.ToListAsync();
			return proofs;
		}
	}

}
