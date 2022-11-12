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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAgregarCliente().ShowDialog();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmBusqueda().ShowDialog();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmBusqueda().ShowDialog();
        }

        private void darDeBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmBusqueda().ShowDialog();
        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmClientesTotal().ShowDialog();
        }

        private void listadoDeSaldoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmClientesSaldo().ShowDialog();
        }

        private void listadoDeClientesPorBarrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmClientesBarrio().ShowDialog();
        }

        private void listadoDeClientesPorActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmClientesActividad().ShowDialog();
        }

        private void consultaDeUnClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmConsultaUnCliente().ShowDialog();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmAgregarBarrio().ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmBajaBarrio().ShowDialog();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new frmAgregarActividad().ShowDialog();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmBajaActividad().ShowDialog();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void modificarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
