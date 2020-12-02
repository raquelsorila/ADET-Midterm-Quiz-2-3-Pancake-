using Microsoft.EntityFrameworkCore.Migrations;

namespace Portal.Migrations
{
    public partial class Admin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "FaAve",
                table: "Admin",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "FqAve",
                table: "Admin",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "MaAve",
                table: "Admin",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "MqAve",
                table: "Admin",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PaAve",
                table: "Admin",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PfaAve",
                table: "Admin",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PfqAve",
                table: "Admin",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PqAve",
                table: "Admin",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FaAve",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "FqAve",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "MaAve",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "MqAve",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "PaAve",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "PfaAve",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "PfqAve",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "PqAve",
                table: "Admin");
        }
    }
}
