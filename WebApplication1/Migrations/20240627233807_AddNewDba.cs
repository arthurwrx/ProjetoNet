using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class AddNewDba : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_COLETA_MODEL",
                columns: table => new
                {
                    DiaColetaId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DataHora = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Bairro = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    TipoColeta = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_COLETA_MODEL", x => x.DiaColetaId);
                });

            migrationBuilder.CreateTable(
                name: "TB_DIA_COLETA",
                columns: table => new
                {
                    DiaDeColetaId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DataHora = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Bairro = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_DIA_COLETA", x => x.DiaDeColetaId);
                });

            migrationBuilder.CreateTable(
                name: "TB_MORADOR",
                columns: table => new
                {
                    MoradorId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    MoradorName = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Endereco = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Email = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_MORADOR", x => x.MoradorId);
                });

            migrationBuilder.CreateTable(
                name: "TB_TIPO_RESIDUOS",
                columns: table => new
                {
                    TipoResiduosId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Descricao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_TIPO_RESIDUOS", x => x.TipoResiduosId);
                });

            migrationBuilder.CreateTable(
                name: "TB_NOTIFICACAO",
                columns: table => new
                {
                    NotificacaoId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Email = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Mensagem = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Status = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    MoradorId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DiaColetaId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    TipoResiduosId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_NOTIFICACAO", x => x.NotificacaoId);
                    table.ForeignKey(
                        name: "FK_TB_NOTIFICACAO_TB_DIA_COLETA_DiaColetaId",
                        column: x => x.DiaColetaId,
                        principalTable: "TB_DIA_COLETA",
                        principalColumn: "DiaDeColetaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_NOTIFICACAO_TB_MORADOR_MoradorId",
                        column: x => x.MoradorId,
                        principalTable: "TB_MORADOR",
                        principalColumn: "MoradorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_NOTIFICACAO_TB_TIPO_RESIDUOS_TipoResiduosId",
                        column: x => x.TipoResiduosId,
                        principalTable: "TB_TIPO_RESIDUOS",
                        principalColumn: "TipoResiduosId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_NOTIFICACAO_DiaColetaId",
                table: "TB_NOTIFICACAO",
                column: "DiaColetaId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_NOTIFICACAO_MoradorId",
                table: "TB_NOTIFICACAO",
                column: "MoradorId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_NOTIFICACAO_TipoResiduosId",
                table: "TB_NOTIFICACAO",
                column: "TipoResiduosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_COLETA_MODEL");

            migrationBuilder.DropTable(
                name: "TB_NOTIFICACAO");

            migrationBuilder.DropTable(
                name: "TB_DIA_COLETA");

            migrationBuilder.DropTable(
                name: "TB_MORADOR");

            migrationBuilder.DropTable(
                name: "TB_TIPO_RESIDUOS");
        }
    }
}
