using Microsoft.EntityFrameworkCore.Migrations;

namespace PancakeApp.Migrations
{
    public partial class RemoveFieldsOnGrade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AveFinalAssign",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "AveFinalQuiz",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "AveMidtermAssign",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "AveMidtermQuiz",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "AvePrefinalAssign",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "AvePrefinalQuiz",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "AvePrelimAssign",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "AvePrelimQuiz",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "FinalGrade",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "MidtermGrade",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "PrefinalGrade",
                table: "Grade");

            migrationBuilder.DropColumn(
                name: "PrelimGrade",
                table: "Grade");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "AveFinalAssign",
                table: "Grade",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "AveFinalQuiz",
                table: "Grade",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "AveMidtermAssign",
                table: "Grade",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "AveMidtermQuiz",
                table: "Grade",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "AvePrefinalAssign",
                table: "Grade",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "AvePrefinalQuiz",
                table: "Grade",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "AvePrelimAssign",
                table: "Grade",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "AvePrelimQuiz",
                table: "Grade",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "FinalGrade",
                table: "Grade",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "MidtermGrade",
                table: "Grade",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PrefinalGrade",
                table: "Grade",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PrelimGrade",
                table: "Grade",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
