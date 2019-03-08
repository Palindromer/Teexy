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

		public DbSet<ChallengeDecription> ChallengeDecriptions { get; set; }

		public DbSet<File> Files { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder builder)
		{
			builder.EnableSensitiveDataLogging(true);
			//builder.UseMySql("server=localhost;port=3306;UserId=rooter;Password=rooter;database=teexy;");
			builder.UseMySql("server=91.227.183.147;port=8306;UserId=teexy-user;Password=teexy-user;database=teexy;");
			//builder.UseMySql("server=palmysqlserver.mysql.database.azure.com; Port=3306; Database=Teexy; Uid=Palindromer@palmysqlserver; Pwd=jfrpz(*#5; SslMode=Preferred;");
		}
	}
}
