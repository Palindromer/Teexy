using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teexy.DAL;
using Teexy.Models;

namespace Teexy.Extensions.ServiceCollection
{
	public static class IdentityServiceCollectionExtensions
	{
		public static IServiceCollection AddTeexyIdentity(this IServiceCollection services)
		{
			services.AddDefaultIdentity<User>(opt => {
				opt.Password.RequireUppercase = false;
			})
			.AddEntityFrameworkStores<TeexyContext>();


			services.ConfigureApplicationCookie(options =>
			{
				//this event is called when user is unauthorized and is redirected to login page
				options.Events.OnRedirectToLogin = context =>
				{
					context.Response.StatusCode = 401;

					return Task.CompletedTask;
				};
				options.Events.OnRedirectToAccessDenied = context =>
				{
					context.Response.StatusCode = 403;

					return Task.CompletedTask;
				};
			});

			return services;
		}
	}
}
