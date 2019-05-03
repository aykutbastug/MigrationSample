using Microsoft.EntityFrameworkCore.Migrations;

namespace MigrationSample.Migrations
{
    public partial class mig_murat_base_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdentyNumber",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdentyNumber",
                table: "Employees");
        }
    }
}
