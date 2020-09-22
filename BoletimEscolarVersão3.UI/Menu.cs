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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void btn_aluno_Click(object sender, EventArgs e)
        {
            var menu = new ListarNotas();// tela que voce quer abrir
            this.Hide();//vai “esconder” o formulário atual
            menu.Show(); // Abre nova tela
        }

        private void btn_administrador_Click(object sender, EventArgs e)
        {
            var menuadmin = new MenuAdmin();
            this.Hide();
            menuadmin.Show();
        }

        private void btn_professor_Click(object sender, EventArgs e)
        {
            var menuprof = new CadastroNota();
            this.Hide();
            menuprof.Show();
        }
    }
}
