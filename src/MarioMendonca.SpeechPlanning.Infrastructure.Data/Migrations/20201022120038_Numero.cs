using Microsoft.EntityFrameworkCore.Migrations;

namespace MarioMendonca.SpeechPlanning.Infrastructure.Data.Migrations
{
    public partial class Numero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Numero",
                table: "Esbocos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Numero",
                table: "Canticos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Esbocos");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Canticos");
        }
    }
}
