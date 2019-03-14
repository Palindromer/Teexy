using System;
using System.Collections.Generic;
using System.Text;

namespace Teexy.Models
{
	public class Challenge
	{
		public int Id { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public string EmblemImageUrl { get; set; }

		public string BackgroundImageUrl { get; set; }

		public List<ChallengeDecription> Descriptions { get; set; }

		public int Score { get; set; }

		public int JoinersCount { get; set; }

		public int? QuotaCount { get; set; }

		public bool IsActive { get; set; } = true;

		public ChallengeCategory Category { get; set; }
	}
}
