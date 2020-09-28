using BoletimEscolarVersao3.Model;
using BoletimEscolarVersao3.Model.Model;
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
    public partial class CadastroAdmProfessor : Form
    {
        public CadastroAdmProfessor()
        {
            InitializeComponent();
        }
        private AdmProfessor ListadeCpfAdmProf(string cpflogin)
        {
            try
            {

                var httpClient = new HttpClient();
                var URL = "https://localhost:44355/AdmProfessor/Mostra";
                var resultRequest = httpClient.GetAsync(URL);
                var result = resultRequest.GetAwaiter().GetResult();

                if (result.IsSuccessStatusCode)
                {
                    var resultJson = result.Content.ReadAsStringAsync()
                        .GetAwaiter().GetResult();

                    var data = JsonConvert.DeserializeObject<List<AdmProfessor>>(resultJson);

                    var resultado = data.Where(q => q.Cpf == cpflogin).FirstOrDefault();

                    return resultado;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                throw new Exception();
            }
        }
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var menu = new Login();
            this.Hide();
            menu.Show();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txt_nome.Text, @"^[ a-zA-Z á]*$"))
            {

                if (cb_função.Text != "Aluno")
                {

                    if (Regex.IsMatch(txt_cpf.Text, @"^[0-9]{3}\.?[0-9]{3}\.?[0-9]{3}\-?[0-9]{2}"))
                    {

                        var admprof = ListadeCpfAdmProf(txt_cpf.Text);
                        if (admprof == null)
                        {
                            var caminho = "https://localhost:44355/AdmProfessor/Adicionar";
                            AdmProfessor pessoa = new AdmProfessor();
                            pessoa.Nome = txt_nome.Text;
                            pessoa.Sobrenome = txt_sobrenome.Text;
                            pessoa.Cpf = txt_cpf.Text;
                            pessoa.DataNascimento = Convert.ToDateTime(txt_data.Text);
                            pessoa.Função = cb_função.Text;
                            var curso = cb_função.Text;
                            new Adicionar().Add(pessoa, caminho);
                            txt_nome.Clear();
                            txt_sobrenome.Clear();
                            txt_data.Clear();
                            txt_cpf.Clear();
                            MessageBox.Show(" Cadastrado!");
                        }
                        else
                        {
                            MessageBox.Show("Cpf já cadastrado");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digite um cpf válido");
                    }

                }
                else
                {
                    MessageBox.Show("Você é um aluno, peça ao seu coordenador para realizar seu cadastro");
                }
            }
            else
            {
                MessageBox.Show("Só pode haver letras no nome do Aluno");
            }
        }
    }
}

