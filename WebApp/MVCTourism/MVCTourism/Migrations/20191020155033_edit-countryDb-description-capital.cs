using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCTourism.Migrations
{
    public partial class editcountryDbdescriptioncapital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Countries",
                newName: "Capital");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Capital",
                table: "Countries",
                newName: "Description");
        }
    }
}
