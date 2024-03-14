using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddClassId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Subject",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Subject_ClassId",
                table: "Subject",
                column: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_Class_ClassId",
                table: "Subject",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subject_Class_ClassId",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Subject_ClassId",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Subject");

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

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 20, 38, 33, 353, DateTimeKind.Local).AddTicks(5010));
        }
    }
}
