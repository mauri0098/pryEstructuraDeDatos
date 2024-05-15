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
            this.txtRepaso = new System.Windows.Forms.TextBox();
            this.dgvRepaso = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblOperciónaRealizar = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepaso)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRepaso
            // 
            this.txtRepaso.Location = new System.Drawing.Point(12, 45);
            this.txtRepaso.MinimumSize = new System.Drawing.Size(600, 100);
            this.txtRepaso.Name = "txtRepaso";
            this.txtRepaso.Size = new System.Drawing.Size(684, 100);
            this.txtRepaso.TabIndex = 7;
            // 
            // dgvRepaso
            // 
            this.dgvRepaso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepaso.Location = new System.Drawing.Point(12, 151);
            this.dgvRepaso.Name = "dgvRepaso";
            this.dgvRepaso.Size = new System.Drawing.Size(684, 280);
            this.dgvRepaso.TabIndex = 6;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(600, 15);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(96, 21);
            this.btnListar.TabIndex = 5;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(212, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(382, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // frmBaseDatosRepasoOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 454);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblOperciónaRealizar);
            this.Controls.Add(this.txtRepaso);
            this.Controls.Add(this.dgvRepaso);
            this.Controls.Add(this.btnListar);
            this.Name = "frmBaseDatosRepasoOperaciones";
            this.Text = "Base Datos Repaso Operaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepaso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtRepaso;
        private System.Windows.Forms.DataGridView dgvRepaso;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblOperciónaRealizar;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}