using Microsoft.EntityFrameworkCore.Migrations;

namespace Client.Migrations
{
    public partial class prod1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "A2C",
                table: "AspNetOutlet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AVMonthly",
                table: "AspNetOutlet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CONDOR",
                table: "AspNetOutlet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DisplayPriority",
                table: "AspNetOutlet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Displaystatus",
                table: "AspNetOutlet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Estann",
                table: "AspNetOutlet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LGPromoters",
                table: "AspNetOutlet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PromoterRemarks",
                table: "AspNetOutlet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RACDisplay",
                table: "AspNetOutlet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "REFDisplay",
                table: "AspNetOutlet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SIS",
                table: "AspNetOutlet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SODIG",
                table: "AspNetOutlet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TVDisplay",
                table: "AspNetOutlet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WMDisplay",
                table: "AspNetOutlet",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "A2C",
                table: "AspNetOutlet");

            migrationBuilder.DropColumn(
                name: "AVMonthly",
                table: "AspNetOutlet");

            migrationBuilder.DropColumn(
                name: "CONDOR",
                table: "AspNetOutlet");

            migrationBuilder.DropColumn(
                name: "DisplayPriority",
                table: "AspNetOutlet");

            migrationBuilder.DropColumn(
                name: "Displaystatus",
                table: "AspNetOutlet");

            migrationBuilder.DropColumn(
                name: "Estann",
                table: "AspNetOutlet");

            migrationBuilder.DropColumn(
                name: "LGPromoters",
                table: "AspNetOutlet");

            migrationBuilder.DropColumn(
                name: "PromoterRemarks",
                table: "AspNetOutlet");

            migrationBuilder.DropColumn(
                name: "RACDisplay",
                table: "AspNetOutlet");

            migrationBuilder.DropColumn(
                name: "REFDisplay",
                table: "AspNetOutlet");

            migrationBuilder.DropColumn(
                name: "SIS",
                table: "AspNetOutlet");

            migrationBuilder.DropColumn(
                name: "SODIG",
                table: "AspNetOutlet");

            migrationBuilder.DropColumn(
                name: "TVDisplay",
                table: "AspNetOutlet");

            migrationBuilder.DropColumn(
                name: "WMDisplay",
                table: "AspNetOutlet");
        }
    }
}
