using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVCDay2.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeptManager = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseDegree = table.Column<int>(type: "int", nullable: false),
                    CourseMinDegree = table.Column<int>(type: "int", nullable: false),
                    DeptId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Departments_DeptId",
                        column: x => x.DeptId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Trainees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrGrade = table.Column<int>(type: "int", nullable: false),
                    TrImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeptId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trainees_Departments_DeptId",
                        column: x => x.DeptId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Instractors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InsImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    DeptId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instractors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instractors_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Instractors_Departments_DeptId",
                        column: x => x.DeptId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CRSresults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrsDegree = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    TRId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CRSresults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CRSresults_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CRSresults_Trainees_TRId",
                        column: x => x.TRId,
                        principalTable: "Trainees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "DeptManager", "DeptName" },
                values: new object[,]
                {
                    { 1, "Amr", "NETdept" },
                    { 2, "Amira", "DBdept" },
                    { 3, "Ahmed", "JSdept" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseDegree", "CourseMinDegree", "CourseName", "DeptId" },
                values: new object[,]
                {
                    { 1, 40, 20, "DB", 2 },
                    { 2, 60, 10, "DotNot", 1 },
                    { 3, 80, 20, "Js", 3 }
                });

            migrationBuilder.InsertData(
                table: "Trainees",
                columns: new[] { "Id", "DeptId", "TrAddress", "TrGrade", "TrImage", "TrName" },
                values: new object[,]
                {
                    { 1, 1, "cairo", 50, "mal.jpeg", "hosam" },
                    { 2, 2, "alex", 90, "fem.jpeg", "hager" }
                });

            migrationBuilder.InsertData(
                table: "CRSresults",
                columns: new[] { "Id", "CourseId", "CrsDegree", "TRId" },
                values: new object[,]
                {
                    { 1, 1, 100, 1 },
                    { 2, 2, 200, 2 }
                });

            migrationBuilder.InsertData(
                table: "Instractors",
                columns: new[] { "Id", "CourseId", "DeptId", "InsAddress", "InsImage", "InsName", "InsSalary" },
                values: new object[,]
                {
                    { 1, 3, 1, "cairo", "mal.jpeg", "Omer", 5000m },
                    { 2, 2, 2, "cairo", "mal.jpeg", "hasan", 9000m },
                    { 3, 1, 3, "alex", "fem.jpeg", "reem", 6000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DeptId",
                table: "Courses",
                column: "DeptId");

            migrationBuilder.CreateIndex(
                name: "IX_CRSresults_CourseId",
                table: "CRSresults",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CRSresults_TRId",
                table: "CRSresults",
                column: "TRId");

            migrationBuilder.CreateIndex(
                name: "IX_Instractors_CourseId",
                table: "Instractors",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Instractors_DeptId",
                table: "Instractors",
                column: "DeptId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainees_DeptId",
                table: "Trainees",
                column: "DeptId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CRSresults");

            migrationBuilder.DropTable(
                name: "Instractors");

            migrationBuilder.DropTable(
                name: "Trainees");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
