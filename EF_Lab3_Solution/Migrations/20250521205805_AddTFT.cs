using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Lab3_Solution.Migrations
{
    /// <inheritdoc />
    public partial class AddTFT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "SchoolID", "DepartmentID", "Name", "Type" },
                values: new object[] { 2, 1, "School1", "InterNational" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 1,
                columns: new[] { "BirthOfDate", "HiringDate", "QualificationDate" },
                values: new object[] { new DateTime(2025, 5, 21, 23, 58, 4, 910, DateTimeKind.Local).AddTicks(8102), new DateTime(2025, 5, 21, 23, 58, 4, 910, DateTimeKind.Local).AddTicks(8158), new DateTime(2025, 5, 21, 23, 58, 4, 910, DateTimeKind.Local).AddTicks(8163) });

            migrationBuilder.InsertData(
                table: "TeacherTranferes",
                columns: new[] { "TeacherTranfereID", "Date", "FromSchoolID", "TeacherID", "ToSchoolID" },
                values: new object[] { 1, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TeacherTranferes",
                keyColumn: "TeacherTranfereID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "SchoolID",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 1,
                columns: new[] { "BirthOfDate", "HiringDate", "QualificationDate" },
                values: new object[] { new DateTime(2025, 5, 21, 23, 50, 24, 564, DateTimeKind.Local).AddTicks(44), new DateTime(2025, 5, 21, 23, 50, 24, 564, DateTimeKind.Local).AddTicks(100), new DateTime(2025, 5, 21, 23, 50, 24, 564, DateTimeKind.Local).AddTicks(105) });
        }
    }
}
