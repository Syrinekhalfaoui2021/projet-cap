using Microsoft.EntityFrameworkCore.Migrations;

namespace CE.Migrations
{
    public partial class br : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "AspNetBrand",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetBrand_UserId",
                table: "AspNetBrand",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetBrand_AspNetUsers_UserId",
                table: "AspNetBrand",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetBrand_AspNetUsers_UserId",
                table: "AspNetBrand");

            migrationBuilder.DropIndex(
                name: "IX_AspNetBrand_UserId",
                table: "AspNetBrand");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AspNetBrand");
        }
    }
}
