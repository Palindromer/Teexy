using System;
using System.Collections.Generic;

namespace Teexy.Models
{
	public class UserChallenge : IEntity<int>
	{
		public int Id { get; set; }

		public string UserId { get; set; }

		public User User { get; set; }

		public int ChallengeId { get; set; }

		public Challenge Challenge { get; set; }

		public ChallengeStatus Status { get; set; }

		/// <summary>
		/// When challenge was taken.
		/// </summary>
		public DateTime TakenDateTime { get; set; }

		/// <summary>
		/// When challenge was done.
		/// </summary>
		public DateTime DoneDateTime { get; set; }

		public int? ProofFileId { get; set; }

		public File ProofFile { get; set; }

		public int? LikesCount { get; set; }

		public int? CommentsCount { get; set; }

		public List<UserChallengeLike> Likes { get; set; }

		public List<UserChallengeComment> Comments { get; set; }
	}
}