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
    }
}
