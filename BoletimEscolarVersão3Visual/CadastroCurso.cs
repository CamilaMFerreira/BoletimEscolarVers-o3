using BoletimEscolarVersão3Modelos.Modelos;
using BoletimEscolarVersão3Modelos.Uteis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BoletimEscolarVersão3Visual
{
    public partial class CadastroCurso : Form
    {


        public CadastroCurso()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var menu = new Form1();
            this.Hide();
            menu.Show();
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            var caminho = "https://localhost:44355/Curso/Adicionar";
            Curso curso = new Curso();
            curso.Nome = txt_nome.Text;
            curso.Situação = cb_situação.Text;
            new Adicionar().Add(curso, caminho);
            txt_nome.Clear();
            MessageBox.Show("Curso Cadastrado!");

        }
    }
}
