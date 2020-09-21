using BoletimEscolarVersao3.Model;
using BoletimEscolarVersão3Modelos.Uteis;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace BoletimEscolarVersão3Visual
{
    public partial class CadastroAluno : Form
    {
        public CadastroAluno()
        {
      
            InitializeComponent();
            ListadeCursos();

        }
        private void ListadeCursos()
        {
            var httpClient = new HttpClient();
            var URL = "http://localhost:44355/Curso/MostraCursos";
            var resultRequest = httpClient.GetAsync(URL);
            resultRequest.Wait();
            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();
            var data = JsonConvert.DeserializeObject<Root>(result.Result).Curso;
            foreach (var curso in data)
            {
                cb_curso.Items.Add($"{curso.Id} - {curso.Nome}");
            }
        }
        private class Root
        {
            public List<Curso> Curso { get; set; }
        }
        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            var caminho = "https://localhost:44355/Aluno/Adicionar";
            Aluno aluno = new Aluno();
            aluno.Nome = txt_nome.Text;
            aluno.Sobrenome = txt_sobrenome.Text;
            aluno.Cpf = txt_cpf.Text;
            aluno.DataNascimento =Convert.ToDateTime( txt_data.Text);
            aluno.IdCurso =(cb_curso.SelectedIndex) + 1;
            new Adicionar().Add(aluno, caminho);
            txt_nome.Clear();
            MessageBox.Show("Curso Cadastrado!");

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var menu = new Form1();
            this.Hide();
            menu.Show();
        }
    }
}
