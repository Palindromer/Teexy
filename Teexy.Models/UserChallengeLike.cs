namespace Teexy.Models
{
	public class UserChallengeLike : IEntity<int>
	{
		public int Id { get; set; }

		/// <summary>
		/// Who likes?
		/// </summary>
		public User User { get; set; }

		/// <summary>
		/// What was liked?
		/// </summary>
		public UserChallenge UserChallenge { get; set; }
	}
}