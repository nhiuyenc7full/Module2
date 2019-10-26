using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BoDeTracNghiemDemo.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NguoiDungs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ten = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    MatKhau = table.Column<string>(nullable: false),
                    DiaChi = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDungs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TheLoais",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ten = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheLoais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "This",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ten = table.Column<string>(nullable: false),
                    CauHoiThiId = table.Column<int>(nullable: false),
                    NguoiDungId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_This", x => x.Id);
                    table.ForeignKey(
                        name: "FK_This_NguoiDungs_NguoiDungId",
                        column: x => x.NguoiDungId,
                        principalTable: "NguoiDungs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CauHoi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ten = table.Column<string>(nullable: true),
                    CauTraLoi1 = table.Column<string>(nullable: true),
                    CauTraLoi2 = table.Column<string>(nullable: true),
                    CauTraLoi3 = table.Column<string>(nullable: true),
                    CauTraLoi4 = table.Column<string>(nullable: true),
                    TheLoaiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CauHoi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CauHoi_TheLoais_TheLoaiId",
                        column: x => x.TheLoaiId,
                        principalTable: "TheLoais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Diems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ten = table.Column<string>(nullable: true),
                    ThiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diems_This_ThiId",
                        column: x => x.ThiId,
                        principalTable: "This",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CauHoiThis",
                columns: table => new
                {
                    CauHoiId = table.Column<int>(nullable: false),
                    ThiId = table.Column<int>(nullable: false),
                    Ten = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CauHoiThis", x => new { x.CauHoiId, x.ThiId });
                    table.ForeignKey(
                        name: "FK_CauHoiThis_CauHoi_CauHoiId",
                        column: x => x.CauHoiId,
                        principalTable: "CauHoi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CauHoiThis_This_ThiId",
                        column: x => x.ThiId,
                        principalTable: "This",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DapAns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ten = table.Column<string>(nullable: true),
                    CauHoiId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DapAns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DapAns_CauHoi_CauHoiId",
                        column: x => x.CauHoiId,
                        principalTable: "CauHoi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CauHoi_TheLoaiId",
                table: "CauHoi",
                column: "TheLoaiId");

            migrationBuilder.CreateIndex(
                name: "IX_CauHoiThis_ThiId",
                table: "CauHoiThis",
                column: "ThiId");

            migrationBuilder.CreateIndex(
                name: "IX_DapAns_CauHoiId",
                table: "DapAns",
                column: "CauHoiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Diems_ThiId",
                table: "Diems",
                column: "ThiId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_This_NguoiDungId",
                table: "This",
                column: "NguoiDungId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CauHoiThis");

            migrationBuilder.DropTable(
                name: "DapAns");

            migrationBuilder.DropTable(
                name: "Diems");

            migrationBuilder.DropTable(
                name: "CauHoi");

            migrationBuilder.DropTable(
                name: "This");

            migrationBuilder.DropTable(
                name: "TheLoais");

            migrationBuilder.DropTable(
                name: "NguoiDungs");
        }
    }
}
