using Microsoft.EntityFrameworkCore.Migrations;

namespace PancakeApp.Migrations
{
    public partial class AddUserSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grade_User_UserId",
                table: "Grade");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Grade",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Grade_UserId",
                table: "Grade",
                newName: "IX_Grade_UserID");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Grade",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Grade_User_UserID",
                table: "Grade",
                column: "UserID",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grade_User_UserID",
                table: "Grade");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Grade",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Grade_UserID",
                table: "Grade",
                newName: "IX_Grade_UserId");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Grade",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Grade_User_UserId",
                table: "Grade",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
