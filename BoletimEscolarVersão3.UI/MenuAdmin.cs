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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }
        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var menu = new Login();
            this.Hide();
            menu.Show();
        }

        private void btn_cadaluno_Click(object sender, EventArgs e)
        {
            var menu = new MenuadminAluno();
            this.Hide();
            menu.Show();
        }

        private void btn_cadcurso_Click(object sender, EventArgs e)
        {
            var menu = new MenuAdminCurso();
            this.Hide();
            menu.Show();
        }

        private void btn_cadmateria_Click(object sender, EventArgs e)
        {
            var menu = new MenuAdminMateria();
            this.Hide();
           menu.Show();
        }
    }
}
