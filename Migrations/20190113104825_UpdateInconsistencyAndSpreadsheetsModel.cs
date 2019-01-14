using Microsoft.EntityFrameworkCore.Migrations;

namespace Everis.Migrations
{
    public partial class UpdateInconsistencyAndSpreadsheetsModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Attribute",
                table: "Inconsistencies",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Attribute",
                table: "Inconsistencies",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(int),
                oldMaxLength: 255);
        }
    }
}
