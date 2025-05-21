using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Lab3_Solution.Migrations
{
    /// <inheritdoc />
    public partial class Seeding1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentID", "Name" },
                values: new object[] { 1, "Dep" });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "SchoolID", "DepartmentID", "Name", "Type" },
                values: new object[] { 1, 1, "School1", "National" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherID", "Address", "BirthOfDate", "Code", "HiringDate", "Jop", "Name", "NationalID", "Note", "Qualification", "QualificationDate", "SchoolID", "phone" },
                values: new object[] { 1, "Assuit", new DateTime(2025, 5, 21, 23, 50, 24, 564, DateTimeKind.Local).AddTicks(44), "MMM", new DateTime(2025, 5, 21, 23, 50, 24, 564, DateTimeKind.Local).AddTicks(100), "Teacher", "Maged", "340005687997", "ok", "IT", new DateTime(2025, 5, 21, 23, 50, 24, 564, DateTimeKind.Local).AddTicks(105), 1, "0123456789" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "SchoolID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DepartmentID",
                keyValue: 1);
        }
    }
}
