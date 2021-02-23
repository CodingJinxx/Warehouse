using Microsoft.EntityFrameworkCore.Migrations;

namespace Warehouse.Migrations
{
    public partial class Fixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Facilities",
                table: "Facilities");

            migrationBuilder.RenameTable(
                name: "Facilities",
                newName: "FACILITY");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FACILITY",
                table: "FACILITY",
                column: "FACILITY_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FACILITY",
                table: "FACILITY");

            migrationBuilder.RenameTable(
                name: "FACILITY",
                newName: "Facilities");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Facilities",
                table: "Facilities",
                column: "FACILITY_ID");
        }
    }
}
