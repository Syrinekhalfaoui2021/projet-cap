using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Client.Migrations
{
    public partial class sy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetBrand_AspNetVisitmonthly_VisitsmonthlyIdVisit",
                table: "AspNetBrand");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetBrand_AspNetVisitweekly_VisitsweeklyIdVisit",
                table: "AspNetBrand");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetModels_AspNetVisitmonthly_VisitsmonthlyIdVisit",
                table: "AspNetModels");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetModels_AspNetVisitweekly_VisitsweeklyIdVisit",
                table: "AspNetModels");

            migrationBuilder.DropTable(
                name: "AspNetVisitmonthly");

            migrationBuilder.DropTable(
                name: "AspNetVisitweekly");

            migrationBuilder.DropIndex(
                name: "IX_AspNetModels_VisitsmonthlyIdVisit",
                table: "AspNetModels");

            migrationBuilder.DropIndex(
                name: "IX_AspNetModels_VisitsweeklyIdVisit",
                table: "AspNetModels");

            migrationBuilder.DropIndex(
                name: "IX_AspNetBrand_VisitsmonthlyIdVisit",
                table: "AspNetBrand");

            migrationBuilder.DropIndex(
                name: "IX_AspNetBrand_VisitsweeklyIdVisit",
                table: "AspNetBrand");

            migrationBuilder.DropColumn(
                name: "VisitsmonthlyIdVisit",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "VisitsweeklyIdVisit",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "VisitsmonthlyIdVisit",
                table: "AspNetBrand");

            migrationBuilder.DropColumn(
                name: "VisitsweeklyIdVisit",
                table: "AspNetBrand");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VisitsmonthlyIdVisit",
                table: "AspNetModels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VisitsweeklyIdVisit",
                table: "AspNetModels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VisitsmonthlyIdVisit",
                table: "AspNetBrand",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VisitsweeklyIdVisit",
                table: "AspNetBrand",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AspNetVisitmonthly",
                columns: table => new
                {
                    IdVisit = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Activity = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Article = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Entrytime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Exittime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdOutlet = table.Column<int>(type: "int", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetVisitmonthly", x => x.IdVisit);
                    table.ForeignKey(
                        name: "FK_AspNetVisitmonthly_AspNetOutlet_IdOutlet",
                        column: x => x.IdOutlet,
                        principalTable: "AspNetOutlet",
                        principalColumn: "IdOutlet",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetVisitmonthly_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetVisitweekly",
                columns: table => new
                {
                    IdVisit = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Activity = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Article = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Entrytime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Exittime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IdOutlet = table.Column<int>(type: "int", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetVisitweekly", x => x.IdVisit);
                    table.ForeignKey(
                        name: "FK_AspNetVisitweekly_AspNetOutlet_IdOutlet",
                        column: x => x.IdOutlet,
                        principalTable: "AspNetOutlet",
                        principalColumn: "IdOutlet",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetVisitweekly_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetModels_VisitsmonthlyIdVisit",
                table: "AspNetModels",
                column: "VisitsmonthlyIdVisit");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetModels_VisitsweeklyIdVisit",
                table: "AspNetModels",
                column: "VisitsweeklyIdVisit");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetBrand_VisitsmonthlyIdVisit",
                table: "AspNetBrand",
                column: "VisitsmonthlyIdVisit");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetBrand_VisitsweeklyIdVisit",
                table: "AspNetBrand",
                column: "VisitsweeklyIdVisit");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetVisitmonthly_IdOutlet",
                table: "AspNetVisitmonthly",
                column: "IdOutlet",
                unique: true,
                filter: "[IdOutlet] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetVisitmonthly_UserId",
                table: "AspNetVisitmonthly",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetVisitweekly_IdOutlet",
                table: "AspNetVisitweekly",
                column: "IdOutlet",
                unique: true,
                filter: "[IdOutlet] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetVisitweekly_UserId",
                table: "AspNetVisitweekly",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetBrand_AspNetVisitmonthly_VisitsmonthlyIdVisit",
                table: "AspNetBrand",
                column: "VisitsmonthlyIdVisit",
                principalTable: "AspNetVisitmonthly",
                principalColumn: "IdVisit",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetBrand_AspNetVisitweekly_VisitsweeklyIdVisit",
                table: "AspNetBrand",
                column: "VisitsweeklyIdVisit",
                principalTable: "AspNetVisitweekly",
                principalColumn: "IdVisit",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetModels_AspNetVisitmonthly_VisitsmonthlyIdVisit",
                table: "AspNetModels",
                column: "VisitsmonthlyIdVisit",
                principalTable: "AspNetVisitmonthly",
                principalColumn: "IdVisit",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetModels_AspNetVisitweekly_VisitsweeklyIdVisit",
                table: "AspNetModels",
                column: "VisitsweeklyIdVisit",
                principalTable: "AspNetVisitweekly",
                principalColumn: "IdVisit",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
