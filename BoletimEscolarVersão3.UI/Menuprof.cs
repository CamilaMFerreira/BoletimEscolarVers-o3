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
    public partial class Menuprof : Form
    {
        public Menuprof()
        {
            InitializeComponent();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            var menu = new AlterarNota();
            this.Hide();
            menu.Show();
        }

        private void btn_cadaluno_Click(object sender, EventArgs e)
        {
            var menu = new CadastroNota();
            this.Hide();
            menu.Show();
        }

        private void btn_excluiraluno_Click(object sender, EventArgs e)
        {
            var menu = new ExcluirNota();
            this.Hide();
            menu.Show();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var menu = new Menu();
            this.Hide();
            menu.Show();
        }
    }
}
