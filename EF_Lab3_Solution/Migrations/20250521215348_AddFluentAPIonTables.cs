using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Lab3_Solution.Migrations
{
    /// <inheritdoc />
    public partial class AddFluentAPIonTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "phone",
                table: "Teachers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NationalID",
                table: "Teachers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Teachers",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Teachers_NationalID_phone_Code",
                table: "Teachers",
                columns: new[] { "NationalID", "phone", "Code" });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 1,
                columns: new[] { "BirthOfDate", "HiringDate", "QualificationDate" },
                values: new object[] { new DateTime(2025, 5, 22, 0, 53, 47, 604, DateTimeKind.Local).AddTicks(2087), new DateTime(2025, 5, 22, 0, 53, 47, 604, DateTimeKind.Local).AddTicks(2143), new DateTime(2025, 5, 22, 0, 53, 47, 604, DateTimeKind.Local).AddTicks(2149) });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_DepartmentID",
                table: "Departments",
                column: "DepartmentID",
                unique: true)
                .Annotation("SqlServer:Clustered", false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Teachers_NationalID_phone_Code",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Departments_DepartmentID",
                table: "Departments");

            migrationBuilder.AlterColumn<string>(
                name: "phone",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "NationalID",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "TeacherID",
                keyValue: 1,
                columns: new[] { "BirthOfDate", "HiringDate", "QualificationDate" },
                values: new object[] { new DateTime(2025, 5, 21, 23, 58, 4, 910, DateTimeKind.Local).AddTicks(8102), new DateTime(2025, 5, 21, 23, 58, 4, 910, DateTimeKind.Local).AddTicks(8158), new DateTime(2025, 5, 21, 23, 58, 4, 910, DateTimeKind.Local).AddTicks(8163) });
        }
    }
}
