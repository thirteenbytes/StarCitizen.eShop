using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StarCitizen.eShop.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Update_Armor_AddColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "BiochemicalResistance",
                table: "Armor",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DistortionResistence",
                table: "Armor",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "EnergyResistance",
                table: "Armor",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Manufacturer",
                table: "Armor",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "PhysicalResistance",
                table: "Armor",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "StunResistance",
                table: "Armor",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ThermalResistance",
                table: "Armor",
                type: "decimal(18,2)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BiochemicalResistance",
                table: "Armor");

            migrationBuilder.DropColumn(
                name: "DistortionResistence",
                table: "Armor");

            migrationBuilder.DropColumn(
                name: "EnergyResistance",
                table: "Armor");

            migrationBuilder.DropColumn(
                name: "Manufacturer",
                table: "Armor");

            migrationBuilder.DropColumn(
                name: "PhysicalResistance",
                table: "Armor");

            migrationBuilder.DropColumn(
                name: "StunResistance",
                table: "Armor");

            migrationBuilder.DropColumn(
                name: "ThermalResistance",
                table: "Armor");
        }
    }
}
