using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace School.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddLevelErrors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 41,
                column: "LongText1",
                value: "The specified school does not exist or disabled.");

            migrationBuilder.InsertData(
                table: "SysParamValue",
                columns: new[] { "Id", "Code", "CreatedAt", "CreatedBy", "DecimalValue1", "IntValue1", "LongText1", "ShortText1", "SysParamId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 47, "40018", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "The class name is mandatory.", "ClassName", 4, null, null },
                    { 48, "40019", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "The specified level does not exist or disabled.", "Level", 4, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 41,
                column: "LongText1",
                value: "The specified school does not exist.");
        }
    }
}
