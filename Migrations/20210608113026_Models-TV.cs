using Microsoft.EntityFrameworkCore.Migrations;

namespace CE.Migrations
{
    public partial class ModelsTV : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TypeTV",
                table: "AspNetModels",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SmartTV",
                table: "AspNetModels",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SegmentTV",
                table: "AspNetModels",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Resolution",
                table: "AspNetModels",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Form",
                table: "AspNetModels",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HDMI",
                table: "AspNetModels",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Integrated",
                table: "AspNetModels",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "USB",
                table: "AspNetModels",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HDMI",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "Integrated",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "USB",
                table: "AspNetModels");

            migrationBuilder.AlterColumn<int>(
                name: "TypeTV",
                table: "AspNetModels",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SmartTV",
                table: "AspNetModels",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SegmentTV",
                table: "AspNetModels",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Resolution",
                table: "AspNetModels",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Form",
                table: "AspNetModels",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
