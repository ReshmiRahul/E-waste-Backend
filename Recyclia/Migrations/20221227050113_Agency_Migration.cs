using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recyclia.Migrations
{
    public partial class Agency_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Agency",
                columns: table => new
                {
                    agency_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    agency_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    agency_district = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    agency_location = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    agency_username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    agency_password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Agency", x => x.agency_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Agency");
        }
    }
}
