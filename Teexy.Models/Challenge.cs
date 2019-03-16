using System;
using System.Collections.Generic;
using System.Text;

namespace Teexy.Models
{
	/// <summary>
	/// Challenge.
	/// </summary>
	public class Challenge : IEntity<int>
	{
		public int Id { get; set; }

		/// <summary>
		/// Title of challenge.
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Description of challenge.
		/// </summary>
		public string Description { get; set; }

		public string EmblemImageUrl { get; set; }

		public string BackgroundImageUrl { get; set; }

		/// <summary>
		/// List of descriptions.
		/// </summary>
		public List<ChallengeDecription> Descriptions { get; set; }

		/// <summary>
		/// The amount of points the user gets after execution. 
		/// </summary>
		public int Score { get; set; }

		/// <summary>
		/// Count of users which took this challenge.
		/// </summary>
		public int JoinersCount { get; set; }

		/// <summary>
		/// Count of users which can execute this challenge.
		/// </summary>
		public int? QuotaCount { get; set; }

		/// <summary>
		/// Determines whether this challenge is active.
		/// </summary>
		public bool IsActive { get; set; } = true;

		/// <summary>
		/// Category of challenge.
		/// </summary>
		public ChallengeCategory Category { get; set; }
	}
}
