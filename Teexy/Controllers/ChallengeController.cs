using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teexy.DAL;
using Teexy.Models;
using Teexy.ViewModels;

namespace Teexy.Controllers
{
	[Route("api/[controller]")]
	public class ChallengesController : Controller
	{
		private ChallengeRepository _challengeRepository;

		public ChallengesController(ChallengeRepository challengeRepository)
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

		[HttpPost("Save")]
		public async Task<ActionResult> Save(Challenge challenge)
		{
			await _challengeRepository.Save(challenge);
			return Ok();
		}

		[HttpGet("{challengeId}/GetProofs")]
		public async Task<IEnumerable<ChallengeProofViewModel>> GetProofs(int challengeId)
		{
			var proofs = (await _challengeRepository.GetProofs(challengeId))
				.Select(pr => ChallengeProofViewModel.FromChallengeProof(pr));
			return proofs;
		}
	}
}
