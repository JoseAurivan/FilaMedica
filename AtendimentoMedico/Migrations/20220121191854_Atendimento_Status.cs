using Microsoft.EntityFrameworkCore.Migrations;

namespace AtendimentoMedico.Migrations
{
    public partial class Atendimento_Status : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Atendido",
                table: "atendimento",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Atendido",
                table: "atendimento");
        }
    }
}
