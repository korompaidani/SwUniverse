using Microsoft.EntityFrameworkCore.Migrations;

namespace StarWars.Data.Migrations
{
    public partial class OnToOnerelationshipbetweencharacterandlifeTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Characters_LifeTimeId",
                table: "Characters");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_LifeTimeId",
                table: "Characters",
                column: "LifeTimeId",
                unique: true,
                filter: "[LifeTimeId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Characters_LifeTimeId",
                table: "Characters");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_LifeTimeId",
                table: "Characters",
                column: "LifeTimeId");
        }
    }
}
