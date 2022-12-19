using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCIPSSET.Migrations
{
    /// <inheritdoc />
    public partial class octavamigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movimientos_Personas_persona_idId",
                table: "Movimientos");

            migrationBuilder.DropIndex(
                name: "IX_Movimientos_persona_idId",
                table: "Movimientos");

            migrationBuilder.DropColumn(
                name: "persona_idId",
                table: "Movimientos");

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

            migrationBuilder.AddColumn<int>(
                name: "persona_idId",
                table: "Movimientos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Movimientos_persona_idId",
                table: "Movimientos",
                column: "persona_idId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movimientos_Personas_persona_idId",
                table: "Movimientos",
                column: "persona_idId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
