using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recyclia.Migrations
{
    public partial class Customer_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Customer",
                columns: table => new
                {
                    customer_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customer_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    customer_address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    customer_mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customer_district = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    customer_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customer_username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    customer_password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Customer", x => x.customer_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Customer");
        }
    }
}
