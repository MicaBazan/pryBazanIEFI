namespace pryBazanIEFI
{
    partial class frmAgregarCliente
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
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lstActividad = new System.Windows.Forms.ComboBox();
            this.lstBarrio = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNuevo = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.MaskedTextBox();
            this.gbDatos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtDni);
            this.gbDatos.Controls.Add(this.txtSaldo);
            this.gbDatos.Controls.Add(this.lstActividad);
            this.gbDatos.Controls.Add(this.lstBarrio);
            this.gbDatos.Controls.Add(this.txtDireccion);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.lblBarrio);
            this.gbDatos.Controls.Add(this.lblActividad);
            this.gbDatos.Controls.Add(this.lblSaldo);
            this.gbDatos.Controls.Add(this.lblDireccion);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Controls.Add(this.lblDni);
            this.gbDatos.Location = new System.Drawing.Point(9, 42);
            this.gbDatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbDatos.Size = new System.Drawing.Size(469, 179);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Carga de datos";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(338, 126);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(82, 20);
            this.txtSaldo.TabIndex = 9;
            // 
            // lstActividad
            // 
            this.lstActividad.FormattingEnabled = true;
            this.lstActividad.Location = new System.Drawing.Point(66, 126);
            this.lstActividad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstActividad.Name = "lstActividad";
            this.lstActividad.Size = new System.Drawing.Size(132, 21);
            this.lstActividad.TabIndex = 8;
            // 
            // lstBarrio
            // 
            this.lstBarrio.FormattingEnabled = true;
            this.lstBarrio.Location = new System.Drawing.Point(338, 79);
            this.lstBarrio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstBarrio.Name = "lstBarrio";
            this.lstBarrio.Size = new System.Drawing.Size(115, 21);
            this.lstBarrio.TabIndex = 7;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(66, 83);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(200, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(268, 32);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(186, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(283, 83);
            this.lblBarrio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(34, 13);
            this.lblBarrio.TabIndex = 1;
            this.lblBarrio.Text = "Barrio";
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(14, 133);
            this.lblActividad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(51, 13);
            this.lblActividad.TabIndex = 2;
            this.lblActividad.Text = "Actividad";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(283, 128);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(58, 13);
            this.lblSaldo.TabIndex = 3;
            this.lblSaldo.Text = "Saldo      $";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(14, 85);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(167, 35);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(92, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre y Apellido";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(14, 35);
            this.lblDni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(26, 13);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "DNI";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(369, 240);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(109, 48);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(234, 240);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(109, 48);
            this.btnCargar.TabIndex = 12;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.lblNuevo);
            this.panel1.Location = new System.Drawing.Point(0, -6);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 34);
            this.panel1.TabIndex = 13;
            // 
            // lblNuevo
            // 
            this.lblNuevo.AutoSize = true;
            this.lblNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevo.ForeColor = System.Drawing.Color.Black;
            this.lblNuevo.Location = new System.Drawing.Point(12, 13);
            this.lblNuevo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNuevo.Name = "lblNuevo";
            this.lblNuevo.Size = new System.Drawing.Size(96, 15);
            this.lblNuevo.TabIndex = 0;
            this.lblNuevo.Text = "Nuevo Cliente";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(66, 32);
            this.txtDni.Mask = "9999";
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(33, 20);
            this.txtDni.TabIndex = 10;
            // 
            // frmAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 301);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAgregarCliente";
            this.Text = "Nuevo Cliente";
            this.Load += new System.EventHandler(this.frmAgregarCliente_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.ComboBox lstActividad;
        private System.Windows.Forms.ComboBox lstBarrio;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNuevo;
        private System.Windows.Forms.MaskedTextBox txtDni;
    }
}