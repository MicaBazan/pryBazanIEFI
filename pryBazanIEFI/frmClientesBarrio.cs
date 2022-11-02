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
    public partial class frmClientesBarrio : Form
    {
        string ruta = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=BD_Clientes.accdb";
        public frmClientesBarrio()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string barrio = lstBarrio.Text;
            string codBarrio;

            OleDbConnection conexion = new OleDbConnection(ruta);
            conexion.Open();

            //Buscar Código Barrio
            string selectBarrio = "SELECT * FROM Tabla_Barrio WHERE Nombre_Barrio='" + barrio + "'";
            OleDbDataAdapter daBarrio = new OleDbDataAdapter(selectBarrio, conexion);
            DataSet dsBarrio = new DataSet();
            daBarrio.Fill(dsBarrio);

            if (dsBarrio.Tables[0].Rows.Count == 0)
            {
                dsBarrio.Dispose();
                return;
            }
            else
            {
                codBarrio = dsBarrio.Tables[0].Rows[0]["Codigo_Barrio"].ToString();
            }

            //Mover a la Grilla
            DataTable dt = new DataTable();
            string selectdgv = "SELECT Dni_Socio, Nombre_Apellido FROM Socio WHERE Codigo_Barrio=" + codBarrio;
            OleDbCommand cmd = new OleDbCommand(selectdgv, conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.SelectCommand = cmd;
            da.Fill(dt);
            dgvClientes.DataSource = dt;

            conexion.Close();

        }

        private void listarBarrio()
        {
            OleDbConnection conexionBarrio = new OleDbConnection(ruta);
            conexionBarrio.Open();
            DataTable tablaBarrio = new DataTable();
            string selectBarrio = "Select * From Tabla_Barrio";
            OleDbCommand cmdBarrio = new OleDbCommand(selectBarrio, conexionBarrio);
            OleDbDataAdapter daBarrio = new OleDbDataAdapter(cmdBarrio);
            daBarrio.SelectCommand = cmdBarrio;
            daBarrio.Fill(tablaBarrio);
            lstBarrio.DisplayMember = "Nombre_Barrio";
            lstBarrio.ValueMember = "Codigo_Barrio";
            lstBarrio.DataSource = tablaBarrio;
            conexionBarrio.Close();
        }

        private void frmClientesBarrio_Load(object sender, EventArgs e)
        {
            listarBarrio();
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
