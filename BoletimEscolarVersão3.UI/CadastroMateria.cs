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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoletimEscolarVersão3.UI
{
    public partial class CadastroMateria : Form
    {
        
       
        public CadastroMateria()
        {
            InitializeComponent();
            cb_curso.DataSource = new Listas().ListadeCursos();
        }

      

       

        private void button1_Click(object sender, EventArgs e)
        {
            var data = DateTime.Now;
            if (!Regex.IsMatch(txt_descrição.Text, @"^[ a-zA-Z á]*$"))
            {
                MessageBox.Show("Só pode haver letras na descrição da materia");
            }
            else
            {
                if (Convert.ToDateTime(txt_data.Text) > data)
                {
                    MessageBox.Show("Data maior que a atual");
                }
                else
                {
                    var caminho = "https://localhost:44355/Materia/Adicionar";
                    Materia materia = new Materia();
                    materia.Nome = txt_nome.Text;
                    materia.Descrição = txt_descrição.Text;
                    materia.DataCadastro = Convert.ToDateTime(txt_data.Text);
                    materia.IdCurso = (cb_curso.SelectedIndex) + 1;
                    materia.Situação = cb_situação.Text;
                    var httpClient = new HttpClient();
                    var serializedProduto = JsonConvert.SerializeObject(materia);
                    var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                    var resultRequest = httpClient.PostAsync(caminho, content);
                    resultRequest.Wait();
                    var result = resultRequest.Result.Content.ReadAsStringAsync();
                    result.Wait();
                    txt_nome.Clear();
                    txt_data.Clear();
                    txt_descrição.Clear();
                    MessageBox.Show(result.Result);
                }
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var menu = new MenuAdminMateria();
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
