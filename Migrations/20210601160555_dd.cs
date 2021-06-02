using Microsoft.EntityFrameworkCore.Migrations;

namespace CE.Migrations
{
    public partial class dd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Weeklysail",
                table: "AspNetModels");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Weeklysail",
                table: "AspNetModels",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
