namespace pryBazanIEFI
{
    partial class frmConsultaUnCliente
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
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lstNombre = new System.Windows.Forms.ComboBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblDeudaCliente = new System.Windows.Forms.Label();
            this.lblActividadCliente = new System.Windows.Forms.Label();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(152)))));
            this.pnlMenu.Controls.Add(this.picCerrar);
            this.pnlMenu.Controls.Add(this.lblMenu);
            this.pnlMenu.Location = new System.Drawing.Point(-7, -7);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(478, 49);
            this.pnlMenu.TabIndex = 0;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(19, 16);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(214, 22);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Consulta de un Cliente";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 65);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(120, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre del cliente";
            // 
            // lstNombre
            // 
            this.lstNombre.FormattingEnabled = true;
            this.lstNombre.Location = new System.Drawing.Point(149, 62);
            this.lstNombre.Name = "lstNombre";
            this.lstNombre.Size = new System.Drawing.Size(178, 24);
            this.lstNombre.TabIndex = 2;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(149, 101);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(178, 46);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.lblActividad);
            this.gbCliente.Controls.Add(this.lblDeuda);
            this.gbCliente.Controls.Add(this.lblDeudaCliente);
            this.gbCliente.Controls.Add(this.lblActividadCliente);
            this.gbCliente.Location = new System.Drawing.Point(15, 162);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(312, 136);
            this.gbCliente.TabIndex = 4;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Datos del cliente";
            // 
            // lblActividad
            // 
            this.lblActividad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblActividad.Location = new System.Drawing.Point(104, 36);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(184, 32);
            this.lblActividad.TabIndex = 16;
            // 
            // lblDeuda
            // 
            this.lblDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeuda.Location = new System.Drawing.Point(104, 83);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(184, 32);
            this.lblDeuda.TabIndex = 15;
            // 
            // lblDeudaCliente
            // 
            this.lblDeudaCliente.AutoSize = true;
            this.lblDeudaCliente.Location = new System.Drawing.Point(22, 84);
            this.lblDeudaCliente.Name = "lblDeudaCliente";
            this.lblDeudaCliente.Size = new System.Drawing.Size(48, 16);
            this.lblDeudaCliente.TabIndex = 13;
            this.lblDeudaCliente.Text = "Deuda";
            // 
            // lblActividadCliente
            // 
            this.lblActividadCliente.AutoSize = true;
            this.lblActividadCliente.Location = new System.Drawing.Point(22, 37);
            this.lblActividadCliente.Name = "lblActividadCliente";
            this.lblActividadCliente.Size = new System.Drawing.Size(63, 16);
            this.lblActividadCliente.TabIndex = 14;
            this.lblActividadCliente.Text = "Actividad";
            // 
            // picCerrar
            // 
            this.picCerrar.Image = global::pryBazanIEFI.Properties.Resources.cerrar1;
            this.picCerrar.Location = new System.Drawing.Point(306, 16);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(27, 22);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCerrar.TabIndex = 2;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmConsultaUnCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 318);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lstNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultaUnCliente";
            this.Text = "frmConsultaUnCliente";
            this.Load += new System.EventHandler(this.frmConsultaUnCliente_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox lstNombre;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblDeudaCliente;
        private System.Windows.Forms.Label lblActividadCliente;
        private System.Windows.Forms.PictureBox picCerrar;
    }
}