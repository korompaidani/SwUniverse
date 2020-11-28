using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarWars.Data.Migrations
{
    public partial class LifeTimeIdinCharacterTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "LifeTimeId",
                table: "Characters",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Characters_LifeTimeId",
                table: "Characters",
                column: "LifeTimeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Lifetimes_LifeTimeId",
                table: "Characters",
                column: "LifeTimeId",
                principalTable: "Lifetimes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Lifetimes_LifeTimeId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_LifeTimeId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "LifeTimeId",
                table: "Characters");
        }
    }
}
