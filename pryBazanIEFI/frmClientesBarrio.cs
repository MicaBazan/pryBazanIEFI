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
        OleDbConnection conexion = new OleDbConnection();
        public frmClientesBarrio()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            string barrio = lstBarrio.Text;
            string codBarrio = null;

            conexion.ConnectionString = ruta;
            conexion.Open();

            //Buscar Código Barrio
            string selectBarrio = "SELECT * FROM Tabla_Barrio";

            OleDbCommand commandBarrio = new OleDbCommand(selectBarrio, conexion);
            OleDbDataReader lectorBarrio = commandBarrio.ExecuteReader();

            while(lectorBarrio.Read())
            {
                if (Convert.ToString(lectorBarrio["Nombre_Barrio"]) == barrio)
                {
                    codBarrio = Convert.ToString(lectorBarrio["Codigo_Barrio"]);
                }
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
            conexion.ConnectionString = ruta;
            conexion.Open();
            DataTable tablaBarrio = new DataTable();
            string selectBarrio = "Select * From Tabla_Barrio";
            OleDbCommand cmdBarrio = new OleDbCommand(selectBarrio, conexion);
            OleDbDataAdapter daBarrio = new OleDbDataAdapter(cmdBarrio);
            daBarrio.SelectCommand = cmdBarrio;
            daBarrio.Fill(tablaBarrio);
            lstBarrio.DisplayMember = "Nombre_Barrio";
            lstBarrio.ValueMember = "Codigo_Barrio";
            lstBarrio.DataSource = tablaBarrio;
            conexion.Close();
        }

        private void frmClientesBarrio_Load(object sender, EventArgs e)
        {
            listarBarrio();
            lstBarrio.SelectedIndex = -1;
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
