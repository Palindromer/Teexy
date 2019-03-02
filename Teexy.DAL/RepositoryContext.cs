using AutoFixture;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Teexy.Models;

namespace Teexy.DAL
{
	public class RepositoryContext : DbContext
	{
		public RepositoryContext()
		{

		}

		public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
		{

		}


		public DbSet<User> Users { get; set; }

		public DbSet<UserChallenge> UserChallenges { get; set; }

		public DbSet<Challenge> Challenges { get; set; }


		protected override void OnConfiguring(DbContextOptionsBuilder builder)
		{
			builder.UseMySql("server=palmysqlserver.mysql.database.azure.com; Port=3306; Database=Teexy; Uid=Palindromer@palmysqlserver; Pwd=jfrpz(*#5; SslMode=Preferred;");
		}
	}

	public class TeexyDBInitializer
	{
		public void Seed(RepositoryContext context)
		{
			context.Database.EnsureDeleted();
			context.Database.EnsureCreated();
			//context.Database.Migrate();

			var user = new User()
			{
				Id = 235,
				Name = "Vasya"
			};

			var userChallenge = new UserChallenge()
			{
				Id = 1,
				User = user,
				Status = ChallengeStatus.InProgress,
				Challenge = new Challenge()
				{
					Id = 0,
					Title = "Посадити дерево",
					Description = "Підвищуємо екологію!!!",
					Score = 15
				}
			};

			var fixture = new Fixture();

			var userChList = fixture.Build<UserChallenge>()
				.With(uch => uch.User, user)
				.With(uch => uch.Challenge, () => { return fixture.Create<Challenge>(); })
				.CreateMany(20);




			context.UserChallenges.Add(userChallenge);
			context.UserChallenges.AddRange(userChList);
			context.SaveChanges();
		}
	}

}
