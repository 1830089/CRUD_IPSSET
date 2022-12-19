using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCIPSSET.Migrations
{
    /// <inheritdoc />
    public partial class quintamigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonasId",
                table: "Movimientos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movimientos_PersonasId",
                table: "Movimientos",
                column: "PersonasId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Personas_PersonasId",
                table: "Movimientos",
                column: "PersonasId",
                principalTable: "Personas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_Personas_PersonasId",
                table: "Movimientos");

            migrationBuilder.DropIndex(
                name: "IX_Movimientos_PersonasId",
                table: "Movimientos");

            migrationBuilder.DropColumn(
                name: "PersonasId",
                table: "Movimientos");
        }
    }
}
