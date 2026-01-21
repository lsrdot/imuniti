using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoVacinas.Migrations
{
    /// <inheritdoc />
    public partial class AddUserIdToMembros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Membros",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "default-user-id");

            migrationBuilder.CreateIndex(
                name: "IX_Membros_UserId",
                table: "Membros",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Membros_AspNetUsers_UserId",
                table: "Membros",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Membros_AspNetUsers_UserId",
                table: "Membros");

            migrationBuilder.DropIndex(
                name: "IX_Membros_UserId",
                table: "Membros");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Membros");
        }
    }
}
