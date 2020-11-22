using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MarioMendonca.SpeechPlanning.Infrastructure.Data.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Esbocos_Idiomas_IdiomaId1",
                table: "Esbocos");

            migrationBuilder.DropIndex(
                name: "IX_Esbocos_IdiomaId1",
                table: "Esbocos");

            migrationBuilder.DropColumn(
                name: "IdiomaId1",
                table: "Esbocos");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdiomaId",
                table: "Esbocos",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Esbocos_IdiomaId",
                table: "Esbocos",
                column: "IdiomaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Esbocos_Idiomas_IdiomaId",
                table: "Esbocos",
                column: "IdiomaId",
                principalTable: "Idiomas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Esbocos_Idiomas_IdiomaId",
                table: "Esbocos");

            migrationBuilder.DropIndex(
                name: "IX_Esbocos_IdiomaId",
                table: "Esbocos");

            migrationBuilder.AlterColumn<int>(
                name: "IdiomaId",
                table: "Esbocos",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<Guid>(
                name: "IdiomaId1",
                table: "Esbocos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Esbocos_IdiomaId1",
                table: "Esbocos",
                column: "IdiomaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Esbocos_Idiomas_IdiomaId1",
                table: "Esbocos",
                column: "IdiomaId1",
                principalTable: "Idiomas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
