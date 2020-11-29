using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarWars.Data.Migrations
{
    public partial class SpeciesIdadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
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
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Species",
                table: "Species",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_SpeciesId",
                table: "Characters",
                column: "SpeciesId",
                unique: true,
                filter: "[SpeciesId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Species_SpeciesId",
                table: "Characters",
                column: "SpeciesId",
                principalTable: "Species",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true);

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
                column: "SpeciesName",
                unique: true,
                filter: "[SpeciesName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Species_SpeciesName",
                table: "Characters",
                column: "SpeciesName",
                principalTable: "Species",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
