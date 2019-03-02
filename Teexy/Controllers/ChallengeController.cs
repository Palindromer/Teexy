using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teexy.Models;

namespace Teexy.Controllers
{
	[Route("api/[controller]")]
	public class ChallengeController : Controller
	{
		public ChallengeController()
		{

		}


		[HttpGet("[action]")]
		public IEnumerable<Challenge> All()
		{
			var rng = new Random();
			return Enumerable.Range(1, 5).Select(index => new Challenge
			{

			});
		}
	}
}
