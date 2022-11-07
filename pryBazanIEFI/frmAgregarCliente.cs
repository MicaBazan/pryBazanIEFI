﻿using System;
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
using System.Security.Policy;

namespace pryBazanIEFI
{
    public partial class frmAgregarCliente : Form
    {
        string ruta = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=BD_Clientes.accdb";
        int[] vecDni = new int[100];
        public frmAgregarCliente()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            int indice = 0;
            string barrio = lstBarrio.Text;
            int codigo = Convert.ToInt32(txtDni.Text);
            string actividad = lstActividad.Text;

            OleDbConnection conexion = new OleDbConnection(ruta);
            conexion.Open();

            string insert = "INSERT INTO Socio(Dni_Socio,Nombre_Apellido,Direccion,Codigo_Barrio,Codigo_Actividad,Saldo)" +
                "VALUES(@Dni, @Nombre, @Direccion, @Barrio, @Actividad, @Saldo)";



            //Muevo los DNI a un vector
            string selectDNI = "SELECT Dni_Socio FROM Socio";
            OleDbCommand cmdDNI = new OleDbCommand(selectDNI, conexion);

            OleDbDataReader objLector = cmdDNI.ExecuteReader();

            while(objLector.Read())
            {
                vecDni[indice] = Convert.ToInt32(objLector[0]);
                indice++;
            }


            //Verifica que no se agrege el mismo DNI 
            if(vecDni.Contains(codigo))
            {
                MessageBox.Show("Verifique el numero de DNI", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                interfazInicial();
            }
            else
            {


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
            interfazInicial();
            txtDni.Focus();   
        }


        private void interfazInicial()
        {
            txtDni.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtSaldo.Text = "";
            lstBarrio.SelectedIndex = -1;
            lstActividad.SelectedIndex = -1;

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

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true; 
            }
        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtDni_TextChanged_1(object sender, EventArgs e)
        {
            validar();
        }
    }
}
