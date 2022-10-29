using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBazanIEFI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void agregarNuevosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAgregarCliente().ShowDialog();
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmBusqueda().ShowDialog();
        }

        private void modiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmBusqueda().ShowDialog();
        }

        private void darDeBajaAClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmBusqueda().ShowDialog();
        }

        private void listadoDeClientesDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmClientesSaldo().ShowDialog();
        }

        private void listadoDeClientesDeUnBarrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmClientesBarrio().ShowDialog();
        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmClientesTotal().ShowDialog();
        }

        private void consultaDeUnClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmClientesActividad().ShowDialog();
        }

        private void consultaDeUnClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmConsultaUnCliente().ShowDialog();
        }
    }
}
