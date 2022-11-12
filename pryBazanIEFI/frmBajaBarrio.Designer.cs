namespace pryBazanIEFI
{
    partial class frmBajaBarrio
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbBarrio = new System.Windows.Forms.GroupBox();
            this.lstBarrio = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.gbBarrio.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(163, 182);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(145, 59);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gbBarrio
            // 
            this.gbBarrio.Controls.Add(this.lstBarrio);
            this.gbBarrio.Controls.Add(this.lblNombre);
            this.gbBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbBarrio.Location = new System.Drawing.Point(12, 60);
            this.gbBarrio.Name = "gbBarrio";
            this.gbBarrio.Size = new System.Drawing.Size(296, 108);
            this.gbBarrio.TabIndex = 10;
            this.gbBarrio.TabStop = false;
            this.gbBarrio.Text = "Elegir barrio";
            // 
            // lstBarrio
            // 
            this.lstBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstBarrio.FormattingEnabled = true;
            this.lstBarrio.Location = new System.Drawing.Point(108, 48);
            this.lstBarrio.Name = "lstBarrio";
            this.lstBarrio.Size = new System.Drawing.Size(164, 28);
            this.lstBarrio.TabIndex = 1;
            this.lstBarrio.TextChanged += new System.EventHandler(this.lstBarrio_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 53);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Silver;
            this.pnlMenu.Controls.Add(this.lblMenu);
            this.pnlMenu.Controls.Add(this.picCerrar);
            this.pnlMenu.Location = new System.Drawing.Point(-6, -10);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(389, 53);
            this.pnlMenu.TabIndex = 9;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(18, 19);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(110, 22);
            this.lblMenu.TabIndex = 3;
            this.lblMenu.Text = "Baja Barrio";
            // 
            // picCerrar
            // 
            this.picCerrar.Image = global::pryBazanIEFI.Properties.Resources.cerrar;
            this.picCerrar.Location = new System.Drawing.Point(285, 19);
            this.picCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(29, 22);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCerrar.TabIndex = 2;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // frmBajaBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 253);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.gbBarrio);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBajaBarrio";
            this.Text = "frmBajaBarrio";
            this.Load += new System.EventHandler(this.frmBajaBarrio_Load);
            this.gbBarrio.ResumeLayout(false);
            this.gbBarrio.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gbBarrio;
        private System.Windows.Forms.ComboBox lstBarrio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox picCerrar;
    }
}