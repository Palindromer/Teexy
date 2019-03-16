using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teexy.DAL;
using Teexy.Models;

namespace Teexy.Extensions.ApplicationBuilder
{
	public static class SwaggerApplicationBuilderExtensions
	{
		public static IApplicationBuilder UseTeexySwagger(this IApplicationBuilder app)
		{
			app.UseSwagger();
			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "Teexy API V1");
			});

			return app;
		}
	}
}
