using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace open_close_propriedades_e_funçoes
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastro1_Click(object sender, EventArgs e)
        {

            frmCadastro frmCadastro = new frmCadastro();
            frmCadastro.Show();
        }

        private void btnCadastro2_Click(object sender, EventArgs e)
        {
            frmCadastro frmCadastro = new frmCadastro();
            frmCadastro.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Considere objeto lido do DataGridView
            Contato contato = new Contato();
            contato.nome = "Maria";
            contato.email = "marial@gmail.com";
            contato.telefone = "(54) 99999-8888";

            frmCadastro frmCadastro = new frmCadastro(contato);
            frmCadastro.FormClosed += (s, args) => AtualizarGrid();
            frmCadastro.ShowDialog();
        }

        private void AtualizarGrid()
        {
            MessageBox.Show("GRID ATUALIZADA!");
        }
    }
}
