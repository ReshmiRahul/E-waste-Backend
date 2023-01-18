using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recyclia.Migrations
{
    public partial class Ewaste_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "agency_address",
                table: "tbl_Agency",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "agency_email",
                table: "tbl_Agency",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "agency_mobile",
                table: "tbl_Agency",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "agency_address",
                table: "tbl_Agency");

            migrationBuilder.DropColumn(
                name: "agency_email",
                table: "tbl_Agency");

            migrationBuilder.DropColumn(
                name: "agency_mobile",
                table: "tbl_Agency");
        }
    }
}
