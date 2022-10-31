using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryBazanIEFI
{
    public partial class frmAgregarCliente : Form
    {
        string ruta = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=BD_Clientes.accdb";
        public frmAgregarCliente()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection(ruta);
            conexion.Open();

            string insert = "INSERT INTO Socio(Dni_Socio,Nombre_Apellido,Direccion,Codigo_Barrio,Codigo_Actividad,Saldo)" +
                "VALUES(@Dni, @Nombre, @Direccion, @Barrio, @Actividad, @Saldo)";

            OleDbCommand cmd = new OleDbCommand(insert, conexion);

            if()
            {

            }
            else
            {
                cmd.Parameters.AddWithValue("@Dni", txtDni.Text);
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                cmd.Parameters.AddWithValue("@Barrio", lstBarrio.Text);
                cmd.Parameters.AddWithValue("@Actividad", lstActividad.Text);
                cmd.Parameters.AddWithValue("@Saldo", txtSaldo.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Socio registrado", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
          
            conexion.Close(); 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void limpiar()
        {
            txtDni.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            lstBarrio.Text = "";
            lstActividad.Text = "";
            txtSaldo.Text = "";
        }

        private void agregarListas()
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


            OleDbConnection conexionActividad = new OleDbConnection(ruta);
            conexionActividad.Open();
            DataTable tablaActividad = new DataTable();
            string selectActividad = "Select * From Actividad";
            OleDbCommand cmdActividad = new OleDbCommand(selectActividad, conexionActividad);
            OleDbDataAdapter daActividad = new OleDbDataAdapter(cmdActividad);
            daActividad.SelectCommand = cmdActividad;
            daActividad.Fill(tablaActividad);
            lstActividad.DisplayMember = "Detalle";
            lstActividad.ValueMember = "Codigo_Actividad";
            lstActividad.DataSource = tablaActividad;
            conexionActividad.Close();
        }

        private void frmAgregarCliente_Load(object sender, EventArgs e)
        {
            agregarListas();
        }
    }
}
