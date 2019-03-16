using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teexy.Models;
using Teexy.ViewModels;

namespace Teexy.Controllers
{
	[Route("api/[controller]")]
	public class AccountController : ControllerBase
	{
		private readonly UserManager<User> _userManager;
		private readonly SignInManager<User> _signInManager;

		public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
		{
			_userManager = userManager;
			_signInManager = signInManager;
		}

		[HttpPost("[action]")]
		public async Task<IActionResult> Register(RegisterViewModel model)
		{
			if (ModelState.IsValid)
			{
				var user = new User { Email = model.Email, UserName = model.Email };

				// добавляем пользователя
				var result = await _userManager.CreateAsync(user, model.Password);
				if (result.Succeeded)
				{
					// установка куки
					await _signInManager.SignInAsync(user, false);
					return Ok();
				}
				else
				{
					foreach (var error in result.Errors)
					{
						ModelState.AddModelError(string.Empty, error.Description);
					}
				}
			}
			return StatusCode(401, ModelState.Values.SelectMany(v => v.Errors));
		}

		[HttpPost("[action]")]
		public async Task<IActionResult> Login(LoginViewModel model)
		{
			if (ModelState.IsValid)
			{
				var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
				if (result.Succeeded)
				{
					// проверяем, принадлежит ли URL приложению
					return Ok();
				}
				else
				{
					ModelState.AddModelError("", "Неправильний логін і (або) пароль");
				}
			}
			return StatusCode(401, ModelState.Values.SelectMany(v => v.Errors));
		}

		[HttpPost("[action]")]
		public async Task<IActionResult> LogOff()
		{
			// удаляем аутентификационные куки
			await _signInManager.SignOutAsync();
			return Ok();
		}
	}
}
