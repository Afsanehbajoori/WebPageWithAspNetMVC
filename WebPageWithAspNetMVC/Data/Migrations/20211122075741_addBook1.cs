using Microsoft.EntityFrameworkCore.Migrations;

namespace WebPageWithAspNetMVC.Data.Migrations
{
    public partial class addBook1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Book",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Book");
        }
    }
}
