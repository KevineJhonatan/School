using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddExistingLoginError : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DOB" },
                values: new object[] { new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(1831), new DateTime(2024, 3, 14, 23, 32, 45, 916, DateTimeKind.Local).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DOB" },
                values: new object[] { new DateTime(2024, 3, 14, 23, 32, 45, 924, DateTimeKind.Local).AddTicks(2650), new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2618) });

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 924, DateTimeKind.Local).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 924, DateTimeKind.Local).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 924, DateTimeKind.Local).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 924, DateTimeKind.Local).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 924, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 924, DateTimeKind.Local).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 924, DateTimeKind.Local).AddTicks(2907));

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 916, DateTimeKind.Local).AddTicks(1774));

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "SchoolYear",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 924, DateTimeKind.Local).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "SysParam",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "SysParam",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "SysParam",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "SysParam",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2154));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2560));

            migrationBuilder.InsertData(
                table: "SysParamValue",
                columns: new[] { "Id", "Code", "CreatedAt", "CreatedBy", "DecimalValue1", "IntValue1", "LongText1", "ShortText1", "SysParamId", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 42, "40013", new DateTime(2024, 3, 14, 23, 32, 45, 920, DateTimeKind.Local).AddTicks(2575), 1, null, null, "The specified login already exist", "Login", 4, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 42);

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

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7811));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 23, 13, 2, 174, DateTimeKind.Local).AddTicks(7870));
        }
    }
}
