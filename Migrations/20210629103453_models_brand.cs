using Microsoft.EntityFrameworkCore.Migrations;

namespace CE.Migrations
{
    public partial class models_brand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Namebrand",
                table: "AspNetModels");

            migrationBuilder.AddColumn<double>(
                name: "Codebrand",
                table: "AspNetModels",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Codebrand",
                table: "AspNetModels");

            migrationBuilder.AddColumn<string>(
                name: "Namebrand",
                table: "AspNetModels",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
