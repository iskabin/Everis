using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Everis.Migrations
{
    public partial class AddProductLastEdition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EditType",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastEdit",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EditType",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "LastEdit",
                table: "Products");
        }
    }
}
