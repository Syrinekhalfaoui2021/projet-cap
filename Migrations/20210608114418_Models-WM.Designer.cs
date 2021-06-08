﻿// <auto-generated />
using System;
using CE.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CE.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210608114418_Models-WM")]
    partial class ModelsWM
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CE.Data.ApplicationRole", b =>
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

            modelBuilder.Entity("CE.Data.ApplicationUser", b =>
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

            modelBuilder.Entity("CE.Data.NavigationMenu", b =>
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

            modelBuilder.Entity("CE.Data.Outlets", b =>
                {
                    b.Property<int>("IdOutlet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Activity")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Channel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Class")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Compte")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Keydealer")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Latitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitude")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("NameOutlet")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Outletstype")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Retailer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Zone")
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("IdOutlet");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetOutlet");
                });

            modelBuilder.Entity("CE.Data.RoleMenuPermission", b =>
                {
                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("NavigationMenuId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RoleId", "NavigationMenuId");

                    b.HasIndex("NavigationMenuId");

                    b.ToTable("AspNetRoleMenuPermission");
                });

            modelBuilder.Entity("CE.Data.SammaryReport", b =>
                {
                    b.Property<int>("Idsammary")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ACCode")
                        .HasColumnType("int");

                    b.Property<double?>("Brandscodebrand")
                        .HasColumnType("float");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ModelsCode")
                        .HasColumnType("int");

                    b.Property<int?>("OutletsIdOutlet")
                        .HasColumnType("int");

                    b.Property<int?>("REFCode")
                        .HasColumnType("int");

                    b.Property<int?>("TvCode")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("WmCode")
                        .HasColumnType("int");

                    b.HasKey("Idsammary");

                    b.HasIndex("ACCode");

                    b.HasIndex("Brandscodebrand");

                    b.HasIndex("ModelsCode");

                    b.HasIndex("OutletsIdOutlet");

                    b.HasIndex("REFCode");

                    b.HasIndex("TvCode");

                    b.HasIndex("UserId");

                    b.HasIndex("WmCode");

                    b.ToTable("AspNetsammaryweekly");

                    b.HasDiscriminator<string>("Discriminator").HasValue("SammaryReport");
                });

            modelBuilder.Entity("CE.Data.Visits", b =>
                {
                    b.Property<int>("IdVisit")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Activity")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Article")
                        .HasColumnType("nvarchar(250)");

                    b.Property<double?>("Brandcodebrand")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Entrytime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Exittime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdOutlet")
                        .HasColumnType("int");

                    b.Property<int?>("ModelsCode")
                        .HasColumnType("int");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdVisit");

                    b.HasIndex("Brandcodebrand");

                    b.HasIndex("IdOutlet")
                        .IsUnique()
                        .HasFilter("[IdOutlet] IS NOT NULL");

                    b.HasIndex("ModelsCode");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetVisit");
                });

            modelBuilder.Entity("CE.Data.Visitsmonthly", b =>
                {
                    b.Property<int>("IdVisit")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Activity")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Article")
                        .HasColumnType("nvarchar(250)");

                    b.Property<double?>("Brandcodebrand")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Entrytime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Exittime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdOutlet")
                        .HasColumnType("int");

                    b.Property<int?>("ModelsCode")
                        .HasColumnType("int");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdVisit");

                    b.HasIndex("Brandcodebrand");

                    b.HasIndex("IdOutlet")
                        .IsUnique()
                        .HasFilter("[IdOutlet] IS NOT NULL");

                    b.HasIndex("ModelsCode");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetVisitmonthly");
                });

            modelBuilder.Entity("CE.Data.Visitsweekly", b =>
                {
                    b.Property<int>("IdVisit")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Activity")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Article")
                        .HasColumnType("nvarchar(250)");

                    b.Property<double?>("Brandcodebrand")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Entrytime")
                        .HasColumnType("datetime2");

                    b.Property<DateTimeOffset>("Exittime")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("IdOutlet")
                        .HasColumnType("int");

                    b.Property<int?>("ModelsCode")
                        .HasColumnType("int");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdVisit");

                    b.HasIndex("Brandcodebrand");

                    b.HasIndex("IdOutlet")
                        .IsUnique()
                        .HasFilter("[IdOutlet] IS NOT NULL");

                    b.HasIndex("ModelsCode");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetVisitweekly");
                });

            modelBuilder.Entity("CE.Data.brands", b =>
                {
                    b.Property<double>("codebrand")
                        .HasColumnType("float");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Namebrand")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("codebrand");

                    b.ToTable("AspNetBrand");
                });

            modelBuilder.Entity("CE.Data.models", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Availibility")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Brandcodebrand")
                        .HasColumnType("float");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodeBP")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Display")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MarketShare")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Namebrand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OutletsIdOutlet")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ShelfShare")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stock")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Weeklysail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("typee")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Code");

                    b.HasIndex("Brandcodebrand");

                    b.HasIndex("OutletsIdOutlet");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetModels");

                    b.HasDiscriminator<string>("Name").HasValue("models_base");
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

            modelBuilder.Entity("CE.Data.SammaryReportMonthly", b =>
                {
                    b.HasBaseType("CE.Data.SammaryReport");

                    b.Property<int>("IdSammaryReportMonthly")
                        .HasColumnType("int");

                    b.ToTable("AspNetsammaryweekly");

                    b.HasDiscriminator().HasValue("SammaryReportMonthly");
                });

            modelBuilder.Entity("CE.Data.SammaryReportWeekly", b =>
                {
                    b.HasBaseType("CE.Data.SammaryReport");

                    b.Property<int>("IdSammaryReportWeekly")
                        .HasColumnType("int");

                    b.ToTable("AspNetsammaryweekly");

                    b.HasDiscriminator().HasValue("SammaryReportWeekly");
                });

            modelBuilder.Entity("CE.Data.AC", b =>
                {
                    b.HasBaseType("CE.Data.models");

                    b.Property<int>("Classac")
                        .HasColumnType("int");

                    b.Property<string>("Energeticclass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Inverter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Puissance")
                        .HasColumnType("float");

                    b.Property<string>("TypeAC")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("AspNetModels");

                    b.HasDiscriminator().HasValue("models_AC");
                });

            modelBuilder.Entity("CE.Data.REF", b =>
                {
                    b.HasBaseType("CE.Data.models");

                    b.Property<double>("Capacity")
                        .HasColumnType("float");

                    b.Property<string>("Class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("EnergeticClassREf")
                        .HasColumnType("float");

                    b.Property<int>("Energy")
                        .HasColumnType("int");

                    b.Property<string>("Frost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Segment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Segment2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Technology")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeREF2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Typeref")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Waterdispenser")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("AspNetModels");

                    b.HasDiscriminator().HasValue("models_ref");
                });

            modelBuilder.Entity("CE.Data.TV", b =>
                {
                    b.HasBaseType("CE.Data.models");

                    b.Property<int>("Class")
                        .HasColumnName("TV_Class")
                        .HasColumnType("int");

                    b.Property<string>("Form")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("HDMI")
                        .HasColumnType("float");

                    b.Property<string>("Integrated_Receiver")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resolution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegmentTV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SizeCategory")
                        .HasColumnType("int");

                    b.Property<string>("SmartTV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeTV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("USB")
                        .HasColumnType("float");

                    b.ToTable("AspNetModels");

                    b.HasDiscriminator().HasValue("models_TV");
                });

            modelBuilder.Entity("CE.Data.WM", b =>
                {
                    b.HasBaseType("CE.Data.models");

                    b.Property<double>("Capacity")
                        .HasColumnName("WM_Capacity")
                        .HasColumnType("float");

                    b.Property<string>("Class")
                        .HasColumnName("WM_Class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnName("WM_Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DryerCapacity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Drying")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Motor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SizeCategory")
                        .HasColumnName("WM_SizeCategory")
                        .HasColumnType("int");

                    b.Property<string>("Technology")
                        .HasColumnName("WM_Technology")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeWM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeWM2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("segementWM")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("AspNetModels");

                    b.HasDiscriminator().HasValue("models_wm");
                });

            modelBuilder.Entity("CE.Data.NavigationMenu", b =>
                {
                    b.HasOne("CE.Data.NavigationMenu", "ParentNavigationMenu")
                        .WithMany()
                        .HasForeignKey("ParentMenuId");
                });

            modelBuilder.Entity("CE.Data.Outlets", b =>
                {
                    b.HasOne("CE.Data.ApplicationUser", "User")
                        .WithMany("Outlets")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("CE.Data.RoleMenuPermission", b =>
                {
                    b.HasOne("CE.Data.NavigationMenu", "NavigationMenu")
                        .WithMany()
                        .HasForeignKey("NavigationMenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CE.Data.SammaryReport", b =>
                {
                    b.HasOne("CE.Data.AC", "AC")
                        .WithMany()
                        .HasForeignKey("ACCode");

                    b.HasOne("CE.Data.brands", "Brands")
                        .WithMany("SammaryReports")
                        .HasForeignKey("Brandscodebrand");

                    b.HasOne("CE.Data.models", "Models")
                        .WithMany()
                        .HasForeignKey("ModelsCode");

                    b.HasOne("CE.Data.Outlets", "Outlets")
                        .WithMany()
                        .HasForeignKey("OutletsIdOutlet");

                    b.HasOne("CE.Data.REF", "REF")
                        .WithMany()
                        .HasForeignKey("REFCode");

                    b.HasOne("CE.Data.TV", "Tv")
                        .WithMany()
                        .HasForeignKey("TvCode");

                    b.HasOne("CE.Data.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.HasOne("CE.Data.WM", "Wm")
                        .WithMany()
                        .HasForeignKey("WmCode");
                });

            modelBuilder.Entity("CE.Data.Visits", b =>
                {
                    b.HasOne("CE.Data.brands", "Brand")
                        .WithMany()
                        .HasForeignKey("Brandcodebrand");

                    b.HasOne("CE.Data.Outlets", "Outlets")
                        .WithOne("Visitss")
                        .HasForeignKey("CE.Data.Visits", "IdOutlet");

                    b.HasOne("CE.Data.models", "Models")
                        .WithMany()
                        .HasForeignKey("ModelsCode");

                    b.HasOne("CE.Data.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("CE.Data.Visitsmonthly", b =>
                {
                    b.HasOne("CE.Data.brands", "Brand")
                        .WithMany()
                        .HasForeignKey("Brandcodebrand");

                    b.HasOne("CE.Data.Outlets", "Outlet")
                        .WithOne("Visitssmonthly")
                        .HasForeignKey("CE.Data.Visitsmonthly", "IdOutlet");

                    b.HasOne("CE.Data.models", "Models")
                        .WithMany()
                        .HasForeignKey("ModelsCode");

                    b.HasOne("CE.Data.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("CE.Data.Visitsweekly", b =>
                {
                    b.HasOne("CE.Data.brands", "Brand")
                        .WithMany()
                        .HasForeignKey("Brandcodebrand");

                    b.HasOne("CE.Data.Outlets", "Outlets")
                        .WithOne("Visitssweekly")
                        .HasForeignKey("CE.Data.Visitsweekly", "IdOutlet");

                    b.HasOne("CE.Data.models", "Models")
                        .WithMany()
                        .HasForeignKey("ModelsCode");

                    b.HasOne("CE.Data.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("CE.Data.models", b =>
                {
                    b.HasOne("CE.Data.brands", "Brand")
                        .WithMany("Models")
                        .HasForeignKey("Brandcodebrand");

                    b.HasOne("CE.Data.Outlets", "Outlets")
                        .WithMany()
                        .HasForeignKey("OutletsIdOutlet");

                    b.HasOne("CE.Data.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("CE.Data.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CE.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CE.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("CE.Data.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CE.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CE.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
