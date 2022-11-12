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
    public partial class frmAgregarBarrio : Form
    {
        string ruta = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=BD_Clientes.accdb";
        int[] vecCodigo = new int[100];
        OleDbConnection conexion = new OleDbConnection();
        public frmAgregarBarrio()
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
            string insert = "INSERT INTO Tabla_Barrio(Codigo_Barrio,Nombre_Barrio) VALUES(@Codigo, @Nombre)";

            if (vecCodigo.Contains(codigo))
            {
                MessageBox.Show("Este código ya se encuentra registrado", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            else
            {
                OleDbCommand cmd = new OleDbCommand(insert, conexion);
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@Nombre", nombre);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Barrio registrado", "Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            conexion.Close();
        }

        private void moverVector()
        {
            int indice = 0;

            conexion.ConnectionString = ruta;

            string select = "SELECT Codigo_Barrio FROM Tabla_Barrio";
            OleDbCommand cmd = new OleDbCommand(select, conexion);

            conexion.Open();

            OleDbDataReader objLector = cmd.ExecuteReader();

            while (objLector.Read())
            {
                vecCodigo[indice] = Convert.ToInt32(objLector[0]);
                indice++;
            }

            conexion.Close();

        }

        private void frmAgregarBarrio_Load(object sender, EventArgs e)
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
            if (txtCodigo.Text != string.Empty && txtNombre.Text != string.Empty)
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
