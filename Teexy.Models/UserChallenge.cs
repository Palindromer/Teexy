using System.Collections.Generic;

namespace Teexy.Models
{
	public class UserChallenge
	{
		public int Id { get; set; }

		public User User { get; set; }

		public Challenge Challenge { get; set; }

		public ChallengeStatus Status { get; set; }

		public int ProofFileId { get; set; }

		public int LikesCount { get; set; }

		public int CommentCount { get; set; }

		public List<UserChallengeLike> Likes { get; set; }

		public List<UserChallengeComment> Comments { get; set; }
	}
}