using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentRecordsApp.Migrations
{
    public partial class checkchanges4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Grade");

            migrationBuilder.DropTable(
                name: "Student");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Final_Assign1 = table.Column<int>(type: "int", nullable: false),
                    Final_Assign2 = table.Column<int>(type: "int", nullable: false),
                    Final_Assign3 = table.Column<int>(type: "int", nullable: false),
                    Final_Quiz1 = table.Column<int>(type: "int", nullable: false),
                    Final_Quiz2 = table.Column<int>(type: "int", nullable: false),
                    Final_Quiz3 = table.Column<int>(type: "int", nullable: false),
                    Midterm_Assign1 = table.Column<int>(type: "int", nullable: false),
                    Midterm_Assign2 = table.Column<int>(type: "int", nullable: false),
                    Midterm_Assign3 = table.Column<int>(type: "int", nullable: false),
                    Midterm_Quiz1 = table.Column<int>(type: "int", nullable: false),
                    Midterm_Quiz2 = table.Column<int>(type: "int", nullable: false),
                    Midterm_Quiz3 = table.Column<int>(type: "int", nullable: false),
                    Prefinal_Assign1 = table.Column<int>(type: "int", nullable: false),
                    Prefinal_Assign2 = table.Column<int>(type: "int", nullable: false),
                    Prefinal_Assign3 = table.Column<int>(type: "int", nullable: false),
                    Prefinal_Quiz1 = table.Column<int>(type: "int", nullable: false),
                    Prefinal_Quiz2 = table.Column<int>(type: "int", nullable: false),
                    Prefinal_Quiz3 = table.Column<int>(type: "int", nullable: false),
                    Prelim_Assign1 = table.Column<int>(type: "int", nullable: false),
                    Prelim_Assign2 = table.Column<int>(type: "int", nullable: false),
                    Prelim_Assign3 = table.Column<int>(type: "int", nullable: false),
                    Prelim_Quiz1 = table.Column<int>(type: "int", nullable: false),
                    Prelim_Quiz2 = table.Column<int>(type: "int", nullable: false),
                    Prelim_Quiz3 = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grade_Student_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Grade_StudentID",
                table: "Grade",
                column: "StudentID");
        }
    }
}
