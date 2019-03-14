using Microsoft.EntityFrameworkCore.Migrations;

namespace Teexy.DAL.Migrations
{
    public partial class Four : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ProofFileId",
                table: "UserChallenges",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_UserChallenges_ProofFileId",
                table: "UserChallenges",
                column: "ProofFileId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserChallenges_Files_ProofFileId",
                table: "UserChallenges",
                column: "ProofFileId",
                principalTable: "Files",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserChallenges_Files_ProofFileId",
                table: "UserChallenges");

            migrationBuilder.DropIndex(
                name: "IX_UserChallenges_ProofFileId",
                table: "UserChallenges");

            migrationBuilder.AlterColumn<int>(
                name: "ProofFileId",
                table: "UserChallenges",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
