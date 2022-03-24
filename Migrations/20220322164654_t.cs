using Microsoft.EntityFrameworkCore.Migrations;

namespace Client.Migrations
{
    public partial class t : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetModels_AspNetOutlet_IdOutlet",
                table: "AspNetModels");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetModels_AspNetVisit_IdVisit",
                table: "AspNetModels");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetsammaryweekly_AspNetModels_ACCode",
                table: "AspNetsammaryweekly");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetsammaryweekly_AspNetModels_REFCode",
                table: "AspNetsammaryweekly");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetsammaryweekly_AspNetModels_TvCode",
                table: "AspNetsammaryweekly");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetsammaryweekly_AspNetModels_WmCode",
                table: "AspNetsammaryweekly");

            migrationBuilder.DropIndex(
                name: "IX_AspNetsammaryweekly_ACCode",
                table: "AspNetsammaryweekly");

            migrationBuilder.DropIndex(
                name: "IX_AspNetsammaryweekly_REFCode",
                table: "AspNetsammaryweekly");

            migrationBuilder.DropIndex(
                name: "IX_AspNetsammaryweekly_TvCode",
                table: "AspNetsammaryweekly");

            migrationBuilder.DropIndex(
                name: "IX_AspNetsammaryweekly_WmCode",
                table: "AspNetsammaryweekly");

            migrationBuilder.DropColumn(
                name: "ACCode",
                table: "AspNetsammaryweekly");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetsammaryweekly");

            migrationBuilder.DropColumn(
                name: "REFCode",
                table: "AspNetsammaryweekly");

            migrationBuilder.DropColumn(
                name: "TvCode",
                table: "AspNetsammaryweekly");

            migrationBuilder.DropColumn(
                name: "WmCode",
                table: "AspNetsammaryweekly");

            migrationBuilder.DropColumn(
                name: "IdSammaryReportMonthly",
                table: "AspNetsammaryweekly");

            migrationBuilder.DropColumn(
                name: "IdSammaryReportWeekly",
                table: "AspNetsammaryweekly");

            migrationBuilder.DropColumn(
                name: "Classac",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "Energeticclass",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "Inverter",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "Puissance",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "TypeAC",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "Encastrable",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "Energeticefficiency",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "Numberofcovers",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "Promgramme",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "REF_Color",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "EnergeticClassREf",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "Energy",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "Frost",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "Segment2",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "Technology",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "TypeREF2",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "Typeref",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "TV_Class",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "Form",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "HDMI",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "Integrated_Receiver",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "SegmentTV",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "SizeCategory",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "SmartTV",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "TypeTV",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "USB",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "WM_Capacity",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "WM_Class",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "WM_Color",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "DryerCapacity",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "Drying",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "Motor",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "WM_SizeCategory",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "WM_Technology",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "TypeWM",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "TypeWM2",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "segementWM",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetModels");

            migrationBuilder.RenameColumn(
                name: "Waterdispenser",
                table: "AspNetModels",
                newName: "WaterDispenser");

            migrationBuilder.RenameColumn(
                name: "CodeBP",
                table: "AspNetModels",
                newName: "ModelName");

            migrationBuilder.AlterColumn<int>(
                name: "IdVisit",
                table: "AspNetModels",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdOutlet",
                table: "AspNetModels",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Disc",
                table: "AspNetModels",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Dimension",
                table: "AspNetModels",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DryerCapa",
                table: "AspNetModels",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnergyClass",
                table: "AspNetModels",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Frosttype",
                table: "AspNetModels",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FrzCapa",
                table: "AspNetModels",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OutterDisplay",
                table: "AspNetModels",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductType",
                table: "AspNetModels",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Programs",
                table: "AspNetModels",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "REFCapa",
                table: "AspNetModels",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RPM",
                table: "AspNetModels",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SMART",
                table: "AspNetModels",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SizeCapacity",
                table: "AspNetModels",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "AspNetModels",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetModels_AspNetOutlet_IdOutlet",
                table: "AspNetModels");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetModels_AspNetVisit_IdVisit",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "Dimension",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "DryerCapa",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "EnergyClass",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "Frosttype",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "FrzCapa",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "OutterDisplay",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "ProductType",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "Programs",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "REFCapa",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "RPM",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "SMART",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "SizeCapacity",
                table: "AspNetModels");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "AspNetModels");

            migrationBuilder.RenameColumn(
                name: "WaterDispenser",
                table: "AspNetModels",
                newName: "Waterdispenser");

            migrationBuilder.RenameColumn(
                name: "ModelName",
                table: "AspNetModels",
                newName: "CodeBP");

            migrationBuilder.AddColumn<int>(
                name: "ACCode",
                table: "AspNetsammaryweekly",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetsammaryweekly",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "REFCode",
                table: "AspNetsammaryweekly",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TvCode",
                table: "AspNetsammaryweekly",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WmCode",
                table: "AspNetsammaryweekly",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdSammaryReportMonthly",
                table: "AspNetsammaryweekly",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdSammaryReportWeekly",
                table: "AspNetsammaryweekly",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdVisit",
                table: "AspNetModels",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "IdOutlet",
                table: "AspNetModels",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Disc",
                table: "AspNetModels",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Classac",
                table: "AspNetModels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Energeticclass",
                table: "AspNetModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Inverter",
                table: "AspNetModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Puissance",
                table: "AspNetModels",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeAC",
                table: "AspNetModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Encastrable",
                table: "AspNetModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Energeticefficiency",
                table: "AspNetModels",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Numberofcovers",
                table: "AspNetModels",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Promgramme",
                table: "AspNetModels",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Capacity",
                table: "AspNetModels",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "AspNetModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "REF_Color",
                table: "AspNetModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "EnergeticClassREf",
                table: "AspNetModels",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Energy",
                table: "AspNetModels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Frost",
                table: "AspNetModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Segment2",
                table: "AspNetModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Technology",
                table: "AspNetModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeREF2",
                table: "AspNetModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Typeref",
                table: "AspNetModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TV_Class",
                table: "AspNetModels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Form",
                table: "AspNetModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "HDMI",
                table: "AspNetModels",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Integrated_Receiver",
                table: "AspNetModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SegmentTV",
                table: "AspNetModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "AspNetModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SizeCategory",
                table: "AspNetModels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SmartTV",
                table: "AspNetModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeTV",
                table: "AspNetModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "USB",
                table: "AspNetModels",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "WM_Capacity",
                table: "AspNetModels",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WM_Class",
                table: "AspNetModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WM_Color",
                table: "AspNetModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "DryerCapacity",
                table: "AspNetModels",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Drying",
                table: "AspNetModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Motor",
                table: "AspNetModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WM_SizeCategory",
                table: "AspNetModels",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WM_Technology",
                table: "AspNetModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeWM",
                table: "AspNetModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeWM2",
                table: "AspNetModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "segementWM",
                table: "AspNetModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetsammaryweekly_ACCode",
                table: "AspNetsammaryweekly",
                column: "ACCode");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetsammaryweekly_REFCode",
                table: "AspNetsammaryweekly",
                column: "REFCode");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetsammaryweekly_TvCode",
                table: "AspNetsammaryweekly",
                column: "TvCode");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetsammaryweekly_WmCode",
                table: "AspNetsammaryweekly",
                column: "WmCode");

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

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetsammaryweekly_AspNetModels_ACCode",
                table: "AspNetsammaryweekly",
                column: "ACCode",
                principalTable: "AspNetModels",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetsammaryweekly_AspNetModels_REFCode",
                table: "AspNetsammaryweekly",
                column: "REFCode",
                principalTable: "AspNetModels",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetsammaryweekly_AspNetModels_TvCode",
                table: "AspNetsammaryweekly",
                column: "TvCode",
                principalTable: "AspNetModels",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetsammaryweekly_AspNetModels_WmCode",
                table: "AspNetsammaryweekly",
                column: "WmCode",
                principalTable: "AspNetModels",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
