namespace Teexy.Models
{
	public class UserChallenge
	{
		public int Id { get; set; }

		public User User { get; set; }

		public Challenge Challenge { get; set; }

		public ChallengeStatus Status { get; set; }
	}
}
