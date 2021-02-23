using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Warehouse.Migrations
{
    public partial class Debitors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "INSTITUTE_ID",
                table: "SUBPROJECTS",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Debitors",
                columns: table => new
                {
                    DEBITOR_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NAME = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Debitors", x => x.DEBITOR_ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SUBPROJECTS_INSTITUTE_ID",
                table: "SUBPROJECTS",
                column: "INSTITUTE_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SUBPROJECTS_FACILITY_INSTITUTE_ID",
                table: "SUBPROJECTS",
                column: "INSTITUTE_ID",
                principalTable: "FACILITY",
                principalColumn: "FACILITY_ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SUBPROJECTS_FACILITY_INSTITUTE_ID",
                table: "SUBPROJECTS");

            migrationBuilder.DropTable(
                name: "Debitors");

            migrationBuilder.DropIndex(
                name: "IX_SUBPROJECTS_INSTITUTE_ID",
                table: "SUBPROJECTS");

            migrationBuilder.DropColumn(
                name: "INSTITUTE_ID",
                table: "SUBPROJECTS");
        }
    }
}
