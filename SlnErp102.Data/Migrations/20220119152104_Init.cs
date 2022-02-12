﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SlnErp102.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblCities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Region = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblCompanyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCompanyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblDepartments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDepartments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblHospitalTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblHospitalTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblStockStates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LotSerial = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    ShelfQuantity = table.Column<int>(type: "int", nullable: false),
                    BranchQuantity = table.Column<int>(type: "int", nullable: false),
                    ConsignmentQuantity = table.Column<int>(type: "int", nullable: false),
                    TransferedProductQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblStockStates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblDoctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ClinicAddress = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    BirthDay = table.Column<DateTime>(type: "date", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "date", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "date", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDoctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblDoctors_tblCities_CityId",
                        column: x => x.CityId,
                        principalTable: "tblCities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    WorkStart = table.Column<DateTime>(type: "date", nullable: false),
                    WorkEnd = table.Column<DateTime>(type: "date", nullable: false),
                    BirthDay = table.Column<DateTime>(type: "date", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "date", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "date", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblEmployees_tblCities_CityId",
                        column: x => x.CityId,
                        principalTable: "tblCities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CompanyTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "date", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "date", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCompanies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblCompanies_tblCompanyTypes_CompanyTypeId",
                        column: x => x.CompanyTypeId,
                        principalTable: "tblCompanyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblHospitals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HospitalTypeId = table.Column<int>(type: "int", nullable: false),
                    HospitalName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "date", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "date", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblHospitals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblHospitals_tblHospitalTypes_HospitalTypeId",
                        column: x => x.HospitalTypeId,
                        principalTable: "tblHospitalTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblEmployeeDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Gsm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEmployeeDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblEmployeeDetails_tblDepartments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "tblDepartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblEmployeeDetails_tblEmployees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "tblEmployees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblCompanyBranches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    InvoiceTitle = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "date", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "date", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCompanyBranches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblCompanyBranches_tblCities_CityId",
                        column: x => x.CityId,
                        principalTable: "tblCities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblCompanyBranches_tblCompanies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tblCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblCompanyDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Officer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Gsm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCompanyDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblCompanyDetails_tblCompanies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tblCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblCompanyDetails_tblDepartments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "tblDepartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    EntryDate = table.Column<DateTime>(type: "date", nullable: false),
                    BranchNoId = table.Column<int>(type: "int", nullable: false),
                    Picture = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SutCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SutPrice = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false),
                    SutDescription = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "date", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "date", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblProducts_tblCompanies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tblCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblDoctorDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    HospitalId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gsm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDoctorDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblDoctorDetails_tblDoctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "tblDoctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblDoctorDetails_tblHospitals_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "tblHospitals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblHospitalBranches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HospitalId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: true),
                    InvoiceTitle = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "date", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "date", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblHospitalBranches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblHospitalBranches_tblCities_CityId",
                        column: x => x.CityId,
                        principalTable: "tblCities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblHospitalBranches_tblHospitals_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "tblHospitals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblProductEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EntryDate = table.Column<DateTime>(type: "date", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    LotSerial = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    EntryTypeId = table.Column<int>(type: "int", nullable: false),
                    Barcode = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    ProductionDate = table.Column<DateTime>(type: "date", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "date", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "date", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "date", nullable: false),
                    ModifiedUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProductEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblProductEntries_tblCompanies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "tblCompanies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tblProductEntries_tblProducts_ProductId",
                        column: x => x.ProductId,
                        principalTable: "tblProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblHospitalDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HospitalBranchId = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    Officer = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Gsm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblHospitalDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblHospitalDetails_tblDepartments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "tblDepartments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblHospitalDetails_tblHospitalBranches_HospitalBranchId",
                        column: x => x.HospitalBranchId,
                        principalTable: "tblHospitalBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "tblCities",
                columns: new[] { "Id", "Name", "Region" },
                values: new object[,]
                {
                    { 1, "Istanbul", "Marmara" },
                    { 2, "Ankara", "Ic Anadolu" },
                    { 3, "Izmir", "Ege" },
                    { 4, "Antalya", "Akdeniz" },
                    { 5, "Diyarbakir", "Guney Dogu Anadolu" },
                    { 6, "Samsun", "Karadeniz" },
                    { 7, "Kars", "Dogu Anadolu" }
                });

            migrationBuilder.InsertData(
                table: "tblCompanyTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Musteri" },
                    { 2, "Tedarikci" },
                    { 3, "Ana Satici" },
                    { 4, "Distributor" }
                });

            migrationBuilder.InsertData(
                table: "tblDepartments",
                columns: new[] { "Id", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Satin Alma", "H" },
                    { 2, "Finans", "H" },
                    { 3, "Ameliyathane", "H" },
                    { 4, "Rektorluk", "H" },
                    { 5, "IK", "H" },
                    { 6, "Hasta Haklari", "H" },
                    { 7, "Finans", "C" },
                    { 8, "Satin Alma", "C" },
                    { 9, "Depo", "C" },
                    { 10, "Sahip", "C" }
                });

            migrationBuilder.InsertData(
                table: "tblHospitalTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Ozel" },
                    { 2, "Devlet" },
                    { 3, "Sehir" },
                    { 4, "Universite" },
                    { 5, "Vakif" },
                    { 6, "Askeri" },
                    { 7, "Sb" },
                    { 8, "Klinik" },
                    { 9, "Arastirma" }
                });

            migrationBuilder.InsertData(
                table: "tblCompanies",
                columns: new[] { "Id", "CompanyTypeId", "CreatedOn", "ModifiedOn", "ModifiedUser", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8978), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8979), "system", "Ortek" },
                    { 2, 2, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8980), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8981), "system", "Syntex" },
                    { 3, 3, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8982), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8982), "system", "Kayacan" }
                });

            migrationBuilder.InsertData(
                table: "tblDoctors",
                columns: new[] { "Id", "BirthDay", "CityId", "ClinicAddress", "CreatedOn", "ModifiedOn", "ModifiedUser", "Name", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9021), 1, "Fulya/Besiktas", new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9021), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9022), "system", "Omer Taser", 0 },
                    { 2, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9023), 1, "Tesvikiye/Sisli", new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9023), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9024), "system", "Mehmet Demirhan", 0 },
                    { 3, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9025), 1, "Abide-i Hürriyet Cd No:166, 34381 Şişli/İstanbul", new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9025), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9025), "system", "Azmi Hamzaoglu", 0 }
                });

            migrationBuilder.InsertData(
                table: "tblEmployees",
                columns: new[] { "Id", "BirthDay", "CityId", "CreatedOn", "Description", "ModifiedOn", "ModifiedUser", "Name", "Picture", "WorkEnd", "WorkStart" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9155), 1, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9156), "Aciklama1", new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9156), "system", "Serdar", "user1.png", new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9154), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9154) },
                    { 2, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9158), 1, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9158), "Aciklama2", new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9159), "system", "Recep", "user2.png", new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9157), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9157) },
                    { 3, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9160), 1, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9160), "Aciklama3", new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9161), "system", "Melek", "user3.png", new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9160), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9159) }
                });

            migrationBuilder.InsertData(
                table: "tblHospitals",
                columns: new[] { "Id", "CreatedOn", "HospitalName", "HospitalTypeId", "ModifiedOn", "ModifiedUser" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8656), "AciBadem", 1, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8646), "system" },
                    { 2, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8658), "Florence Nightingale", 1, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8657), "system" },
                    { 3, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8659), "Medicana", 1, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8658), "system" },
                    { 4, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8660), "Beylikduzu Devlet", 2, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8659), "system" },
                    { 5, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8661), "KANUNİ SULTAN SÜLEYMAN", 9, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8660), "system" },
                    { 6, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8662), "Cam ve Sakura", 3, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8661), "system" },
                    { 7, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8663), "Kocaeli Üniversitesi Hastanesi", 4, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8662), "system" },
                    { 8, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8664), "Gata", 6, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8663), "system" },
                    { 9, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8665), "Bezmialem Vakıf Üni. Tıp Fakültesi Hastanesi", 7, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8664), "system" }
                });

            migrationBuilder.InsertData(
                table: "tblCompanyBranches",
                columns: new[] { "Id", "Address", "CityId", "CompanyId", "CreatedOn", "InvoiceTitle", "ModifiedOn", "ModifiedUser", "Name" },
                values: new object[,]
                {
                    { 1, "Esenyurt", 1, 1, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8824), "Ortek Ltd.Sti", new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8824), "system", "Merkez" },
                    { 2, "Izmir", 2, 1, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8825), "Ortek Ltd.Sti", new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8825), "system", "Izmir Sube" },
                    { 3, "Ankara", 3, 1, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8826), "Ortek Ltd.Sti", new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8827), "system", "Ankara Sube" },
                    { 4, "Esenyurt", 1, 2, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8827), "Ortek Ltd.Sti", new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8828), "system", "Merkez" },
                    { 5, "Izmir", 2, 2, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8829), "Ortek Ltd.Sti", new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8829), "system", "Izmir Sube" },
                    { 6, "Ankara", 3, 2, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8830), "Ortek Ltd.Sti", new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8830), "system", "Ankara Sube" }
                });

            migrationBuilder.InsertData(
                table: "tblCompanyDetails",
                columns: new[] { "Id", "CompanyId", "DepartmentId", "Email", "Fax", "Gsm", "Officer", "Phone" },
                values: new object[,]
                {
                    { 1, 1, 7, "111@gmail.com", "111", "111", "Sinan", "111" },
                    { 2, 1, 8, "222@gmail.com", "222", "222", "Sukran", "222" },
                    { 3, 1, 9, "333@gmail.com", "333", "333", "Turgay", "333" },
                    { 4, 1, 10, "444@gmail.com", "444", "444", "Tahir", "444" }
                });

            migrationBuilder.InsertData(
                table: "tblDoctorDetails",
                columns: new[] { "Id", "DoctorId", "Email", "Fax", "Gsm", "HospitalId", "Phone" },
                values: new object[,]
                {
                    { 1, 1, "taser@gmail.com", "111", "111", 1, "111" },
                    { 2, 2, "demirhan@gmail.com", "222", "222", 3, "222" },
                    { 3, 3, "hamzaoglu@gmail.com", "333", "333", 2, "333" },
                    { 4, 3, "", "", "", 6, "444" }
                });

            migrationBuilder.InsertData(
                table: "tblEmployeeDetails",
                columns: new[] { "Id", "DepartmentId", "Email", "EmployeeId", "Fax", "Gsm", "Phone" },
                values: new object[,]
                {
                    { 1, 1, "111@gmail.com", 1, "234", "1234", "1234" },
                    { 2, 2, "222@gmail.com", 2, "234", "1234", "1234" },
                    { 3, 3, "333@gmail.com", 3, "234", "1234", "1234" }
                });

            migrationBuilder.InsertData(
                table: "tblHospitalBranches",
                columns: new[] { "Id", "Address", "CityId", "CreatedOn", "HospitalId", "InvoiceTitle", "ModifiedOn", "ModifiedUser", "Name" },
                values: new object[,]
                {
                    { 1, "Acibadem/Kadikoy", 1, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8758), 1, "Acibadem Saglik Hizmetleri A.S.", new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8759), "system", "Merkez" },
                    { 2, "Çankaya/Ankara", 1, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8760), 1, "Acibadem Saglik Hizmetleri A.S.", new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8761), "system", "Ankara" },
                    { 3, "Tepebaşı/Eskişehir", 1, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8762), 1, "Acibadem Saglik Hizmetleri A.S.", new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8762), "system", "Eskisehir" },
                    { 4, "Şişli/İstanbul", 1, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8763), 2, "Florence Nightingale Saglik Hizmetleri A.S.", new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8763), "system", "Merkez" },
                    { 5, "Beylikdüzü/İstanbul", 1, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8764), 3, "Medikana Saglik Hizmetleri A.S.", new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8764), "system", "Merkez" },
                    { 6, "Beylikdüzü/İstanbul", 1, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8765), 4, "Devlet Saglik Hizmetleri A.S.", new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8765), "system", "Merkez" },
                    { 7, "Gazi Osman Pasa/İstanbul", 1, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8766), 5, "Devlet Saglik Hizmetleri A.S.", new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8766), "system", "Merkez" },
                    { 8, "Basaksehir/İstanbul", 1, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8767), 6, "Devlet Saglik Hizmetleri A.S.", new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8767), "system", "Merkez" }
                });

            migrationBuilder.InsertData(
                table: "tblProducts",
                columns: new[] { "Id", "BranchNoId", "CompanyId", "CreatedOn", "Description", "EntryDate", "ModifiedOn", "ModifiedUser", "Picture", "ProductCode", "SutCode", "SutDescription", "SutPrice" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9246), "Suture Passer, Transosseous", new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9243), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9246), "system", "product1.jpg", "AR-1000", "AE-1000", "DÜZ TİTANYUM", 125.75m },
                    { 2, 2, 1, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9248), "Suture Passer, Transosseous1", new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9247), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9248), "system", "product2.jpg", "AR-1001", "AE-1001", "DÜZ TİTANYUM", 155.75m },
                    { 3, 1, 1, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9250), "Suture Passer, Transosseous2", new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9249), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9250), "system", "product3.jpg", "AR-1002", "AE-1002", "DÜZ TİTANYUM", 115.75m },
                    { 4, 1, 1, new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9251), "Suture Passer, Transosseous3", new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9251), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9252), "system", "product4.jpg", "AR-1003", "AE-1003", "DÜZ TİTANYUM", 215.25m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblCompanies_CompanyTypeId",
                table: "tblCompanies",
                column: "CompanyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCompanyBranches_CityId",
                table: "tblCompanyBranches",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCompanyBranches_CompanyId",
                table: "tblCompanyBranches",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCompanyDetails_CompanyId",
                table: "tblCompanyDetails",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCompanyDetails_DepartmentId",
                table: "tblCompanyDetails",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_tblDoctorDetails_DoctorId",
                table: "tblDoctorDetails",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_tblDoctorDetails_HospitalId",
                table: "tblDoctorDetails",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_tblDoctors_CityId",
                table: "tblDoctors",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_tblEmployeeDetails_DepartmentId",
                table: "tblEmployeeDetails",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_tblEmployeeDetails_EmployeeId",
                table: "tblEmployeeDetails",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_tblEmployees_CityId",
                table: "tblEmployees",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_tblHospitalBranches_CityId",
                table: "tblHospitalBranches",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_tblHospitalBranches_HospitalId",
                table: "tblHospitalBranches",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_tblHospitalDetails_DepartmentId",
                table: "tblHospitalDetails",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_tblHospitalDetails_HospitalBranchId",
                table: "tblHospitalDetails",
                column: "HospitalBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_tblHospitals_HospitalTypeId",
                table: "tblHospitals",
                column: "HospitalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_tblProductEntries_CompanyId",
                table: "tblProductEntries",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tblProductEntries_ProductId",
                table: "tblProductEntries",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_tblProducts_CompanyId",
                table: "tblProducts",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblCompanyBranches");

            migrationBuilder.DropTable(
                name: "tblCompanyDetails");

            migrationBuilder.DropTable(
                name: "tblDoctorDetails");

            migrationBuilder.DropTable(
                name: "tblEmployeeDetails");

            migrationBuilder.DropTable(
                name: "tblHospitalDetails");

            migrationBuilder.DropTable(
                name: "tblProductEntries");

            migrationBuilder.DropTable(
                name: "tblStockStates");

            migrationBuilder.DropTable(
                name: "tblDoctors");

            migrationBuilder.DropTable(
                name: "tblEmployees");

            migrationBuilder.DropTable(
                name: "tblDepartments");

            migrationBuilder.DropTable(
                name: "tblHospitalBranches");

            migrationBuilder.DropTable(
                name: "tblProducts");

            migrationBuilder.DropTable(
                name: "tblCities");

            migrationBuilder.DropTable(
                name: "tblHospitals");

            migrationBuilder.DropTable(
                name: "tblCompanies");

            migrationBuilder.DropTable(
                name: "tblHospitalTypes");

            migrationBuilder.DropTable(
                name: "tblCompanyTypes");
        }
    }
}
