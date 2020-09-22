using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoletimEscolarVersão3.UI
{
    public partial class MenuAdminCurso : Form
    {
        public MenuAdminCurso()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var menu = new MenuAdmin();
            this.Hide();
            menu.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_cadaluno_Click(object sender, EventArgs e)
        {
            var menu = new CadastroCurso();
            this.Hide();
            menu.Show();
        }

        private void btn_excluiraluno_Click(object sender, EventArgs e)
        {
            var menu = new ExcluirCurso();
            this.Hide();
            menu.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
