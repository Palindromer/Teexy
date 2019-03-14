using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Teexy.Models
{
	public class User : IdentityUser
	{
		public string Name { get; set; }

		/// <summary>
		/// Rating.
		/// </summary>
		public int Score { get; set; }

		/// <summary>
		/// Id of avatar-photo.
		/// </summary>
		public int? AvatarFileId { get; set; }

		public File AvatarFile { get; set; }

		/// <summary>
		/// Challenges that user has in progress or done.
		/// </summary>
		public List<UserChallenge> Challenges { get; set; }
	}
}
