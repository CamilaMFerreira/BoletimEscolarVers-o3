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
    public partial class ExcluirAluno : Form
    {
        public ExcluirAluno()
        {
            InitializeComponent();
            cb_curso.DataSource = new Listas().ListadeCursos();
          
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
            cb_aluno.Items.Clear();
            foreach (var item in new Listas().ListadeAlunos(cb_curso.Text))
                cb_aluno.Items.Add(item);
        }
    }
}
