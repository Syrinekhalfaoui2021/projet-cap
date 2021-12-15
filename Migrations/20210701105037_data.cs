﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CAP.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetNavigationMenu",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ParentMenuId = table.Column<Guid>(nullable: true),
                    Area = table.Column<string>(nullable: true),
                    ControllerName = table.Column<string>(nullable: true),
                    ActionName = table.Column<string>(nullable: true),
                    IsExternal = table.Column<bool>(nullable: false),
                    ExternalUrl = table.Column<string>(nullable: true),
                    DisplayOrder = table.Column<int>(nullable: false),
                    Visible = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetNavigationMenu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetNavigationMenu_AspNetNavigationMenu_ParentMenuId",
                        column: x => x.ParentMenuId,
                        principalTable: "AspNetNavigationMenu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleMenuPermission",
                columns: table => new
                {
                    RoleId = table.Column<string>(nullable: false),
                    NavigationMenuId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleMenuPermission", x => new { x.RoleId, x.NavigationMenuId });
                    table.ForeignKey(
                        name: "FK_AspNetRoleMenuPermission_AspNetNavigationMenu_NavigationMenuId",
                        column: x => x.NavigationMenuId,
                        principalTable: "AspNetNavigationMenu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetOutlet",
                columns: table => new
                {
                    IdOutlet = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOutlet = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Keydealer = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Compte = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Class = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Activity = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Zone = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    Address = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Outletstype = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    Channel = table.Column<string>(nullable: true),
                    Retailer = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetOutlet", x => x.IdOutlet);
                    table.ForeignKey(
                        name: "FK_AspNetOutlet_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetVisit",
                columns: table => new
                {
                    IdVisit = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Entrytime = table.Column<DateTime>(nullable: false),
                    Exittime = table.Column<DateTime>(nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    Article = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Activity = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    IdOutlet = table.Column<int>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetVisit", x => x.IdVisit);
                    table.ForeignKey(
                        name: "FK_AspNetVisit_AspNetOutlet_IdOutlet",
                        column: x => x.IdOutlet,
                        principalTable: "AspNetOutlet",
                        principalColumn: "IdOutlet",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetVisit_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetVisitmonthly",
                columns: table => new
                {
                    IdVisit = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Entrytime = table.Column<DateTime>(nullable: false),
                    Exittime = table.Column<DateTime>(nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Article = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Activity = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    IdOutlet = table.Column<int>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
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
                    IdVisit = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Entrytime = table.Column<DateTime>(nullable: false),
                    Exittime = table.Column<DateTimeOffset>(nullable: false),
                    Remark = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Article = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Activity = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    IdOutlet = table.Column<int>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
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

            migrationBuilder.CreateTable(
                name: "AspNetBrand",
                columns: table => new
                {
                    codebrand = table.Column<double>(nullable: false),
                    Namebrand = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    VisitsIdVisit = table.Column<int>(nullable: true),
                    VisitsmonthlyIdVisit = table.Column<int>(nullable: true),
                    VisitsweeklyIdVisit = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetBrand", x => x.codebrand);
                    table.ForeignKey(
                        name: "FK_AspNetBrand_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetBrand_AspNetVisit_VisitsIdVisit",
                        column: x => x.VisitsIdVisit,
                        principalTable: "AspNetVisit",
                        principalColumn: "IdVisit",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetBrand_AspNetVisitmonthly_VisitsmonthlyIdVisit",
                        column: x => x.VisitsmonthlyIdVisit,
                        principalTable: "AspNetVisitmonthly",
                        principalColumn: "IdVisit",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetBrand_AspNetVisitweekly_VisitsweeklyIdVisit",
                        column: x => x.VisitsweeklyIdVisit,
                        principalTable: "AspNetVisitweekly",
                        principalColumn: "IdVisit",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetModels",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeBP = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Availibility = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    MarketShare = table.Column<string>(nullable: true),
                    ShelfShare = table.Column<string>(nullable: true),
                    Stock = table.Column<string>(nullable: true),
                    Weeklysail = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Brandcodebrand = table.Column<double>(nullable: false),
                    IdVisit = table.Column<int>(nullable: true),
                    Display = table.Column<string>(nullable: true),
                    Disc = table.Column<string>(nullable: false),
                    VisitsweeklyIdVisit = table.Column<int>(nullable: true),
                    VisitsmonthlyIdVisit = table.Column<int>(nullable: true),
                    OutletsIdOutlet = table.Column<int>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    TypeAC = table.Column<string>(nullable: true),
                    Inverter = table.Column<string>(nullable: true),
                    Puissance = table.Column<double>(nullable: true),
                    Classac = table.Column<int>(nullable: true),
                    Energeticclass = table.Column<string>(nullable: true),
                    Encastrable = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Promgramme = table.Column<double>(nullable: true),
                    Numberofcovers = table.Column<double>(nullable: true),
                    Energeticefficiency = table.Column<double>(nullable: true),
                    Typeref = table.Column<string>(nullable: true),
                    REF_Color = table.Column<string>(nullable: true),
                    Segment = table.Column<string>(nullable: true),
                    Capacity = table.Column<double>(nullable: true),
                    Energy = table.Column<int>(nullable: true),
                    Class = table.Column<string>(nullable: true),
                    Technology = table.Column<string>(nullable: true),
                    Frost = table.Column<string>(nullable: true),
                    Waterdispenser = table.Column<string>(nullable: true),
                    TypeREF2 = table.Column<string>(nullable: true),
                    Segment2 = table.Column<string>(nullable: true),
                    EnergeticClassREf = table.Column<double>(nullable: true),
                    TV_Class = table.Column<int>(nullable: true),
                    TypeTV = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    SizeCategory = table.Column<int>(nullable: true),
                    Resolution = table.Column<string>(nullable: true),
                    Form = table.Column<string>(nullable: true),
                    SmartTV = table.Column<string>(nullable: true),
                    SegmentTV = table.Column<string>(nullable: true),
                    Integrated_Receiver = table.Column<string>(nullable: true),
                    HDMI = table.Column<double>(nullable: true),
                    USB = table.Column<double>(nullable: true),
                    TypeWM = table.Column<string>(nullable: true),
                    TypeWM2 = table.Column<string>(nullable: true),
                    WM_Color = table.Column<string>(nullable: true),
                    WM_SizeCategory = table.Column<int>(nullable: true),
                    segementWM = table.Column<string>(nullable: true),
                    WM_Capacity = table.Column<double>(nullable: true),
                    Drying = table.Column<string>(nullable: true),
                    DryerCapacity = table.Column<double>(nullable: true),
                    WM_Technology = table.Column<string>(nullable: true),
                    WM_Class = table.Column<string>(nullable: true),
                    Motor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetModels", x => x.Code);
                    table.ForeignKey(
                        name: "FK_AspNetModels_AspNetBrand_Brandcodebrand",
                        column: x => x.Brandcodebrand,
                        principalTable: "AspNetBrand",
                        principalColumn: "codebrand",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetModels_AspNetVisit_IdVisit",
                        column: x => x.IdVisit,
                        principalTable: "AspNetVisit",
                        principalColumn: "IdVisit",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetModels_AspNetOutlet_OutletsIdOutlet",
                        column: x => x.OutletsIdOutlet,
                        principalTable: "AspNetOutlet",
                        principalColumn: "IdOutlet",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetModels_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetModels_AspNetVisitmonthly_VisitsmonthlyIdVisit",
                        column: x => x.VisitsmonthlyIdVisit,
                        principalTable: "AspNetVisitmonthly",
                        principalColumn: "IdVisit",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetModels_AspNetVisitweekly_VisitsweeklyIdVisit",
                        column: x => x.VisitsweeklyIdVisit,
                        principalTable: "AspNetVisitweekly",
                        principalColumn: "IdVisit",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetsammaryweekly",
                columns: table => new
                {
                    Idsammary = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    ModelsCode = table.Column<int>(nullable: true),
                    OutletsIdOutlet = table.Column<int>(nullable: true),
                    Brandscodebrand = table.Column<double>(nullable: true),
                    TvCode = table.Column<int>(nullable: true),
                    WmCode = table.Column<int>(nullable: true),
                    REFCode = table.Column<int>(nullable: true),
                    ACCode = table.Column<int>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    IdSammaryReportMonthly = table.Column<int>(nullable: true),
                    IdSammaryReportWeekly = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetsammaryweekly", x => x.Idsammary);
                    table.ForeignKey(
                        name: "FK_AspNetsammaryweekly_AspNetModels_ACCode",
                        column: x => x.ACCode,
                        principalTable: "AspNetModels",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetsammaryweekly_AspNetBrand_Brandscodebrand",
                        column: x => x.Brandscodebrand,
                        principalTable: "AspNetBrand",
                        principalColumn: "codebrand",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetsammaryweekly_AspNetModels_ModelsCode",
                        column: x => x.ModelsCode,
                        principalTable: "AspNetModels",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetsammaryweekly_AspNetOutlet_OutletsIdOutlet",
                        column: x => x.OutletsIdOutlet,
                        principalTable: "AspNetOutlet",
                        principalColumn: "IdOutlet",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetsammaryweekly_AspNetModels_REFCode",
                        column: x => x.REFCode,
                        principalTable: "AspNetModels",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetsammaryweekly_AspNetModels_TvCode",
                        column: x => x.TvCode,
                        principalTable: "AspNetModels",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetsammaryweekly_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetsammaryweekly_AspNetModels_WmCode",
                        column: x => x.WmCode,
                        principalTable: "AspNetModels",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetBrand_UserId",
                table: "AspNetBrand",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetBrand_VisitsIdVisit",
                table: "AspNetBrand",
                column: "VisitsIdVisit");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetBrand_VisitsmonthlyIdVisit",
                table: "AspNetBrand",
                column: "VisitsmonthlyIdVisit");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetBrand_VisitsweeklyIdVisit",
                table: "AspNetBrand",
                column: "VisitsweeklyIdVisit");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetModels_Brandcodebrand",
                table: "AspNetModels",
                column: "Brandcodebrand");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetModels_IdVisit",
                table: "AspNetModels",
                column: "IdVisit");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetModels_OutletsIdOutlet",
                table: "AspNetModels",
                column: "OutletsIdOutlet");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetModels_UserId",
                table: "AspNetModels",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetModels_VisitsmonthlyIdVisit",
                table: "AspNetModels",
                column: "VisitsmonthlyIdVisit");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetModels_VisitsweeklyIdVisit",
                table: "AspNetModels",
                column: "VisitsweeklyIdVisit");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetNavigationMenu_ParentMenuId",
                table: "AspNetNavigationMenu",
                column: "ParentMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetOutlet_UserId",
                table: "AspNetOutlet",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleMenuPermission_NavigationMenuId",
                table: "AspNetRoleMenuPermission",
                column: "NavigationMenuId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetsammaryweekly_ACCode",
                table: "AspNetsammaryweekly",
                column: "ACCode");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetsammaryweekly_Brandscodebrand",
                table: "AspNetsammaryweekly",
                column: "Brandscodebrand");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetsammaryweekly_ModelsCode",
                table: "AspNetsammaryweekly",
                column: "ModelsCode");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetsammaryweekly_OutletsIdOutlet",
                table: "AspNetsammaryweekly",
                column: "OutletsIdOutlet");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetsammaryweekly_REFCode",
                table: "AspNetsammaryweekly",
                column: "REFCode");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetsammaryweekly_TvCode",
                table: "AspNetsammaryweekly",
                column: "TvCode");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetsammaryweekly_UserId",
                table: "AspNetsammaryweekly",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetsammaryweekly_WmCode",
                table: "AspNetsammaryweekly",
                column: "WmCode");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetVisit_IdOutlet",
                table: "AspNetVisit",
                column: "IdOutlet",
                unique: true,
                filter: "[IdOutlet] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetVisit_UserId",
                table: "AspNetVisit",
                column: "UserId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetRoleMenuPermission");

            migrationBuilder.DropTable(
                name: "AspNetsammaryweekly");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetNavigationMenu");

            migrationBuilder.DropTable(
                name: "AspNetModels");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetBrand");

            migrationBuilder.DropTable(
                name: "AspNetVisit");

            migrationBuilder.DropTable(
                name: "AspNetVisitmonthly");

            migrationBuilder.DropTable(
                name: "AspNetVisitweekly");

            migrationBuilder.DropTable(
                name: "AspNetOutlet");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
