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
    public partial class CadastroMateria : Form
    {
        
       
        public CadastroMateria()
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

       

        private void button1_Click(object sender, EventArgs e)
        {
            var caminho = "https://localhost:44355/Materia/Nota";
            Materia materia = new Materia();
            materia.Nome = txt_nome.Text;
            materia.Descrição = txt_descrição.Text;
            materia.DataCadastro = Convert.ToDateTime(txt_data.Text);
            materia.IdCurso = (cb_curso.SelectedIndex) + 1;
            materia.Situação = cb_situação.Text;
            new Adicionar().Add(materia, caminho);
            txt_nome.Clear();
            txt_data.Clear();
            txt_descrição.Clear();
            MessageBox.Show("Materia Cadastrada!");
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var menu = new MenuAdmin();
            this.Hide();
            menu.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CadastroMateria_Load(object sender, EventArgs e)
        {
            
            

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            
                
        }
    }
}
