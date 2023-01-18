using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recyclia.Migrations
{
    public partial class addidd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "customer_id",
                table: "tbl_Product");

            migrationBuilder.AddColumn<int>(
                name: "customer_id",
                table: "tbl_Ewaste",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "customer_id",
                table: "tbl_Ewaste");

            migrationBuilder.AddColumn<int>(
                name: "customer_id",
                table: "tbl_Product",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
