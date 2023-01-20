using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recyclia.Migrations
{
    public partial class foodwastess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "customer_district",
                table: "tbl_foodwaste",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "customer_id",
                table: "tbl_foodwaste",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "customer_name",
                table: "tbl_foodwaste",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "customer_phone",
                table: "tbl_foodwaste",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "customer_district",
                table: "tbl_foodwaste");

            migrationBuilder.DropColumn(
                name: "customer_id",
                table: "tbl_foodwaste");

            migrationBuilder.DropColumn(
                name: "customer_name",
                table: "tbl_foodwaste");

            migrationBuilder.DropColumn(
                name: "customer_phone",
                table: "tbl_foodwaste");
        }
    }
}
