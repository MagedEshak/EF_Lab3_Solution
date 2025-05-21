using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Lab3_Solution.Migrations
{
    /// <inheritdoc />
    public partial class seeding3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherID", "Address", "BirthOfDate", "Code", "HiringDate", "Jop", "Name", "NationalID", "Note", "Qualification", "QualificationDate", "SchoolID", "phone" },
                values: new object[] { 2, "Assuit", new DateTime(2000, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "MMM", new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teacher", "Maged", "340005687997", "ok", "IT", new DateTime(2020, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "0123456789" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherID", "Address", "BirthOfDate", "Code", "HiringDate", "Jop", "Name", "NationalID", "Note", "Qualification", "QualificationDate", "SchoolID", "phone" },
                values: new object[] { 1, "Assuit", new DateTime(2000, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "MMM", new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teacher", "Maged", "340005687997", "ok", "IT", new DateTime(2020, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "0123456789" });
        }
    }
}
