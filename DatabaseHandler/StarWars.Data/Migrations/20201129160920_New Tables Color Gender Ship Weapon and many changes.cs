using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarWars.Data.Migrations
{
    public partial class NewTablesColorGenderShipWeaponandmanychanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Affiliations_Characters_CharacterId",
                table: "Affiliations");

            migrationBuilder.DropForeignKey(
                name: "FK_Planets_Planets_PlanetId",
                table: "Planets");

            migrationBuilder.DropForeignKey(
                name: "FK_Species_PlanetDescriptions_PlanetDescriptionId",
                table: "Species");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "PlanetDescriptions");

            migrationBuilder.DropColumn(
                name: "FloraAndFauna",
                table: "PlanetDescriptions");

            migrationBuilder.DropColumn(
                name: "Geography",
                table: "PlanetDescriptions");

            migrationBuilder.DropColumn(
                name: "History",
                table: "PlanetDescriptions");

            migrationBuilder.DropColumn(
                name: "IsCrystalSite",
                table: "PlanetDescriptions");

            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "PlanetDescriptions");

            migrationBuilder.RenameColumn(
                name: "PlanetDescriptionId",
                table: "Species",
                newName: "PlanetForNativeId");

            migrationBuilder.RenameIndex(
                name: "IX_Species_PlanetDescriptionId",
                table: "Species",
                newName: "IX_Species_PlanetForNativeId");

            migrationBuilder.RenameColumn(
                name: "PlanetId",
                table: "Planets",
                newName: "PlanetForMoonId");

            migrationBuilder.RenameIndex(
                name: "IX_Planets_PlanetId",
                table: "Planets",
                newName: "IX_Planets_PlanetForMoonId");

            migrationBuilder.RenameColumn(
                name: "CharacterId",
                table: "Affiliations",
                newName: "CharacterAsMemberId");

            migrationBuilder.RenameIndex(
                name: "IX_Affiliations_CharacterId",
                table: "Affiliations",
                newName: "IX_Affiliations_CharacterAsMemberId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Planets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FloraAndFauna",
                table: "Planets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Geography",
                table: "Planets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "History",
                table: "Planets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCrystalSite",
                table: "Planets",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "Planets",
                type: "nvarchar(1500)",
                maxLength: 1500,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CharacterForApprenticeId",
                table: "Characters",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CharacterForMasterId",
                table: "Characters",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EyeColorId",
                table: "Characters",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FavouriteShipId",
                table: "Characters",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FavouriteWeaponId",
                table: "Characters",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "GenderId",
                table: "Characters",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "HairColorId",
                table: "Characters",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasTattoo",
                table: "Characters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "HomeWorldId",
                table: "Characters",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SkinColorId",
                table: "Characters",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SkinPattern",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Specialrecognizance",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ColorName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenderName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ships",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShipName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Kind = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasHyperSpaceEngine = table.Column<bool>(type: "bit", nullable: false),
                    CharacterForOwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ships", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ships_Characters_CharacterForOwnerId",
                        column: x => x.CharacterForOwnerId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WeaponName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CharacterForOwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weapons_Characters_CharacterForOwnerId",
                        column: x => x.CharacterForOwnerId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_CharacterForApprenticeId",
                table: "Characters",
                column: "CharacterForApprenticeId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_CharacterForMasterId",
                table: "Characters",
                column: "CharacterForMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_EyeColorId",
                table: "Characters",
                column: "EyeColorId",
                unique: true,
                filter: "[EyeColorId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_FavouriteShipId",
                table: "Characters",
                column: "FavouriteShipId",
                unique: true,
                filter: "[FavouriteShipId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_FavouriteWeaponId",
                table: "Characters",
                column: "FavouriteWeaponId",
                unique: true,
                filter: "[FavouriteWeaponId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_GenderId",
                table: "Characters",
                column: "GenderId",
                unique: true,
                filter: "[GenderId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_HairColorId",
                table: "Characters",
                column: "HairColorId",
                unique: true,
                filter: "[HairColorId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_HomeWorldId",
                table: "Characters",
                column: "HomeWorldId",
                unique: true,
                filter: "[HomeWorldId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_SkinColorId",
                table: "Characters",
                column: "SkinColorId",
                unique: true,
                filter: "[SkinColorId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Ships_CharacterForOwnerId",
                table: "Ships",
                column: "CharacterForOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_CharacterForOwnerId",
                table: "Weapons",
                column: "CharacterForOwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Affiliations_Characters_CharacterAsMemberId",
                table: "Affiliations",
                column: "CharacterAsMemberId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Characters_CharacterForApprenticeId",
                table: "Characters",
                column: "CharacterForApprenticeId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Characters_CharacterForMasterId",
                table: "Characters",
                column: "CharacterForMasterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Colors_EyeColorId",
                table: "Characters",
                column: "EyeColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Colors_HairColorId",
                table: "Characters",
                column: "HairColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Colors_SkinColorId",
                table: "Characters",
                column: "SkinColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Genders_GenderId",
                table: "Characters",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Planets_HomeWorldId",
                table: "Characters",
                column: "HomeWorldId",
                principalTable: "Planets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Ships_FavouriteShipId",
                table: "Characters",
                column: "FavouriteShipId",
                principalTable: "Ships",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Weapons_FavouriteWeaponId",
                table: "Characters",
                column: "FavouriteWeaponId",
                principalTable: "Weapons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Planets_Planets_PlanetForMoonId",
                table: "Planets",
                column: "PlanetForMoonId",
                principalTable: "Planets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Species_Planets_PlanetForNativeId",
                table: "Species",
                column: "PlanetForNativeId",
                principalTable: "Planets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Affiliations_Characters_CharacterAsMemberId",
                table: "Affiliations");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Characters_CharacterForApprenticeId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Characters_CharacterForMasterId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Colors_EyeColorId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Colors_HairColorId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Colors_SkinColorId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Genders_GenderId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Planets_HomeWorldId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Ships_FavouriteShipId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Weapons_FavouriteWeaponId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Planets_Planets_PlanetForMoonId",
                table: "Planets");

            migrationBuilder.DropForeignKey(
                name: "FK_Species_Planets_PlanetForNativeId",
                table: "Species");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Ships");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropIndex(
                name: "IX_Characters_CharacterForApprenticeId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_CharacterForMasterId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_EyeColorId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_FavouriteShipId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_FavouriteWeaponId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_GenderId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_HairColorId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_HomeWorldId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_SkinColorId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Planets");

            migrationBuilder.DropColumn(
                name: "FloraAndFauna",
                table: "Planets");

            migrationBuilder.DropColumn(
                name: "Geography",
                table: "Planets");

            migrationBuilder.DropColumn(
                name: "History",
                table: "Planets");

            migrationBuilder.DropColumn(
                name: "IsCrystalSite",
                table: "Planets");

            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "Planets");

            migrationBuilder.DropColumn(
                name: "CharacterForApprenticeId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "CharacterForMasterId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "EyeColorId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "FavouriteShipId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "FavouriteWeaponId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "HairColorId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "HasTattoo",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "HomeWorldId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "SkinColorId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "SkinPattern",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Specialrecognizance",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Characters");

            migrationBuilder.RenameColumn(
                name: "PlanetForNativeId",
                table: "Species",
                newName: "PlanetDescriptionId");

            migrationBuilder.RenameIndex(
                name: "IX_Species_PlanetForNativeId",
                table: "Species",
                newName: "IX_Species_PlanetDescriptionId");

            migrationBuilder.RenameColumn(
                name: "PlanetForMoonId",
                table: "Planets",
                newName: "PlanetId");

            migrationBuilder.RenameIndex(
                name: "IX_Planets_PlanetForMoonId",
                table: "Planets",
                newName: "IX_Planets_PlanetId");

            migrationBuilder.RenameColumn(
                name: "CharacterAsMemberId",
                table: "Affiliations",
                newName: "CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_Affiliations_CharacterAsMemberId",
                table: "Affiliations",
                newName: "IX_Affiliations_CharacterId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "PlanetDescriptions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FloraAndFauna",
                table: "PlanetDescriptions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Geography",
                table: "PlanetDescriptions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "History",
                table: "PlanetDescriptions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCrystalSite",
                table: "PlanetDescriptions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "PlanetDescriptions",
                type: "nvarchar(1500)",
                maxLength: 1500,
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Affiliations_Characters_CharacterId",
                table: "Affiliations",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Planets_Planets_PlanetId",
                table: "Planets",
                column: "PlanetId",
                principalTable: "Planets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Species_PlanetDescriptions_PlanetDescriptionId",
                table: "Species",
                column: "PlanetDescriptionId",
                principalTable: "PlanetDescriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
