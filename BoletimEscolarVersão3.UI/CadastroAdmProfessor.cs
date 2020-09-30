using BoletimEscolarVersao3.Model;
using BoletimEscolarVersao3.Model.Model;
using BoletimEscolarVersao3.Model.Utilitarios;
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
       
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var menu = new Login();
            this.Hide();
            menu.Show();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {

            var caminho = "https://localhost:44355/AdmProfessor/Adicionar";
            AdmProfessor pessoa = new AdmProfessor();
            pessoa.Nome = txt_nome.Text;
            pessoa.Sobrenome = txt_sobrenome.Text;
            pessoa.Cpf = txt_cpf.Text;
            pessoa.DataNascimento = Convert.ToDateTime(txt_data.Text);
            pessoa.Função = cb_função.Text;
            var verificador = new Validaçoes().Verificaadmprofessocadastro(pessoa);
            if (verificador.Valido)
            {
                new Adicionar().Add(pessoa, caminho);
                txt_nome.Clear();
                txt_sobrenome.Clear();
                txt_data.Clear();
                txt_cpf.Clear();
                MessageBox.Show(" Cadastrado!");
            }
            else
            {
                MessageBox.Show(verificador.Erros);
            }
        }
    }
}

