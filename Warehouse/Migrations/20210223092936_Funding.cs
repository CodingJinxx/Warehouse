using Microsoft.EntityFrameworkCore.Migrations;

namespace Warehouse.Migrations
{
    public partial class Funding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FUNDING",
                columns: table => new
                {
                    PROJECT_ID = table.Column<int>(type: "int", nullable: false),
                    DEBTIOR_ID = table.Column<int>(type: "int", nullable: false),
                    FUNDING_AMOUNT = table.Column<decimal>(type: "DECIMAL(38,17)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FUNDING", x => new { x.DEBTIOR_ID, x.PROJECT_ID });
                    table.ForeignKey(
                        name: "FK_FUNDING_DEBITOR_DEBTIOR_ID",
                        column: x => x.DEBTIOR_ID,
                        principalTable: "DEBITOR",
                        principalColumn: "DEBITOR_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FUNDING_PROJECTS_PROJECT_ID",
                        column: x => x.PROJECT_ID,
                        principalTable: "PROJECTS",
                        principalColumn: "PROJECT_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FUNDING_PROJECT_ID",
                table: "FUNDING",
                column: "PROJECT_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FUNDING");
        }
    }
}
