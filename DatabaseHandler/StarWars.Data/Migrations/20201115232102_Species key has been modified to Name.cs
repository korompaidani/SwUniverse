using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarWars.Data.Migrations
{
    public partial class SpecieskeyhasbeenmodifiedtoName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Species_SpeciesId",
                table: "Characters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Species",
                table: "Species");

            migrationBuilder.DropIndex(
                name: "IX_Characters_SpeciesId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Species");

            migrationBuilder.DropColumn(
                name: "SpeciesId",
                table: "Characters");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Species",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "SpeciesName",
                table: "Characters",
                type: "nvarchar(15)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Species",
                table: "Species",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_SpeciesName",
                table: "Characters",
                column: "SpeciesName");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Species_SpeciesName",
                table: "Characters",
                column: "SpeciesName",
                principalTable: "Species",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Species_SpeciesName",
                table: "Characters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Species",
                table: "Species");

            migrationBuilder.DropIndex(
                name: "IX_Characters_SpeciesName",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "SpeciesName",
                table: "Characters");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Species",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Species",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "SpeciesId",
                table: "Characters",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Species",
                table: "Species",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_SpeciesId",
                table: "Characters",
                column: "SpeciesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Species_SpeciesId",
                table: "Characters",
                column: "SpeciesId",
                principalTable: "Species",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
