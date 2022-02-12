using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SlnErp102.Data.Migrations
{
    public partial class updateseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tblCompanies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3092), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3093) });

            migrationBuilder.UpdateData(
                table: "tblCompanies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3094), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "tblCompanies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3095), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2922), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2923) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2924), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2925), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2925) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2926), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2927) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2927), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2928) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2928), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2929) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3142), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3143), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3145), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3145), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3146), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3146), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3147) });

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn", "WorkEnd", "WorkStart" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3236), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3237), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3237), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3236), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn", "WorkEnd", "WorkStart" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3239), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3240), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3240), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3239), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn", "WorkEnd", "WorkStart" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3241), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3242), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3242), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3241), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2871), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2873), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2874) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2875), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2875) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2876), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2877), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2878), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2878) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2879), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2879) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2880), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2881) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2777), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2765) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2779), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2778) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2780), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2781), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2782), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2781) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2783), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2782) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2784), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2783) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2785), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2785) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2790), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(2789) });

            migrationBuilder.UpdateData(
                table: "tblProductEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "EntryDate", "ExpirationDate", "ModifiedUser", "ProductionDate", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3385), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3386), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3387), "system", new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3387), 100 });

            migrationBuilder.UpdateData(
                table: "tblProductEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "EntryDate", "ExpirationDate", "ModifiedUser", "ProductionDate", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3389), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3389), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3390), "system", new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3390), 200 });

            migrationBuilder.UpdateData(
                table: "tblProductEntries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "EntryDate", "ExpirationDate", "ModifiedUser", "ProductionDate", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3391), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3392), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3392), "system", new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3393), 50 });

            migrationBuilder.UpdateData(
                table: "tblProductEntries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "EntryDate", "ExpirationDate", "ModifiedUser", "ProductionDate", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3393), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3394), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3394), "system", new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3394), 150 });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "EntryDate", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3340), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3335), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "EntryDate", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3342), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3341), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3342) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "EntryDate", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3344), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3343), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "EntryDate", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3346), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3345), new DateTime(2022, 1, 19, 19, 43, 2, 937, DateTimeKind.Local).AddTicks(3346) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "tblCompanies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4607), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4608) });

            migrationBuilder.UpdateData(
                table: "tblCompanies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4609), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "tblCompanies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4611), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4611) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4441), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4441) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4443), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4443) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4444), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4444) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4445), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4445) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4446), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4446) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4447), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4652), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4653), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4654), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4655), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4656), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4656), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4656) });

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn", "WorkEnd", "WorkStart" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4747), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4748), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4748), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4746), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4746) });

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn", "WorkEnd", "WorkStart" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4750), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4750), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4751), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4749), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4749) });

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn", "WorkEnd", "WorkStart" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4752), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4753), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4753), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4752), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4751) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4371), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4371) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4373), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4374), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4375) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4375), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4377), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4377) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4378), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4378) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4379), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4380), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4232), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4233), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4234), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4234) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4235), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4235) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4236), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4236) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4237), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4237) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4238), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4237) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4239), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4238) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4269), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "tblProductEntries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "EntryDate", "ExpirationDate", "ModifiedUser", "ProductionDate", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4935), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4935), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4936), null, new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4937), 0 });

            migrationBuilder.UpdateData(
                table: "tblProductEntries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "EntryDate", "ExpirationDate", "ModifiedUser", "ProductionDate", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4938), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4938), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4939), null, new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4939), 0 });

            migrationBuilder.UpdateData(
                table: "tblProductEntries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "EntryDate", "ExpirationDate", "ModifiedUser", "ProductionDate", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4941), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4941), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4941), null, new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4942), 0 });

            migrationBuilder.UpdateData(
                table: "tblProductEntries",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "EntryDate", "ExpirationDate", "ModifiedUser", "ProductionDate", "Quantity" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4942), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4943), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4943), null, new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4944), 0 });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "EntryDate", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4883), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4878), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4884) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "EntryDate", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4886), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4885), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4887) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "EntryDate", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4888), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4887), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4888) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "EntryDate", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4891), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4889), new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4891) });
        }
    }
}
