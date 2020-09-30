using BoletimEscolarVersao3.Model;
using BoletimEscolarVersao3.Model.Utilitarios;
using BoletimEscolarVersao3.Utilitarios;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoletimEscolarVersão3.UI
{
    public partial class CadastroAluno : Form
    {
        public CadastroAluno()
        {
            InitializeComponent();
            cb_curso.DataSource = new Listas().ListadeCursos();


        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            var caminho = "https://localhost:44355/Aluno/Adicionar";
            Aluno aluno = new Aluno();
            aluno.Nome = txt_nome.Text;
            aluno.Sobrenome = txt_sobrenome.Text;
            aluno.Cpf = txt_cpf.Text;
            aluno.DataNascimento = Convert.ToDateTime(txt_data.Text);
            aluno.IdCurso = (cb_curso.SelectedIndex) + 1;
            var httpClient = new HttpClient();
            var serializedProduto = JsonConvert.SerializeObject(aluno);
            var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
            var resultRequest = httpClient.PostAsync(caminho, content);
            resultRequest.Wait();
            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            txt_nome.Clear();
            MessageBox.Show(result.Result);

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var menu = new MenuadminAluno();
            this.Hide();
            menu.Show();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            var verificadata = new Validaçoes().Verificadata(txt_data.Text);
            var verficacpf = new Validaçoes().Existecpfaluno(txt_cpf.Text);
            if (verificadata.Valido && verficacpf.Valido)
            {
                var caminho = "https://localhost:44355/Aluno/Adicionar";
                Aluno aluno = new Aluno();
                aluno.Nome = txt_nome.Text;
                aluno.Sobrenome = txt_sobrenome.Text;
                aluno.Cpf = txt_cpf.Text;
                aluno.DataNascimento = Convert.ToDateTime(txt_data.Text);
                aluno.Função = "Aluno";
                var curso = cb_curso.Text;
                curso = curso.Substring(0, curso.IndexOf("-"));
                aluno.IdCurso = Convert.ToInt32(curso);
                var verificador = new Validaçoes().Verificaalunocadastro(aluno);
                if (verificador.Valido)
                {
                    new Adicionar().Add(aluno, caminho);
                    txt_nome.Clear();
                    txt_sobrenome.Clear();
                    txt_data.Clear();
                    txt_cpf.Clear();
                    MessageBox.Show("Aluno Cadastrado!");
                }
                else
                {
                    MessageBox.Show(verificador.Erros);
                }
            }
            else
            {
                MessageBox.Show(verificadata.Erros);
            }
        }


    }
}
