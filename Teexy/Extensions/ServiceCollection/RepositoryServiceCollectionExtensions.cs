using Microsoft.Extensions.DependencyInjection;
using Teexy.DAL;

namespace Teexy.Extensions.ServiceCollection
{
	public static class RepositoryServiceCollectionExtensions
	{
		public static IServiceCollection AddTeexyRepositories(this IServiceCollection services)
		{
			services.AddSingleton<ChallengeRepository>();
			services.AddSingleton<FileRepository>();
			services.AddSingleton<UserRepository>();
			services.AddSingleton<UserChallengeRepository>();

			return services;
		}
	}
}
