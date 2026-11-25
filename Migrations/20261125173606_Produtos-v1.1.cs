using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoFinal.Migrations
{
    /// <inheritdoc />
    public partial class Produtosv11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataHora_Criacao",
                table: "TB_PRODUTOS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Ultima_Atualizacao",
                table: "TB_PRODUTOS",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TB_PRODUTOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataHora_Criacao", "Ultima_Atualizacao" },
                values: new object[] { new DateTime(2026, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataHora_Criacao",
                table: "TB_PRODUTOS");

            migrationBuilder.DropColumn(
                name: "Ultima_Atualizacao",
                table: "TB_PRODUTOS");
        }
    }
}
