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
		public ChallengeRepository(TeexyContextFactory contextFactory)
			: base(contextFactory)
		{
		}


		public async Task<List<Challenge>> GetAll()
		{
			var result = await DbContext.Challenges
				.Include(ch => ch.Descriptions)
				.ToListAsync();
			return result;
		}

		public async Task<Challenge> Get(int challengeId)
		{
			var result = await DbContext.Challenges
				.Include(ch => ch.Descriptions)
				.SingleOrDefaultAsync(ch => ch.Id == challengeId);
			return result;
		}

		public async Task Save(Challenge challenge)
		{
			var result = await DbContext.Challenges.AddAsync(challenge);
			await DbContext.SaveChangesAsync();
		}

		public async Task<List<UserChallenge>> GetProofs(int challengeId)
		{
			var proofs = await DbContext.UserChallenges
				.Where(uch => uch.Challenge.Id == challengeId)
				.Include(uch => uch.User)
				.ToListAsync();
			return proofs;
		}
	}

}
