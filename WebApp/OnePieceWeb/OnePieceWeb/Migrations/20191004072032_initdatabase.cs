using Microsoft.EntityFrameworkCore.Migrations;

namespace OnePieceWeb.Data.Migrations
{
    public partial class initdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DevilFruits",
                columns: table => new
                {
                    DevilFruitId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevilFruits", x => x.DevilFruitId);
                });

            migrationBuilder.CreateTable(
                name: "Pirates",
                columns: table => new
                {
                    PirateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pirates", x => x.PirateId);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    PositionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.PositionId);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<long>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    PirateId = table.Column<int>(nullable: false),
                    DevilFruitId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterId);
                    table.ForeignKey(
                        name: "FK_Characters_DevilFruits_DevilFruitId",
                        column: x => x.DevilFruitId,
                        principalTable: "DevilFruits",
                        principalColumn: "DevilFruitId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Pirates_PirateId",
                        column: x => x.PirateId,
                        principalTable: "Pirates",
                        principalColumn: "PirateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterPositions",
                columns: table => new
                {
                    CharacterId = table.Column<int>(nullable: false),
                    PositionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterPositions", x => new { x.CharacterId, x.PositionId });
                    table.ForeignKey(
                        name: "FK_CharacterPositions_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterPositions_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "PositionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterPositions_PositionId",
                table: "CharacterPositions",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_DevilFruitId",
                table: "Characters",
                column: "DevilFruitId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Characters_PirateId",
                table: "Characters",
                column: "PirateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterPositions");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "DevilFruits");

            migrationBuilder.DropTable(
                name: "Pirates");
        }
    }
}
