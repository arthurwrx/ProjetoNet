using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class AddModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_DIA_COLETA",
                columns: table => new
                {
                    DiaColetaId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DataHora = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Bairro = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_DIA_COLETA", x => x.DiaColetaId);
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
                name: "TB_NOTIFICACAO",
                columns: table => new
                {
                    NotificacaoId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Email = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Mensagem = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Status = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_NOTIFICACAO", x => x.NotificacaoId);
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_DIA_COLETA");

            migrationBuilder.DropTable(
                name: "TB_LOG_NOTIFICACOES");

            migrationBuilder.DropTable(
                name: "TB_MORADOR");

            migrationBuilder.DropTable(
                name: "TB_NOTIFICACAO");

            migrationBuilder.DropTable(
                name: "TB_TIPO_RESIDUOS");
        }
    }
}
