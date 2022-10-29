namespace pryBazanIEFI
{
    partial class frmClientesSaldo
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
            this.lblListado = new System.Windows.Forms.Label();
            this.gbConsulta = new System.Windows.Forms.GroupBox();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblPromedioDeSaldos = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCantidadDeClientes = new System.Windows.Forms.Label();
            this.lblTotaldeSaldos = new System.Windows.Forms.Label();
            this.dgvDuedas = new System.Windows.Forms.DataGridView();
            this.pnlMenu.SuspendLayout();
            this.gbConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuedas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(152)))));
            this.pnlMenu.Controls.Add(this.lblListado);
            this.pnlMenu.Location = new System.Drawing.Point(-18, -14);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(773, 57);
            this.pnlMenu.TabIndex = 0;
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListado.Location = new System.Drawing.Point(30, 23);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(188, 22);
            this.lblListado.TabIndex = 1;
            this.lblListado.Text = "Listado de Clientes ";
            // 
            // gbConsulta
            // 
            this.gbConsulta.Controls.Add(this.lblPromedio);
            this.gbConsulta.Controls.Add(this.lblClientes);
            this.gbConsulta.Controls.Add(this.lblPromedioDeSaldos);
            this.gbConsulta.Controls.Add(this.btnListar);
            this.gbConsulta.Controls.Add(this.lblTotal);
            this.gbConsulta.Controls.Add(this.lblCantidadDeClientes);
            this.gbConsulta.Controls.Add(this.lblTotaldeSaldos);
            this.gbConsulta.Controls.Add(this.dgvDuedas);
            this.gbConsulta.Location = new System.Drawing.Point(16, 65);
            this.gbConsulta.Name = "gbConsulta";
            this.gbConsulta.Size = new System.Drawing.Size(719, 455);
            this.gbConsulta.TabIndex = 1;
            this.gbConsulta.TabStop = false;
            this.gbConsulta.Text = "Consulta de datos";
            // 
            // lblPromedio
            // 
            this.lblPromedio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedio.Location = new System.Drawing.Point(524, 324);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(175, 31);
            this.lblPromedio.TabIndex = 7;
            // 
            // lblClientes
            // 
            this.lblClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblClientes.Location = new System.Drawing.Point(524, 273);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(175, 31);
            this.lblClientes.TabIndex = 6;
            // 
            // lblPromedioDeSaldos
            // 
            this.lblPromedioDeSaldos.AutoSize = true;
            this.lblPromedioDeSaldos.Location = new System.Drawing.Point(369, 325);
            this.lblPromedioDeSaldos.Name = "lblPromedioDeSaldos";
            this.lblPromedioDeSaldos.Size = new System.Drawing.Size(131, 16);
            this.lblPromedioDeSaldos.TabIndex = 5;
            this.lblPromedioDeSaldos.Text = "Promedio de Saldos";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(538, 382);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(161, 56);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(524, 222);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(175, 31);
            this.lblTotal.TabIndex = 3;
            // 
            // lblCantidadDeClientes
            // 
            this.lblCantidadDeClientes.AutoSize = true;
            this.lblCantidadDeClientes.Location = new System.Drawing.Point(369, 274);
            this.lblCantidadDeClientes.Name = "lblCantidadDeClientes";
            this.lblCantidadDeClientes.Size = new System.Drawing.Size(129, 16);
            this.lblCantidadDeClientes.TabIndex = 2;
            this.lblCantidadDeClientes.Text = "Cantidad de clientes";
            // 
            // lblTotaldeSaldos
            // 
            this.lblTotaldeSaldos.AutoSize = true;
            this.lblTotaldeSaldos.Location = new System.Drawing.Point(369, 223);
            this.lblTotaldeSaldos.Name = "lblTotaldeSaldos";
            this.lblTotaldeSaldos.Size = new System.Drawing.Size(101, 16);
            this.lblTotaldeSaldos.TabIndex = 1;
            this.lblTotaldeSaldos.Text = "Total de saldos";
            // 
            // dgvDuedas
            // 
            this.dgvDuedas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuedas.Location = new System.Drawing.Point(20, 33);
            this.dgvDuedas.Name = "dgvDuedas";
            this.dgvDuedas.RowHeadersWidth = 51;
            this.dgvDuedas.RowTemplate.Height = 24;
            this.dgvDuedas.Size = new System.Drawing.Size(679, 159);
            this.dgvDuedas.TabIndex = 0;
            // 
            // frmClientesSaldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 538);
            this.Controls.Add(this.gbConsulta);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientesSaldo";
            this.Text = "Listado de Clientes Deudores";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.gbConsulta.ResumeLayout(false);
            this.gbConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuedas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.GroupBox gbConsulta;
        private System.Windows.Forms.DataGridView dgvDuedas;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblPromedioDeSaldos;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCantidadDeClientes;
        private System.Windows.Forms.Label lblTotaldeSaldos;
    }
}