using Microsoft.EntityFrameworkCore.Migrations;

namespace MigrationSample.Migrations
{
    public partial class mig_murat_base_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "Companies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Desc",
                table: "Companies");
        }
    }
}
