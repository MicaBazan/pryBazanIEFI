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
//Para imprimir
using System.Drawing.Printing;
using System.IO;


namespace pryBazanIEFI
{
    public partial class frmClientesActividad : Form
    {
        string ruta = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=BD_Clientes.accdb";
        OleDbConnection conexion = new OleDbConnection();

        public frmClientesActividad()
        {
            InitializeComponent();
        }

        private void frmClientesActividad_Load(object sender, EventArgs e)
        {
            agregarLista();
            lstActividad.SelectedIndex = -1;
            btnExportar.Enabled = false;
            btnImprimir.Enabled = false;
            btnListar.Enabled = false;
        }

        private void agregarLista()
        {
            conexion.ConnectionString = ruta;
            conexion.Open();
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

        private void btnListar_Click(object sender, EventArgs e)
        {
            
            string actividad = lstActividad.Text;
            string codActividad = null;
            string promedio;
            int mayor = 0;
            int menor = 0;

            conexion.ConnectionString = ruta;
            conexion.Open();

            try
            {
                //Buscar código actividad
                string selectactividad = "SELECT * FROM Actividad WHERE Detalle='" + actividad + "'";

                OleDbCommand commandActividad = new OleDbCommand(selectactividad, conexion);
                OleDbDataReader lectorActividad = commandActividad.ExecuteReader();

                while (lectorActividad.Read())
                {
                    if (Convert.ToString(lectorActividad["Detalle"]) == actividad)
                    {
                        codActividad = Convert.ToString(lectorActividad["Codigo_Actividad"]);
                    }
                }
                

                //Mover a la grilla
                DataTable dt = new DataTable();
                string selectdgv = "SELECT Dni_Socio, Nombre_Apellido FROM Socio WHERE Codigo_Actividad=" + codActividad;
                OleDbCommand cmd = new OleDbCommand(selectdgv, conexion);
                OleDbDataReader lector = cmd.ExecuteReader();
                dt.Load(lector);
                dgvClientes.DataSource = dt;


                //Total saldos
                int[] vecSaldo = new int[1000];
                int indice = 0;

                string selectSaldo = "SELECT Saldo FROM Socio WHERE Codigo_Actividad=" + codActividad;
                OleDbCommand cmdSaldo = new OleDbCommand(selectSaldo, conexion);
                OleDbDataAdapter daSaldo = new OleDbDataAdapter(cmdSaldo);

                OleDbDataReader objLector = cmdSaldo.ExecuteReader();
                while (objLector.Read())
                {
                    vecSaldo[indice] = Convert.ToInt32(objLector[0]);
                    indice++;
                }

                int suma = vecSaldo.Sum();
                lblTotal.Text = suma.ToString();


                //Busca Mayor y Menor
                indice = 0;
                while(indice <= 999)    
                {
                    if (vecSaldo[indice] > mayor)
                    {
                        mayor = vecSaldo[indice];
                    }

                    if (vecSaldo[indice] < menor)
                    {
                        menor = vecSaldo[indice];
                    }
                    indice++;
                }
                lblMayor.Text = mayor.ToString();
                lblMenor.Text = menor.ToString();


                //Sacar Promedio
                int total = Convert.ToInt32(lblTotal.Text);
                int cantidadRegistros = dgvClientes.Rows.Count;

                promedio = Convert.ToString(total / cantidadRegistros);
                lblPromedio.Text = promedio;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            conexion.Close();

            btnExportar.Enabled = true;
            btnImprimir.Enabled = true;

        }

        private void picCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //Para establecer las propiedades que describen lo que desea imprimir 
            PrintDocument doc = new PrintDocument();

            //DefaultPageSetting: especifica la configuracion de pagina predeterminada para el documento
            //Landscape: Para que se imprima horizontal
            doc.DefaultPageSettings.Landscape = true;

            //PrinterSettings: donde y como se imprime el documento
            //PrinterName: Nombre de la impresora que se va a utilizar
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            //PrintPreviewDialog: cuadro de diálogo preconfigurado que se utiliza para mostrar cómo aparecerá un PrintDocument cuando se imprima
            //Muestra el documento antes de imprimir
            PrintPreviewDialog ppd = new PrintPreviewDialog { Document = doc};

            //el cuadro de dialogo se va a abrir de forma maximizada
            ((Form)ppd).WindowState = FormWindowState.Maximized;

            //PrintPage: Especifica información sobre cómo se imprime un documento
            //+= : se produce cuando se necesita el resultado que se va a imprimir
            doc.PrintPage += delegate (object ev, PrintPageEventArgs ep)
            {
                //Alto de cada casilla
                const int DGV_ALTO = 40;
                //variable para la coordenada del borde izquierdo y borde superior
                int left = ep.MarginBounds.Left, top = ep.MarginBounds.Top;


                //Para cada columna de la grilla
                foreach(DataGridViewColumn col in dgvClientes.Columns)
                {
                    //Graphics: se utiliza para dibujar en la pagina
                    //DrawString: Dibuja la cadena de texto especificada en la ubicación especificada y con los objetos Brush y Font especificados.
                    //Font: Define un formato concreto para el texto
                    //Brushes: determina el color y la textura del texto
                    ep.Graphics.DrawString(col.HeaderText, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.DeepSkyBlue, left, top);
                    left += col.Width;
                }
                //MarginBounds: Obtiene el area rectangular que representa la parte de la pagina comprendida entre los margenes
                left = ep.MarginBounds.Left;
                //FillRectangle: Rellena el interior de un rectangulo por un par de coordenadas, un valor de ancho y uno de alto
                ep.Graphics.FillRectangle(Brushes.Black, left, top+40, ep.MarginBounds.Right - left, 3);
                top += 43;

                //Para cada fila de la grilla
                foreach (DataGridViewRow row in dgvClientes.Rows)
                {
                    left = ep.MarginBounds.Left;

                    //para cada fila y celda de la grilla
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Segoe UI", 13), Brushes.Black, left, top + 4);
                        left += cell.OwningColumn.Width;
                    }

                    //Deja un espacio de 40
                    top += DGV_ALTO;
               }
            };

            //Abre el doc en una nueva ventana
            ppd.ShowDialog();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            reporteExcel(dgvClientes);
        }

