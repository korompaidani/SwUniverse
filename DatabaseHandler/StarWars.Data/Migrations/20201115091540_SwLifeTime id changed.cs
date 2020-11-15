using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarWars.Data.Migrations
{
    public partial class SwLifeTimeidchanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lifetimes_Characters_Id1",
                table: "Lifetimes");

            migrationBuilder.DropIndex(
                name: "IX_Lifetimes_Id1",
                table: "Lifetimes");

            migrationBuilder.DropColumn(
                name: "Id1",
                table: "Lifetimes");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Lifetimes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "Lifetimes");

            migrationBuilder.AddColumn<Guid>(
                name: "Id1",
                table: "Lifetimes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lifetimes_Id1",
                table: "Lifetimes",
                column: "Id1");

            migrationBuilder.AddForeignKey(
                name: "FK_Lifetimes_Characters_Id1",
                table: "Lifetimes",
                column: "Id1",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
