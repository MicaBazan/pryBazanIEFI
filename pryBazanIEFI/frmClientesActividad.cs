﻿using System;
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
//Para exportar
using iTextSharp.text.pdf;
using iTextSharp.text;
using Font = System.Drawing.Font;

//Instale iTextSharp para poder exportar a un pdf
//Buscar bien que es iTextSharp
//Y estudiar código imprimir y exportar


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
                int[] vecSaldo = new int[50];
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
                while(indice <= 49)    
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



        //ESTUDIAR CÓDIGO
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.DefaultPageSettings.Landscape = true;
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF";

            PrintPreviewDialog ppd = new PrintPreviewDialog { Document = doc};
            ((Form)ppd).WindowState = FormWindowState.Maximized;

            doc.PrintPage += delegate (object ev, PrintPageEventArgs ep)
            {
                const int DGV_ALTO = 35;
                int left = ep.MarginBounds.Left, top = ep.MarginBounds.Top;

                foreach(DataGridViewColumn col in dgvClientes.Columns)
                {
                    ep.Graphics.DrawString(col.HeaderText, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.DeepSkyBlue, left, top);
                    left += col.Width;
                }
                left = ep.MarginBounds.Left;
                ep.Graphics.FillRectangle(Brushes.Black, left, top+40, ep.MarginBounds.Right - left, 3);
                top += 43;

                foreach (DataGridViewRow row in dgvClientes.Rows)
                {
                    left = ep.MarginBounds.Left;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        ep.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Segoe UI", 13), Brushes.Black, left, top + 4);
                        left += cell.OwningColumn.Width;
                    }
                    top += DGV_ALTO;
               }
            };

            ppd.ShowDialog();
        }



        //ESTUDIAR CÓDIGO
        private void btnExportar_Click(object sender, EventArgs e)
        {
            if(dgvClientes.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();

                save.Filter = "PDF (*.pdf)|*.pdf";

                save.FileName = "ActividadCliente.pdf";

                bool ErrorMessage = false;

                if(save.ShowDialog() == DialogResult.OK)
                {
                    if(File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch(Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("No se pueden escribir datos en el disco" + ex.Message);
                        }
                    }

                    if(!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dgvClientes.Columns.Count);

                            pTable.DefaultCell.Padding = 2;

                            pTable.WidthPercentage = 100;

                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach(DataGridViewColumn col in dgvClientes.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));

                                pTable.AddCell(pCell);
                            }

                            foreach(DataGridViewRow viewRow in dgvClientes.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    pTable.AddCell(dcell.Value.ToString());
                                }
                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);

                                PdfWriter.GetInstance(document, fileStream);

                                document.Open();

                                document.Add(pTable);

                                document.Close();

                                fileStream.Close();
                            }

                            MessageBox.Show("Exportación de datos con éxito", "Aviso");
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Error while exporting Data" + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No Record Found", "Info");
                }
            }
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
