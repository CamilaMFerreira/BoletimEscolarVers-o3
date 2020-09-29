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
            cb_curso.DataSource = new Listas().ListadeCursos();
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
            cb_aluno.Items.Clear();
            cb_materia.Items.Clear();
            foreach (var item in new Listas().ListadeMateria(cb_curso.Text))
                cb_materia.Items.Add(item);
            foreach (var item in new Listas().ListadeAlunos(cb_curso.Text))
                cb_aluno.Items.Add(item);
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var menu = new Menuprof();
            this.Hide();
            menu.Show();
        }
    }
}
