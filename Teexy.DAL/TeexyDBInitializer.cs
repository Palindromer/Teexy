using AutoFixture;
using System;
using System.Linq;
using Teexy.Models;


namespace Teexy.DAL
{
	public class TeexyDBInitializer
	{
		public void Seed(TeexyContext context)
		{
			context.Database.EnsureDeleted();
			context.Database.EnsureCreated();
			//context.Database.Migrate();
			
			var user = new User()
			{
				Id = Guid.NewGuid().ToString(),
				Name = "Vasya",
				PasswordHash = "afweioj"
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
				.With(uch => uch.User, () => { return user; })
				.With(uch => uch.Challenge, () => { return fixture.Create<Challenge>(); })
				.CreateMany(20).ToList();
			


			context.UserChallenges.Add(userChallenge);
			context.UserChallenges.AddRange(userChList);
			context.SaveChanges();
		}
	}

}
