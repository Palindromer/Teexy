using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Teexy.Models;

namespace Teexy.DAL
{
	public class UserChallengeRepository : EFGenericRepository<UserChallenge>
	{
		public UserChallengeRepository(TeexyContext teexyContext)
			: base(teexyContext)
		{ }		
	}
}
