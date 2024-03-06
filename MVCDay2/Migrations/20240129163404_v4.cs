using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVCDay2.Migrations
{
    /// <inheritdoc />
    public partial class v4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Trainees",
                columns: new[] { "Id", "DeptId", "TrAddress", "TrGrade", "TrImage", "TrName" },
                values: new object[,]
                {
                    { 3, 3, "cairo", 20, "mal.jpeg", "hithem" },
                    { 4, 2, "alex", 170, "fem.jpeg", "hoda" }
                });

            migrationBuilder.InsertData(
                table: "CRSresults",
                columns: new[] { "Id", "CourseId", "CrsDegree", "TRId" },
                values: new object[,]
                {
                    { 3, 2, 40, 3 },
                    { 4, 2, 10, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CRSresults",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CRSresults",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trainees",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
