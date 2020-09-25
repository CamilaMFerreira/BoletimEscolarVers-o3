using Microsoft.EntityFrameworkCore.Migrations;

namespace BoletimEscolarVersão3Modelos.Migrations
{
    public partial class AddAlunoFunção : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Função",
                table: "Aluno",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Função",
                table: "Aluno");
        }
    }
}
