using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teexy.DAL;
using Teexy.Extensions;
using Teexy.Models;
using Teexy.ViewModels;

namespace Teexy.Controllers
{
	[Route("api/[controller]")]
	public class ChallengesController : ControllerBase
	{
		private ChallengeRepository _challengeRepository;
		private UserChallengeRepository _userChallengeRepository;
		private FileRepository _fileRepository;

		private readonly UserManager<User> _userManager;
		private readonly IMapper _mapper;

		public ChallengesController(ChallengeRepository challengeRepository, UserChallengeRepository userChallengeRepository,
			FileRepository fileRepository, UserManager<User> userManager, IMapper mapper)
		{
			_challengeRepository = challengeRepository;
			_userChallengeRepository = userChallengeRepository;
			_fileRepository = fileRepository;
			_userManager = userManager;
			_mapper = mapper;
		}


		/// <summary>
		/// Get all challenges.
		/// </summary>
		[HttpGet("")]
		public async Task<IEnumerable<Challenge>> Index()
		{
			var result = await _challengeRepository.GetAll();
			return result;
		}

		/// <summary>
		/// Get challenge by id.
		/// </summary>
		/// <param name="id">Id of challenge.</param>
		[HttpGet("{id}")]
		public async Task<Challenge> Get(int id)
		{
			var result = await _challengeRepository.FindById(id);
			return result;
		}


		/// <summary>
		/// Create new challenge.
		/// </summary>
		[HttpPost("[action]")]
		public async Task<ActionResult> New(Challenge challenge)
		{
			await _challengeRepository.Create(challenge);
			return Ok();
		}

		/// <summary>
		/// Get all proofs of the challenge.
		/// </summary>
		/// <param name="challengeId">Id of challenge.</param>
		[HttpGet("{challengeId}/GetProofs")]
		public async Task<IEnumerable<UserChallengeViewModel>> GetProofs(int challengeId)
		{
			var proofs = (await _challengeRepository.GetProofs(challengeId))
				.Select(pr => _mapper.Map<UserChallengeViewModel>(pr))
				.ToList();
			return proofs;
		}

		/// <summary>
		/// Mark the challenge as taken by current user.
		/// </summary>
		/// <param name="challengeId">Id of challenge.</param>
		[Authorize]
		[HttpGet("{challengeId}/Take")]
		public async Task<int> TakeChallenge(int challengeId)
		{
			var userId = _userManager.GetUserId(User);
			var userChallenge = new UserChallenge()
			{
				ChallengeId = challengeId,
				Status = ChallengeStatus.InProgress,
				TakenDateTime = DateTime.Now,
				UserId = userId
			};

			await _userChallengeRepository.Create(userChallenge);

			return userChallenge.Id;
		}

		/// <summary>
		/// Mark the challenge as done by current user.
		/// </summary>
		/// <param name="challengeId">Id of challenge.</param>
		/// <param name="proofFile">The file thant proves the execution of the challenge.</param>
		[Authorize]
		[HttpGet("{challengeId}/Done")]
		public async Task<ActionResult> DoneChallenge(int challengeId, IFormFile proofFile)
		{
			var userId = _userManager.GetUserId(User);
			var fileModel = proofFile.ToModel();
			var fileModelId = await _fileRepository.Create(fileModel);

			var userChallenge = _userChallengeRepository
				.FirstOrDefault(uc => uc.UserId == userId && uc.ChallengeId == challengeId);

			userChallenge.Status = ChallengeStatus.Done;
			userChallenge.ProofFileId = fileModelId;
			userChallenge.DoneDateTime = DateTime.Now;

			await _userChallengeRepository.Update(userChallenge);

			return Ok();
		}
	}
}
