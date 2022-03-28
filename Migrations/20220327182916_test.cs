using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Client.Migrations
{
    public partial class test : Migration
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
                name: "AspNetBrand",
                columns: table => new
                {
                    codebrand = table.Column<double>(nullable: false),
                    Namebrand = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
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
                });

            migrationBuilder.CreateTable(
                name: "AspNetOutlet",
                columns: table => new
                {
                    IdOutlet = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Account = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Estann = table.Column<string>(nullable: true),
                    AVMonthly = table.Column<string>(nullable: true),
                    TVDisplay = table.Column<string>(nullable: true),
                    REFDisplay = table.Column<string>(nullable: true),
                    RACDisplay = table.Column<string>(nullable: true),
                    WMDisplay = table.Column<string>(nullable: true),
                    Displaystatus = table.Column<string>(nullable: true),
                    DisplayPriority = table.Column<string>(nullable: true),
                    SIS = table.Column<string>(nullable: true),
                    SODIG = table.Column<string>(nullable: true),
                    CONDOR = table.Column<string>(nullable: true),
                    A2C = table.Column<string>(nullable: true),
                    LGPromoters = table.Column<string>(nullable: true),
                    PromoterRemarks = table.Column<string>(nullable: true),
                    POSName = table.Column<string>(nullable: true),
                    Keydealer = table.Column<string>(nullable: true),
                    Compte = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Class = table.Column<string>(nullable: true),
                    Activity = table.Column<string>(nullable: true),
                    Zone = table.Column<string>(nullable: true),
                    District = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true),
                    ContactPerson = table.Column<string>(nullable: true),
                    ContactPerson2 = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    Delegation = table.Column<string>(nullable: true),
                    StoreClass = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    FullAddress = table.Column<string>(nullable: true),
                    LinkGoogleMAPS = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    Outletstype = table.Column<string>(nullable: true),
                    StoreSize = table.Column<string>(nullable: true),
                    Channeltype = table.Column<string>(nullable: true),
                    Retailer = table.Column<string>(nullable: true),
                    Area = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Coverage = table.Column<string>(nullable: true),
                    Antenna = table.Column<string>(nullable: true),
                    HA = table.Column<string>(nullable: true),
                    AV = table.Column<string>(nullable: true),
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
                name: "AspNetModels",
                columns: table => new
                {
                    Code = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelName = table.Column<string>(nullable: true),
                    Availibility = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    MarketShare = table.Column<string>(nullable: true),
                    ShelfShare = table.Column<string>(nullable: true),
                    Stock = table.Column<string>(nullable: true),
                    Weeklysail = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    ProductType = table.Column<string>(nullable: true),
                    SizeCapacity = table.Column<string>(nullable: true),
                    REFCapa = table.Column<string>(nullable: true),
                    FrzCapa = table.Column<string>(nullable: true),
                    DryerCapa = table.Column<string>(nullable: true),
                    RPM = table.Column<string>(nullable: true),
                    Segment = table.Column<string>(nullable: true),
                    Resolution = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    SMART = table.Column<string>(nullable: true),
                    Programs = table.Column<string>(nullable: true),
                    Frosttype = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    EnergyClass = table.Column<string>(nullable: true),
                    Dimension = table.Column<string>(nullable: true),
                    OutterDisplay = table.Column<string>(nullable: true),
                    WaterDispenser = table.Column<string>(nullable: true),
                    Brandcodebrand = table.Column<double>(nullable: true),
                    IdVisit = table.Column<int>(nullable: true),
                    IdOutlet = table.Column<int>(nullable: true),
                    Display = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetModels", x => x.Code);
                    table.ForeignKey(
                        name: "FK_AspNetModels_AspNetBrand_Brandcodebrand",
                        column: x => x.Brandcodebrand,
                        principalTable: "AspNetBrand",
                        principalColumn: "codebrand",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetModels_AspNetOutlet_IdOutlet",
                        column: x => x.IdOutlet,
                        principalTable: "AspNetOutlet",
                        principalColumn: "IdOutlet",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetModels_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    Remark = table.Column<string>(nullable: true),
                    Presence = table.Column<string>(nullable: true),
                    SalesQ = table.Column<string>(nullable: true),
                    SalesA = table.Column<string>(nullable: true),
                    Article = table.Column<string>(nullable: true),
                    Activity = table.Column<string>(nullable: true),
                    IdOutlet = table.Column<int>(nullable: true),
                    ModelsCode = table.Column<int>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    Brandcodebrand = table.Column<double>(nullable: true),
                    Code = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetVisit", x => x.IdVisit);
                    table.ForeignKey(
                        name: "FK_AspNetVisit_AspNetBrand_Brandcodebrand",
                        column: x => x.Brandcodebrand,
                        principalTable: "AspNetBrand",
                        principalColumn: "codebrand",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetVisit_AspNetOutlet_IdOutlet",
                        column: x => x.IdOutlet,
                        principalTable: "AspNetOutlet",
                        principalColumn: "IdOutlet",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetVisit_AspNetModels_ModelsCode",
                        column: x => x.ModelsCode,
                        principalTable: "AspNetModels",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetVisit_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetBrand_UserId",
                table: "AspNetBrand",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetModels_Brandcodebrand",
                table: "AspNetModels",
                column: "Brandcodebrand");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetModels_IdOutlet",
                table: "AspNetModels",
                column: "IdOutlet");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetModels_UserId",
                table: "AspNetModels",
                column: "UserId");

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
                name: "IX_AspNetVisit_Brandcodebrand",
                table: "AspNetVisit",
                column: "Brandcodebrand");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetVisit_IdOutlet",
                table: "AspNetVisit",
                column: "IdOutlet");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetVisit_ModelsCode",
                table: "AspNetVisit",
                column: "ModelsCode");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetVisit_UserId",
                table: "AspNetVisit",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetRoleMenuPermission");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetVisit");

            migrationBuilder.DropTable(
                name: "AspNetNavigationMenu");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetModels");

            migrationBuilder.DropTable(
                name: "AspNetBrand");

            migrationBuilder.DropTable(
                name: "AspNetOutlet");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
