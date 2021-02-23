using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Warehouse.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PROJECTS",
                columns: table => new
                {
                    PROJECT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TITLE = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    LEGAL_FOUNDATION = table.Column<string>(type: "VARCHAR(4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PROJECTS", x => x.PROJECT_ID);
                });

            migrationBuilder.CreateTable(
                name: "REQUEST_FUNDING_PROJECTS",
                columns: table => new
                {
                    PROJECT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IS_SMALL_PROJECT = table.Column<bool>(type: "TINYINT(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_REQUEST_FUNDING_PROJECTS", x => x.PROJECT_ID);
                    table.ForeignKey(
                        name: "FK_REQUEST_FUNDING_PROJECTS_PROJECTS_PROJECT_ID",
                        column: x => x.PROJECT_ID,
                        principalTable: "PROJECTS",
                        principalColumn: "PROJECT_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RESEARCH_FUNDING_PROJECTS",
                columns: table => new
                {
                    PROJECT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IS_FWF_SPONSORED = table.Column<bool>(type: "TINYINT(1)", nullable: false),
                    IS_FFG_SPONSORED = table.Column<bool>(type: "TINYINT(1)", nullable: false),
                    IS_EU_SPONSORED = table.Column<bool>(type: "TINYINT(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RESEARCH_FUNDING_PROJECTS", x => x.PROJECT_ID);
                    table.ForeignKey(
                        name: "FK_RESEARCH_FUNDING_PROJECTS_PROJECTS_PROJECT_ID",
                        column: x => x.PROJECT_ID,
                        principalTable: "PROJECTS",
                        principalColumn: "PROJECT_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SUBPROJECTS",
                columns: table => new
                {
                    SUBPROJECT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DESCRIPTION = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    APPLIED_RESEARCH = table.Column<bool>(type: "TINYINT(1)", nullable: false),
                    THEORETICAL_RESEARCH = table.Column<bool>(type: "TINYINT(1)", nullable: false),
                    FOCUS_RESEARCH = table.Column<bool>(type: "TINYINT(1)", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SUBPROJECTS", x => x.SUBPROJECT_ID);
                    table.ForeignKey(
                        name: "FK_SUBPROJECTS_PROJECTS_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "PROJECTS",
                        principalColumn: "PROJECT_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SUBPROJECTS_ProjectId",
                table: "SUBPROJECTS",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "REQUEST_FUNDING_PROJECTS");

            migrationBuilder.DropTable(
                name: "RESEARCH_FUNDING_PROJECTS");

            migrationBuilder.DropTable(
                name: "SUBPROJECTS");

            migrationBuilder.DropTable(
                name: "PROJECTS");
        }
    }
}
