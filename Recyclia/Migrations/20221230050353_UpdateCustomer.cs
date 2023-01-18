using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recyclia.Migrations
{
    public partial class UpdateCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "tbl_Customer");

            migrationBuilder.AlterColumn<string>(
                name: "Customer_status",
                table: "tbl_Customer",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Customer_status",
                table: "tbl_Customer",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<float>(
                name: "Amount",
                table: "tbl_Customer",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }
    }
}
