using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teexy.ViewModels
{
	public class RegisterViewModel
	{
		[Required]
		[EmailAddress(ErrorMessage = "Некоректна Email-адреса")]
		public string Email { get; set; }

		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Required]
		[DataType(DataType.Password)]
		[Compare(nameof(Password))]
		public string PasswordConfirm { get; set; }
	}
}
