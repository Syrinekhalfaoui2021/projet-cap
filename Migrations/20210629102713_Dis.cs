using Microsoft.EntityFrameworkCore.Migrations;

namespace CE.Migrations
{
    public partial class Dis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "typee",
                table: "AspNetModels");

            migrationBuilder.AddColumn<string>(
                name: "Encastrable",
                table: "AspNetModels",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Energeticefficiency",
                table: "AspNetModels",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Numberofcovers",
                table: "AspNetModels",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Promgramme",
                table: "AspNetModels",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "REF_Color",
                table: "AspNetModels",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Encastrable",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "Energeticefficiency",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "Numberofcovers",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "Promgramme",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "REF_Color",
                table: "AspNetModels");

            migrationBuilder.AddColumn<string>(
                name: "typee",
                table: "AspNetModels",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
