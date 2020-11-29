﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StarWars.Data.DbContexts;

namespace StarWars.Data.Migrations
{
    [DbContext(typeof(SwContext))]
    partial class SwContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("StarWars.Data.Entities.Affiliation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CharacterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("History")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CharacterId");

                    b.ToTable("Affiliations");
                });

            modelBuilder.Entity("StarWars.Data.Entities.Character", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FamilyName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("GivenName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid?>("LifeTimeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SpeciesName")
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("LifeTimeId")
                        .IsUnique()
                        .HasFilter("[LifeTimeId] IS NOT NULL");

                    b.HasIndex("SpeciesName")
                        .IsUnique()
                        .HasFilter("[SpeciesName] IS NOT NULL");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("StarWars.Data.Entities.CharactersInFilms", b =>
                {
                    b.Property<Guid>("CharacterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FilmId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CharacterId", "FilmId");

                    b.HasIndex("FilmId");

                    b.ToTable("CharactersInFilms");
                });

            modelBuilder.Entity("StarWars.Data.Entities.CharactersInSeries", b =>
                {
                    b.Property<Guid>("CharacterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SeriesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CharacterId", "SeriesId");

                    b.HasIndex("SeriesId");

                    b.ToTable("CharactersInSeries");
                });

            modelBuilder.Entity("StarWars.Data.Entities.Event", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("StarWars.Data.Entities.Film", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Film");
                });

            modelBuilder.Entity("StarWars.Data.Entities.LifeTime", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("BeginDate")
                        .HasColumnType("int");

                    b.Property<int?>("EndDate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Lifetimes");
                });

            modelBuilder.Entity("StarWars.Data.Entities.Planet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("HasRing")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDestroyed")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid?>("PlanetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Shape")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlanetId");

                    b.ToTable("Planets");
                });

            modelBuilder.Entity("StarWars.Data.Entities.PlanetDescription", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FloraAndFauna")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Geography")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("History")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCrystalSite")
                        .HasColumnType("bit");

                    b.Property<Guid>("PlanetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ShortDescription")
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)");

                    b.HasKey("Id");

                    b.HasIndex("PlanetId");

                    b.ToTable("PlanetDescriptions");
                });

            modelBuilder.Entity("StarWars.Data.Entities.Series", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Series");
                });

            modelBuilder.Entity("StarWars.Data.Entities.Species", b =>
                {
                    b.Property<string>("Name")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<Guid?>("PlanetDescriptionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Name");

                    b.HasIndex("PlanetDescriptionId");

                    b.ToTable("Species");
                });

            modelBuilder.Entity("StarWars.Data.Entities.Affiliation", b =>
                {
                    b.HasOne("StarWars.Data.Entities.Character", null)
                        .WithMany("MemberOf")
                        .HasForeignKey("CharacterId");
                });

            modelBuilder.Entity("StarWars.Data.Entities.Character", b =>
                {
                    b.HasOne("StarWars.Data.Entities.LifeTime", "LifeTime")
                        .WithOne("Character")
                        .HasForeignKey("StarWars.Data.Entities.Character", "LifeTimeId");

                    b.HasOne("StarWars.Data.Entities.Species", "Species")
                        .WithOne("Character")
                        .HasForeignKey("StarWars.Data.Entities.Character", "SpeciesName");

                    b.Navigation("LifeTime");

                    b.Navigation("Species");
                });

            modelBuilder.Entity("StarWars.Data.Entities.CharactersInFilms", b =>
                {
                    b.HasOne("StarWars.Data.Entities.Character", "Character")
                        .WithMany("CharactersInFilms")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StarWars.Data.Entities.Film", "Film")
                        .WithMany("CharactersInFilms")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Film");
                });

            modelBuilder.Entity("StarWars.Data.Entities.CharactersInSeries", b =>
                {
                    b.HasOne("StarWars.Data.Entities.Character", "Character")
                        .WithMany("CharactersInSeries")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StarWars.Data.Entities.Series", "Series")
                        .WithMany("CharactersInSeries")
                        .HasForeignKey("SeriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Series");
                });

            modelBuilder.Entity("StarWars.Data.Entities.Planet", b =>
                {
                    b.HasOne("StarWars.Data.Entities.Planet", null)
                        .WithMany("Moons")
                        .HasForeignKey("PlanetId");
                });

            modelBuilder.Entity("StarWars.Data.Entities.PlanetDescription", b =>
                {
                    b.HasOne("StarWars.Data.Entities.Planet", "Planet")
                        .WithMany()
                        .HasForeignKey("PlanetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Planet");
                });

            modelBuilder.Entity("StarWars.Data.Entities.Species", b =>
                {
                    b.HasOne("StarWars.Data.Entities.PlanetDescription", null)
                        .WithMany("NativeSpecies")
                        .HasForeignKey("PlanetDescriptionId");
                });

            modelBuilder.Entity("StarWars.Data.Entities.Character", b =>
                {
                    b.Navigation("CharactersInFilms");

                    b.Navigation("CharactersInSeries");

                    b.Navigation("MemberOf");
                });

            modelBuilder.Entity("StarWars.Data.Entities.Film", b =>
                {
                    b.Navigation("CharactersInFilms");
                });

            modelBuilder.Entity("StarWars.Data.Entities.LifeTime", b =>
                {
                    b.Navigation("Character");
                });

            modelBuilder.Entity("StarWars.Data.Entities.Planet", b =>
                {
                    b.Navigation("Moons");
                });

            modelBuilder.Entity("StarWars.Data.Entities.PlanetDescription", b =>
                {
                    b.Navigation("NativeSpecies");
                });

            modelBuilder.Entity("StarWars.Data.Entities.Series", b =>
                {
                    b.Navigation("CharactersInSeries");
                });

            modelBuilder.Entity("StarWars.Data.Entities.Species", b =>
                {
                    b.Navigation("Character");
                });
#pragma warning restore 612, 618
        }
    }
}
