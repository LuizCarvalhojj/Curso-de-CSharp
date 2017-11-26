using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtótipoPortaria
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTN_Entrar_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();

        }

        private void TXT_Usuario_Enter(object sender, EventArgs e)
        {
            if (TXT_Usuario.Text == "Usuário")
            {
                TXT_Usuario.Text = "";
                TXT_Usuario.ForeColor = Color.Black;

            }
        }

        private void TXT_Usuario_Leave(object sender, EventArgs e)
        {
            if (TXT_Usuario.Text == "")
            {
                TXT_Usuario.Text = "Usuário";
                TXT_Usuario.ForeColor = Color.Silver;

            }

        }

        private void TXT_Senha_Enter(object sender, EventArgs e)
        {
            if (TXT_Senha.Text == "Senha")
            {
                TXT_Senha.Text = "";
                TXT_Senha.ForeColor = Color.Black;

            }

        }

        private void TXT_Senha_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TXT_Senha.Text))
                TXT_Senha.PasswordChar = '\0';

            if (TXT_Senha.Text == "")
            {
                TXT_Senha.Text = "Senha";
                TXT_Senha.ForeColor = Color.Silver;
            }

        }

        private void TXT_Senha_TextChanged(object sender, EventArgs e)
        {
            if (TXT_Senha.Text != "Senha")
                TXT_Senha.PasswordChar = '*';
        }
    }
}
