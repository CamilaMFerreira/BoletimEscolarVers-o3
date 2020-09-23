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
    public partial class ExcluirNota : Form
    {
        public ExcluirNota()
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
        private void ListadeMateria()
        {
            try
            {
                cb_materia.Items.Clear();
                var httpClient = new HttpClient();
                var URL = "https://localhost:44355/Materia/FiltroMateria";
                var curso = cb_curso.Text;
                curso = curso.Substring(0, curso.IndexOf("-"));
                var resultRequest = httpClient.GetAsync($"{URL}?id={curso}");
                var result = resultRequest.GetAwaiter().GetResult();

                if (result.IsSuccessStatusCode)
                {
                    var resultJson = result.Content.ReadAsStringAsync()
                        .GetAwaiter().GetResult();

                    var data = JsonConvert.DeserializeObject<List<Materia>>(resultJson);

                    foreach (var materia in data)
                    {
                        cb_materia.Items.Add($"{materia.Id} - {materia.Nome}");
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
                        cb_aluno.Items.Add($"{aluno.Id} - {aluno.Nome} {aluno.Sobrenome}");
                    }
                }
            }
            catch { }
        }
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                var materia = cb_materia.Text;
                materia = materia.Substring(0, materia.IndexOf("-"));
                var idmateria = Convert.ToInt32(materia);
                var aluno = cb_aluno.Text;
                aluno = aluno.Substring(0, aluno.IndexOf("-"));
                var idaluno = Convert.ToInt32(materia);
                var caminho = "https://localhost:44355/Materia/DeletarNota";
                var httpClient = new HttpClient();
                var serializedProduto = JsonConvert.SerializeObject(materia);
                var resultRequest = httpClient.DeleteAsync($"{caminho}?idaluno={idaluno}&idmateria={idmateria}");
                resultRequest.Wait();
                var result = resultRequest.Result.Content.ReadAsStringAsync();
                result.Wait();
                MessageBox.Show(result.Result);
            }
            catch { }

        }

        private void cb_curso_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListadeMateria();
            ListadeAlunos();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var menu = new Menuprof();
            this.Hide();
            menu.Show();
        }
    }
}
