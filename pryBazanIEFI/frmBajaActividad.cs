using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBazanIEFI
{
    public partial class frmBajaActividad : Form
    {
        string ruta = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=BD_Clientes.accdb";
        OleDbConnection conexion = new OleDbConnection();

        public frmBajaActividad()
        {
            InitializeComponent();
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmBajaActividad_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            agregarListas();
            lstActividad.SelectedIndex = -1;
        }

        private void lstActividad_TextChanged(object sender, EventArgs e)
        {
            if(lstActividad.Text != string.Empty)
            {
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string actividad = lstActividad.Text;
            conexion.ConnectionString = ruta;

            string delete = "DELETE FROM Actividad WHERE Detalle='" + actividad + "'";
            OleDbCommand cmd = new OleDbCommand(delete, conexion);
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Actividad Eliminada Existosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lstActividad.SelectedIndex = -1;
        }

        private void agregarListas()
        {
            conexion.ConnectionString = ruta;
            conexion.Open();

            DataTable tablaActividad = new DataTable();
            string selectActividad = "Select * From Actividad";
            OleDbCommand cmdActividad = new OleDbCommand(selectActividad, conexion);
            OleDbDataAdapter daActividad = new OleDbDataAdapter(cmdActividad);
            daActividad.SelectCommand = cmdActividad;
            daActividad.Fill(tablaActividad);
            lstActividad.DisplayMember = "Detalle";
            lstActividad.ValueMember = "Codigo_Actividad";
            lstActividad.DataSource = tablaActividad;

            conexion.Close();
        }
    }
}
