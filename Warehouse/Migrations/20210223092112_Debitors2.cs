using Microsoft.EntityFrameworkCore.Migrations;

namespace Warehouse.Migrations
{
    public partial class Debitors2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Debitors",
                table: "Debitors");

            migrationBuilder.RenameTable(
                name: "Debitors",
                newName: "DEBITOR");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DEBITOR",
                table: "DEBITOR",
                column: "DEBITOR_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DEBITOR",
                table: "DEBITOR");

            migrationBuilder.RenameTable(
                name: "DEBITOR",
                newName: "Debitors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Debitors",
                table: "Debitors",
                column: "DEBITOR_ID");
        }
    }
}
