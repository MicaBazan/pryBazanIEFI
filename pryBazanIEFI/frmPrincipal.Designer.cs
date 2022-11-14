namespace pryBazanIEFI
{
    partial class frmPrincipal
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
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.socioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darDeBajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeTodosLosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeSaldoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesPorBarrioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesPorActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barrioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesDeudoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.consultaDeUnClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // piclogo
            // 
            this.piclogo.Image = global::pryBazanIEFI.Properties.Resources.logo;
            this.piclogo.Location = new System.Drawing.Point(73, 72);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(194, 116);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclogo.TabIndex = 1;
            this.piclogo.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.lblNombre.Location = new System.Drawing.Point(118, 221);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(109, 22);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Hyper Gym";
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.socioToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.barrioToolStripMenuItem,
            this.actividadToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(349, 28);
            this.menu.TabIndex = 14;
            this.menu.Text = "menuStrip1";
            // 
            // socioToolStripMenuItem
            // 
            this.socioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.darDeBajaToolStripMenuItem});
            this.socioToolStripMenuItem.Name = "socioToolStripMenuItem";
            this.socioToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.socioToolStripMenuItem.Text = "Socio";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // darDeBajaToolStripMenuItem
            // 
            this.darDeBajaToolStripMenuItem.Name = "darDeBajaToolStripMenuItem";
            this.darDeBajaToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.darDeBajaToolStripMenuItem.Text = "Dar de baja";
            this.darDeBajaToolStripMenuItem.Click += new System.EventHandler(this.darDeBajaToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeTodosLosClientesToolStripMenuItem,
            this.listadoDeSaldoDeClientesToolStripMenuItem,
            this.listadoDeClientesPorBarrioToolStripMenuItem,
            this.listadoDeClientesPorActividadToolStripMenuItem,
            this.listadoDeClientesDeudoresToolStripMenuItem,
            this.toolStripSeparator1,
            this.consultaDeUnClienteToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // listadoDeTodosLosClientesToolStripMenuItem
            // 
            this.listadoDeTodosLosClientesToolStripMenuItem.Name = "listadoDeTodosLosClientesToolStripMenuItem";
            this.listadoDeTodosLosClientesToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.listadoDeTodosLosClientesToolStripMenuItem.Text = "Listado de todos los clientes...";
            this.listadoDeTodosLosClientesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeTodosLosClientesToolStripMenuItem_Click);
            // 
            // listadoDeSaldoDeClientesToolStripMenuItem
            // 
            this.listadoDeSaldoDeClientesToolStripMenuItem.Name = "listadoDeSaldoDeClientesToolStripMenuItem";
            this.listadoDeSaldoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.listadoDeSaldoDeClientesToolStripMenuItem.Text = "Listado de saldo de clientes...";
            this.listadoDeSaldoDeClientesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeSaldoDeClientesToolStripMenuItem_Click);
            // 
            // listadoDeClientesPorBarrioToolStripMenuItem
            // 
            this.listadoDeClientesPorBarrioToolStripMenuItem.Name = "listadoDeClientesPorBarrioToolStripMenuItem";
            this.listadoDeClientesPorBarrioToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.listadoDeClientesPorBarrioToolStripMenuItem.Text = "Listado de clientes por barrio...";
            this.listadoDeClientesPorBarrioToolStripMenuItem.Click += new System.EventHandler(this.listadoDeClientesPorBarrioToolStripMenuItem_Click);
            // 
            // listadoDeClientesPorActividadToolStripMenuItem
            // 
            this.listadoDeClientesPorActividadToolStripMenuItem.Name = "listadoDeClientesPorActividadToolStripMenuItem";
            this.listadoDeClientesPorActividadToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.listadoDeClientesPorActividadToolStripMenuItem.Text = "Listado de clientes por actividad...";
            this.listadoDeClientesPorActividadToolStripMenuItem.Click += new System.EventHandler(this.listadoDeClientesPorActividadToolStripMenuItem_Click);
            // 
            // barrioToolStripMenuItem
            // 
            this.barrioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1,
            this.eliminarToolStripMenuItem});
            this.barrioToolStripMenuItem.Name = "barrioToolStripMenuItem";
            this.barrioToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.barrioToolStripMenuItem.Text = "Barrio";
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(146, 26);
            this.agregarToolStripMenuItem1.Text = "Agregar";
            this.agregarToolStripMenuItem1.Click += new System.EventHandler(this.agregarToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // actividadToolStripMenuItem
            // 
            this.actividadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem2,
            this.eliminarToolStripMenuItem1});
            this.actividadToolStripMenuItem.Name = "actividadToolStripMenuItem";
            this.actividadToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.actividadToolStripMenuItem.Text = "Actividad";
            // 
            // agregarToolStripMenuItem2
            // 
            this.agregarToolStripMenuItem2.Name = "agregarToolStripMenuItem2";
            this.agregarToolStripMenuItem2.Size = new System.Drawing.Size(146, 26);
            this.agregarToolStripMenuItem2.Text = "Agregar";
            this.agregarToolStripMenuItem2.Click += new System.EventHandler(this.agregarToolStripMenuItem2_Click);
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(146, 26);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            this.eliminarToolStripMenuItem1.Click += new System.EventHandler(this.eliminarToolStripMenuItem1_Click);
            // 
            // listadoDeClientesDeudoresToolStripMenuItem
            // 
            this.listadoDeClientesDeudoresToolStripMenuItem.Name = "listadoDeClientesDeudoresToolStripMenuItem";
            this.listadoDeClientesDeudoresToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.listadoDeClientesDeudoresToolStripMenuItem.Text = "Listado de clientes deudores...";
            this.listadoDeClientesDeudoresToolStripMenuItem.Click += new System.EventHandler(this.listadoDeClientesDeudoresToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(313, 6);
            // 
            // consultaDeUnClienteToolStripMenuItem
            // 
            this.consultaDeUnClienteToolStripMenuItem.Name = "consultaDeUnClienteToolStripMenuItem";
            this.consultaDeUnClienteToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.consultaDeUnClienteToolStripMenuItem.Text = "Consulta de un cliente...";
            this.consultaDeUnClienteToolStripMenuItem.Click += new System.EventHandler(this.consultaDeUnClienteToolStripMenuItem_Click_1);
            // 
            // frmPrincipal
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::pryBazanIEFI.Properties.Resources.ico_Socio;
            this.ClientSize = new System.Drawing.Size(349, 293);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.piclogo);
            this.Controls.Add(this.menu);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox piclogo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem socioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeBajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeTodosLosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeSaldoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesPorBarrioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesPorActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barrioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesDeudoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem consultaDeUnClienteToolStripMenuItem;
    }
}