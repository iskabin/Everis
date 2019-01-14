using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Everis.Migrations
{
    public partial class AddSpreadsheetModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SpreadsheetIdID",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SpreadsheetEntries",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    ReferenceDate = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpreadsheetEntries", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_SpreadsheetIdID",
                table: "Products",
                column: "SpreadsheetIdID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SpreadsheetEntries_SpreadsheetIdID",
                table: "Products",
                column: "SpreadsheetIdID",
                principalTable: "SpreadsheetEntries",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_SpreadsheetEntries_SpreadsheetIdID",
                table: "Products");

            migrationBuilder.DropTable(
                name: "SpreadsheetEntries");

            migrationBuilder.DropIndex(
                name: "IX_Products_SpreadsheetIdID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SpreadsheetIdID",
                table: "Products");
        }
    }
}
