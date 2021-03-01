using Microsoft.EntityFrameworkCore.Migrations;

namespace MarioMendonca.SpeechPlanning.Infrastructure.Data.Migrations
{
    public partial class azure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Programacoes_CanticoId",
                table: "Programacoes",
                column: "CanticoId");

            migrationBuilder.CreateIndex(
                name: "IX_Programacoes_CongregacaoId",
                table: "Programacoes",
                column: "CongregacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Programacoes_EsbocoId",
                table: "Programacoes",
                column: "EsbocoId");

            migrationBuilder.CreateIndex(
                name: "IX_Programacoes_OradorId",
                table: "Programacoes",
                column: "OradorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Programacoes_Canticos_CanticoId",
                table: "Programacoes",
                column: "CanticoId",
                principalTable: "Canticos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Programacoes_Congregacoes_CongregacaoId",
                table: "Programacoes",
                column: "CongregacaoId",
                principalTable: "Congregacoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Programacoes_Esbocos_EsbocoId",
                table: "Programacoes",
                column: "EsbocoId",
                principalTable: "Esbocos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Programacoes_Oradores_OradorId",
                table: "Programacoes",
                column: "OradorId",
                principalTable: "Oradores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Programacoes_Canticos_CanticoId",
                table: "Programacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Programacoes_Congregacoes_CongregacaoId",
                table: "Programacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Programacoes_Esbocos_EsbocoId",
                table: "Programacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Programacoes_Oradores_OradorId",
                table: "Programacoes");

            migrationBuilder.DropIndex(
                name: "IX_Programacoes_CanticoId",
                table: "Programacoes");

            migrationBuilder.DropIndex(
                name: "IX_Programacoes_CongregacaoId",
                table: "Programacoes");

            migrationBuilder.DropIndex(
                name: "IX_Programacoes_EsbocoId",
                table: "Programacoes");

            migrationBuilder.DropIndex(
                name: "IX_Programacoes_OradorId",
                table: "Programacoes");
        }
    }
}
