using Microsoft.EntityFrameworkCore.Migrations;

namespace PancakeApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prelim_Quiz1 = table.Column<int>(nullable: false),
                    Prelim_Quiz2 = table.Column<int>(nullable: false),
                    Prelim_Quiz3 = table.Column<int>(nullable: false),
                    Prelim_Assign1 = table.Column<int>(nullable: false),
                    Prelim_Assign2 = table.Column<int>(nullable: false),
                    Prelim_Assign3 = table.Column<int>(nullable: false),
                    AvePrelimAssign = table.Column<float>(nullable: false),
                    AvePrelimQuiz = table.Column<float>(nullable: false),
                    PrelimGrade = table.Column<float>(nullable: false),
                    Midterm_Quiz1 = table.Column<int>(nullable: false),
                    Midterm_Quiz2 = table.Column<int>(nullable: false),
                    Midterm_Quiz3 = table.Column<int>(nullable: false),
                    Midterm_Assign1 = table.Column<int>(nullable: false),
                    Midterm_Assign2 = table.Column<int>(nullable: false),
                    Midterm_Assign3 = table.Column<int>(nullable: false),
                    AveMidtermAssign = table.Column<float>(nullable: false),
                    AveMidtermQuiz = table.Column<float>(nullable: false),
                    MidtermGrade = table.Column<float>(nullable: false),
                    Prefinal_Quiz1 = table.Column<int>(nullable: false),
                    Prefinal_Quiz2 = table.Column<int>(nullable: false),
                    Prefinal_Quiz3 = table.Column<int>(nullable: false),
                    Prefinal_Assign1 = table.Column<int>(nullable: false),
                    Prefinal_Assign2 = table.Column<int>(nullable: false),
                    Prefinal_Assign3 = table.Column<int>(nullable: false),
                    AvePrefinalAssign = table.Column<float>(nullable: false),
                    AvePrefinalQuiz = table.Column<float>(nullable: false),
                    PrefinalGrade = table.Column<float>(nullable: false),
                    Final_Quiz1 = table.Column<int>(nullable: false),
                    Final_Quiz2 = table.Column<int>(nullable: false),
                    Final_Quiz3 = table.Column<int>(nullable: false),
                    Final_Assign1 = table.Column<int>(nullable: false),
                    Final_Assign2 = table.Column<int>(nullable: false),
                    Final_Assign3 = table.Column<int>(nullable: false),
                    AveFinalAssign = table.Column<float>(nullable: false),
                    AveFinalQuiz = table.Column<float>(nullable: false),
                    FinalGrade = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    GradeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Grade_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    GradeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_Grade_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_GradeId",
                table: "Student",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_UserId",
                table: "Student",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_GradeId",
                table: "User",
                column: "GradeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Grade");
        }
    }
}
