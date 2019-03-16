﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Teexy.DAL;

namespace Teexy.DAL.Migrations
{
    [DbContext(typeof(TeexyContext))]
    [Migration("20190315011911_fileds")]
    partial class fileds
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UsersLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UsersTokens");
                });

            modelBuilder.Entity("Teexy.Models.Challenge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BackgroundImageUrl");

                    b.Property<int>("Category");

                    b.Property<string>("Description");

                    b.Property<string>("EmblemImageUrl");

                    b.Property<bool>("IsActive");

                    b.Property<int>("JoinersCount");

                    b.Property<int?>("QuotaCount");

                    b.Property<int>("Score");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Challenges");
                });

            modelBuilder.Entity("Teexy.Models.ChallengeDecription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ChallengeId");

                    b.Property<string>("Text");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("ChallengeId");

                    b.ToTable("ChallengeDecriptions");
                });

            modelBuilder.Entity("Teexy.Models.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("Body");

                    b.Property<string>("ContentType");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("Teexy.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<int?>("AvatarFileId");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<int>("Score");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("AvatarFileId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Teexy.Models.UserChallenge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ChallengeId");

                    b.Property<int?>("CommentsCount");

                    b.Property<DateTime>("DoneDateTime");

                    b.Property<int?>("LikesCount");

                    b.Property<int?>("ProofFileId");

                    b.Property<int>("Status");

                    b.Property<DateTime>("TakenDateTime");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ChallengeId");

                    b.HasIndex("ProofFileId");

                    b.HasIndex("UserId");

                    b.ToTable("UserChallenges");
                });

            modelBuilder.Entity("Teexy.Models.UserChallengeComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Text");

                    b.Property<int?>("UserChallengeId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserChallengeId");

                    b.HasIndex("UserId");

                    b.ToTable("UserChallengeComments");
                });

            modelBuilder.Entity("Teexy.Models.UserChallengeLike", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("UserChallengeId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserChallengeId");

                    b.HasIndex("UserId");

                    b.ToTable("UserChallengeLikes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Teexy.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Teexy.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Teexy.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Teexy.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Teexy.Models.ChallengeDecription", b =>
                {
                    b.HasOne("Teexy.Models.Challenge")
                        .WithMany("Descriptions")
                        .HasForeignKey("ChallengeId");
                });

            modelBuilder.Entity("Teexy.Models.User", b =>
                {
                    b.HasOne("Teexy.Models.File", "AvatarFile")
                        .WithMany()
                        .HasForeignKey("AvatarFileId");
                });

            modelBuilder.Entity("Teexy.Models.UserChallenge", b =>
                {
                    b.HasOne("Teexy.Models.Challenge", "Challenge")
                        .WithMany()
                        .HasForeignKey("ChallengeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Teexy.Models.File", "ProofFile")
                        .WithMany()
                        .HasForeignKey("ProofFileId");

                    b.HasOne("Teexy.Models.User", "User")
                        .WithMany("Challenges")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Teexy.Models.UserChallengeComment", b =>
                {
                    b.HasOne("Teexy.Models.UserChallenge", "UserChallenge")
                        .WithMany("Comments")
                        .HasForeignKey("UserChallengeId");

                    b.HasOne("Teexy.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Teexy.Models.UserChallengeLike", b =>
                {
                    b.HasOne("Teexy.Models.UserChallenge", "UserChallenge")
                        .WithMany("Likes")
                        .HasForeignKey("UserChallengeId");

                    b.HasOne("Teexy.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
