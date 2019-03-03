﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Teexy.DAL.Migrations
{
    public partial class likesCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LikesCount",
                table: "ChallengeProofs",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LikesCount",
                table: "ChallengeProofs");
        }
    }
}
