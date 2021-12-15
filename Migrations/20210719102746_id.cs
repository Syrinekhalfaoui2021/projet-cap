using Microsoft.EntityFrameworkCore.Migrations;

namespace CAP.Migrations
{
    public partial class id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetModels_AspNetOutlet_OutletsIdOutlet",
                table: "AspNetModels");

            migrationBuilder.DropIndex(
                name: "IX_AspNetModels_OutletsIdOutlet",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "OutletsIdOutlet",
                table: "AspNetModels");

            migrationBuilder.AddColumn<int>(
                name: "IdOutlet",
                table: "AspNetModels",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetModels_IdOutlet",
                table: "AspNetModels",
                column: "IdOutlet");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetModels_AspNetOutlet_IdOutlet",
                table: "AspNetModels",
                column: "IdOutlet",
                principalTable: "AspNetOutlet",
                principalColumn: "IdOutlet",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetModels_AspNetOutlet_IdOutlet",
                table: "AspNetModels");

            migrationBuilder.DropIndex(
                name: "IX_AspNetModels_IdOutlet",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "IdOutlet",
                table: "AspNetModels");

            migrationBuilder.AddColumn<int>(
                name: "OutletsIdOutlet",
                table: "AspNetModels",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetModels_OutletsIdOutlet",
                table: "AspNetModels",
                column: "OutletsIdOutlet");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetModels_AspNetOutlet_OutletsIdOutlet",
                table: "AspNetModels",
                column: "OutletsIdOutlet",
                principalTable: "AspNetOutlet",
                principalColumn: "IdOutlet",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
