using Microsoft.EntityFrameworkCore.Migrations;

namespace CE.Migrations
{
    public partial class acEnergyEfficiency : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Efficiency",
                table: "AspNetModels",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EnergyEfficiency",
                table: "AspNetModels",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Efficiency",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "EnergyEfficiency",
                table: "AspNetModels");
        }
    }
}
