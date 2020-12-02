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
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "FqAve",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "MaAve",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "MqAve",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PaAve",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PfaAve",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PfqAve",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PqAve",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Fa1",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Fa2",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Fa3",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Fq1",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Fq2",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Fq3",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Pq1",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Pq2",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Pq3",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Pa1",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Pa2",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Pa3",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Ma1",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Ma2",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Ma3",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Mq1",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Mq2",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Mq3",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Pfq1",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Pfq2",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Pfq3",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Pfa1",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Pfa2",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Pfa3",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Midterm",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Prelim",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Prefinals",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Finals",
                table: "Admin",
                nullable: true,
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

            migrationBuilder.AddColumn<float>(
                name: "Fa1",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Fa2",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Fa3",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Fq1",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Fq2",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Fq3",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Pq1",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Pq2",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Pq3",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Pa1",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Pa2",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Pa3",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Ma1",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Ma2",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Ma3",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Mq1",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Mq2",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Mq3",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Pfq1",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Pfq2",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Pfq3",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Pfa1",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Pfa2",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Pfa3",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Midterm",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Prelim",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Prefinals",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Finals",
                table: "Admin",
                nullable: true,
                defaultValue: 0f);
        }
    }
}
