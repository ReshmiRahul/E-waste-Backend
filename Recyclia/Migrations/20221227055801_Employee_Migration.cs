using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recyclia.Migrations
{
    public partial class Employee_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "tbl_Customer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_Customer",
                table: "tbl_Customer",
                column: "customer_id");

            migrationBuilder.CreateTable(
                name: "tbl_Employee",
                columns: table => new
                {
                    employee_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employee_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    employee_mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    employee_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    agency_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    employee_username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    employee_password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Employee", x => x.employee_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_Customer",
                table: "tbl_Customer");

            migrationBuilder.RenameTable(
                name: "tbl_Customer",
                newName: "Customer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "customer_id");
        }
    }
}
