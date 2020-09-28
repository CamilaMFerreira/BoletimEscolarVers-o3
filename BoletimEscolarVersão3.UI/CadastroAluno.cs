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
    public partial class CadastroAluno : Form
    {
        public CadastroAluno()
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
        private bool ListadeCpfAlunos(string cpflogin)
        {
            try
            {
                List<string> cpf = new List<string>();
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
                        cpf.Add(aluno.Cpf);
                    }


                    if (cpf.Contains(cpflogin))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
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
        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            var caminho = "https://localhost:44355/Aluno/Adicionar";
            Aluno aluno = new Aluno();
            aluno.Nome = txt_nome.Text;
            aluno.Sobrenome = txt_sobrenome.Text;
            aluno.Cpf = txt_cpf.Text;
            aluno.DataNascimento = Convert.ToDateTime(txt_data.Text);
            aluno.IdCurso = (cb_curso.SelectedIndex) + 1;
            var httpClient = new HttpClient();
            var serializedProduto = JsonConvert.SerializeObject(aluno);
            var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
            var resultRequest = httpClient.PostAsync(caminho, content);
            resultRequest.Wait();
            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();

            txt_nome.Clear();
            MessageBox.Show(result.Result);

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var menu = new MenuadminAluno();
            this.Hide();
            menu.Show();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            var data = "01/01/2002";
            if (Regex.IsMatch(txt_nome.Text, @"^[ a-zA-Z á]*$"))
            {

                if (Convert.ToDateTime(txt_data.Text) < Convert.ToDateTime(data))
                {

                    if (Regex.IsMatch(txt_cpf.Text, @"^[0-9]{3}\.?[0-9]{3}\.?[0-9]{3}\-?[0-9]{2}"))
                    {
                        var alunos = ListadeCpfAlunos(txt_cpf.Text);
                        if (!alunos)
                        {
                            var caminho = "https://localhost:44355/Aluno/Adicionar";
                            Aluno aluno = new Aluno();
                            aluno.Nome = txt_nome.Text;
                            aluno.Sobrenome = txt_sobrenome.Text;
                            aluno.Cpf = txt_cpf.Text;
                            aluno.DataNascimento = Convert.ToDateTime(txt_data.Text);
                            aluno.Função = "Aluno";
                            var curso = cb_curso.Text;
                            curso = curso.Substring(0, curso.IndexOf("-"));
                            aluno.IdCurso = Convert.ToInt32(curso);
                            new Adicionar().Add(aluno, caminho);
                            txt_nome.Clear();
                            txt_sobrenome.Clear();
                            txt_data.Clear();
                            txt_cpf.Clear();

                            MessageBox.Show("Aluno Cadastrado!");
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
                    MessageBox.Show("O aluno tem menos de 18 anos");
                }
            }
            else 
            {
                MessageBox.Show("Só pode haver letras no nome do Aluno");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CadastroAluno_Load(object sender, EventArgs e)
        {

        }

        private void cb_curso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_cpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_data_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
