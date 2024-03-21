using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace School.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "School",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DOB = table.Column<DateTime>(type: "date", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysParam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysParam", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DOB = table.Column<DateTime>(type: "date", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DOB = table.Column<DateTime>(type: "date", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    IsSuper = table.Column<bool>(type: "bit", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Admin_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SchoolYear",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "date", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolYear", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchoolYear_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tutor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    DOB = table.Column<DateTime>(type: "date", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    IsParent = table.Column<bool>(type: "bit", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tutor_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SysParamValue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ShortText1 = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    LongText1 = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true),
                    IntValue1 = table.Column<int>(type: "int", nullable: true),
                    DecimalValue1 = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    SysParamId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysParamValue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SysParamValue_SysParam_SysParamId",
                        column: x => x.SysParamId,
                        principalTable: "SysParam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Level_Id = table.Column<int>(type: "int", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Class_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Class_SysParamValue_Level_Id",
                        column: x => x.Level_Id,
                        principalTable: "SysParamValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    SchoolYearId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentHistory_Class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentHistory_SchoolYear_SchoolYearId",
                        column: x => x.SchoolYearId,
                        principalTable: "SchoolYear",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentHistory_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subject_Class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClassCalendar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayOfWeek_Id = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time(0)", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time(0)", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    SchoolYearId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassCalendar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassCalendar_Class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassCalendar_SchoolYear_SchoolYearId",
                        column: x => x.SchoolYearId,
                        principalTable: "SchoolYear",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassCalendar_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassCalendar_SysParamValue_DayOfWeek_Id",
                        column: x => x.DayOfWeek_Id,
                        principalTable: "SysParamValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClassCalendar_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Attendance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttendanceDate = table.Column<DateTime>(type: "date", nullable: false),
                    Status_Id = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    ClassCalendarId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendance_ClassCalendar_ClassCalendarId",
                        column: x => x.ClassCalendarId,
                        principalTable: "ClassCalendar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Attendance_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Attendance_SysParamValue_Status_Id",
                        column: x => x.Status_Id,
                        principalTable: "SysParamValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "School",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "IsActive", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 1, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "AdminSchool", false, "AdminSchool", null, null });

            migrationBuilder.InsertData(
                table: "School",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 2, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Vitale", "Vitale", null, null });

            migrationBuilder.InsertData(
                table: "SysParam",
                columns: new[] { "Id", "Code", "CreatedAt", "CreatedBy", "Description", "Title", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "ATTENDANCE_STATUS", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Présence", "Présence", null, null },
                    { 2, "CLASS_LEVEL", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Niveau", "Niveau", null, null },
                    { 3, "DAY_OF_WEEK", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Jours de la semaine", "Jours de la semaine", null, null },
                    { 4, "ERRORS", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Errors", "Errors", null, null }
                });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DOB", "Description", "Firstname", "Gender", "IsSuper", "Lastname", "Login", "Password", "SchoolId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Admin", "M", true, "Admin", "Admin", "9d1dcd944007aae2128b93513c1ed1eb3e4fa952a356d51205d82f2b668d6438", 1, null, null },
                    { 2, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Camil", "M", false, "Vitale", "vitale@gmail.com", "9683f1c52eb029d8550223700c87e3e21127c5142301c2be1f0670ca65c9f1b0", 2, null, null }
                });

            migrationBuilder.InsertData(
                table: "SchoolYear",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "EndDate", "SchoolId", "StartDate", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 1, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.InsertData(
                table: "SysParamValue",
                columns: new[] { "Id", "Code", "CreatedAt", "CreatedBy", "DecimalValue1", "IntValue1", "LongText1", "ShortText1", "SysParamId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "PRESENT", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, null, "Present", 1, null, null },
                    { 2, "ABSENT", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, null, "Absent", 1, null, null },
                    { 3, "CLASS_LEVEL_1", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 1, null, "Petite section", 2, null, null },
                    { 4, "CLASS_LEVEL_2", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 2, null, "Moyenne section", 2, null, null },
                    { 5, "CLASS_LEVEL_3", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 3, null, "Grande section", 2, null, null },
                    { 6, "CLASS_LEVEL_4", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 4, null, "Maternelle", 2, null, null },
                    { 7, "CLASS_LEVEL_5", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 5, null, "12 ème", 2, null, null },
                    { 8, "CLASS_LEVEL_6", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 6, null, "11 ème", 2, null, null },
                    { 9, "CLASS_LEVEL_7", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 7, null, "10 ème", 2, null, null },
                    { 10, "CLASS_LEVEL_8", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 8, null, "0 ème", 2, null, null },
                    { 11, "CLASS_LEVEL_9", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 9, null, "8 ème", 2, null, null },
                    { 12, "CLASS_LEVEL_10", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 10, null, "7 ème", 2, null, null },
                    { 13, "MONDAY", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 1, null, "Lundi", 3, null, null },
                    { 14, "TUESDAY", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 2, null, "Mardi", 3, null, null },
                    { 15, "WEDNESDAY", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 3, null, "Mercredi", 3, null, null },
                    { 16, "THURSDAY", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 4, null, "Jeudi", 3, null, null },
                    { 17, "FRIDAY", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 5, null, "Vendredi", 3, null, null },
                    { 18, "SATURDAY", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 6, null, "Samedi", 3, null, null },
                    { 19, "SUNDAY", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 7, null, "Dimanche", 3, null, null },
                    { 20, "40001", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "School name is mandatory", "Name", 4, null, null },
                    { 21, "40002", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Invalid UserId while creating token", "UserId", 4, null, null },
                    { 22, "40003", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Invalid UserRole while creating token", "UserRole", 4, null, null },
                    { 24, "40004", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Invalid Login or Password", "Credentials", 4, null, null },
                    { 25, "40005", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Invalid Firstname", "Firstname", 4, null, null },
                    { 26, "40006", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Invalid Lastname", "Lastname", 4, null, null },
                    { 27, "40007", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Invalid Birthdate", "Birthdate", 4, null, null },
                    { 28, "40008", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Invalid Birthdate format. The valid format is 'dd/MM/yyyy'", "Birthdate", 4, null, null },
                    { 29, "40009", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Invalid Gender. The only valid gender is 'M' or 'F'", "Gender", 4, null, null },
                    { 30, "40010", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Invalid Login for Admin", "Login", 4, null, null },
                    { 40, "40011", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Invalid Password", "Password", 4, null, null },
                    { 41, "40012", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "The specified school does not exist", "SchoolID", 4, null, null },
                    { 42, "40013", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "The specified login already exist", "Login", 4, null, null },
                    { 43, "40014", new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "The password length must be greater than 10 characters", "Password", 4, null, null }
                });

            migrationBuilder.InsertData(
                table: "Class",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "Level_Id", "Name", "SchoolId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "", 6, "Maternnel", 2, null, null },
                    { 2, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "", 7, "12 ème", 2, null, null },
                    { 3, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "", 8, "11 ème", 2, null, null },
                    { 4, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "", 9, "10 ème", 2, null, null },
                    { 5, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "", 10, "9 ème", 2, null, null },
                    { 6, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "", 11, "8 ème", 2, null, null },
                    { 7, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "", 12, "7 ème", 2, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admin_SchoolId",
                table: "Admin",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_ClassCalendarId",
                table: "Attendance",
                column: "ClassCalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_Status_Id",
                table: "Attendance",
                column: "Status_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_StudentId",
                table: "Attendance",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Class_Level_Id",
                table: "Class",
                column: "Level_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Class_SchoolId",
                table: "Class",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassCalendar_ClassId",
                table: "ClassCalendar",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassCalendar_DayOfWeek_Id",
                table: "ClassCalendar",
                column: "DayOfWeek_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ClassCalendar_SchoolYearId",
                table: "ClassCalendar",
                column: "SchoolYearId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassCalendar_SubjectId",
                table: "ClassCalendar",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassCalendar_TeacherId",
                table: "ClassCalendar",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolYear_SchoolId",
                table: "SchoolYear",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentHistory_ClassId",
                table: "StudentHistory",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentHistory_SchoolYearId",
                table: "StudentHistory",
                column: "SchoolYearId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentHistory_StudentId",
                table: "StudentHistory",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_ClassId",
                table: "Subject",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_SysParamValue_SysParamId",
                table: "SysParamValue",
                column: "SysParamId");

            migrationBuilder.CreateIndex(
                name: "IX_Tutor_StudentId",
                table: "Tutor",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Attendance");

            migrationBuilder.DropTable(
                name: "StudentHistory");

            migrationBuilder.DropTable(
                name: "Tutor");

            migrationBuilder.DropTable(
                name: "ClassCalendar");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "SchoolYear");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "School");

            migrationBuilder.DropTable(
                name: "SysParamValue");

            migrationBuilder.DropTable(
                name: "SysParam");
        }
    }
}
