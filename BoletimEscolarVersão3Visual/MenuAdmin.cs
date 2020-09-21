using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BoletimEscolarVersão3Visual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void btn_cadaluno_Click(object sender, EventArgs e)
        {
            var menu = new CadastroAluno();
            this.Hide();
            menu.ShowDialog();
            this.Show();
        }

        private void btn_cadcurso_Click(object sender, EventArgs e)
        {
            var menu = new CadastroCurso();
            this.Hide();
            menu.Show();
        }

        private void btn_cadmateria_Click(object sender, EventArgs e)
        {
            var menu = new CadastroMateria();
            this.Hide();
            menu.Show();
        }
    }
}
