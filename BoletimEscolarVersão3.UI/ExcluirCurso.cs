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
    public partial class ExcluirCurso : Form
    {
        public ExcluirCurso()
        {
            InitializeComponent();
            cb_curso.DataSource = new Listas().ListadeCursos();
            
        }
     

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var menu = new MenuAdminCurso();
            this.Hide();
            menu.Show();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            var curso = cb_curso.Text;
            curso = curso.Substring(0, curso.IndexOf("-"));
            var idcurso = Convert.ToInt32(curso);
            var caminho = "https://localhost:44355/Curso/Deletar";
            var httpClient = new HttpClient();
            var serializedProduto = JsonConvert.SerializeObject(curso);
            var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
            var resultRequest = httpClient.DeleteAsync($"{caminho}?id={idcurso}");
            resultRequest.Wait();
            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();
            MessageBox.Show(result.Result);
        }
    }
}
