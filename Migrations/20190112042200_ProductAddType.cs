using Microsoft.EntityFrameworkCore.Migrations;

namespace Everis.Migrations
{
    public partial class ProductAddType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddType",
                table: "Products",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddType",
                table: "Products");
        }
    }
}
