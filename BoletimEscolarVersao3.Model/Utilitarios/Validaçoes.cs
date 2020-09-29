using BoletimEscolarVersao3.Model.Model;
using BoletimEscolarVersao3.Utilitarios;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using static BoletimEscolarVersao3.Model.Utilitarios.Verificador;

namespace BoletimEscolarVersao3.Model.Utilitarios
{
    public class Validaçoes
    {
        public Verificador verifica = new Verificador();
        public Verificador Verificaalunocadastro(Aluno aluno)
        {
            if (!Regex.IsMatch(aluno.Nome, @"^[ a-zA-Z á]*$"))
            {
                verifica.Valido = false;
                verifica.Erros = "Só pode haver letras no nome do Aluno";
                return verifica;
            }
            if (aluno.Nome is null || aluno.Sobrenome is null || aluno.Cpf is null)
            {
                verifica.Valido = false;
                verifica.Erros = "Não pode haver campos vazios";
                return verifica;
            }
            if (Convert.ToDateTime(aluno.DataNascimento) > Convert.ToDateTime("01/01/2002"))
            {
                verifica.Valido = false;
                verifica.Erros = "O aluno tem menos de 18 anos";
                return verifica;
            }

            if (!Regex.IsMatch(aluno.Cpf, @"^[0-9]*$") || aluno.Cpf.Length > 11)
            {
                verifica.Valido = false;
                verifica.Erros = "Digite um cpf válido";
                return verifica;
            }

            var alunos = new Listas().ListadeCpfAlunos(aluno.Cpf);
            if (alunos)
            {
                verifica.Valido = false;
                verifica.Erros = "Cpf já cadastrado";
                return verifica;
            }
            return verifica;

        }
        public Verificador Verificaadmprofessocadastro(AdmProfessor pessoa)
        {
            if (!Regex.IsMatch(pessoa.Nome, @"^[ a-zA-Z á]*$"))
            {
                verifica.Valido = false;
                verifica.Erros = "Só pode haver letras no nome ";
                return verifica;
            }
            if (pessoa.Nome is null || pessoa.Sobrenome is null || pessoa.Cpf is null)
            {
                verifica.Valido = false;
                verifica.Erros = "Não pode haver campos vazios";
                return verifica;
            }


            if (!Regex.IsMatch(pessoa.Cpf, @"^[0-9]*$") || pessoa.Cpf.Length > 11)
            {
                verifica.Valido = false;
                verifica.Erros = "Digite um cpf válido";
                return verifica;
            }

            var alunos = new Listas().ListadeCpfAlunos(pessoa.Cpf);
            if (alunos)
            {
                verifica.Valido = false;
                verifica.Erros = "Cpf já cadastrado";
                return verifica;
            }
            if (pessoa.Função == "Aluno")
            {
                verifica.Valido = false;
                verifica.Erros = "Você é um aluno, peça ao seu coordenador para realizar seu cadastro";
                return verifica;
            }
            return verifica;

        }

        public Verificador VerificaMateria(Materia materia)
        {
            var data = DateTime.Now;
            if (!Regex.IsMatch(materia.Descrição, @"^[ a-zA-Z á]*$"))
            {
                verifica.Valido = false;
                verifica.Erros = "Só pode haver letras na descrição da materia";
                return verifica;
            }


            if (materia.DataCadastro > data)
            {
                verifica.Valido = false;
                verifica.Erros = "Data maior que a atual";
                return verifica;

            }
            return verifica;


        }
        public Verificador VerificaNota(string nota)
        {
            if (Convert.ToInt32(nota) < 0 || Convert.ToInt32(nota) > 100)
            {
                verifica.Valido = false;
                verifica.Erros = "Nota inválida";
                return verifica;
            }
          
            return verifica;


        }
        public Verificador VerificaCpf(string cpf)
        {
            if (!Regex.IsMatch(cpf, @"^[0-9]*$") || cpf.Length > 11)
            {
                verifica.Valido = false;
                verifica.Erros = "Cpf inválido";
                return verifica;
            }

            return verifica;


        }
        public Verificador Verificadata(string data)
        {
            try
            {
                var Data = Convert.ToDateTime(data);
                return verifica;

            }
            catch 
            {
                verifica.Valido = false;
                verifica.Erros = "Digite data Válida";
                return verifica;
            }
            


        }
    }
}
