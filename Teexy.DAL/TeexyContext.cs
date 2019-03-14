using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using Teexy.Models;

namespace Teexy.DAL
{
	public class TeexyContext : IdentityDbContext<User>
	{
		public TeexyContext(DbContextOptions<TeexyContext> options) : base(options)
		{
			// Database.EnsureCreated();
		}

		public DbSet<UserChallenge> UserChallenges { get; set; }

		public DbSet<Challenge> Challenges { get; set; }

		public DbSet<ChallengeDecription> ChallengeDecriptions { get; set; }

		public DbSet<File> Files { get; set; }

		public DbSet<UserChallengeComment> UserChallengeComments { get; set; }

		public DbSet<UserChallengeLike> UserChallengeLikes { get; set; }


		protected override void OnConfiguring(DbContextOptionsBuilder builder)
		{
			//builder.EnableSensitiveDataLogging(true);
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			// Identity rename table-names:
			builder.Entity<User>().ToTable("users");
			builder.Entity<IdentityRole>().ToTable("Roles");
			builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles");
			builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims");
			builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims");
			builder.Entity<IdentityUserLogin<string>>().ToTable("UsersLogins");
			builder.Entity<IdentityUserToken<string>>().ToTable("UsersTokens");
		}
	}
}
