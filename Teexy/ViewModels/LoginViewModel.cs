using System.ComponentModel.DataAnnotations;

namespace Teexy.ViewModels
{
	public class LoginViewModel
	{
		[Required]
		[EmailAddress(ErrorMessage = "Некоректна Email-адреса")]
		public string Email { get; set; }

		[Required]
		public string Password { get; set; }

		public bool RememberMe { get; set; }
	}
}
