using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace School.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddSchoolYearErrors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 20,
                column: "LongText1",
                value: "School name is mandatory.");

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 21,
                column: "LongText1",
                value: "Invalid UserId while creating token.");

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 22,
                column: "LongText1",
                value: "Invalid UserRole while creating token.");

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 24,
                column: "LongText1",
                value: "Invalid Login or Password. Or the user may be disabled.");

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 25,
                column: "LongText1",
                value: "Invalid Firstname.");

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 26,
                column: "LongText1",
                value: "Invalid Lastname.");

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 27,
                column: "LongText1",
                value: "Invalid Birthdate.");

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 28,
                column: "LongText1",
                value: "Invalid Birthdate format. The valid format is 'dd/MM/yyyy'.");

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 29,
                column: "LongText1",
                value: "Invalid Gender. The only valid gender is 'M' or 'F'.");

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 30,
                column: "LongText1",
                value: "Invalid Login for Admin.");

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 40,
                column: "LongText1",
                value: "Invalid Password.");

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 41,
                column: "LongText1",
                value: "The specified school does not exist.");

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 42,
                column: "LongText1",
                value: "The specified login already exist.");

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 43,
                column: "LongText1",
                value: "The password must contains at least 10 characters.");

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 44,
                column: "LongText1",
                value: "The admin user does not exist.");

            migrationBuilder.InsertData(
                table: "SysParamValue",
                columns: new[] { "Id", "Code", "CreatedAt", "CreatedBy", "DecimalValue1", "IntValue1", "LongText1", "ShortText1", "SysParamId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 45, "40016", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "The EndDate must be greater than StartDate.", "SchoolYearDate", 4, null, null },
                    { 46, "40017", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "The specified school does not belong to the user in session.", "School", 4, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 20,
                column: "LongText1",
                value: "School name is mandatory");

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 21,
                column: "LongText1",
                value: "Invalid UserId while creating token");

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 22,
                column: "LongText1",
                value: "Invalid UserRole while creating token");

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 24,
                column: "LongText1",
                value: "Invalid Login or Password");

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 25,
                column: "LongText1",
                value: "Invalid Firstname");

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 26,
                column: "LongText1",
                value: "Invalid Lastname");

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 27,
                column: "LongText1",
                value: "Invalid Birthdate");

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 28,
                column: "LongText1",
                value: "Invalid Birthdate format. The valid format is 'dd/MM/yyyy'");

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 29,
                column: "LongText1",
                value: "Invalid Gender. The only valid gender is 'M' or 'F'");

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 30,
                column: "LongText1",
                value: "Invalid Login for Admin");

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 40,
                column: "LongText1",
                value: "Invalid Password");

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 41,
                column: "LongText1",
                value: "The specified school does not exist");

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 42,
                column: "LongText1",
                value: "The specified login already exist");

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 43,
                column: "LongText1",
                value: "The password length must be greater than 10 characters");

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 44,
                column: "LongText1",
                value: "The admin user does not exist");
        }
    }
}
