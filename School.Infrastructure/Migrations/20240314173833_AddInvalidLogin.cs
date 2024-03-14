using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace School.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddInvalidLogin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DOB" },
                values: new object[] { new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(3547), new DateTime(2024, 3, 14, 20, 38, 33, 349, DateTimeKind.Local).AddTicks(1973) });

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DOB" },
                values: new object[] { new DateTime(2024, 3, 14, 20, 38, 33, 357, DateTimeKind.Local).AddTicks(293), new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 357, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 357, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 357, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 357, DateTimeKind.Local).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 357, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 357, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 357, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 349, DateTimeKind.Local).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "SchoolYear",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 357, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "SysParam",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "SysParam",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "SysParam",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "SysParam",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(4972));

            migrationBuilder.InsertData(
                table: "SysParamValue",
                columns: new[] { "Id", "Code", "CreatedAt", "CreatedBy", "DecimalValue1", "IntValue1", "LongText1", "ShortText1", "SysParamId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 21, "40002", new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(4985), 1, null, null, "Invalid UserId while creating token", "UserId", 4, null, null },
                    { 22, "40003", new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(4998), 1, null, null, "Invalid UserRole while creating token", "UserRole", 4, null, null },
                    { 24, "40004", new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(5010), 1, null, null, "Invalid Login or Password", "Credentials", 4, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DOB" },
                values: new object[] { new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(2906), new DateTime(2024, 3, 14, 13, 33, 50, 179, DateTimeKind.Local).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DOB" },
                values: new object[] { new DateTime(2024, 3, 14, 13, 33, 50, 183, DateTimeKind.Local).AddTicks(5000), new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 183, DateTimeKind.Local).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 183, DateTimeKind.Local).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 183, DateTimeKind.Local).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 183, DateTimeKind.Local).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 183, DateTimeKind.Local).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 183, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 183, DateTimeKind.Local).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 179, DateTimeKind.Local).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "SchoolYear",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 183, DateTimeKind.Local).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "SysParam",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "SysParam",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "SysParam",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "SysParam",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3137));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3228));
        }
    }
}
