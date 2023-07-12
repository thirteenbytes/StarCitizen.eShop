using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StarCitizen.eShop.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Create_Armor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Armor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DamageReduction = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MinimumTemperature = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MaximumTemperature = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Capacity = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Volume = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armor", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Armor_Name",
                table: "Armor",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Armor");
        }
    }
}
