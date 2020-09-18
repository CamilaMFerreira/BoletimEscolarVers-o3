using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BoletimEscolarVersão3Modelos.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    Situação = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Aluno",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    Sobrenome = table.Column<string>(maxLength: 100, nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Cpf = table.Column<string>(maxLength: 100, nullable: false),
                    IdCurso = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aluno_Curso_IdCurso",
                        column: x => x.IdCurso,
                        principalTable: "Curso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Materia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Descrição = table.Column<string>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    Situação = table.Column<string>(nullable: false),
                    IdCurso = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Materia_Curso_IdCurso",
                        column: x => x.IdCurso,
                        principalTable: "Curso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlunoMateriaNotas",
                columns: table => new
                {
                    IdMateria = table.Column<int>(nullable: false),
                    IdAluno = table.Column<int>(nullable: false),
                    MateriaId = table.Column<int>(nullable: true),
                    AlunoId = table.Column<int>(nullable: true),
                    Nota = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunoMateriaNotas", x => new { x.IdAluno, x.IdMateria });
                    table.ForeignKey(
                        name: "FK_AlunoMateriaNotas_Aluno_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Aluno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AlunoMateriaNotas_Materia_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "Materia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_IdCurso",
                table: "Aluno",
                column: "IdCurso");

            migrationBuilder.CreateIndex(
                name: "IX_AlunoMateriaNotas_AlunoId",
                table: "AlunoMateriaNotas",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_AlunoMateriaNotas_MateriaId",
                table: "AlunoMateriaNotas",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Materia_IdCurso",
                table: "Materia",
                column: "IdCurso");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlunoMateriaNotas");

            migrationBuilder.DropTable(
                name: "Aluno");

            migrationBuilder.DropTable(
                name: "Materia");

            migrationBuilder.DropTable(
                name: "Curso");
        }
    }
}
