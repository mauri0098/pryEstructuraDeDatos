namespace pryEstructuraDeDatos
{
    partial class frmBaseDatosConsulta
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
            this.lblConsultaEnSQL = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvConsultaEnSQL = new System.Windows.Forms.DataGridView();
            this.txtConsultaEnSQL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaEnSQL)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsultaEnSQL
            // 
            this.lblConsultaEnSQL.AutoSize = true;
            this.lblConsultaEnSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaEnSQL.Location = new System.Drawing.Point(7, 16);
            this.lblConsultaEnSQL.Name = "lblConsultaEnSQL";
            this.lblConsultaEnSQL.Size = new System.Drawing.Size(169, 25);
            this.lblConsultaEnSQL.TabIndex = 0;
            this.lblConsultaEnSQL.Text = "Cosulta en SQL:";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(620, 260);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(99, 23);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // dgvConsultaEnSQL
            // 
            this.dgvConsultaEnSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaEnSQL.Location = new System.Drawing.Point(12, 289);
            this.dgvConsultaEnSQL.Name = "dgvConsultaEnSQL";
            this.dgvConsultaEnSQL.Size = new System.Drawing.Size(707, 221);
            this.dgvConsultaEnSQL.TabIndex = 3;
            // 
            // txtConsultaEnSQL
            // 
            this.txtConsultaEnSQL.Location = new System.Drawing.Point(12, 44);
            this.txtConsultaEnSQL.MinimumSize = new System.Drawing.Size(600, 210);
            this.txtConsultaEnSQL.Name = "txtConsultaEnSQL";
            this.txtConsultaEnSQL.Size = new System.Drawing.Size(707, 210);
            this.txtConsultaEnSQL.TabIndex = 4;
            // 
            // frmBaseDatosConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 526);
            this.Controls.Add(this.txtConsultaEnSQL);
            this.Controls.Add(this.dgvConsultaEnSQL);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblConsultaEnSQL);
            this.Name = "frmBaseDatosConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta en la Base de Datos";
            this.Load += new System.EventHandler(this.frmBaseDatosConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaEnSQL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultaEnSQL;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvConsultaEnSQL;
        public System.Windows.Forms.TextBox txtConsultaEnSQL;
    }
}