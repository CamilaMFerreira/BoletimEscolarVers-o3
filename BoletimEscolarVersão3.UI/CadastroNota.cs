using BoletimEscolarVersao3.Model;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoletimEscolarVersão3.UI
{
    public partial class CadastroNota : Form
    {
        public CadastroNota()
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
                        cb_aluno.Items.Add($"{aluno.Id} - {aluno.Nome}");
                    }
                }
            }
            catch { }
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var menu = new Menuprof();
            this.Hide();
            menu.Show();
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_nota.Text) < 0 || Convert.ToInt32(txt_nota.Text) > 100)
            {
                MessageBox.Show("Nota inválida");
            }
            else
            {
                var caminho = "https://localhost:44355/Materia/Nota";
                AlunoMateriaNotas nota = new AlunoMateriaNotas();
                var materia = cb_materia.Text;
                materia = materia.Substring(0, materia.IndexOf("-"));
                nota.IdMateria = Convert.ToInt32(materia);
                var aluno = cb_aluno.Text;
                aluno = aluno.Substring(0, aluno.IndexOf("-"));
                nota.IdAluno = Convert.ToInt32(aluno);
                nota.Nota = Convert.ToInt32(txt_nota.Text);
                var httpClient = new HttpClient();
                var resultRequest = httpClient.PostAsync($"{caminho}?idaluno={nota.IdAluno}&idmateria={nota.IdMateria}&nota={nota.Nota}", null);
                resultRequest.Wait();
                var result = resultRequest.Result.Content.ReadAsStringAsync();
                result.Wait();
                MessageBox.Show(result.Result);
                txt_nota.Clear();
            }

        }

        private void cb_curso_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListadeAlunos();
            ListadeMateria();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var caminho = "https://localhost:44355/Materia/AtualizarNota";
            AlunoMateriaNotas nota = new AlunoMateriaNotas();
            var materia = cb_materia.Text;
            materia = materia.Substring(0, materia.IndexOf("-"));
            nota.IdMateria = Convert.ToInt32(materia);
            var aluno = cb_aluno.Text;
            aluno = aluno.Substring(0, aluno.IndexOf("-"));
            nota.IdAluno = Convert.ToInt32(aluno);
            nota.Nota = Convert.ToInt32(txt_nota.Text);
            var httpClient = new HttpClient();
            var resultRequest = httpClient.PutAsync($"{caminho}?idaluno={nota.IdAluno}&idmateria={nota.IdMateria}&novanota={nota.Nota}", null);
            resultRequest.Wait();
            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();
            MessageBox.Show(result.Result);
            txt_nota.Clear();
        }
    }
}
