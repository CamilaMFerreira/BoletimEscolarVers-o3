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
    public partial class ExcluirMateria : Form
    {
        public ExcluirMateria()
        {
            InitializeComponent();
            cb_curso.DataSource = new Listas().ListadeCursos();
        }
      
   
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var menu = new MenuAdminMateria();
            this.Hide();
            menu.Show();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                var materia = cb_materia.Text;
                materia = materia.Substring(0, materia.IndexOf("-"));
                var idmateria = Convert.ToInt32(materia);
                var caminho = "https://localhost:44355/Materia/Deletar";
                var httpClient = new HttpClient();
                var serializedProduto = JsonConvert.SerializeObject(materia);
                var resultRequest = httpClient.DeleteAsync($"{caminho}?id={idmateria}");
                resultRequest.Wait();
                var result = resultRequest.Result.Content.ReadAsStringAsync();
                result.Wait();
                MessageBox.Show(result.Result);
            }
            catch { }

        }

        private void cb_curso_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_materia.Items.Clear();
            foreach (var item in new Listas().ListadeMateria(cb_curso.Text))
                cb_materia.Items.Add(item);
        }
    }
}
