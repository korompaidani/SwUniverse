using Microsoft.EntityFrameworkCore.Migrations;

namespace StarWars.Data.Migrations
{
    public partial class societysucks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "History4",
                table: "Society",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "History4",
                table: "Society");
        }
    }
}
