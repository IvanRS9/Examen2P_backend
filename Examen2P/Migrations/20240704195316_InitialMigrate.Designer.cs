﻿// <auto-generated />
using System;
using Examen2P.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Examen2P.Migrations
{
    [DbContext(typeof(ExamenContext))]
    [Migration("20240704195316_InitialMigrate")]
    partial class InitialMigrate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Examen2P.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Gama")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Gama = "Baja"
                        },
                        new
                        {
                            Id = 2,
                            Gama = "Media Baja"
                        },
                        new
                        {
                            Id = 3,
                            Gama = "Media"
                        },
                        new
                        {
                            Id = 4,
                            Gama = "Media Alta"
                        },
                        new
                        {
                            Id = 5,
                            Gama = "Alta"
                        });
                });

            modelBuilder.Entity("Examen2P.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Components")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Components = "Intel Core i3, 8GB RAM, 256GB SSD, GTX 1050",
                            CreatedAt = new DateTime(2024, 7, 4, 13, 53, 15, 826, DateTimeKind.Local).AddTicks(9603),
                            Description = "PC Gamer de entrada",
                            Image = "a",
                            Name = "Xtreme Entry",
                            Price = 12000f
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Components = "AMD Ryzen 5, 16GB RAM, 512GB SSD, GTX 1660",
                            CreatedAt = new DateTime(2024, 7, 4, 13, 53, 15, 826, DateTimeKind.Local).AddTicks(9617),
                            Description = "PC Gamer de gama media baja",
                            Image = "a",
                            Name = "Mid Range Warrior",
                            Price = 18000f
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Components = "Intel Core i5, 16GB RAM, 1TB SSD, RTX 2060",
                            CreatedAt = new DateTime(2024, 7, 4, 13, 53, 15, 826, DateTimeKind.Local).AddTicks(9620),
                            Description = "PC Gamer de gama media",
                            Image = "a",
                            Name = "Gamer Pro",
                            Price = 25000f
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 4,
                            Components = "AMD Ryzen 7, 32GB RAM, 1TB SSD, RTX 2070",
                            CreatedAt = new DateTime(2024, 7, 4, 13, 53, 15, 826, DateTimeKind.Local).AddTicks(9622),
                            Description = "PC Gamer de gama media alta",
                            Image = "a",
                            Name = "Elite Gaming",
                            Price = 32000f
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 5,
                            Components = "Intel Core i7, 32GB RAM, 2TB SSD, RTX 2080 Ti",
                            CreatedAt = new DateTime(2024, 7, 4, 13, 53, 15, 826, DateTimeKind.Local).AddTicks(9624),
                            Description = "PC Gamer de gama alta",
                            Image = "a",
                            Name = "Ultimate Beast",
                            Price = 45000f
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Components = "AMD Ryzen 3, 8GB RAM, 256GB SSD, RX 550",
                            CreatedAt = new DateTime(2024, 7, 4, 13, 53, 15, 826, DateTimeKind.Local).AddTicks(9628),
                            Description = "PC Gamer de entrada",
                            Image = "a",
                            Name = "Starter Pack",
                            Price = 11000f
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Components = "Intel Core i3, 16GB RAM, 512GB SSD, GTX 1650",
                            CreatedAt = new DateTime(2024, 7, 4, 13, 53, 15, 826, DateTimeKind.Local).AddTicks(9629),
                            Description = "PC Gamer de gama media baja",
                            Image = "a",
                            Name = "Budget Pro",
                            Price = 16000f
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Components = "AMD Ryzen 5, 16GB RAM, 1TB SSD, RTX 3050",
                            CreatedAt = new DateTime(2024, 7, 4, 13, 53, 15, 826, DateTimeKind.Local).AddTicks(9631),
                            Description = "PC Gamer de gama media",
                            Image = "a",
                            Name = "Performance Master",
                            Price = 23000f
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 4,
                            Components = "Intel Core i5, 32GB RAM, 1TB SSD, RTX 3070",
                            CreatedAt = new DateTime(2024, 7, 4, 13, 53, 15, 826, DateTimeKind.Local).AddTicks(9633),
                            Description = "PC Gamer de gama media alta",
                            Image = "a",
                            Name = "High End Fighter",
                            Price = 35000f
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 5,
                            Components = "AMD Ryzen 9, 64GB RAM, 2TB SSD, RTX 3090",
                            CreatedAt = new DateTime(2024, 7, 4, 13, 53, 15, 826, DateTimeKind.Local).AddTicks(9636),
                            Description = "PC Gamer de gama alta",
                            Image = "a",
                            Name = "Godlike Power",
                            Price = 50000f
                        });
                });

            modelBuilder.Entity("Examen2P.Models.Product", b =>
                {
                    b.HasOne("Examen2P.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Examen2P.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
