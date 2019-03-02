﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Teexy.DAL;

namespace Teexy.DAL.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20190302164902_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Teexy.Models.Challenge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("Score");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Challenges");
                });

            modelBuilder.Entity("Teexy.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Teexy.Models.UserChallenge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ChallengeId");

                    b.Property<int>("Status");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ChallengeId");

                    b.HasIndex("UserId");

                    b.ToTable("UserChallenge");
                });

            modelBuilder.Entity("Teexy.Models.UserChallenge", b =>
                {
                    b.HasOne("Teexy.Models.Challenge", "Challenge")
                        .WithMany()
                        .HasForeignKey("ChallengeId");

                    b.HasOne("Teexy.Models.User")
                        .WithMany("Challenges")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
