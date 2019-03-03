using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Teexy.DAL;
using Teexy.Models;
using Teexy.ViewModels;

namespace Teexy.Controllers
{
	[Route("api/[controller]")]
	public class UsersController : Controller
	{
		private UserRepository _userRepository;

		private readonly UserManager<User> _userManager;

		public UsersController(UserRepository userRepository, UserManager<User> userManager)
		{
			_userRepository = userRepository;
			_userManager = userManager;
		}

		[Authorize]
		[HttpGet("[action]")]
		public async Task<IndexUserViewModel> My()
		{
			var user = await _userManager.GetUserAsync(this.User);
			return IndexUserViewModel.FromUser(user);
		}

		[HttpGet("{id}")]
		public async Task<IndexUserViewModel> GetUser(string id)
		{
			var user = await _userRepository.Get(id);			
			return IndexUserViewModel.FromUser(user);
		}
	}
}
