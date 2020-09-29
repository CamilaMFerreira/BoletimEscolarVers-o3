using BoletimEscolarVersao3.Model;
using System;
using Xunit;

namespace BoletimEscolarVersão3.Teste
{
    public class UnitTest1
    {
        [Fact]
        public void CadastroAluno()
        {
            var aluno = new Aluno();
            aluno.Nome = "Arthur";
            aluno.Sobrenome = "Silva";
            aluno.Cpf = "14725836912";
            aluno.DataNascimento = Convert.ToDateTime("12/09/2000");
            aluno.Função = "Aluno";
            aluno.IdCurso = 1;
            Assert.Equal(aluno,);


        }
    }
}
