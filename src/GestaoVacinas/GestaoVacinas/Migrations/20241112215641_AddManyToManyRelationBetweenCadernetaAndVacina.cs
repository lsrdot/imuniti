using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoVacinas.Migrations
{
    /// <inheritdoc />
    public partial class AddManyToManyRelationBetweenCadernetaAndVacina : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CadernetaVacina",
                columns: table => new
                {
                    CadernetaId = table.Column<int>(type: "int", nullable: false),
                    VacinaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadernetaVacina", x => new { x.CadernetaId, x.VacinaId });
                    table.ForeignKey(
                        name: "FK_CadernetaVacina_Cadernetas_CadernetaId",
                        column: x => x.CadernetaId,
                        principalTable: "Cadernetas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CadernetaVacina_Vacinas_VacinaId",
                        column: x => x.VacinaId,
                        principalTable: "Vacinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CadernetaVacina_VacinaId",
                table: "CadernetaVacina",
                column: "VacinaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CadernetaVacina");
        }
    }
}
