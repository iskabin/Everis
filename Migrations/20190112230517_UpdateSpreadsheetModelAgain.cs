using Microsoft.EntityFrameworkCore.Migrations;

namespace Everis.Migrations
{
    public partial class UpdateSpreadsheetModelAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InconsistentRowsMin",
                table: "SpreadsheetEntries",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InconsistentRowsMin",
                table: "SpreadsheetEntries");
        }
    }
}
