using Microsoft.EntityFrameworkCore.Migrations;

namespace StarWars.Data.Migrations
{
    public partial class OnToOnerelationshipbetweencharacterandspecies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Characters_SpeciesName",
                table: "Characters");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_SpeciesName",
                table: "Characters",
                column: "SpeciesName",
                unique: true,
                filter: "[SpeciesName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Characters_SpeciesName",
                table: "Characters");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_SpeciesName",
                table: "Characters",
                column: "SpeciesName");
        }
    }
}
