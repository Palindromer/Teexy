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
			builder.EnableSensitiveDataLogging(true);
			builder.UseMySql("server=localhost;port=3306;UserId=rooter;Password=rooter;database=teexy;");
		}
	}
}