        private void reporteExcel(DataGridView grillaActividad)
        {
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();

            //Es de cir a exportar excel le estamos indicando que vamos a crear un nuevo libro y le estamos diciendo que es verdadero
            exportarExcel.Application.Workbooks.Add(true);

            //Vamos a leer las columnas de la grilla
            int indiceColumna = 0;


            //Primero se van a leer las columnas
            foreach (DataGridViewColumn columna in grillaActividad.Columns)
            {
                //se va a ir incrementando a medida que lee las columnas
                indiceColumna++;

                //Se va a ir rellenando las celdas de nuestra grilla
                //Y esto va a ser igual al nombre de nuestra columna
                exportarExcel.Cells[1, indiceColumna] = columna.Name;
            }

            int indiceFila = 0;


            //Luego vamos a leer las filas
            foreach (DataGridViewRow filas in grillaActividad.Rows)
            {
                indiceFila++;
                //Una vez que lee todas las filas de esa columna
                //Vuelva a la siguiente columna empezando desde 0
                indiceColumna = 0;

                foreach (DataGridViewColumn columna in grillaActividad.Columns)
                {
                    indiceColumna++;

                    //Primero el indice fila va a ir aumentando uno en uno en la columna correspondiente
                    //se encia el nombre de las columnas
                    exportarExcel.Cells[indiceFila + 1, indiceColumna] = filas.Cells[columna.Name].Value;
                }
            }

            //se va a mostrar el excel
            exportarExcel.Visible = true;
        }
        private void lstActividad_TextChanged(object sender, EventArgs e)
        {
            if (lstActividad.Text != string.Empty)
            {
                btnListar.Enabled = true;
            }
            else
            {
                btnListar.Enabled = false;
            }
        }
    }
}
