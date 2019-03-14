using Microsoft.EntityFrameworkCore.Migrations;

namespace Teexy.DAL.Migrations
{
    public partial class Five : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommentCount",
                table: "UserChallenges");

            migrationBuilder.AlterColumn<int>(
                name: "LikesCount",
                table: "UserChallenges",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CommentsCount",
                table: "UserChallenges",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommentsCount",
                table: "UserChallenges");

            migrationBuilder.AlterColumn<int>(
                name: "LikesCount",
                table: "UserChallenges",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CommentCount",
                table: "UserChallenges",
                nullable: false,
                defaultValue: 0);
        }
    }
}
