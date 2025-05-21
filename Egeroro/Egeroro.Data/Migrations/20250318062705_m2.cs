using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Egeroro.Data.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Fleets");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MyProperty",
                table: "Fleets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
