using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recyclia.Migrations
{
    public partial class ComplaintBox : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_Complaints",
                columns: table => new
                {
                    complaint_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    customer_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customer_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customer_mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    complaint_topic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    complaint_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    complaint_status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Complaints", x => x.complaint_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_Complaints");
        }
    }
}
