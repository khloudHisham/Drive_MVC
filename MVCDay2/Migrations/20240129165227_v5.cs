using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCDay2.Migrations
{
    /// <inheritdoc />
    public partial class v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CRSresults",
                columns: new[] { "Id", "CourseId", "CrsDegree", "TRId" },
                values: new object[] { 5, 3, 30, 4 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CourseDegree", "CourseMinDegree" },
                values: new object[] { 200, 90 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CourseDegree", "CourseMinDegree" },
                values: new object[] { 150, 50 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CRSresults",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CourseDegree", "CourseMinDegree" },
                values: new object[] { 40, 20 });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CourseDegree", "CourseMinDegree" },
                values: new object[] { 60, 10 });
        }
    }
}
