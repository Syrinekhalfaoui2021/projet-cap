using Microsoft.EntityFrameworkCore.Migrations;

namespace Client.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetOutlet");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "AspNetOutlet");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "AspNetOutlet",
                newName: "FullAddress");

            migrationBuilder.AlterColumn<string>(
                name: "District",
                table: "AspNetOutlet",
                type: "nvarchar(250)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AV",
                table: "AspNetOutlet",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Antenna",
                table: "AspNetOutlet",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "AspNetOutlet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChannelType",
                table: "AspNetOutlet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactPerson",
                table: "AspNetOutlet",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Coverage",
                table: "AspNetOutlet",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Delegation",
                table: "AspNetOutlet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HA",
                table: "AspNetOutlet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LinkGoogleMAPS2",
                table: "AspNetOutlet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "POSName",
                table: "AspNetOutlet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "AspNetOutlet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "AspNetOutlet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StoreSize",
                table: "AspNetOutlet",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "AspNetOutlet",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AV",
                table: "AspNetOutlet");

            migrationBuilder.DropColumn(
                name: "Antenna",
                table: "AspNetOutlet");

            migrationBuilder.DropColumn(
                name: "Area",
                table: "AspNetOutlet");

            migrationBuilder.DropColumn(
                name: "ChannelType",
                table: "AspNetOutlet");

            migrationBuilder.DropColumn(
                name: "ContactPerson",
                table: "AspNetOutlet");

            migrationBuilder.DropColumn(
                name: "Coverage",
                table: "AspNetOutlet");

            migrationBuilder.DropColumn(
                name: "Delegation",
                table: "AspNetOutlet");

            migrationBuilder.DropColumn(
                name: "HA",
                table: "AspNetOutlet");

            migrationBuilder.DropColumn(
                name: "LinkGoogleMAPS2",
                table: "AspNetOutlet");

            migrationBuilder.DropColumn(
                name: "POSName",
                table: "AspNetOutlet");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "AspNetOutlet");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "AspNetOutlet");

            migrationBuilder.DropColumn(
                name: "StoreSize",
                table: "AspNetOutlet");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "AspNetOutlet");

            migrationBuilder.RenameColumn(
                name: "FullAddress",
                table: "AspNetOutlet",
                newName: "State");

            migrationBuilder.AlterColumn<string>(
                name: "District",
                table: "AspNetOutlet",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetOutlet",
                type: "nvarchar(250)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "AspNetOutlet",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
