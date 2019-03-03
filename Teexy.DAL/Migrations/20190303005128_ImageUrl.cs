using Microsoft.EntityFrameworkCore.Migrations;

namespace Teexy.DAL.Migrations
{
    public partial class ImageUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BackgroundImageUrl",
                table: "Challenges",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmblemImageUrl",
                table: "Challenges",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BackgroundImageUrl",
                table: "Challenges");

            migrationBuilder.DropColumn(
                name: "EmblemImageUrl",
                table: "Challenges");
        }
    }
}
