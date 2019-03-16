using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Teexy.DAL.Migrations
{
    public partial class fileds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserChallenges_Challenges_ChallengeId",
                table: "UserChallenges");

            migrationBuilder.AlterColumn<int>(
                name: "ChallengeId",
                table: "UserChallenges",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DoneDateTime",
                table: "UserChallenges",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "TakenDateTime",
                table: "UserChallenges",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_UserChallenges_Challenges_ChallengeId",
                table: "UserChallenges",
                column: "ChallengeId",
                principalTable: "Challenges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserChallenges_Challenges_ChallengeId",
                table: "UserChallenges");

            migrationBuilder.DropColumn(
                name: "DoneDateTime",
                table: "UserChallenges");

            migrationBuilder.DropColumn(
                name: "TakenDateTime",
                table: "UserChallenges");

            migrationBuilder.AlterColumn<int>(
                name: "ChallengeId",
                table: "UserChallenges",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_UserChallenges_Challenges_ChallengeId",
                table: "UserChallenges",
                column: "ChallengeId",
                principalTable: "Challenges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
