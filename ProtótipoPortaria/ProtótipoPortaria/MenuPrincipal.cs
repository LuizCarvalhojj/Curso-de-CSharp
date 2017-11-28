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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frmlog = new frmLogin();
            frmlog.Show();
            this.Close();
        }

        private void cadastroDeCondomimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCondôminos frmcadastroCond = new frmCadastroCondôminos();
            frmcadastroCond.ShowDialog();
        }

        private void cadastroDeVisitantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroVisitantes cadastrovisit = new frmCadastroVisitantes();
            cadastrovisit.ShowDialog();
        }

        private void veículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroVeículos cadastrovei = new frmCadastroVeículos();
            cadastrovei.ShowDialog();
        }

        private void reservaDeÁreaComumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReservararea reservaarea = new frmReservararea();
            reservaarea.ShowDialog();
        }

        private void verificarDisponibilidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarArea consultaarea = new frmConsultarArea();
            consultaarea.ShowDialog();
        }

        private void visitantesAutorizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisitantesAutori visitauto = new frmVisitantesAutori();
            visitauto.ShowDialog();
        }

        private void prestadoresDeServiçoAutorizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrestadoresAutorizados prestadorauto = new frmPrestadoresAutorizados();
            prestadorauto.ShowDialog();
        }
    }
}
