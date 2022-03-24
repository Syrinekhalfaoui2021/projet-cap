using Microsoft.EntityFrameworkCore.Migrations;

namespace Client.Migrations
{
    public partial class trend2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetVisit_IdOutlet",
                table: "AspNetVisit");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetVisit_IdOutlet",
                table: "AspNetVisit",
                column: "IdOutlet");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetVisit_IdOutlet",
                table: "AspNetVisit");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetVisit_IdOutlet",
                table: "AspNetVisit",
                column: "IdOutlet",
                unique: true,
                filter: "[IdOutlet] IS NOT NULL");
        }
    }
}
