using System;
using System.Collections.Generic;
using System.Text;

namespace Teexy.Models
{
	public class User
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public List<UserChallenge> Challenges { get; set; }
	}
}
