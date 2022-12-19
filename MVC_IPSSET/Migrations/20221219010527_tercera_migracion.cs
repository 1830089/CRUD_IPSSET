using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCIPSSET.Migrations
{
    /// <inheritdoc />
    public partial class terceramigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEstado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pensiones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pensiones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_sexo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_sexo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Fecha = table.Column<DateTime>(type: "date", nullable: true),
                    Clave = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Usuarios__3214EC07E2C8797D", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    npension = table.Column<int>(name: "n_pension", type: "int", nullable: false),
                    cobroindebido = table.Column<bool>(name: "cobro_indebido", type: "bit", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidopaterno = table.Column<string>(name: "Apellido_paterno", type: "nvarchar(max)", nullable: false),
                    Apellidomaterno = table.Column<string>(name: "Apellido_materno", type: "nvarchar(max)", nullable: false),
                    Fechanacimiento = table.Column<DateTime>(name: "Fecha_nacimiento", type: "datetime2", nullable: false),
                    RFC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Curp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idSexoId = table.Column<int>(name: "id_SexoId", type: "int", nullable: false),
                    idPensionId = table.Column<int>(name: "id_PensionId", type: "int", nullable: false),
                    EstadocivilId = table.Column<int>(name: "Estado_civilId", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personas_Estados_Estado_civilId",
                        column: x => x.EstadocivilId,
                        principalTable: "Estados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personas_Pensiones_id_PensionId",
                        column: x => x.idPensionId,
                        principalTable: "Pensiones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personas_Tipo_sexo_id_SexoId",
                        column: x => x.idSexoId,
                        principalTable: "Tipo_sexo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movimientos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Importe = table.Column<float>(type: "real", nullable: false),
                    Fechainicio = table.Column<DateTime>(name: "Fecha_inicio", type: "datetime2", nullable: false),
                    Fechafin = table.Column<DateTime>(name: "Fecha_fin", type: "datetime2", nullable: false),
                    TipoidId = table.Column<int>(name: "Tipo_idId", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimientos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movimientos_Tipos_Tipo_idId",
                        column: x => x.TipoidId,
                        principalTable: "Tipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movimientos_Tipo_idId",
                table: "Movimientos",
                column: "Tipo_idId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Estado_civilId",
                table: "Personas",
                column: "Estado_civilId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_id_PensionId",
                table: "Personas",
                column: "id_PensionId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_id_SexoId",
                table: "Personas",
                column: "id_SexoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movimientos");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Tipos");

            migrationBuilder.DropTable(
                name: "Estados");

            migrationBuilder.DropTable(
                name: "Pensiones");

            migrationBuilder.DropTable(
                name: "Tipo_sexo");
        }
    }
}
