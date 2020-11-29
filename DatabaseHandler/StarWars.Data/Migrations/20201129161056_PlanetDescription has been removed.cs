using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarWars.Data.Migrations
{
    public partial class PlanetDescriptionhasbeenremoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlanetDescriptions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlanetDescriptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlanetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanetDescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanetDescriptions_Planets_PlanetId",
                        column: x => x.PlanetId,
                        principalTable: "Planets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlanetDescriptions_PlanetId",
                table: "PlanetDescriptions",
                column: "PlanetId");
        }
    }
}
