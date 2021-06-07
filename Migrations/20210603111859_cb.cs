using Microsoft.EntityFrameworkCore.Migrations;

namespace CE.Migrations
{
    public partial class cb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "codebrand",
                table: "AspNetModels");

            migrationBuilder.AddColumn<string>(
                name: "Namebrand",
                table: "AspNetModels",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Namebrand",
                table: "AspNetModels");

            migrationBuilder.AddColumn<double>(
                name: "codebrand",
                table: "AspNetModels",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
