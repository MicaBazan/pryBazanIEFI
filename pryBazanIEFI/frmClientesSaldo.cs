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
    public partial class frmClientesSaldo : Form
    {
        string ruta = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=BD_Clientes.accdb";

        public frmClientesSaldo()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listar();
            totalSaldos();
            cantidadDeClientes();


            string promedio;
            int total = Convert.ToInt32(lblTotal.Text);
            int clientes = Convert.ToInt32(lblClientes.Text);


            promedio = Convert.ToString(total / clientes);

            lblPromedio.Text = promedio;
            
        }

        private void listar()
        {
            OleDbConnection conexion = new OleDbConnection(ruta);

            conexion.Open();

            DataTable dt = new DataTable();

            string select = "SELECT Dni_Socio, Nombre_Apellido, Saldo FROM Socio";

            OleDbCommand cmd = new OleDbCommand(select, conexion);

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);

            da.SelectCommand = cmd;

            da.Fill(dt);

            dgvDuedas.DataSource = dt;

            conexion.Close();

        }

        private void totalSaldos()
        {
            double total = 0;

            foreach(DataGridViewRow row in dgvDuedas.Rows)
            {
                total += Convert.ToDouble(row.Cells["Saldo"].Value);
            }

            lblTotal.Text = Convert.ToString(total);
        }

        private void cantidadDeClientes()
        {
            int cantidadRegistros = dgvDuedas.Rows.Count;
            lblClientes.Text = cantidadRegistros.ToString();
        }

        private void frmClientesSaldo_Load(object sender, EventArgs e)
        {
           
        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
