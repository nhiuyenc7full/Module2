using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCTourism.Migrations
{
    public partial class editphone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Tel",
                table: "Tourists",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Tel",
                table: "Tourists",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
