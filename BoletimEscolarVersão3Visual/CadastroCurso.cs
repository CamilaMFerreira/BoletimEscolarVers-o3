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
    }
}
