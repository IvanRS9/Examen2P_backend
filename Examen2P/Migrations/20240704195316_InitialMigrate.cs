using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Examen2P.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Components = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Gama" },
                values: new object[,]
                {
                    { 1, "Baja" },
                    { 2, "Media Baja" },
                    { 3, "Media" },
                    { 4, "Media Alta" },
                    { 5, "Alta" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Components", "CreatedAt", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Intel Core i3, 8GB RAM, 256GB SSD, GTX 1050", new DateTime(2024, 7, 4, 13, 53, 15, 826, DateTimeKind.Local).AddTicks(9603), "PC Gamer de entrada", "a", "Xtreme Entry", 12000f },
                    { 2, 2, "AMD Ryzen 5, 16GB RAM, 512GB SSD, GTX 1660", new DateTime(2024, 7, 4, 13, 53, 15, 826, DateTimeKind.Local).AddTicks(9617), "PC Gamer de gama media baja", "a", "Mid Range Warrior", 18000f },
                    { 3, 3, "Intel Core i5, 16GB RAM, 1TB SSD, RTX 2060", new DateTime(2024, 7, 4, 13, 53, 15, 826, DateTimeKind.Local).AddTicks(9620), "PC Gamer de gama media", "a", "Gamer Pro", 25000f },
                    { 4, 4, "AMD Ryzen 7, 32GB RAM, 1TB SSD, RTX 2070", new DateTime(2024, 7, 4, 13, 53, 15, 826, DateTimeKind.Local).AddTicks(9622), "PC Gamer de gama media alta", "a", "Elite Gaming", 32000f },
                    { 5, 5, "Intel Core i7, 32GB RAM, 2TB SSD, RTX 2080 Ti", new DateTime(2024, 7, 4, 13, 53, 15, 826, DateTimeKind.Local).AddTicks(9624), "PC Gamer de gama alta", "a", "Ultimate Beast", 45000f },
                    { 6, 1, "AMD Ryzen 3, 8GB RAM, 256GB SSD, RX 550", new DateTime(2024, 7, 4, 13, 53, 15, 826, DateTimeKind.Local).AddTicks(9628), "PC Gamer de entrada", "a", "Starter Pack", 11000f },
                    { 7, 2, "Intel Core i3, 16GB RAM, 512GB SSD, GTX 1650", new DateTime(2024, 7, 4, 13, 53, 15, 826, DateTimeKind.Local).AddTicks(9629), "PC Gamer de gama media baja", "a", "Budget Pro", 16000f },
                    { 8, 3, "AMD Ryzen 5, 16GB RAM, 1TB SSD, RTX 3050", new DateTime(2024, 7, 4, 13, 53, 15, 826, DateTimeKind.Local).AddTicks(9631), "PC Gamer de gama media", "a", "Performance Master", 23000f },
                    { 9, 4, "Intel Core i5, 32GB RAM, 1TB SSD, RTX 3070", new DateTime(2024, 7, 4, 13, 53, 15, 826, DateTimeKind.Local).AddTicks(9633), "PC Gamer de gama media alta", "a", "High End Fighter", 35000f },
                    { 10, 5, "AMD Ryzen 9, 64GB RAM, 2TB SSD, RTX 3090", new DateTime(2024, 7, 4, 13, 53, 15, 826, DateTimeKind.Local).AddTicks(9636), "PC Gamer de gama alta", "a", "Godlike Power", 50000f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
