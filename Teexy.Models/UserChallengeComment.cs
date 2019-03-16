namespace Teexy.Models
{
	public class UserChallengeComment : IEntity<int>
	{
		public int Id { get; set; }

		/// <summary>
		/// Who wrote the comment?
		/// </summary>
		public User User { get; set; }

		/// <summary>
		/// What was commented?
		/// </summary>
		public UserChallenge UserChallenge { get; set; }

		/// <summary>
		/// Text of comment.
		/// </summary>
		public string Text { get; set; }
	}
}