using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recyclia.Migrations
{
    public partial class customerdistrict : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "customer_address",
                table: "tbl_Ewaste",
                newName: "customer_district");

            migrationBuilder.RenameColumn(
                name: "customer_address",
                table: "tbl_Complaints",
                newName: "customer_district");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "customer_district",
                table: "tbl_Ewaste",
                newName: "customer_address");

            migrationBuilder.RenameColumn(
                name: "customer_district",
                table: "tbl_Complaints",
                newName: "customer_address");
        }
    }
}
