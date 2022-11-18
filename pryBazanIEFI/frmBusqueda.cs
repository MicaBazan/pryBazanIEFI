using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBazanIEFI
{
    public partial class frmBusqueda : Form
    {
        string ruta = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=BD_Clientes.accdb";
        

        public frmBusqueda()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar()
        {
            string codigo = txtCodigo.Text;
            string cadenaGimnasio = "Select * From Socio";

            OleDbConnection conexion = new OleDbConnection(ruta);
            conexion.Open();
            OleDbCommand command = new OleDbCommand(cadenaGimnasio, conexion);
            OleDbDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                if(Convert.ToString(reader["Dni_Socio"]) == codigo)
                {
                    txtNombre.Text = Convert.ToString(reader["Nombre_Apellido"]);
                    txtDireccion.Text = Convert.ToString(reader["Direccion"]);
                    lstBarrio.Text = Convert.ToString(reader["Codigo_Barrio"]);
                    buscarBarrio();
                    lstActividad.Text = Convert.ToString(reader["Codigo_Actividad"]);
                    buscarActividad();
                    txtSaldo.Text = Convert.ToString(reader["Saldo"]);

                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;
                }
            }
            conexion.Close();
        }

        private void buscarBarrio()
        {
            string barrio = lstBarrio.Text;
            string cadenaBarrio = "Select * From Tabla_Barrio";

            OleDbConnection conexion = new OleDbConnection(ruta);

            OleDbCommand commandBarrio = new OleDbCommand(cadenaBarrio, conexion);
            conexion.Open();
            OleDbDataReader lectorBarrio = commandBarrio.ExecuteReader();

            

            while(lectorBarrio.Read())
            {
                if (Convert.ToString(lectorBarrio["Codigo_Barrio"]) == barrio)
                {
                    lstBarrio.Text = Convert.ToString(lectorBarrio["Nombre_Barrio"]);
                }
            }

            conexion.Close();
        }

        private void buscarActividad()
        {
            string actividad = lstActividad.Text;
            string cadenaActividad = "Select * From Actividad";

            OleDbConnection conexion = new OleDbConnection(ruta);

            OleDbCommand commandActividad = new OleDbCommand(cadenaActividad, conexion);
            conexion.Open();
            OleDbDataReader lectorActividad = commandActividad.ExecuteReader();

            while (lectorActividad.Read())
            {
                if (Convert.ToString(lectorActividad["Codigo_Actividad"]) == actividad)
                {
                    lstActividad.Text = Convert.ToString(lectorActividad["Detalle"]);
                }
            }

            conexion.Close();
        }

        private void agregarListas()
        {
            OleDbConnection conexion = new OleDbConnection(ruta);
            conexion.Open();

            //Agregar listas barrio
            DataTable tablaBarrio = new DataTable();
            string selectBarrio = "Select * From Tabla_Barrio";
            OleDbCommand cmdBarrio = new OleDbCommand(selectBarrio, conexion);
            OleDbDataAdapter daBarrio = new OleDbDataAdapter(cmdBarrio);
            daBarrio.SelectCommand = cmdBarrio;
            daBarrio.Fill(tablaBarrio);
            lstBarrio.DisplayMember = "Nombre_Barrio";
            lstBarrio.ValueMember = "Codigo_Barrio";
            lstBarrio.DataSource = tablaBarrio;
            

            //Agregar listas actividad
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


        private void limpiar()
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            lstBarrio.Text = "";
            lstActividad.Text = "";
            txtSaldo.Text = "";
        }


        private void habilitar()
        {
            txtNombre.Enabled = true;
            txtDireccion.Enabled = true;
            lstBarrio.Enabled = true;
            lstActividad.Enabled = true;
            txtSaldo.Enabled = true;

            btnGuardar.Enabled = true;
        }

        private void frmBusqueda_Load(object sender, EventArgs e)
        {
            interfaz_Inicial();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            habilitar();
            txtCodigo.Enabled = false;
            agregarListas();
            buscar();
        }

        private void interfaz_Inicial()
        {
            txtCodigo.Enabled = true;
            txtNombre.Enabled = false;
            txtDireccion.Enabled = false;
            lstBarrio.Enabled = false;
            lstActividad.Enabled = false;
            txtSaldo.Enabled = false;

            btnGuardar.Enabled = false;
            btnBuscar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string dni = txtCodigo.Text;
            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string barrio = lstBarrio.Text;
            string actividad = lstActividad.Text;
            string saldo = txtSaldo.Text;

            OleDbConnection conexion = new OleDbConnection(ruta);
            string update = "UPDATE Socio SET Nombre_Apellido=@Nombre,Direccion=@Direccion,Codigo_Barrio=@Barrio,Codigo_Actividad=@Actividad,Saldo=@Saldo WHERE Dni_Socio=@Codigo";

            try
            {
                OleDbCommand command = new OleDbCommand(update, conexion);

                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Direccion", direccion);

                //Buscar código barrio
                string selectBarrio = "Select * From Tabla_Barrio";

                conexion.Open();
                OleDbCommand commandBarrio = new OleDbCommand(selectBarrio, conexion);
                OleDbDataReader lectorBarrio = commandBarrio.ExecuteReader();

                while(lectorBarrio.Read())
                {
                    if (Convert.ToString(lectorBarrio["Nombre_Barrio"]) == barrio)
                    {
                        command.Parameters.AddWithValue("@Barrio", lectorBarrio["Codigo_Barrio"]);
                    }
                }

                //Buscar código actividad
                string selectactividad = "SELECT * FROM Actividad";

                OleDbCommand commandActividad = new OleDbCommand(selectactividad, conexion);
                OleDbDataReader lectorActividad = commandActividad.ExecuteReader();

                while(lectorActividad.Read())
                {
                    if (Convert.ToString(lectorActividad["Detalle"]) == actividad)
                    {
                        command.Parameters.AddWithValue("@Actividad", lectorActividad["Codigo_Actividad"]);              
                    }
                }

                conexion.Close();

                command.Parameters.AddWithValue("@Saldo", saldo);
                command.Parameters.AddWithValue("@Codigo", dni);
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();

                MessageBox.Show("Registro Actualizado Existosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            interfaz_Inicial();
            txtCodigo.Text = "";
            limpiar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;

            OleDbConnection conexion = new OleDbConnection(ruta);
            string delete = "DELETE FROM Socio WHERE Dni_Socio=" + codigo;
            OleDbCommand cmd = new OleDbCommand(delete, conexion);
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
            interfaz_Inicial();
            MessageBox.Show("Registro Eliminado Existosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtCodigo.Text = "";
            limpiar();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != string.Empty)
            {
                btnBuscar.Enabled = true;
            }
            else
            {
                btnBuscar.Enabled = false;
                txtNombre.Text = "";
                txtDireccion.Text = "";
                lstActividad.Text = "";
                lstBarrio.Text = "";
                txtSaldo.Text = "";
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
        }
    }
}