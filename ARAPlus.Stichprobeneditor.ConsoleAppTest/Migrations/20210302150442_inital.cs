using Microsoft.EntityFrameworkCore.Migrations;

namespace ARAPlus.Stichprobeneditor.ConsoleAppTest.Migrations
{
    public partial class inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artikel",
                columns: table => new
                {
                    ArtikelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bezeichnung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Absatzmenge = table.Column<double>(type: "float", nullable: false),
                    ArtikelNummer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artikel", x => x.ArtikelId);
                });

            migrationBuilder.CreateTable(
                name: "Packstoffs",
                columns: table => new
                {
                    PackstoffId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bezeichnung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Menge = table.Column<int>(type: "int", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    PackstoffCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArtikelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packstoffs", x => x.PackstoffId);
                    table.ForeignKey(
                        name: "FK_Packstoffs_Artikel_ArtikelId",
                        column: x => x.ArtikelId,
                        principalTable: "Artikel",
                        principalColumn: "ArtikelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Packstoffs_ArtikelId",
                table: "Packstoffs",
                column: "ArtikelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Packstoffs");

            migrationBuilder.DropTable(
                name: "Artikel");
        }
    }
}
