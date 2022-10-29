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

            OleDbConnection conexion = new OleDbConnection(ruta);

            string cadenaGimnasio = "Select * From Socio Where Dni_Socio=" + codigo;

            OleDbDataAdapter adaptadorGimnasio = new OleDbDataAdapter(cadenaGimnasio, conexion);

            DataSet dataSetGimnasio = new DataSet();

            conexion.Open();

            adaptadorGimnasio.Fill(dataSetGimnasio);

            conexion.Close();


            if (dataSetGimnasio.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Lo siento el código ingresado no existe", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataSetGimnasio.Dispose();
                return;
            }
            else
            {
                txtNombre.Text = dataSetGimnasio.Tables[0].Rows[0]["Nombre_Apellido"].ToString();
                txtDireccion.Text = dataSetGimnasio.Tables[0].Rows[0]["Direccion"].ToString();
                lstBarrio.Text = dataSetGimnasio.Tables[0].Rows[0]["Codigo_Barrio"].ToString();
                buscarBarrio();
                lstActividad.Text = dataSetGimnasio.Tables[0].Rows[0]["Codigo_Actividad"].ToString();
                buscarActividad();
                txtSaldo.Text = dataSetGimnasio.Tables[0].Rows[0]["Saldo"].ToString();
                dataSetGimnasio.Dispose();

                return;
            }
        }

        private void buscarBarrio()
        {
            string barrio = lstBarrio.Text;

            OleDbConnection conexion = new OleDbConnection(ruta);
            string cadenaBarrio = "Select * From Tabla_Barrio Where Codigo_Barrio=" + Convert.ToString(barrio);
            OleDbDataAdapter adaptadorBarrio = new OleDbDataAdapter(cadenaBarrio, conexion);
            DataSet dataSetBarrio = new DataSet();
            conexion.Open();
            adaptadorBarrio.Fill(dataSetBarrio);
            conexion.Close();

            if(dataSetBarrio.Tables[0].Rows.Count == 0)
            {
                dataSetBarrio.Dispose();
                return;
            }
            else
            {
                lstBarrio.Text = dataSetBarrio.Tables[0].Rows[0]["Nombre_Barrio"].ToString();
                dataSetBarrio.Dispose();
                return;
            }
        }

        private void buscarActividad()
        {
            string actividad = lstActividad.Text;

            OleDbConnection conexion = new OleDbConnection(ruta);
            string cadenaActividad = "Select * From Actividad Where Codigo_Actividad=" + Convert.ToString(actividad);
            OleDbDataAdapter adaptadorActividad = new OleDbDataAdapter(cadenaActividad, conexion);
            DataSet dataSetActividad = new DataSet();
            conexion.Open();
            adaptadorActividad.Fill(dataSetActividad);
            conexion.Close();

            if(dataSetActividad.Tables[0].Rows.Count == 0)
            {
                dataSetActividad.Dispose();
                return;
            }
            else
            {
                lstActividad.Text = dataSetActividad.Tables[0].Rows[0]["Detalle"].ToString();
                dataSetActividad.Dispose();
                return;
            }
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
            txtNombre.Enabled = false;
            agregarListas();
            buscar();
        }

        private void interfaz_Inicial()
        {
            txtNombre.Enabled = false;
            txtDireccion.Enabled = false;
            lstBarrio.Enabled = false;
            lstActividad.Enabled = false;
            txtSaldo.Enabled = false;

            btnGuardar.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection(ruta);
            string update = "UPDATE Socio SET Nombre_Apellido=@Nombre,Direccion=@Direccion,Codigo_Barrio=@Barrio,Codigo_Actividad=@Actividad,Saldo=@Saldo WHERE Dni_Socio=@Codigo";
            

            try
            {
                OleDbCommand cmd = new OleDbCommand(update, conexion);

                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);




                string ltBarrio = lstBarrio.Text;

                string selectBarrio = "Select * From Tabla_Barrio Where Nombre_Barrio='" + ltBarrio + "'";
                OleDbDataAdapter adaptadorBarrio = new OleDbDataAdapter(selectBarrio, conexion);
                DataSet ds = new DataSet();
                conexion.Open();
                adaptadorBarrio.Fill(ds);
                conexion.Close();

                if (ds.Tables[0].Rows.Count == 0)
                {
                    ds.Dispose();
                    return;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Barrio", "Codigo_Barrio");
                    ds.Dispose();
                    return;
                }




                //cmd.Parameters.AddWithValue("@Barrio", lstBarrio.Text);
                //cmd.Parameters.AddWithValue("@Actividad", lstActividad.Text);



                string ltActividad = lstBarrio.Text;

                string selectActividad = "Select * From Tabla_Barrio Where Nombre_Barrio=" + ltActividad;
                OleDbDataAdapter adaptadorActividad = new OleDbDataAdapter(selectActividad, conexion);
                DataSet dsActividad = new DataSet();
                conexion.Open();
                adaptadorActividad.Fill(ds);
                conexion.Close();

                if (ds.Tables[0].Rows.Count == 0)
                {
                    ds.Dispose();
                    return;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Actividad", lstActividad.Text);
                    ds.Dispose();
                    return;
                }








                cmd.Parameters.AddWithValue("@Saldo", txtSaldo.Text);

                cmd.Parameters.AddWithValue("@Codigo", txtCodigo.Text);
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                interfaz_Inicial();
                MessageBox.Show("Registro Actualizado Existosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Close();
                interfaz_Inicial();
            }

        }

        private void modificarBarrio()
        {
            string ltBarrio = lstBarrio.Text;
            OleDbConnection conexion = new OleDbConnection(ruta);

            string select = "Select * From Tabla_Barrio Where Nombre_Barrio=" + ltBarrio;
            OleDbDataAdapter Adaptador = new OleDbDataAdapter(select, conexion);
            DataSet ds = new DataSet();
            conexion.Open();
            Adaptador.Fill(ds);
            conexion.Close();

            if (ds.Tables[0].Rows.Count == 0)
            {
                ds.Dispose();
                return;
            }
            else
            {
                //cmd.Parameters.AddWithValue("@Barrio", lstBarrio.Text);
                ds.Dispose();
                return;
            }
        }

        private void modificarActividad()
        {
            string ltActividad = lstBarrio.Text;
            OleDbConnection conexion = new OleDbConnection(ruta);

            string select = "Select * From Tabla_Barrio Where Nombre_Barrio=" + ltActividad;
            OleDbDataAdapter Adaptador = new OleDbDataAdapter(select, conexion);
            DataSet ds = new DataSet();
            conexion.Open();
            Adaptador.Fill(ds);
            conexion.Close();

            if (ds.Tables[0].Rows.Count == 0)
            {
                ds.Dispose();
                return;
            }
            else
            {
                //lstActividad = ds.Tables[0].Rows[0]["Codigo_Actividad"].ToString();
                ds.Dispose();
                return;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String codigo = txtCodigo.Text;

            OleDbConnection conexion = new OleDbConnection(ruta);
            string delete = "DELETE FROM Socio WHERE Dni_Socio=" + codigo;
            OleDbCommand cmd = new OleDbCommand(delete, conexion);
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
            interfaz_Inicial();
            MessageBox.Show("Registro Eliminado Existosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiar();
        }
    }
}
