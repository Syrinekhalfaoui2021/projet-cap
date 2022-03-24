using Microsoft.EntityFrameworkCore.Migrations;

namespace Client.Migrations
{
    public partial class _1234 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ModelName",
                table: "AspNetModels",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ModelName",
                table: "AspNetModels",
                type: "nvarchar(250)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
