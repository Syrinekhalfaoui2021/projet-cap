using Microsoft.EntityFrameworkCore.Migrations;

namespace Client.Migrations
{
    public partial class trend3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetBrand_AspNetVisit_VisitsIdVisit",
                table: "AspNetBrand");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetModels_AspNetOutlet_IdOutlet",
                table: "AspNetModels");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetModels_AspNetVisit_IdVisit",
                table: "AspNetModels");

            migrationBuilder.DropIndex(
                name: "IX_AspNetModels_IdOutlet",
                table: "AspNetModels");

            migrationBuilder.DropIndex(
                name: "IX_AspNetModels_IdVisit",
                table: "AspNetModels");

            migrationBuilder.DropIndex(
                name: "IX_AspNetBrand_VisitsIdVisit",
                table: "AspNetBrand");

            migrationBuilder.DropColumn(
                name: "IdOutlet",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "IdVisit",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "VisitsIdVisit",
                table: "AspNetBrand");

            migrationBuilder.AddColumn<double>(
                name: "Brandcodebrand",
                table: "AspNetVisit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModelsCode",
                table: "AspNetVisit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OutletsIdOutlet",
                table: "AspNetModels",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetVisit_Brandcodebrand",
                table: "AspNetVisit",
                column: "Brandcodebrand");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetVisit_ModelsCode",
                table: "AspNetVisit",
                column: "ModelsCode");

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

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetVisit_AspNetBrand_Brandcodebrand",
                table: "AspNetVisit",
                column: "Brandcodebrand",
                principalTable: "AspNetBrand",
                principalColumn: "codebrand",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetVisit_AspNetModels_ModelsCode",
                table: "AspNetVisit",
                column: "ModelsCode",
                principalTable: "AspNetModels",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetModels_AspNetOutlet_OutletsIdOutlet",
                table: "AspNetModels");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetVisit_AspNetBrand_Brandcodebrand",
                table: "AspNetVisit");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetVisit_AspNetModels_ModelsCode",
                table: "AspNetVisit");

            migrationBuilder.DropIndex(
                name: "IX_AspNetVisit_Brandcodebrand",
                table: "AspNetVisit");

            migrationBuilder.DropIndex(
                name: "IX_AspNetVisit_ModelsCode",
                table: "AspNetVisit");

            migrationBuilder.DropIndex(
                name: "IX_AspNetModels_OutletsIdOutlet",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "Brandcodebrand",
                table: "AspNetVisit");

            migrationBuilder.DropColumn(
                name: "ModelsCode",
                table: "AspNetVisit");

            migrationBuilder.DropColumn(
                name: "OutletsIdOutlet",
                table: "AspNetModels");

            migrationBuilder.AddColumn<int>(
                name: "IdOutlet",
                table: "AspNetModels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdVisit",
                table: "AspNetModels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VisitsIdVisit",
                table: "AspNetBrand",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetModels_IdOutlet",
                table: "AspNetModels",
                column: "IdOutlet");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetModels_IdVisit",
                table: "AspNetModels",
                column: "IdVisit");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetBrand_VisitsIdVisit",
                table: "AspNetBrand",
                column: "VisitsIdVisit");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetBrand_AspNetVisit_VisitsIdVisit",
                table: "AspNetBrand",
                column: "VisitsIdVisit",
                principalTable: "AspNetVisit",
                principalColumn: "IdVisit",
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
    }
}
