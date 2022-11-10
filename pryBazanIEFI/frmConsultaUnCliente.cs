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
    public partial class frmConsultaUnCliente : Form
    {
        string ruta = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=BD_Clientes.accdb";
        OleDbConnection conexion = new OleDbConnection();

        public frmConsultaUnCliente()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string nombre = lstNombre.Text;

            conexion.ConnectionString = ruta;

            string select = "SELECT * FROM Socio WHERE Nombre_Apellido='" + nombre + "'";

            OleDbDataAdapter da = new OleDbDataAdapter(select, conexion);

            DataSet ds = new DataSet();

            conexion.Open();

            da.Fill(ds);

            conexion.Close();

            if (ds.Tables[0].Rows.Count == 0)
            {
                ds.Dispose();
                return;
            }
            else
            {
                lblActividad.Text = ds.Tables[0].Rows[0]["Codigo_Actividad"].ToString();
                buscarActividad();
                lblSaldo.Text = ds.Tables[0].Rows[0]["Saldo"].ToString();
                ds.Dispose();

                return;
            }
        }

        private void listarNombre()
        {
            conexion.ConnectionString = ruta;
            
            DataTable dt = new DataTable();
            string selectBarrio = "Select * From Socio";
            OleDbCommand cmdBarrio = new OleDbCommand(selectBarrio, conexion);
            OleDbDataAdapter daBarrio = new OleDbDataAdapter(cmdBarrio);
            daBarrio.SelectCommand = cmdBarrio;
            conexion.Open();
            daBarrio.Fill(dt);
            conexion.Close();
            lstNombre.DisplayMember = "Nombre_Apellido";
            lstNombre.ValueMember = "Dni_Socio";
            lstNombre.DataSource = dt;
            
        }

        private void frmConsultaUnCliente_Load(object sender, EventArgs e)
        {
            listarNombre();
            lstNombre.SelectedIndex = -1;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buscarActividad()
        {
            string actividad = lblActividad.Text;

            conexion.ConnectionString = ruta;
            string cadenaActividad = "Select * From Actividad Where Codigo_Actividad=" + Convert.ToString(actividad);
            OleDbDataAdapter adaptadorActividad = new OleDbDataAdapter(cadenaActividad, conexion);
            DataSet dataSetActividad = new DataSet();
            conexion.Open();
            adaptadorActividad.Fill(dataSetActividad);
            conexion.Close();

            if (dataSetActividad.Tables[0].Rows.Count == 0)
            {
                dataSetActividad.Dispose();
                return;
            }
            else
            {
                lblActividad.Text = dataSetActividad.Tables[0].Rows[0]["Detalle"].ToString();
                dataSetActividad.Dispose();
                return;
            }
        }
    }
}
