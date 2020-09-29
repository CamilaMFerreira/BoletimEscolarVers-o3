using BoletimEscolarVersao3.Model;
using BoletimEscolarVersao3.Model.Utilitarios;
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
    public partial class ListarNotas : Form
    {
        public ListarNotas()
        {
            InitializeComponent();
        }
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var menu = new Login();
            this.Hide();
            menu.Show();
        }

        private void btn_verificar_Click(object sender, EventArgs e)
        {
            try
            {
                var verificador = new Validaçoes().VerificaCpf(txt_cpf.Text);

                if (verificador.Valido)
                {
                    var cpf = txt_cpf.Text;
                    var httpClient = new HttpClient();
                    var URL = "https://localhost:44355/Aluno/ListarNotas";
                    var resultRequest = httpClient.GetAsync($"{URL}?cpf={cpf}");
                    var result = resultRequest.GetAwaiter().GetResult();

                    if (result.IsSuccessStatusCode)
                    {
                        var resultJson = result.Content.ReadAsStringAsync()
                            .GetAwaiter().GetResult();

                        var data = JsonConvert.DeserializeObject<List<AlunoMateriaNotas>>(resultJson);
                        foreach (var materia in data)
                        {
                            txt_notas.Text = $"Materia : {materia.Materia.Nome}\t Nota : {materia.Nota}";
                        }


                    }
                }
                else 
                {
                    MessageBox.Show(verificador.Erros);
                }
            }
            catch { }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
