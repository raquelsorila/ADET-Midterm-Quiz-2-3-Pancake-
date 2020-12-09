using Microsoft.EntityFrameworkCore.Migrations;

namespace PancakeApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(nullable: false),
                    Prelim_Quiz1 = table.Column<int>(nullable: false),
                    Prelim_Quiz2 = table.Column<int>(nullable: false),
                    Prelim_Quiz3 = table.Column<int>(nullable: false),
                    Prelim_Assign1 = table.Column<int>(nullable: false),
                    Prelim_Assign2 = table.Column<int>(nullable: false),
                    Prelim_Assign3 = table.Column<int>(nullable: false),
                    Midterm_Quiz1 = table.Column<int>(nullable: false),
                    Midterm_Quiz2 = table.Column<int>(nullable: false),
                    Midterm_Quiz3 = table.Column<int>(nullable: false),
                    Midterm_Assign1 = table.Column<int>(nullable: false),
                    Midterm_Assign2 = table.Column<int>(nullable: false),
                    Midterm_Assign3 = table.Column<int>(nullable: false),
                    Prefinal_Quiz1 = table.Column<int>(nullable: false),
                    Prefinal_Quiz2 = table.Column<int>(nullable: false),
                    Prefinal_Quiz3 = table.Column<int>(nullable: false),
                    Prefinal_Assign1 = table.Column<int>(nullable: false),
                    Prefinal_Assign2 = table.Column<int>(nullable: false),
                    Prefinal_Assign3 = table.Column<int>(nullable: false),
                    Final_Quiz1 = table.Column<int>(nullable: false),
                    Final_Quiz2 = table.Column<int>(nullable: false),
                    Final_Quiz3 = table.Column<int>(nullable: false),
                    Final_Assign1 = table.Column<int>(nullable: false),
                    Final_Assign2 = table.Column<int>(nullable: false),
                    Final_Assign3 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grade_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "Email", "FirstName", "LastName", "MiddleName", "Password", "Role", "UserId" },
                values: new object[] { 1, "Cavite", "carson_alexander@email.com", "Carson", "Alexander", null, "1234", "2", "100001" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "Email", "FirstName", "LastName", "MiddleName", "Password", "Role", "UserId" },
                values: new object[] { 2, "Cavite", "meredith_alonso@email.com", "Meredith", "Alonso", null, "1234", "2", "100002" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Address", "Email", "FirstName", "LastName", "MiddleName", "Password", "Role", "UserId" },
                values: new object[] { 3, "Cavite", "arturo_anand@email.com", "Arturo", "Anand", null, "1234", "2", "100003" });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "Id", "Final_Assign1", "Final_Assign2", "Final_Assign3", "Final_Quiz1", "Final_Quiz2", "Final_Quiz3", "Midterm_Assign1", "Midterm_Assign2", "Midterm_Assign3", "Midterm_Quiz1", "Midterm_Quiz2", "Midterm_Quiz3", "Prefinal_Assign1", "Prefinal_Assign2", "Prefinal_Assign3", "Prefinal_Quiz1", "Prefinal_Quiz2", "Prefinal_Quiz3", "Prelim_Assign1", "Prelim_Assign2", "Prelim_Assign3", "Prelim_Quiz1", "Prelim_Quiz2", "Prelim_Quiz3", "UserID" },
                values: new object[] { 1, 6, 8, 8, 7, 7, 7, 6, 5, 9, 8, 7, 9, 6, 7, 7, 5, 7, 9, 6, 7, 6, 8, 7, 9, 1 });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "Id", "Final_Assign1", "Final_Assign2", "Final_Assign3", "Final_Quiz1", "Final_Quiz2", "Final_Quiz3", "Midterm_Assign1", "Midterm_Assign2", "Midterm_Assign3", "Midterm_Quiz1", "Midterm_Quiz2", "Midterm_Quiz3", "Prefinal_Assign1", "Prefinal_Assign2", "Prefinal_Assign3", "Prefinal_Quiz1", "Prefinal_Quiz2", "Prefinal_Quiz3", "Prelim_Assign1", "Prelim_Assign2", "Prelim_Assign3", "Prelim_Quiz1", "Prelim_Quiz2", "Prelim_Quiz3", "UserID" },
                values: new object[] { 2, 6, 8, 8, 8, 7, 9, 6, 8, 8, 8, 5, 9, 6, 7, 7, 5, 7, 9, 6, 7, 5, 7, 7, 9, 2 });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "Id", "Final_Assign1", "Final_Assign2", "Final_Assign3", "Final_Quiz1", "Final_Quiz2", "Final_Quiz3", "Midterm_Assign1", "Midterm_Assign2", "Midterm_Assign3", "Midterm_Quiz1", "Midterm_Quiz2", "Midterm_Quiz3", "Prefinal_Assign1", "Prefinal_Assign2", "Prefinal_Assign3", "Prefinal_Quiz1", "Prefinal_Quiz2", "Prefinal_Quiz3", "Prelim_Assign1", "Prelim_Assign2", "Prelim_Assign3", "Prelim_Quiz1", "Prelim_Quiz2", "Prelim_Quiz3", "UserID" },
                values: new object[] { 3, 6, 9, 8, 5, 7, 7, 6, 8, 8, 8, 5, 9, 6, 5, 7, 5, 7, 9, 6, 7, 5, 7, 7, 9, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Grade_UserID",
                table: "Grade",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Student_GradeId",
                table: "Student",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_UserId",
                table: "Student",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Grade");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
