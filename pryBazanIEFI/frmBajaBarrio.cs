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
    public partial class frmBajaBarrio : Form
    {
        string ruta = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=BD_Clientes.accdb";
        OleDbConnection conexion = new OleDbConnection();
        public frmBajaBarrio()
        {
            InitializeComponent();
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string barrio = lstBarrio.Text;
            conexion.ConnectionString = ruta;

            string delete = "DELETE FROM Tabla_Barrio WHERE Nombre_Barrio='" + barrio + "'";
            OleDbCommand cmd = new OleDbCommand(delete, conexion);
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Barrio Eliminado Existosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lstBarrio.SelectedIndex = -1;
        }

        private void lstBarrio_TextChanged(object sender, EventArgs e)
        {
            if (lstBarrio.Text != string.Empty)
            {
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
            }
        }

        private void frmBajaBarrio_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            agregarLista();
            lstBarrio.SelectedIndex = -1;
        }
        
        private void agregarLista()
        {
            conexion.ConnectionString = ruta;
            conexion.Open();

            DataTable tabla = new DataTable();
            string select = "Select * From Tabla_Barrio";
            OleDbCommand cmd = new OleDbCommand(select, conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.SelectCommand = cmd;
            da.Fill(tabla);
            lstBarrio.DisplayMember = "Nombre_Barrio";
            lstBarrio.ValueMember = "Codigo_Barrio";
            lstBarrio.DataSource = tabla;

            conexion.Close();
        }
    }
}
