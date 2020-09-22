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
    public partial class MenuAdminMateria : Form
    {
        public MenuAdminMateria()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var menu = new MenuAdmin();
            this.Hide();
            menu.Show();
        }

        private void btn_cadaluno_Click(object sender, EventArgs e)
        {
            var menu = new CadastroMateria();
            this.Hide();
            menu.Show();
        }

        private void btn_excluiraluno_Click(object sender, EventArgs e)
        {
            var menu = new ExcluirMateria();
            this.Hide();
            menu.Show();
        }
    }
}
