using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SlnErp102.Data.Migrations
{
    public partial class addseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "tblProductEntries",
                columns: new[] { "Id", "Barcode", "CompanyId", "CreatedOn", "Description", "EntryDate", "EntryTypeId", "ExpirationDate", "InvoiceNumber", "LotSerial", "ModifiedOn", "ModifiedUser", "ProductId", "ProductionDate", "Quantity" },
                values: new object[,]
                {
                    { 1, "AR-1000/1", 1, new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4935), "TEST1", new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4935), 1, new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4936), "1234", "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4937), 0 },
                    { 2, "AR-1000/2", 1, new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4938), "TEST1", new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4938), 1, new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4939), "1234", "2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4939), 0 },
                    { 3, "AR-1001/1", 1, new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4941), "TEST1", new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4941), 1, new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4941), "1234", "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4942), 0 },
                    { 4, "AR-1002/1", 2, new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4942), "TEST1", new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4943), 1, new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4943), "4321", "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2022, 1, 19, 19, 39, 47, 759, DateTimeKind.Local).AddTicks(4944), 0 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tblProductEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tblProductEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tblProductEntries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tblProductEntries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "tblCompanies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8978), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8979) });

            migrationBuilder.UpdateData(
                table: "tblCompanies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8980), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8981) });

            migrationBuilder.UpdateData(
                table: "tblCompanies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8982), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8824), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8824) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8825), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8826), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8827), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8828) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8829), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "tblCompanyBranches",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8830), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9021), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9021), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9022) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9023), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9023), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "tblDoctors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9025), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9025), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9025) });

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn", "WorkEnd", "WorkStart" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9155), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9156), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9156), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9154), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn", "WorkEnd", "WorkStart" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9158), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9158), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9159), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9157), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "tblEmployees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDay", "CreatedOn", "ModifiedOn", "WorkEnd", "WorkStart" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9160), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9160), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9161), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9160), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9159) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8758), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8760), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8761) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8762), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8762) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8763), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8763) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8764), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8764) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8765), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8765) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8766), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "tblHospitalBranches",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8767), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8767) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8656), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8646) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8658), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8657) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8659), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8658) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8660), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8659) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8661), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8662), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8661) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8663), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8664), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "tblHospitals",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8665), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(8664) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "EntryDate", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9246), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9243), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "EntryDate", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9248), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9247), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9248) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "EntryDate", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9250), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9249), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "tblProducts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "EntryDate", "ModifiedOn" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9251), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9251), new DateTime(2022, 1, 19, 18, 21, 3, 881, DateTimeKind.Local).AddTicks(9252) });
        }
    }
}
