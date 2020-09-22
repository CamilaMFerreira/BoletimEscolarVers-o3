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
            ListadeAlunos();
            ListadeMateria();
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
                var httpClient = new HttpClient();
                var URL = "https://localhost:44355/Materia/MostraMateria";
                var resultRequest = httpClient.GetAsync(URL);
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
                var httpClient = new HttpClient();
                var URL = "https://localhost:44355/Aluno/Mostra";
                var resultRequest = httpClient.GetAsync(URL);
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
            var menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            var caminho = "https://localhost:44355/Materia/Nota";
            AlunoMateriaNotas nota = new AlunoMateriaNotas();
            nota.IdMateria= (cb_curso.SelectedIndex) + 1;
            nota.IdAluno = (cb_aluno.SelectedIndex) + 1;
            nota.Nota = Convert.ToInt32(txt_nota.Text);
            var httpClient = new HttpClient();
            var serializedProduto = JsonConvert.SerializeObject(nota);
            var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
            var resultRequest = httpClient.PostAsync(caminho, content);
            resultRequest.Wait();
            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();
            MessageBox.Show("Nota Cadastrada!");
        }
    }
}
