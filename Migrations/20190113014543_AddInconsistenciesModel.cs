using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Everis.Migrations
{
    public partial class AddInconsistenciesModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InconsistentRowsMin",
                table: "SpreadsheetEntries");

            migrationBuilder.CreateTable(
                name: "Inconsistencies",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SpreadsheetIDID = table.Column<int>(nullable: false),
                    Collumn = table.Column<int>(nullable: true),
                    Row = table.Column<int>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    CellValue = table.Column<string>(maxLength: 255, nullable: true),
                    Attribute = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inconsistencies", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Inconsistencies_SpreadsheetEntries_SpreadsheetIDID",
                        column: x => x.SpreadsheetIDID,
                        principalTable: "SpreadsheetEntries",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inconsistencies_SpreadsheetIDID",
                table: "Inconsistencies",
                column: "SpreadsheetIDID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inconsistencies");

            migrationBuilder.AddColumn<string>(
                name: "InconsistentRowsMin",
                table: "SpreadsheetEntries",
                nullable: false,
                defaultValue: "");
        }
    }
}
