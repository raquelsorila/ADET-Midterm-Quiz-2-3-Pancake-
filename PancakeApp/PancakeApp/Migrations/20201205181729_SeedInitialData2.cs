using Microsoft.EntityFrameworkCore.Migrations;

namespace PancakeApp.Migrations
{
    public partial class SeedInitialData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Grade",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
