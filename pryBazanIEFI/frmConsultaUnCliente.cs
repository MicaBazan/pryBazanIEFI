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

            string select = "SELECT * FROM Socio";

            conexion.Open();
            OleDbCommand cmd = new OleDbCommand(select, conexion);
            OleDbDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                if (Convert.ToString(reader["Nombre_Apellido"]) == nombre)
                {
                    lblActividad.Text = Convert.ToString(reader["Codigo_Actividad"]);
                    buscarActividad();
                    lblSaldo.Text = Convert.ToString(reader["Saldo"]);
                }
            }

            conexion.Close();
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
            string cadenaActividad = "Select * From Actividad";

            OleDbCommand commandActividad = new OleDbCommand(cadenaActividad, conexion);
            OleDbDataReader lectorActividad = commandActividad.ExecuteReader();

            while (lectorActividad.Read())
            {
                if (Convert.ToString(lectorActividad["Codigo_Actividad"]) == actividad)
                {
                    lblActividad.Text = Convert.ToString(lectorActividad["Detalle"]);
                }
            }
        }
    }
}
