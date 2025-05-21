using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egeroro.Data.Migrations
{
    public partial class m5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DetailDescription",
                table: "OurServices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DetailDescription2",
                table: "OurServices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DetailDescription3",
                table: "OurServices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DetailTitle2",
                table: "OurServices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DetailTitle3",
                table: "OurServices",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DetailDescription",
                table: "OurServices");

            migrationBuilder.DropColumn(
                name: "DetailDescription2",
                table: "OurServices");

            migrationBuilder.DropColumn(
                name: "DetailDescription3",
                table: "OurServices");

            migrationBuilder.DropColumn(
                name: "DetailTitle2",
                table: "OurServices");

            migrationBuilder.DropColumn(
                name: "DetailTitle3",
                table: "OurServices");
        }
    }
}
