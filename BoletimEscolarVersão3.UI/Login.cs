using BoletimEscolarVersao3.Model;
using BoletimEscolarVersao3.Model.Model;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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
        private void txt_cpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var alunos = ListadeCpfAlunos(txt_cpf.Text);
            if (alunos) 
            {
                var menu = new ListarNotas();
                this.Hide();
                menu.Show();
            }
           
            var admprof = ListadeCpfAdmProf(txt_cpf.Text);
            if (admprof!= null)
            {
                if(admprof.Função== "Professor") 
                {
                    var menu = new Menuprof();
                    this.Hide();
                    menu.Show();
                }

               if (admprof.Função == "Administrador") 
                {
                    var menu = new MenuAdmin();
                    this.Hide();
                    menu.Show();
                }
            }
            if (!alunos && admprof is null) 
            {
                MessageBox.Show("Voce não está cadastrado");
            }


        }
    }
}
