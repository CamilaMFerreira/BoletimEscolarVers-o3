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
    public partial class CadastroCurso : Form
    {
        public CadastroCurso()
        {
            InitializeComponent();
        }
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var menu = new MenuAdmin();
            this.Hide();
            menu.Show();
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            var caminho = "https://localhost:44355/Curso/Adicionar";
            Curso curso = new Curso();
            curso.Nome = txt_nome.Text;
            curso.Situação = cb_situação.Text;
            var httpClient = new HttpClient();
            var serializedProduto = JsonConvert.SerializeObject(curso);
            var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
            var resultRequest = httpClient.PostAsync(caminho, content);
            resultRequest.Wait();
            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();
            txt_nome.Clear();
            MessageBox.Show(result.Result);

        }
    }
}
