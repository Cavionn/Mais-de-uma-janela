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
    public partial class frmCadastro : Form
    {
        public frmCadastro(Contato? contato = null)
        {
            InitializeComponent();

            if(contato != null)
            {
                txtNome.Text = contato.nome;
                txtTelefone.Text = contato.telefone;
                txtEmail.Text = contato.email;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
