using Microsoft.EntityFrameworkCore.Migrations;

namespace CE.Migrations
{
    public partial class models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Efficiency",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "EnergyEfficiency",
                table: "AspNetModels");

            migrationBuilder.AddColumn<int>(
                name: "Energeticclass",
                table: "AspNetModels",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Inverter",
                table: "AspNetModels",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Energeticclass",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "Inverter",
                table: "AspNetModels");

            migrationBuilder.AddColumn<int>(
                name: "Efficiency",
                table: "AspNetModels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EnergyEfficiency",
                table: "AspNetModels",
                type: "int",
                nullable: true);
        }
    }
}
