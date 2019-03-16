using AutoMapper;
using System.Collections.Generic;
using Teexy.Models;

namespace Teexy.ViewModels
{
	public class UserChallengeViewModel
	{
		public int Id { get; set; }

		/// <summary>
		/// Proof.
		/// </summary>
		public string FileUrl { get; set; }

		/// <summary>
		/// Wich challenge was done?
		/// </summary>
		public Challenge Challenge { get; set; }

		public ChallengeStatus Status { get; set; }


		/// <summary>
		/// Who performed the challenge?
		/// </summary>
		public IndexUserViewModel User { get; set; }

		public int LikesCount { get; set; }

		public int CommentsCount { get; set; }

		public List<UserChallengeLike> Likes { get; set; }

		public List<UserChallengeComment> Comments { get; set; }
	}
}
