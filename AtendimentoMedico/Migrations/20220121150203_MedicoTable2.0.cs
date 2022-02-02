using Microsoft.EntityFrameworkCore.Migrations;

namespace AtendimentoMedico.Migrations
{
    public partial class MedicoTable20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AtendimentoId",
                table: "medico",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_medico_AtendimentoId",
                table: "medico",
                column: "AtendimentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_medico_atendimento_AtendimentoId",
                table: "medico",
                column: "AtendimentoId",
                principalTable: "atendimento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_medico_atendimento_AtendimentoId",
                table: "medico");

            migrationBuilder.DropIndex(
                name: "IX_medico_AtendimentoId",
                table: "medico");

            migrationBuilder.DropColumn(
                name: "AtendimentoId",
                table: "medico");
        }
    }
}
