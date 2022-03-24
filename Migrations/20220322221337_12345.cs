using Microsoft.EntityFrameworkCore.Migrations;

namespace Client.Migrations
{
    public partial class _12345 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetModels_AspNetBrand_Brandcodebrand",
                table: "AspNetModels");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetModels_AspNetOutlet_IdOutlet",
                table: "AspNetModels");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetModels_AspNetVisit_IdVisit",
                table: "AspNetModels");

            migrationBuilder.AlterColumn<int>(
                name: "IdVisit",
                table: "AspNetModels",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IdOutlet",
                table: "AspNetModels",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "Brandcodebrand",
                table: "AspNetModels",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetModels_AspNetBrand_Brandcodebrand",
                table: "AspNetModels",
                column: "Brandcodebrand",
                principalTable: "AspNetBrand",
                principalColumn: "codebrand",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetModels_AspNetOutlet_IdOutlet",
                table: "AspNetModels",
                column: "IdOutlet",
                principalTable: "AspNetOutlet",
                principalColumn: "IdOutlet",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetModels_AspNetVisit_IdVisit",
                table: "AspNetModels",
                column: "IdVisit",
                principalTable: "AspNetVisit",
                principalColumn: "IdVisit",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetModels_AspNetBrand_Brandcodebrand",
                table: "AspNetModels");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetModels_AspNetOutlet_IdOutlet",
                table: "AspNetModels");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetModels_AspNetVisit_IdVisit",
                table: "AspNetModels");

            migrationBuilder.AlterColumn<int>(
                name: "IdVisit",
                table: "AspNetModels",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdOutlet",
                table: "AspNetModels",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Brandcodebrand",
                table: "AspNetModels",
                type: "float",
                nullable: false,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetModels_AspNetBrand_Brandcodebrand",
                table: "AspNetModels",
                column: "Brandcodebrand",
                principalTable: "AspNetBrand",
                principalColumn: "codebrand",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetModels_AspNetOutlet_IdOutlet",
                table: "AspNetModels",
                column: "IdOutlet",
                principalTable: "AspNetOutlet",
                principalColumn: "IdOutlet",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetModels_AspNetVisit_IdVisit",
                table: "AspNetModels",
                column: "IdVisit",
                principalTable: "AspNetVisit",
                principalColumn: "IdVisit",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
