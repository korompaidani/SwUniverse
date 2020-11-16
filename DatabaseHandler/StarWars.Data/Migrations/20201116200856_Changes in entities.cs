using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarWars.Data.Migrations
{
    public partial class Changesinentities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PlanetDescriptionId",
                table: "Species",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "PlanetDescriptions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "FloraAndFauna",
                table: "PlanetDescriptions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlanetDescriptions",
                table: "PlanetDescriptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lifetimes",
                table: "Lifetimes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Species_PlanetDescriptionId",
                table: "Species",
                column: "PlanetDescriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Species_PlanetDescriptions_PlanetDescriptionId",
                table: "Species",
                column: "PlanetDescriptionId",
                principalTable: "PlanetDescriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Species_PlanetDescriptions_PlanetDescriptionId",
                table: "Species");

            migrationBuilder.DropIndex(
                name: "IX_Species_PlanetDescriptionId",
                table: "Species");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlanetDescriptions",
                table: "PlanetDescriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lifetimes",
                table: "Lifetimes");

            migrationBuilder.DropColumn(
                name: "PlanetDescriptionId",
                table: "Species");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PlanetDescriptions");

            migrationBuilder.DropColumn(
                name: "FloraAndFauna",
                table: "PlanetDescriptions");
        }
    }
}
