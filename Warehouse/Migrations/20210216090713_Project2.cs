using Microsoft.EntityFrameworkCore.Migrations;

namespace Warehouse.Migrations
{
    public partial class Project2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TITLE",
                table: "PROJECTS",
                type: "VARCHAR(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DESCRIPTION",
                table: "PROJECTS",
                type: "VARCHAR(4000)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LEGAL_FOUNDATION",
                table: "PROJECTS",
                type: "VARCHAR(4)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DESCRIPTION",
                table: "PROJECTS");

            migrationBuilder.DropColumn(
                name: "LEGAL_FOUNDATION",
                table: "PROJECTS");

            migrationBuilder.AlterColumn<string>(
                name: "TITLE",
                table: "PROJECTS",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)");
        }
    }
}
