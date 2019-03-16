using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teexy.Models;

namespace Teexy.DAL
{
	public class ChallengeRepository : EFGenericRepository<Challenge>
	{
		public ChallengeRepository(TeexyContext teexyContext) : base(teexyContext)
		{
		}


		public new async Task<List<Challenge>> GetAll()
		{
			var result = await Context.Challenges
				.Include(ch => ch.Descriptions)
				.ToListAsync();
			return result;
		}

		public new async Task<Challenge> FindById(int challengeId)
		{
			var result = await Context.Challenges
				.Include(ch => ch.Descriptions)
				.SingleOrDefaultAsync(ch => ch.Id == challengeId);
			return result;
		}

		public async Task<List<UserChallenge>> GetProofs(int challengeId)
		{
			var proofs = await Context.UserChallenges
				.Where(uch => uch.Challenge.Id == challengeId)
				.Include(uch => uch.User)
				.ToListAsync();
			return proofs;
		}
	}

}
