using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Warehouse.Migrations
{
    public partial class Project3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "REQUEST_FUNDING_PROJECTS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IS_SMALL_PROJECT = table.Column<bool>(type: "TINYINT(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_REQUEST_FUNDING_PROJECTS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_REQUEST_FUNDING_PROJECTS_PROJECTS_ID",
                        column: x => x.ID,
                        principalTable: "PROJECTS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RESEARCH_FUNDING_PROJECTS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IS_FWF_SPONSORED = table.Column<bool>(type: "TINYINT(1)", nullable: false),
                    IS_FFG_SPONSORED = table.Column<bool>(type: "TINYINT(1)", nullable: false),
                    IS_EU_SPONSORED = table.Column<bool>(type: "TINYINT(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RESEARCH_FUNDING_PROJECTS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RESEARCH_FUNDING_PROJECTS_PROJECTS_ID",
                        column: x => x.ID,
                        principalTable: "PROJECTS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "REQUEST_FUNDING_PROJECTS");

            migrationBuilder.DropTable(
                name: "RESEARCH_FUNDING_PROJECTS");
        }
    }
}
