﻿namespace pryBazanIEFI
{
    partial class frmClientesBarrio
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
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lstBarrio = new System.Windows.Forms.ComboBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(152)))));
            this.pnlMenu.Controls.Add(this.lblMenu);
            this.pnlMenu.Location = new System.Drawing.Point(-30, -28);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(849, 73);
            this.pnlMenu.TabIndex = 0;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(42, 37);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(298, 22);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "Listado de Clientes de un Barrio";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(24, 72);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(43, 16);
            this.lblBarrio.TabIndex = 1;
            this.lblBarrio.Text = "Barrio";
            // 
            // lstBarrio
            // 
            this.lstBarrio.FormattingEnabled = true;
            this.lstBarrio.Location = new System.Drawing.Point(84, 69);
            this.lstBarrio.Name = "lstBarrio";
            this.lstBarrio.Size = new System.Drawing.Size(452, 24);
            this.lstBarrio.TabIndex = 2;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(27, 114);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(509, 210);
            this.dgvClientes.TabIndex = 3;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(411, 341);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(124, 55);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // frmClientesBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 417);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.lstBarrio);
            this.Controls.Add(this.lblBarrio);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientesBarrio";
            this.Text = "frmClientesBarrio";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.ComboBox lstBarrio;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnListar;
    }
}