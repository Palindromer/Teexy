using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.IO;
using System.Xml.XPath;

namespace Teexy.Extensions.ServiceCollection
{
	public static class SwaggerServiceCollectionExtensions
	{
		public static IServiceCollection AddTeexySwagger(this IServiceCollection services)
		{
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new Info { Title = "Teexy API", Version = "v1" });


				c.DescribeAllEnumsAsStrings();

				var teexyXmlPath = Path.Combine(AppContext.BaseDirectory, $"Teexy.xml");
				var teexyModelsXmlPath = Path.Combine(AppContext.BaseDirectory, $"Teexy.Models.xml");

				if (File.Exists(teexyXmlPath))
				{
					c.IncludeXmlComments(teexyXmlPath);
				}
				if (File.Exists(teexyModelsXmlPath))
				{
					c.IncludeXmlComments(teexyModelsXmlPath);
				}

			});

			return services;
		}
	}
}
