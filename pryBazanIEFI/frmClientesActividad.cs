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
    public partial class frmClientesActividad : Form
    {
        string ruta = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=BD_Clientes.accdb";

        public frmClientesActividad()
        {
            InitializeComponent();
        }

        private void frmClientesActividad_Load(object sender, EventArgs e)
        {
            agregarLista();
            lstActividad.Text = "";
        }

        private void agregarLista()
        {
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

        private void btnListar_Click(object sender, EventArgs e)
        {
            lblMayor.Text = "";
            string actividad = lstActividad.Text;
            string codActividad;
            

            OleDbConnection conexion = new OleDbConnection(ruta);
            conexion.Open();



            //Buscar código actividad
            string selectActividad = "SELECT * FROM Actividad WHERE Detalle='" + actividad + "'";
            OleDbDataAdapter daActividad = new OleDbDataAdapter(selectActividad, conexion); 
            DataSet dsActividad = new DataSet();
            daActividad.Fill(dsActividad);

            if(dsActividad.Tables[0].Rows.Count == 0)
            {
                dsActividad.Dispose();
                return;
            }
            else
            {
                codActividad = dsActividad.Tables[0].Rows[0]["Codigo_Actividad"].ToString();
            }



            //Mover a la grilla

            DataTable dt = new DataTable();
            string selectdgv = "SELECT Dni_Socio, Nombre_Apellido FROM Socio WHERE Codigo_Actividad=" + codActividad;
            OleDbCommand cmd = new OleDbCommand(selectdgv, conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.SelectCommand = cmd;
            da.Fill(dt);
            dgvClientes.DataSource = dt;
            



            //Busca Mayor
            try
            {
                string selectMayor = "SELECT MAX(Saldo) AS ValorMaximo FROM Socio Where Codigo_Actividad=" + codActividad;
                OleDbCommand cmdMayor = new OleDbCommand(selectMayor, conexion);
                OleDbDataAdapter daMayor = new OleDbDataAdapter(cmdMayor);

                lblMayor.Text = Convert.ToString(cmdMayor.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




            //Buscar Menor
            try
            {
                string selectMenor = "SELECT MIN(Saldo) AS ValorMinimo FROM Socio WHERE Codigo_Actividad=" + codActividad;
                OleDbCommand cmdMenor = new OleDbCommand(selectMenor, conexion);
                OleDbDataAdapter daMenor = new OleDbDataAdapter(cmdMenor);

                lblMenor.Text = Convert.ToString(cmdMenor.ExecuteScalar());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            //Sacar Promedio
            



            conexion.Close();


        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
