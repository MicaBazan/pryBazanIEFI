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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            string barrio = lstBarrio.Text;
            string codigo = txtDni.Text;
            string actividad = lstActividad.Text;

            OleDbConnection conexion = new OleDbConnection(ruta);
            conexion.Open();

            string insert = "INSERT INTO Socio(Dni_Socio,Nombre_Apellido,Direccion,Codigo_Barrio,Codigo_Actividad,Saldo)" +
                "VALUES(@Dni, @Nombre, @Direccion, @Barrio, @Actividad, @Saldo)";

            OleDbCommand cmd = new OleDbCommand(insert, conexion);

         
            cmd.Parameters.AddWithValue("@Dni", txtDni.Text);
            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);






            //Busca el codigo de barrio
            string selectBarrio = "SELECT * FROM Tabla_Barrio WHERE Nombre_Barrio='" + barrio + "'";

            OleDbDataAdapter adapterBarrio = new OleDbDataAdapter(selectBarrio, conexion);

            DataSet dtBarrio = new DataSet();

            adapterBarrio.Fill(dtBarrio);


            if (dtBarrio.Tables[0].Rows.Count == 0)
            {
                dtBarrio.Dispose();
                return;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Barrio", (dtBarrio.Tables[0].Rows[0]["Codigo_Barrio"].ToString()));
                dtBarrio.Dispose();
            }



            //Busca el código de actividad
            string selectactividad = "SELECT * FROM Actividad WHERE Detalle='" + actividad + "'";

            OleDbDataAdapter adapterActividad = new OleDbDataAdapter(selectactividad, conexion);

            DataSet dtActividad = new DataSet();

            adapterActividad.Fill(dtActividad);

            if (dtActividad.Tables[0].Rows.Count == 0)
            {
                dtActividad.Dispose();
                return;
            }
            else
            {
                cmd.Parameters.AddWithValue("@Actividad", (dtActividad.Tables[0].Rows[0]["Codigo_Actividad"].ToString()));
            }



            cmd.Parameters.AddWithValue("@Saldo", txtSaldo.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Socio registrado", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar();
          
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
            interfazInicial();
        }


        private void interfazInicial()
        {
            txtDni.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            lstBarrio.Text = "";
            lstActividad.Text = "";
            txtSaldo.Text = "";

            txtDni.Focus();
        }


        private void validar()
        {
            if (txtDni.Text != string.Empty && txtNombre.Text != string.Empty && txtDireccion.Text != string.Empty && txtSaldo.Text !=
                string.Empty && lstActividad.Text != string.Empty && lstBarrio.Text != string.Empty)
            {
                btnCargar.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;
            }
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            validar();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            validar();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            validar();
        }

        private void lstBarrio_TextChanged(object sender, EventArgs e)
        {
            validar();
        }

        private void lstActividad_TextChanged(object sender, EventArgs e)
        {
            validar();
        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {
            validar();
        }
    }
}
