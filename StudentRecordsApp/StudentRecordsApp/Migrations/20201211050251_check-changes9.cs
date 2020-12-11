using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentRecordsApp.Migrations
{
    public partial class checkchanges9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "341743f0", "341743f0", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserID", "UserName" },
                values: new object[] { "02174cf0", 0, null, "fea72734-9174-4db6-9ad2-fcc0c94692cc", "admin@gmail.com", true, "Raquel", "Sorila", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEEXvj4HDNFuXn4B2w0suAsDOGEoaykEtqSVJa7xE3m6Kf2reoj3Q7FFc0JHW6A/rzQ==", null, false, "2f37f786-0dbb-40e1-85f3-fa60613a6a2a", false, "0", "admin" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "Address", "Email", "FirstName", "LastName", "MiddleName", "StudentId" },
                values: new object[,]
                {
                    { 1, "Cavite", "carson_alexander@email.com", "Carson", "Alexander", null, "100001" },
                    { 2, "Cavite", "meredith_alonso@email.com", "Meredith", "Alonso", null, "100002" },
                    { 3, "Cavite", "arturo_anand@email.com", "Arturo", "Anand", null, "100003" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "341743f0", "02174cf0" });

            migrationBuilder.InsertData(
                table: "Grade",
                columns: new[] { "Id", "Final_Assign1", "Final_Assign2", "Final_Assign3", "Final_Quiz1", "Final_Quiz2", "Final_Quiz3", "Midterm_Assign1", "Midterm_Assign2", "Midterm_Assign3", "Midterm_Quiz1", "Midterm_Quiz2", "Midterm_Quiz3", "Prefinal_Assign1", "Prefinal_Assign2", "Prefinal_Assign3", "Prefinal_Quiz1", "Prefinal_Quiz2", "Prefinal_Quiz3", "Prelim_Assign1", "Prelim_Assign2", "Prelim_Assign3", "Prelim_Quiz1", "Prelim_Quiz2", "Prelim_Quiz3", "StudentID" },
                values: new object[,]
                {
                    { 1, 6, 8, 8, 7, 7, 7, 6, 5, 9, 8, 7, 9, 6, 7, 7, 5, 7, 9, 6, 7, 6, 8, 7, 9, 1 },
                    { 2, 6, 8, 8, 8, 7, 9, 6, 8, 8, 8, 5, 9, 6, 7, 7, 5, 7, 9, 6, 7, 5, 7, 7, 9, 2 },
                    { 3, 6, 9, 8, 5, 7, 7, 6, 8, 8, 8, 5, 9, 6, 5, 7, 5, 7, 9, 6, 7, 5, 7, 7, 9, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "341743f0", "02174cf0" });

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

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "341743f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
