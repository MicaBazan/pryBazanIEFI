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
    public partial class frmAgregarActividad : Form
    {
        string ruta = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=BD_Clientes.accdb";
        int[] vecCodigo = new int[100];
        OleDbConnection conexion = new OleDbConnection();
        public frmAgregarActividad()
        {
            InitializeComponent();
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            string nombre = txtNombre.Text;

            conexion.ConnectionString = ruta;
            conexion.Open();
            string insert = "INSERT INTO Actividad(Codigo_Actividad,Detalle) VALUES(@Codigo, @Detalle)";

            if(vecCodigo.Contains(codigo))
            {
                MessageBox.Show("Este código ya se encuentra registrado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            else
            {
                OleDbCommand cmd = new OleDbCommand(insert, conexion);
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@Detalle", nombre);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Actividad registrada", "Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            conexion.Close();

        }

        private void moverVector()
        {
            int indice = 0;
            conexion.ConnectionString = ruta;

            string selectCodigo = "SELECT Codigo_Actividad FROM Actividad";
            OleDbCommand cmdCodigo = new OleDbCommand(selectCodigo, conexion);

            conexion.Open();

            OleDbDataReader objLector = cmdCodigo.ExecuteReader();

            while (objLector.Read())
            {
                vecCodigo[indice] = Convert.ToInt32(objLector[0]);
                indice++;
            }

            conexion.Close();
        }

        private void frmAgregarActividad_Load(object sender, EventArgs e)
        {
            moverVector();
            btnAgregar.Enabled = false;
        }

        private void limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
        }

        private void validar()
        {
            if(txtCodigo.Text != string.Empty && txtNombre.Text != string.Empty)
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            validar();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            validar();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
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
                if (e.KeyChar != (char)Keys.Space)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
