using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recyclia.Migrations
{
    public partial class Product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "product_interest",
                table: "tbl_Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "product_rply",
                table: "tbl_Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "product_interest",
                table: "tbl_Product");

            migrationBuilder.DropColumn(
                name: "product_rply",
                table: "tbl_Product");
        }
    }
}
