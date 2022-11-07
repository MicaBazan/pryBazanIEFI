namespace pryBazanIEFI
{
    partial class frmClientesActividad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lstActividad = new System.Windows.Forms.ComboBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.lblMayorSaldo = new System.Windows.Forms.Label();
            this.lblPromedioSaldo = new System.Windows.Forms.Label();
            this.lblMayor = new System.Windows.Forms.Label();
            this.lblMenorSaldo = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.gbEtiquetas = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblMenor = new System.Windows.Forms.Label();
            this.lblTotalSaldo = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.gbEtiquetas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Silver;
            this.pnlMenu.Controls.Add(this.picCerrar);
            this.pnlMenu.Controls.Add(this.lblMenu);
            this.pnlMenu.Location = new System.Drawing.Point(-4, -6);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(544, 41);
            this.pnlMenu.TabIndex = 0;
            // 
            // picCerrar
            // 
            this.picCerrar.Image = global::pryBazanIEFI.Properties.Resources.cerrar;
            this.picCerrar.Location = new System.Drawing.Point(435, 13);
            this.picCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(22, 18);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCerrar.TabIndex = 2;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(14, 13);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(250, 18);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Listado de clientes por actividad";
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(10, 54);
            this.lblActividad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(51, 13);
            this.lblActividad.TabIndex = 1;
            this.lblActividad.Text = "Actividad";
            // 
            // lstActividad
            // 
            this.lstActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstActividad.FormattingEnabled = true;
            this.lstActividad.Location = new System.Drawing.Point(69, 51);
            this.lstActividad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstActividad.Name = "lstActividad";
            this.lstActividad.Size = new System.Drawing.Size(270, 21);
            this.lstActividad.TabIndex = 2;
            this.lstActividad.TextChanged += new System.EventHandler(this.lstActividad_TextChanged);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 89);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(326, 152);
            this.dgvClientes.TabIndex = 3;
            // 
            // lblMayorSaldo
            // 
            this.lblMayorSaldo.AutoSize = true;
            this.lblMayorSaldo.Location = new System.Drawing.Point(20, 33);
            this.lblMayorSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMayorSaldo.Name = "lblMayorSaldo";
            this.lblMayorSaldo.Size = new System.Drawing.Size(36, 13);
            this.lblMayorSaldo.TabIndex = 4;
            this.lblMayorSaldo.Text = "Mayor";
            // 
            // lblPromedioSaldo
            // 
            this.lblPromedioSaldo.AutoSize = true;
            this.lblPromedioSaldo.Location = new System.Drawing.Point(20, 91);
            this.lblPromedioSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPromedioSaldo.Name = "lblPromedioSaldo";
            this.lblPromedioSaldo.Size = new System.Drawing.Size(51, 13);
            this.lblPromedioSaldo.TabIndex = 5;
            this.lblPromedioSaldo.Text = "Promedio";
            // 
            // lblMayor
            // 
            this.lblMayor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMayor.Location = new System.Drawing.Point(88, 32);
            this.lblMayor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(100, 26);
            this.lblMayor.TabIndex = 6;
            // 
            // lblMenorSaldo
            // 
            this.lblMenorSaldo.AutoSize = true;
            this.lblMenorSaldo.Location = new System.Drawing.Point(242, 33);
            this.lblMenorSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenorSaldo.Name = "lblMenorSaldo";
            this.lblMenorSaldo.Size = new System.Drawing.Size(37, 13);
            this.lblMenorSaldo.TabIndex = 9;
            this.lblMenorSaldo.Text = "Menor";
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.ForeColor = System.Drawing.Color.White;
            this.btnListar.Location = new System.Drawing.Point(354, 51);
            this.btnListar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(97, 49);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(354, 119);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(97, 49);
            this.btnImprimir.TabIndex = 10;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Location = new System.Drawing.Point(354, 192);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(97, 49);
            this.btnExportar.TabIndex = 11;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // gbEtiquetas
            // 
            this.gbEtiquetas.Controls.Add(this.lblTotal);
            this.gbEtiquetas.Controls.Add(this.lblPromedio);
            this.gbEtiquetas.Controls.Add(this.lblMenor);
            this.gbEtiquetas.Controls.Add(this.lblTotalSaldo);
            this.gbEtiquetas.Controls.Add(this.lblMayor);
            this.gbEtiquetas.Controls.Add(this.lblMayorSaldo);
            this.gbEtiquetas.Controls.Add(this.lblPromedioSaldo);
            this.gbEtiquetas.Controls.Add(this.lblMenorSaldo);
            this.gbEtiquetas.Location = new System.Drawing.Point(12, 262);
            this.gbEtiquetas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbEtiquetas.Name = "gbEtiquetas";
            this.gbEtiquetas.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbEtiquetas.Size = new System.Drawing.Size(439, 141);
            this.gbEtiquetas.TabIndex = 12;
            this.gbEtiquetas.TabStop = false;
            this.gbEtiquetas.Text = "Datos";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(311, 90);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 26);
            this.lblTotal.TabIndex = 13;
            // 
            // lblPromedio
            // 
            this.lblPromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedio.Location = new System.Drawing.Point(88, 90);
            this.lblPromedio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(100, 26);
            this.lblPromedio.TabIndex = 12;
            // 
            // lblMenor
            // 
            this.lblMenor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMenor.Location = new System.Drawing.Point(311, 32);
            this.lblMenor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(100, 26);
            this.lblMenor.TabIndex = 11;
            // 
            // lblTotalSaldo
            // 
            this.lblTotalSaldo.AutoSize = true;
            this.lblTotalSaldo.Location = new System.Drawing.Point(242, 91);
            this.lblTotalSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalSaldo.Name = "lblTotalSaldo";
            this.lblTotalSaldo.Size = new System.Drawing.Size(61, 13);
            this.lblTotalSaldo.TabIndex = 10;
            this.lblTotalSaldo.Text = "Total Saldo";
            // 
            // frmClientesActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 418);
            this.Controls.Add(this.gbEtiquetas);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.lstActividad);
            this.Controls.Add(this.lblActividad);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmClientesActividad";
            this.Text = "frmClientesActividad";
            this.Load += new System.EventHandler(this.frmClientesActividad_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.gbEtiquetas.ResumeLayout(false);
            this.gbEtiquetas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.ComboBox lstActividad;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label lblMayorSaldo;
        private System.Windows.Forms.Label lblPromedioSaldo;
        private System.Windows.Forms.Label lblMayor;
        private System.Windows.Forms.Label lblMenorSaldo;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.GroupBox gbEtiquetas;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.Label lblTotalSaldo;
        private System.Windows.Forms.PictureBox picCerrar;
    }
}