namespace pryEstructuraDeDatos
{
    partial class frmBaseDatosRepasoOperaciones
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
            this.lblOperacion = new System.Windows.Forms.TextBox();
            this.dgvOperaciones = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblOperciónaRealizar = new System.Windows.Forms.Label();
            this.cbOperaciones = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOperacion
            // 
            this.lblOperacion.Location = new System.Drawing.Point(8, 42);
            this.lblOperacion.MinimumSize = new System.Drawing.Size(600, 100);
            this.lblOperacion.Multiline = true;
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(688, 100);
            this.lblOperacion.TabIndex = 7;
            // 
            // dgvOperaciones
            // 
            this.dgvOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperaciones.Location = new System.Drawing.Point(8, 148);
            this.dgvOperaciones.Name = "dgvOperaciones";
            this.dgvOperaciones.Size = new System.Drawing.Size(688, 294);
            this.dgvOperaciones.TabIndex = 6;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(600, 13);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(96, 24);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblOperciónaRealizar
            // 
            this.lblOperciónaRealizar.AutoSize = true;
            this.lblOperciónaRealizar.Location = new System.Drawing.Point(9, 19);
            this.lblOperciónaRealizar.Name = "lblOperciónaRealizar";
            this.lblOperciónaRealizar.Size = new System.Drawing.Size(197, 13);
            this.lblOperciónaRealizar.TabIndex = 8;
            this.lblOperciónaRealizar.Text = "Opercióna a realizar en la base de datos";
            // 
            // cbOperaciones
            // 
            this.cbOperaciones.FormattingEnabled = true;
            this.cbOperaciones.Items.AddRange(new object[] {
            "Proyección Simple de Nombres de los autores",
            "Proyección Simple de Nombres de los países",
            "Proyección Simple de Nombres de los idiomas",
            "Proyección Multiatributo de Títulos de los libros con la cantidad de unidades dis" +
                "ponibles en inventario",
            "Proyección Multiatributo de Títulos de los libros con su precio de venta",
            "Proyección Simple de Títulos de los libros ordenados alfabéticamente de la Z a la" +
                " A",
            "Union De Libros",
            "Union De Los Autores",
            "Intersección de Paises",
            "Union de Idiomas ",
            "Juntar Libros con Autores",
            "Diferencia de Autores",
            "Juntar Libros con Idiomas",
            "Seleccion simple de Cantidad",
            "Seleccion simple de Precio",
            "Seleccion simple de Año ",
            "Seleccion simple de Iidioma",
            "Diferencia de Idiomas",
            "Seleccion simple de Pais",
            "Union de Paises"});
            this.cbOperaciones.Location = new System.Drawing.Point(212, 15);
            this.cbOperaciones.Name = "cbOperaciones";
            this.cbOperaciones.Size = new System.Drawing.Size(382, 21);
            this.cbOperaciones.TabIndex = 9;
            // 
            // frmBaseDatosRepasoOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 454);
            this.Controls.Add(this.cbOperaciones);
            this.Controls.Add(this.lblOperciónaRealizar);
            this.Controls.Add(this.lblOperacion);
            this.Controls.Add(this.dgvOperaciones);
            this.Controls.Add(this.btnListar);
            this.Name = "frmBaseDatosRepasoOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base Datos Repaso Operaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox lblOperacion;
        private System.Windows.Forms.DataGridView dgvOperaciones;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblOperciónaRealizar;
        private System.Windows.Forms.ComboBox cbOperaciones;
    }
}