using Microsoft.EntityFrameworkCore.Migrations;

namespace CE.Migrations
{
    public partial class ModelsTV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Integrated",
                table: "AspNetModels");

            migrationBuilder.AddColumn<string>(
                name: "Integrated_Receiver",
                table: "AspNetModels",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Integrated_Receiver",
                table: "AspNetModels");

            migrationBuilder.AddColumn<string>(
                name: "Integrated",
                table: "AspNetModels",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
