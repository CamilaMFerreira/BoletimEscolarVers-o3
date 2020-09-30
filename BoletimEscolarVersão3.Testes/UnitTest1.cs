using BoletimEscolarVersao3.Model;
using BoletimEscolarVersao3.Model.Model;
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
                Cpf ="65478912358",
                IdCurso =1,
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
                Nome = string.Empty,
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

        [Fact]
        public void CadastroAdmProf()
        {
            AdmProfessor pessoa = new AdmProfessor()
            {
                Nome = "Camila",
                Sobrenome = "Martins",
                DataNascimento = Convert.ToDateTime("12/09/1996"),
                Cpf = "36201777123",
                Função = "Professor"
            };
            var result = new Validaçoes().Verificaadmprofessocadastro(pessoa);
            Assert.True(result.Valido);
        }
        [Fact]
        public void CadastroMateria()
        {
           Materia materia = new Materia()
            {
                Nome = "Camila",
               Descrição = "Martins",
                DataCadastro= Convert.ToDateTime("12/09/1996"),
                Situação="Ativa",
                IdCurso=1
            };
            var result = new Validaçoes().VerificaMateria(materia);
            Assert.True(result.Valido);
        }
        [Fact]
        public void CadastroMateriadescrisao()
        {
            Materia materia = new Materia()
            {
                Nome = "Camila",
                Descrição = "Martins1111",
                DataCadastro = Convert.ToDateTime("12/09/1996"),
                Situação = "Ativa",
                IdCurso = 1
            };
            var result = new Validaçoes().VerificaMateria(materia);
            Assert.False(result.Valido);
        }
        [Fact]
        public void CadastroMateriadata()
        {
            Materia materia = new Materia()
            {
                Nome = "Camila",
                Descrição = "Martins1111",
                DataCadastro = Convert.ToDateTime("12/09/2021"),
                Situação = "Ativa",
                IdCurso = 1
            };
            var result = new Validaçoes().VerificaMateria(materia);
            Assert.False(result.Valido);
        }
        [Fact]
        public void Nota()
        {
            AlunoMateriaNotas nota = new AlunoMateriaNotas
            {
               Nota=20
            };
            var result = new Validaçoes().VerificaNota(nota.Nota.ToString());
            Assert.True(result.Valido);
        }
        [Fact]
        public void Notafalse()
        {
            AlunoMateriaNotas nota = new AlunoMateriaNotas
            {
                Nota = 200
            };
            var result = new Validaçoes().VerificaNota(nota.Nota.ToString());
            Assert.False(result.Valido);
        }
        [Fact]
        public void cpf()
        {
            var cpf = "12345678912";
            var result = new Validaçoes().VerificaCpf(cpf);
            Assert.True(result.Valido);
        }
        [Fact]
        public void cpffalse()
        {
            var cpf = "12345678912aa";
            var result = new Validaçoes().VerificaCpf(cpf);
            Assert.False(result.Valido);
        }
       
        [Fact]
        public void data()
        {
            var data = "15/02/2005";
            var result = new Validaçoes().Verificadata(data);
            Assert.True(result.Valido);
        }
        [Fact]
        public void dataerro()
        {
            var data = "158/02/2005";
            var result = new Validaçoes().Verificadata(data);
            Assert.False(result.Valido);
        }

    }
}
