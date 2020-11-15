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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Characters");
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

            modelBuilder.Entity("StarWars.Data.Entities.LifeTime", b =>
                {
                    b.Property<int>("BeginDate")
                        .HasColumnType("int");

                    b.Property<int>("EndDate")
                        .HasColumnType("int");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

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
                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Geography")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("History")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PlanetId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ShortDescription")
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)");

                    b.HasIndex("PlanetId");

                    b.ToTable("PlanetDescriptions");
                });

            modelBuilder.Entity("StarWars.Data.Entities.Species", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Species");
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

            modelBuilder.Entity("StarWars.Data.Entities.Planet", b =>
                {
                    b.Navigation("Moons");
                });
#pragma warning restore 612, 618
        }
    }
}
