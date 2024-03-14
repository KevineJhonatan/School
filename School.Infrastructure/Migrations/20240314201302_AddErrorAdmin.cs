using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace School.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddErrorAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DOB" },
                values: new object[] { new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(6953), new DateTime(2024, 3, 14, 23, 13, 2, 170, DateTimeKind.Local).AddTicks(324) });

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DOB" },
                values: new object[] { new DateTime(2024, 3, 14, 23, 13, 2, 178, DateTimeKind.Local).AddTicks(5370), new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7916) });

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 178, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 178, DateTimeKind.Local).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 178, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 178, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 178, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 178, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 178, DateTimeKind.Local).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 170, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "SchoolYear",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 178, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "SysParam",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "SysParam",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "SysParam",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7555));

            migrationBuilder.UpdateData(
                table: "SysParam",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7623));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.InsertData(
                table: "SysParamValue",
                columns: new[] { "Id", "Code", "CreatedAt", "CreatedBy", "DecimalValue1", "IntValue1", "LongText1", "ShortText1", "SysParamId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 25, "40005", new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7732), 1, null, null, "Invalid Firstname", "Firstname", 4, null, null },
                    { 26, "40006", new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7745), 1, null, null, "Invalid Lastname", "Lastname", 4, null, null },
                    { 27, "40007", new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7759), 1, null, null, "Invalid Birthdate", "Birthdate", 4, null, null },
                    { 28, "40008", new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7772), 1, null, null, "Invalid Birthdate format. The valid format is 'dd/MM/yyyy'", "Birthdate", 4, null, null },
                    { 29, "40009", new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7785), 1, null, null, "Invalid Gender. The only valid gender is 'M' or 'F'", "Gender", 4, null, null },
                    { 30, "40010", new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7798), 1, null, null, "Invalid Login for Admin", "Login", 4, null, null },
                    { 40, "40011", new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7811), 1, null, null, "Invalid Password", "Password", 4, null, null },
                    { 41, "40012", new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7870), 1, null, null, "The specified school does not exist", "SchoolID", 4, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DOB" },
                values: new object[] { new DateTime(2024, 3, 14, 21, 24, 17, 201, DateTimeKind.Local).AddTicks(1172), new DateTime(2024, 3, 14, 21, 24, 17, 197, DateTimeKind.Local).AddTicks(1262) });

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DOB" },
                values: new object[] { new DateTime(2024, 3, 14, 21, 24, 17, 205, DateTimeKind.Local).AddTicks(8013), new DateTime(2024, 3, 14, 21, 24, 17, 201, DateTimeKind.Local).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 205, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 205, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 205, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 205, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 205, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 205, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 205, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 197, DateTimeKind.Local).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 201, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "SchoolYear",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 205, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "SysParam",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 201, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "SysParam",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 201, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "SysParam",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 201, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "SysParam",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 201, DateTimeKind.Local).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 201, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 201, DateTimeKind.Local).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 201, DateTimeKind.Local).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 201, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 201, DateTimeKind.Local).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 201, DateTimeKind.Local).AddTicks(1398));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 201, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 201, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 201, DateTimeKind.Local).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 201, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 201, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 201, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 201, DateTimeKind.Local).AddTicks(1584));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 201, DateTimeKind.Local).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 201, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 201, DateTimeKind.Local).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 201, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 201, DateTimeKind.Local).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 201, DateTimeKind.Local).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 201, DateTimeKind.Local).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 201, DateTimeKind.Local).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 201, DateTimeKind.Local).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 21, 24, 17, 201, DateTimeKind.Local).AddTicks(1893));
        }
    }
}
