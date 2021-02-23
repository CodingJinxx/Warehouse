using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Warehouse.Migrations
{
    public partial class Project4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_REQUEST_FUNDING_PROJECTS_PROJECTS_ID",
                table: "REQUEST_FUNDING_PROJECTS");

            migrationBuilder.DropForeignKey(
                name: "FK_RESEARCH_FUNDING_PROJECTS_PROJECTS_ID",
                table: "RESEARCH_FUNDING_PROJECTS");

            migrationBuilder.DropTable(
                name: "Dishes");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "RESEARCH_FUNDING_PROJECTS",
                newName: "PROJECT_ID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "REQUEST_FUNDING_PROJECTS",
                newName: "PROJECT_ID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "PROJECTS",
                newName: "PROJECT_ID");

            migrationBuilder.AlterColumn<string>(
                name: "DESCRIPTION",
                table: "PROJECTS",
                type: "VARCHAR(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(4000)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "SUBPROJECTS",
                columns: table => new
                {
                    SUBPROJECT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DESCRIPTION = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    APPLIED_RESEARCH = table.Column<bool>(type: "TINYINT(1)", nullable: false),
                    THEORETICAL_RESEARCH = table.Column<bool>(type: "TINYINT(1)", nullable: false),
                    FOCUS_RESEARCH = table.Column<bool>(type: "TINYINT(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SUBPROJECTS", x => x.SUBPROJECT_ID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_REQUEST_FUNDING_PROJECTS_PROJECTS_PROJECT_ID",
                table: "REQUEST_FUNDING_PROJECTS",
                column: "PROJECT_ID",
                principalTable: "PROJECTS",
                principalColumn: "PROJECT_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RESEARCH_FUNDING_PROJECTS_PROJECTS_PROJECT_ID",
                table: "RESEARCH_FUNDING_PROJECTS",
                column: "PROJECT_ID",
                principalTable: "PROJECTS",
                principalColumn: "PROJECT_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_REQUEST_FUNDING_PROJECTS_PROJECTS_PROJECT_ID",
                table: "REQUEST_FUNDING_PROJECTS");

            migrationBuilder.DropForeignKey(
                name: "FK_RESEARCH_FUNDING_PROJECTS_PROJECTS_PROJECT_ID",
                table: "RESEARCH_FUNDING_PROJECTS");

            migrationBuilder.DropTable(
                name: "SUBPROJECTS");

            migrationBuilder.RenameColumn(
                name: "PROJECT_ID",
                table: "RESEARCH_FUNDING_PROJECTS",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "PROJECT_ID",
                table: "REQUEST_FUNDING_PROJECTS",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "PROJECT_ID",
                table: "PROJECTS",
                newName: "ID");

            migrationBuilder.AlterColumn<string>(
                name: "DESCRIPTION",
                table: "PROJECTS",
                type: "VARCHAR(4000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(255)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Dishes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Title = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dishes", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_REQUEST_FUNDING_PROJECTS_PROJECTS_ID",
                table: "REQUEST_FUNDING_PROJECTS",
                column: "ID",
                principalTable: "PROJECTS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RESEARCH_FUNDING_PROJECTS_PROJECTS_ID",
                table: "RESEARCH_FUNDING_PROJECTS",
                column: "ID",
                principalTable: "PROJECTS",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
