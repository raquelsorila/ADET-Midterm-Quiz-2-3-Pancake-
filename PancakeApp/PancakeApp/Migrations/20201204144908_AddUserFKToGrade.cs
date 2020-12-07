using Microsoft.EntityFrameworkCore.Migrations;

namespace PancakeApp.Migrations
{
    public partial class AddUserFKToGrade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Grade_GradeId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_GradeId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "GradeId",
                table: "User");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Grade",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Grade_UserId",
                table: "Grade",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Grade_User_UserId",
                table: "Grade",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grade_User_UserId",
                table: "Grade");

            migrationBuilder.DropIndex(
                name: "IX_Grade_UserId",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Grade");

            migrationBuilder.AddColumn<int>(
                name: "GradeId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_GradeId",
                table: "User",
                column: "GradeId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Grade_GradeId",
                table: "User",
                column: "GradeId",
                principalTable: "Grade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
