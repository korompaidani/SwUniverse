using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarWars.Data.Migrations
{
    public partial class LifeTimeIdGuidpropertyisnullableinCharactertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Lifetimes_LifeTimeId",
                table: "Characters");

            migrationBuilder.AlterColumn<Guid>(
                name: "LifeTimeId",
                table: "Characters",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Lifetimes_LifeTimeId",
                table: "Characters",
                column: "LifeTimeId",
                principalTable: "Lifetimes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Lifetimes_LifeTimeId",
                table: "Characters");

            migrationBuilder.AlterColumn<Guid>(
                name: "LifeTimeId",
                table: "Characters",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Lifetimes_LifeTimeId",
                table: "Characters",
                column: "LifeTimeId",
                principalTable: "Lifetimes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
