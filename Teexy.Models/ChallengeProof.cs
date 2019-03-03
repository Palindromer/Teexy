using System;
using System.Collections.Generic;
using System.Text;

namespace Teexy.Models
{
	public class ChallengeProof
	{
		public int Id { get; set; }

		/// <summary>
		/// Proof.
		/// </summary>
		public int FileId { get; set; }

		/// <summary>
		/// Wich challenge was done?
		/// </summary>
		public Challenge Challenge { get; set; }

		/// <summary>
		/// Who performed the challenge?
		/// </summary>
		public User User { get; set; }

		public int LikesCount { get; set; }
	}
}
