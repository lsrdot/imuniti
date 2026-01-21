using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestaoVacinas.Migrations
{
    /// <inheritdoc />
    public partial class UpdateVacinaDataRecomendada : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataRecomendada",
                table: "DetalhesVacinas",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataRecomendada",
                table: "DetalhesVacinas");
        }
    }
}
