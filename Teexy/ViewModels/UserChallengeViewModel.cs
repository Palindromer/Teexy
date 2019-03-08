using AutoMapper;
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

		/// <summary>
		/// Who performed the challenge?
		/// </summary>
		public IndexUserViewModel User { get; set; }

		public int LikesCount { get; set; }

		public int CommentsCount { get; set; }
	}
}
