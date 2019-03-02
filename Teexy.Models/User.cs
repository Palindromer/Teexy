using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Teexy.Models
{
	public class User : IdentityUser<string>
	{
		public string Name { get; set; }

		public int Score { get; set; }

		public List<UserChallenge> Challenges { get; set; }
	}
}
