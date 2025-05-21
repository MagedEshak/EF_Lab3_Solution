using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Lab3_Solution.Migrations
{
    /// <inheritdoc />
    public partial class seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 1,
                columns: new[] { "BirthOfDate", "HiringDate", "QualificationDate" },
                values: new object[] { new DateTime(2000, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 1,
                columns: new[] { "BirthOfDate", "HiringDate", "QualificationDate" },
                values: new object[] { new DateTime(2025, 5, 22, 0, 53, 47, 604, DateTimeKind.Local).AddTicks(2087), new DateTime(2025, 5, 22, 0, 53, 47, 604, DateTimeKind.Local).AddTicks(2143), new DateTime(2025, 5, 22, 0, 53, 47, 604, DateTimeKind.Local).AddTicks(2149) });
        }
    }
}
