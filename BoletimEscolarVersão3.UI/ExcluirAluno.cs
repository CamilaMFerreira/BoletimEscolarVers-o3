using BoletimEscolarVersao3.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoletimEscolarVersão3.UI
{
    public partial class ExcluirAluno : Form
    {
        public ExcluirAluno()
        {
            InitializeComponent();
            ListadeCursos();
        }
        private void ListadeCursos()
        {
            try
            {

                var httpClient = new HttpClient();
                var URL = "https://localhost:44355/Curso/Mostracursos";
                var resultRequest = httpClient.GetAsync(URL);
                var result = resultRequest.GetAwaiter().GetResult();

                if (result.IsSuccessStatusCode)
                {
                    var resultJson = result.Content.ReadAsStringAsync()
                        .GetAwaiter().GetResult();

                    var data = JsonConvert.DeserializeObject<List<Curso>>(resultJson);

                    foreach (var curso in data)
                    {
                        cb_curso.Items.Add($"{curso.Id} - {curso.Nome}");
                    }
                }

            }
            catch { }
        }
    
        private void ListadeAlunos()
        {
            try
            {
                cb_aluno.Items.Clear();
                var httpClient = new HttpClient();
                var URL = "https://localhost:44355/Aluno/FiltroAlunos";
                var curso = cb_curso.Text;
                curso = curso.Substring(0, curso.IndexOf("-"));
                var idcurso = Convert.ToInt32(curso);
                var resultRequest = httpClient.GetAsync($"{URL}?id={idcurso}");
                var result = resultRequest.GetAwaiter().GetResult();

                if (result.IsSuccessStatusCode)
                {
                    var resultJson = result.Content.ReadAsStringAsync()
                        .GetAwaiter().GetResult();

                    var data = JsonConvert.DeserializeObject<List<Aluno>>(resultJson);

                    foreach (var aluno in data)
                    {
                        cb_aluno.Items.Add($"{aluno.Id} - {aluno.Nome}");
                    }
                }
            }
            catch { }
        }
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var menu = new MenuadminAluno();
            this.Hide();
            menu.Show();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                var aluno = cb_aluno.Text;
                aluno = aluno.Substring(0, aluno.IndexOf("-"));
                var idcurso = Convert.ToInt32(aluno);
                var caminho = "https://localhost:44355/Aluno/Deletar";
                var httpClient = new HttpClient();
                var serializedProduto = JsonConvert.SerializeObject(aluno);
                var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                var resultRequest = httpClient.DeleteAsync($"{caminho}?id={idcurso}");
                resultRequest.Wait();
                var result = resultRequest.Result.Content.ReadAsStringAsync();
                result.Wait();
                MessageBox.Show(result.Result);
            }
            catch { }
        }

        private void cb_curso_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListadeAlunos();
        }
    }
}
