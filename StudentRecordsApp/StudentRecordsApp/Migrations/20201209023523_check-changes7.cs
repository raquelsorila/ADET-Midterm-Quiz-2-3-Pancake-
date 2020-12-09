using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentRecordsApp.Migrations
{
    public partial class checkchanges7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    Prelim_Quiz1 = table.Column<int>(type: "int", nullable: false),
                    Prelim_Quiz2 = table.Column<int>(type: "int", nullable: false),
                    Prelim_Quiz3 = table.Column<int>(type: "int", nullable: false),
                    Prelim_Assign1 = table.Column<int>(type: "int", nullable: false),
                    Prelim_Assign2 = table.Column<int>(type: "int", nullable: false),
                    Prelim_Assign3 = table.Column<int>(type: "int", nullable: false),
                    Midterm_Quiz1 = table.Column<int>(type: "int", nullable: false),
                    Midterm_Quiz2 = table.Column<int>(type: "int", nullable: false),
                    Midterm_Quiz3 = table.Column<int>(type: "int", nullable: false),
                    Midterm_Assign1 = table.Column<int>(type: "int", nullable: false),
                    Midterm_Assign2 = table.Column<int>(type: "int", nullable: false),
                    Midterm_Assign3 = table.Column<int>(type: "int", nullable: false),
                    Prefinal_Quiz1 = table.Column<int>(type: "int", nullable: false),
                    Prefinal_Quiz2 = table.Column<int>(type: "int", nullable: false),
                    Prefinal_Quiz3 = table.Column<int>(type: "int", nullable: false),
                    Prefinal_Assign1 = table.Column<int>(type: "int", nullable: false),
                    Prefinal_Assign2 = table.Column<int>(type: "int", nullable: false),
                    Prefinal_Assign3 = table.Column<int>(type: "int", nullable: false),
                    Final_Quiz1 = table.Column<int>(type: "int", nullable: false),
                    Final_Quiz2 = table.Column<int>(type: "int", nullable: false),
                    Final_Quiz3 = table.Column<int>(type: "int", nullable: false),
                    Final_Assign1 = table.Column<int>(type: "int", nullable: false),
                    Final_Assign2 = table.Column<int>(type: "int", nullable: false),
                    Final_Assign3 = table.Column<int>(type: "int", nullable: false)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Grade");
        }
    }
}
