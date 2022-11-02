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
    public partial class frmClientesTotal : Form
    {
        string ruta = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source= BD_Clientes.accdb";

        public frmClientesTotal()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conexion = new OleDbConnection(ruta);
                conexion.Open();

                DataTable dt = new DataTable();

                string select = @"SELECT Dni_Socio, Nombre_Apellido FROM Socio";

                OleDbCommand cmd = new OleDbCommand(select, conexion);

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                da.SelectCommand = cmd;

                da.Fill(dt);

                dgvClientes.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
