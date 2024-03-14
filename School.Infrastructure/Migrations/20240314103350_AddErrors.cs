using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddErrors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "SysParam",
                columns: new[] { "Id", "Code", "CreatedAt", "CreatedBy", "Description", "Title", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 4, "ERRORS", new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3221), 1, "Errors", "Errors", null, null });

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
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(2998), 1 });

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
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3024), 1 });

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3032), 1 });

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3042), 1 });

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3051), 1 });

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3059), 1 });

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3066), 1 });

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3076), 1 });

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3137), 1 });

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3147), 1 });

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3163), 1 });

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3171), 1 });

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3178), 1 });

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3186), 1 });

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3194), 1 });

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3206), 1 });

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3214), 1 });

            migrationBuilder.InsertData(
                table: "SysParamValue",
                columns: new[] { "Id", "Code", "CreatedAt", "CreatedBy", "DecimalValue1", "IntValue1", "LongText1", "ShortText1", "SysParamId", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 20, "40001", new DateTime(2024, 3, 14, 13, 33, 50, 181, DateTimeKind.Local).AddTicks(3228), 1, null, null, "School name is mandatory", "Name", 4, null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SysParam",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DOB" },
                values: new object[] { new DateTime(2024, 3, 13, 16, 29, 52, 580, DateTimeKind.Local).AddTicks(6283), new DateTime(2024, 3, 13, 16, 29, 52, 578, DateTimeKind.Local).AddTicks(7633) });

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DOB" },
                values: new object[] { new DateTime(2024, 3, 13, 16, 29, 52, 582, DateTimeKind.Local).AddTicks(4894), new DateTime(2024, 3, 13, 16, 29, 52, 580, DateTimeKind.Local).AddTicks(6497) });

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 16, 29, 52, 582, DateTimeKind.Local).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 16, 29, 52, 582, DateTimeKind.Local).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 16, 29, 52, 582, DateTimeKind.Local).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 16, 29, 52, 582, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 16, 29, 52, 582, DateTimeKind.Local).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 16, 29, 52, 582, DateTimeKind.Local).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "Class",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 16, 29, 52, 582, DateTimeKind.Local).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 16, 29, 52, 578, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 16, 29, 52, 580, DateTimeKind.Local).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "SchoolYear",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 16, 29, 52, 582, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "SysParam",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 16, 29, 52, 580, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "SysParam",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 16, 29, 52, 580, DateTimeKind.Local).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "SysParam",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 16, 29, 52, 580, DateTimeKind.Local).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 16, 29, 52, 580, DateTimeKind.Local).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 13, 16, 29, 52, 580, DateTimeKind.Local).AddTicks(6323), 2 });

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 16, 29, 52, 580, DateTimeKind.Local).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 13, 16, 29, 52, 580, DateTimeKind.Local).AddTicks(6345), 2 });

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 13, 16, 29, 52, 580, DateTimeKind.Local).AddTicks(6370), 3 });

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 13, 16, 29, 52, 580, DateTimeKind.Local).AddTicks(6379), 4 });

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 13, 16, 29, 52, 580, DateTimeKind.Local).AddTicks(6386), 5 });

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 13, 16, 29, 52, 580, DateTimeKind.Local).AddTicks(6392), 6 });

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 13, 16, 29, 52, 580, DateTimeKind.Local).AddTicks(6398), 7 });

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 13, 16, 29, 52, 580, DateTimeKind.Local).AddTicks(6407), 8 });

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 13, 16, 29, 52, 580, DateTimeKind.Local).AddTicks(6413), 9 });

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 13, 16, 29, 52, 580, DateTimeKind.Local).AddTicks(6419), 10 });

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 13, 16, 29, 52, 580, DateTimeKind.Local).AddTicks(6431), 13 });

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 13, 16, 29, 52, 580, DateTimeKind.Local).AddTicks(6437), 14 });

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 13, 16, 29, 52, 580, DateTimeKind.Local).AddTicks(6443), 15 });

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 13, 16, 29, 52, 580, DateTimeKind.Local).AddTicks(6449), 16 });

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 13, 16, 29, 52, 580, DateTimeKind.Local).AddTicks(6455), 17 });

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 13, 16, 29, 52, 580, DateTimeKind.Local).AddTicks(6461), 18 });

            migrationBuilder.UpdateData(
                table: "SysParamValue",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "CreatedBy" },
                values: new object[] { new DateTime(2024, 3, 13, 16, 29, 52, 580, DateTimeKind.Local).AddTicks(6467), 19 });
        }
    }
}
