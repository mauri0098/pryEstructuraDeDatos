namespace pryEstructuraDeDatos
{
    partial class frmEstructurasDeDatos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDeAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructurasLinialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDespleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructurasNoLinialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolBinarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacioensConToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repasoDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.estructurasLinialesToolStripMenuItem,
            this.estructurasNoLinialesToolStripMenuItem,
            this.baseDeDatosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDeAlumnoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema ";
            // 
            // datosDeAlumnoToolStripMenuItem
            // 
            this.datosDeAlumnoToolStripMenuItem.Name = "datosDeAlumnoToolStripMenuItem";
            this.datosDeAlumnoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.datosDeAlumnoToolStripMenuItem.Text = "Datos De Alumno";
            this.datosDeAlumnoToolStripMenuItem.Click += new System.EventHandler(this.datosDeAlumnoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // estructurasLinialesToolStripMenuItem
            // 
            this.estructurasLinialesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colaToolStripMenuItem,
            this.pilaToolStripMenuItem,
            this.listaSimpleToolStripMenuItem,
            this.listaDespleToolStripMenuItem});
            this.estructurasLinialesToolStripMenuItem.Name = "estructurasLinialesToolStripMenuItem";
            this.estructurasLinialesToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.estructurasLinialesToolStripMenuItem.Text = "Estructuras Liniales ";
            // 
            // colaToolStripMenuItem
            // 
            this.colaToolStripMenuItem.Name = "colaToolStripMenuItem";
            this.colaToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.colaToolStripMenuItem.Text = "Cola..";
            this.colaToolStripMenuItem.Click += new System.EventHandler(this.colaToolStripMenuItem_Click);
            // 
            // pilaToolStripMenuItem
            // 
            this.pilaToolStripMenuItem.Name = "pilaToolStripMenuItem";
            this.pilaToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.pilaToolStripMenuItem.Text = "Pila..";
            // 
            // listaSimpleToolStripMenuItem
            // 
            this.listaSimpleToolStripMenuItem.Name = "listaSimpleToolStripMenuItem";
            this.listaSimpleToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.listaSimpleToolStripMenuItem.Text = "Lista Simple..";
            // 
            // listaDespleToolStripMenuItem
            // 
            this.listaDespleToolStripMenuItem.Name = "listaDespleToolStripMenuItem";
            this.listaDespleToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.listaDespleToolStripMenuItem.Text = "Lista Desple..";
            // 
            // estructurasNoLinialesToolStripMenuItem
            // 
            this.estructurasNoLinialesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arbolBinarioToolStripMenuItem});
            this.estructurasNoLinialesToolStripMenuItem.Name = "estructurasNoLinialesToolStripMenuItem";
            this.estructurasNoLinialesToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.estructurasNoLinialesToolStripMenuItem.Text = "Estructuras No Liniales ";
            // 
            // arbolBinarioToolStripMenuItem
            // 
            this.arbolBinarioToolStripMenuItem.Name = "arbolBinarioToolStripMenuItem";
            this.arbolBinarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.arbolBinarioToolStripMenuItem.Text = "Arbol Binario...";
            // 
            // baseDeDatosToolStripMenuItem
            // 
            this.baseDeDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacioensConToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.repasoDeToolStripMenuItem});
            this.baseDeDatosToolStripMenuItem.Name = "baseDeDatosToolStripMenuItem";
            this.baseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.baseDeDatosToolStripMenuItem.Text = " Base De Datos";
            // 
            // operacioensConToolStripMenuItem
            // 
            this.operacioensConToolStripMenuItem.Name = "operacioensConToolStripMenuItem";
            this.operacioensConToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.operacioensConToolStripMenuItem.Text = " Operaciones Con Tabla ";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // repasoDeToolStripMenuItem
            // 
            this.repasoDeToolStripMenuItem.Name = "repasoDeToolStripMenuItem";
            this.repasoDeToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.repasoDeToolStripMenuItem.Text = "Repaso De Operaciones";
            this.repasoDeToolStripMenuItem.Click += new System.EventHandler(this.repasoDeToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryEstructuraDeDatos.Properties.Resources.istockphoto_1046046242_612x612;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 424);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmEstructurasDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEstructurasDeDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructuras De Datos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructurasLinialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDespleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructurasNoLinialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolBinarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacioensConToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repasoDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDeAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

