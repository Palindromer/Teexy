using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teexy.DAL;
using Teexy.Models;

namespace Teexy.Controllers
{
	[Route("api/[controller]")]
	public class ChallengeController : Controller
	{

		private ChallengeRepository _challengeRepository;

		public ChallengeController(ChallengeRepository challengeRepository)
		{
			_challengeRepository = challengeRepository;
		}


		[HttpGet("")]
		public async Task<IEnumerable<Challenge>> Index()
		{
			var result = await _challengeRepository.GetAll();
			return result;
		}

		[HttpGet("{id}")]
		public async Task<Challenge> Index(int id)
		{
			var result = await _challengeRepository.Get(id);
			return result;
		}

		[HttpGet("Save")]
		public async Task<ActionResult> Save(Challenge challenge)
		{
			await _challengeRepository.Save(challenge);
			return Ok();
		}
	}
}
