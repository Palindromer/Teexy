using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Teexy.DAL;
using Teexy.Extensions;
using Teexy.Models;
using Teexy.ViewModels;

namespace Teexy.Controllers
{
	[Route("api/[controller]")]
	public class UsersController : ControllerBase
	{
		private UserRepository _userRepository;
		private FileRepository _fileRepository;

		private readonly UserManager<User> _userManager;

		private readonly IMapper _mapper;

		public UsersController(UserRepository userRepository,
			FileRepository fileRepository, UserManager<User> userManager, IMapper mapper)
		{
			_userRepository = userRepository;
			_fileRepository = fileRepository;
			_userManager = userManager;
			_mapper = mapper;
		}

		/// <summary>
		/// Get current user.
		/// </summary>
		[Authorize]
		[HttpGet("[action]")]
		public async Task<IndexUserViewModel> My()
		{
			var user = await _userManager.GetUserAsync(User);
			return _mapper.Map<IndexUserViewModel>(user);
		}

		/// <summary>
		/// Get user by id.
		/// </summary>
		[HttpGet("{id}")]
		public async Task<IndexUserViewModel> GetUser(string id)
		{
			var user = await _userRepository.Get(id);			
			return _mapper.Map<IndexUserViewModel>(user);
		}

		/// <summary>
		/// Update personal photo of current user.
		/// </summary>
		/// <param name="file">Personal photo.</param>
		[Authorize]
		[HttpPost("[action]")]
		public async Task<ActionResult> UpdateAvatar(IFormFile file)
		{
			var avatar = file.ToModel();
			var fileId = await _fileRepository.Create(avatar);

			var user = await _userManager.GetUserAsync(User);
			user.AvatarFileId = fileId;
			await _userRepository.Update(user);
			return Ok();
		}
	}
}
