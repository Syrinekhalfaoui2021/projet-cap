using Microsoft.EntityFrameworkCore.Migrations;

namespace Client.Migrations
{
    public partial class trend : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Activity",
                table: "AspNetVisit",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Presence",
                table: "AspNetVisit",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SalesA",
                table: "AspNetVisit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SalesQ",
                table: "AspNetVisit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Presence",
                table: "AspNetVisit");

            migrationBuilder.DropColumn(
                name: "SalesA",
                table: "AspNetVisit");

            migrationBuilder.DropColumn(
                name: "SalesQ",
                table: "AspNetVisit");

            migrationBuilder.AlterColumn<string>(
                name: "Activity",
                table: "AspNetVisit",
                type: "nvarchar(250)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
