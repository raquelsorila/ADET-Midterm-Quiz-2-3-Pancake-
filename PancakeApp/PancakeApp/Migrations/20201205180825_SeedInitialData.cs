using Microsoft.EntityFrameworkCore.Migrations;

namespace PancakeApp.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
