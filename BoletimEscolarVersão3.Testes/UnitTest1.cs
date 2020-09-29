using BoletimEscolarVersao3.Model;
using BoletimEscolarVersao3.Model.Utilitarios;
using System;
using Xunit;

namespace BoletimEscolarVersão3.Testes
{
    public class UnitTest1
    {
        [Fact]
        public void CadastroAlunoValido()
        {
            Aluno aluno = new Aluno()
            {
                Nome = "Camila",
                Sobrenome = "Martins",
                DataNascimento = Convert.ToDateTime("12/09/1996"),
                Cpf = "36201777123",
                IdCurso=1,
                Função = "Aluno"

            };
            var result = new Validaçoes().Verificaalunocadastro(aluno);
            Assert.True(result.Valido);
        }
        [Fact]
        public void CadastroAlunoNãovalidonome()
        {
            Aluno aluno = new Aluno()
            {
                Nome = "Camila5",
                Sobrenome = "Martins",
                DataNascimento = Convert.ToDateTime("12/09/1996"),
                Cpf = "36201777123",
                 IdCurso = 1,
                Função = "Aluno"
            };
            var result = new Validaçoes().Verificaalunocadastro(aluno);
            Assert.False(result.Valido);
        }
        [Fact]
        public void CadastroAlunoNãovalidovazio()
        {
            Aluno aluno = new Aluno()
            {
                Nome = "",
                Sobrenome = "Martins",
                DataNascimento = Convert.ToDateTime("12/09/1996"),
                Cpf = "36201777123",
                 IdCurso = 1,
                Função = "Aluno"
            };
            var result = new Validaçoes().Verificaalunocadastro(aluno);
            Assert.False(result.Valido);
        }
        [Fact]
        public void CadastroAlunoNãovalidoidade()
        {
            Aluno aluno = new Aluno()
            {
                Nome = "Camila",
                Sobrenome = "Martins",
                DataNascimento = Convert.ToDateTime("12/09/2010"),
                Cpf = "36201777123",
                IdCurso = 1,
                Função = "Aluno"
            };
            var result = new Validaçoes().Verificaalunocadastro(aluno);
            Assert.False(result.Valido);
        }
        [Fact]
        public void CadastroAlunoNãovalidocpf()
        {
            Aluno aluno = new Aluno()
            {
                Nome = "Camila",
                Sobrenome = "Martins",
                DataNascimento = Convert.ToDateTime("12/09/1996"),
                Cpf = "362017771231548",
                IdCurso = 1,
                Função = "Aluno"
            };
            var result = new Validaçoes().Verificaalunocadastro(aluno);
                
                
            Assert.False(result.Valido);
        }
    }
}
