﻿// <auto-generated />
using System;
using CAP.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Client.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220322193210_sy")]
    partial class sy
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CAP.Data.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("CAP.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("CAP.Data.NavigationMenu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ActionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ControllerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("ExternalUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsExternal")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ParentMenuId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ParentMenuId");

                    b.ToTable("AspNetNavigationMenu");
                });

            modelBuilder.Entity("CAP.Data.Outlets", b =>
                {
                    b.Property<int>("IdOutlet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("A2C")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AVMonthly")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Account")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Activity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Antenna")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CONDOR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Channeltype")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Compte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPerson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPerson2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Coverage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Delegation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayPriority")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Displaystatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estann")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Keydealer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LGPromoters")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkGoogleMAPS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Outletstype")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("POSName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PromoterRemarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RACDisplay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("REFDisplay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Retailer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SIS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SODIG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoreClass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoreSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TVDisplay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("WMDisplay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdOutlet");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetOutlet");
                });

            modelBuilder.Entity("CAP.Data.RoleMenuPermission", b =>
                {
                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("NavigationMenuId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RoleId", "NavigationMenuId");

                    b.HasIndex("NavigationMenuId");

                    b.ToTable("AspNetRoleMenuPermission");
                });

            modelBuilder.Entity("CAP.Data.SammaryReport", b =>
                {
                    b.Property<int>("Idsammary")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("Brandscodebrand")
                        .HasColumnType("float");

                    b.Property<int?>("ModelsCode")
                        .HasColumnType("int");

                    b.Property<int?>("OutletsIdOutlet")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Idsammary");

                    b.HasIndex("Brandscodebrand");

                    b.HasIndex("ModelsCode");

                    b.HasIndex("OutletsIdOutlet");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetsammaryweekly");
                });

            modelBuilder.Entity("CAP.Data.Visits", b =>
                {
                    b.Property<int>("IdVisit")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Activity")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Article")
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Entrytime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Exittime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdOutlet")
                        .HasColumnType("int");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdVisit");

                    b.HasIndex("IdOutlet")
                        .IsUnique()
                        .HasFilter("[IdOutlet] IS NOT NULL");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetVisit");
                });

            modelBuilder.Entity("CAP.Data.brands", b =>
                {
                    b.Property<double>("codebrand")
                        .HasColumnType("float");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Namebrand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("VisitsIdVisit")
                        .HasColumnType("int");

                    b.HasKey("codebrand");

                    b.HasIndex("UserId");

                    b.HasIndex("VisitsIdVisit");

                    b.ToTable("AspNetBrand");
                });

            modelBuilder.Entity("CAP.Data.models", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Availibility")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Brandcodebrand")
                        .HasColumnType("float");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dimension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Disc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Display")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DryerCapa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnergyClass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Frosttype")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FrzCapa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdOutlet")
                        .HasColumnType("int");

                    b.Property<int>("IdVisit")
                        .HasColumnType("int");

                    b.Property<string>("MarketShare")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelName")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("OutterDisplay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProductType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Programs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("REFCapa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RPM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resolution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SMART")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Segment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShelfShare")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeCapacity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stock")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("WaterDispenser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Weeklysail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Code");

                    b.HasIndex("Brandcodebrand");

                    b.HasIndex("IdOutlet");

                    b.HasIndex("IdVisit");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetModels");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CAP.Data.NavigationMenu", b =>
                {
                    b.HasOne("CAP.Data.NavigationMenu", "ParentNavigationMenu")
                        .WithMany()
                        .HasForeignKey("ParentMenuId");
                });

            modelBuilder.Entity("CAP.Data.Outlets", b =>
                {
                    b.HasOne("CAP.Data.ApplicationUser", "User")
                        .WithMany("Outlets")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("CAP.Data.RoleMenuPermission", b =>
                {
                    b.HasOne("CAP.Data.NavigationMenu", "NavigationMenu")
                        .WithMany()
                        .HasForeignKey("NavigationMenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CAP.Data.SammaryReport", b =>
                {
                    b.HasOne("CAP.Data.brands", "Brands")
                        .WithMany("SammaryReports")
                        .HasForeignKey("Brandscodebrand");

                    b.HasOne("CAP.Data.models", "Models")
                        .WithMany()
                        .HasForeignKey("ModelsCode");

                    b.HasOne("CAP.Data.Outlets", "Outlets")
                        .WithMany()
                        .HasForeignKey("OutletsIdOutlet");

                    b.HasOne("CAP.Data.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("CAP.Data.Visits", b =>
                {
                    b.HasOne("CAP.Data.Outlets", "Outlets")
                        .WithOne("Visitss")
                        .HasForeignKey("CAP.Data.Visits", "IdOutlet");

                    b.HasOne("CAP.Data.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("CAP.Data.brands", b =>
                {
                    b.HasOne("CAP.Data.ApplicationUser", "User")
                        .WithMany("Brands")
                        .HasForeignKey("UserId");

                    b.HasOne("CAP.Data.Visits", "Visits")
                        .WithMany("Brand")
                        .HasForeignKey("VisitsIdVisit");
                });

            modelBuilder.Entity("CAP.Data.models", b =>
                {
                    b.HasOne("CAP.Data.brands", "Brand")
                        .WithMany("Models")
                        .HasForeignKey("Brandcodebrand")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CAP.Data.Outlets", "Outlets")
                        .WithMany()
                        .HasForeignKey("IdOutlet")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CAP.Data.Visits", "Visits")
                        .WithMany("Models")
                        .HasForeignKey("IdVisit")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CAP.Data.ApplicationUser", "User")
                        .WithMany("Models")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("CAP.Data.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CAP.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CAP.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("CAP.Data.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CAP.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CAP.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
