using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Livraria
{
    public partial class Menu4 : Form
    {
        public Menu4()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastroLivro_Click(object sender, EventArgs e)
        {
            CadastroLivro cadastroLivro = new CadastroLivro();
            cadastroLivro.Show();
            this.Hide();
        }

        private void btnConsultarLivro_Click(object sender, EventArgs e)
        {
            ConsultaLivros consultaLivros = new ConsultaLivros();
            consultaLivros.Show();
            this.Hide();
        }
    }
}
