namespace pryEstructuraDeDatos
{
    partial class frmBaseDatosOperaciones
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
            this.dgvBaseDeOperaciones = new System.Windows.Forms.DataGridView();
            this.gbOperacionesDeProyeccìon = new System.Windows.Forms.GroupBox();
            this.gbOperaciónesDeSelección = new System.Windows.Forms.GroupBox();
            this.gbOperaciónesAlgebraicas = new System.Windows.Forms.GroupBox();
            this.btnProyeccìonSimple = new System.Windows.Forms.Button();
            this.btnProyeccìonMultiatributo = new System.Windows.Forms.Button();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.btnSelecciónSimple = new System.Windows.Forms.Button();
            this.btnSelecciónMultiatributo = new System.Windows.Forms.Button();
            this.btnSelecciónPorConvolución = new System.Windows.Forms.Button();
            this.bntUnion = new System.Windows.Forms.Button();
            this.btnIntersección = new System.Windows.Forms.Button();
            this.btnDiferencia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDeOperaciones)).BeginInit();
            this.gbOperacionesDeProyeccìon.SuspendLayout();
            this.gbOperaciónesDeSelección.SuspendLayout();
            this.gbOperaciónesAlgebraicas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBaseDeOperaciones
            // 
            this.dgvBaseDeOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseDeOperaciones.Location = new System.Drawing.Point(5, 2);
            this.dgvBaseDeOperaciones.Name = "dgvBaseDeOperaciones";
            this.dgvBaseDeOperaciones.Size = new System.Drawing.Size(725, 241);
            this.dgvBaseDeOperaciones.TabIndex = 0;
            // 
            // gbOperacionesDeProyeccìon
            // 
            this.gbOperacionesDeProyeccìon.Controls.Add(this.btnProyeccìonSimple);
            this.gbOperacionesDeProyeccìon.Controls.Add(this.btnProyeccìonMultiatributo);
            this.gbOperacionesDeProyeccìon.Controls.Add(this.btnJuntar);
            this.gbOperacionesDeProyeccìon.Location = new System.Drawing.Point(5, 259);
            this.gbOperacionesDeProyeccìon.Name = "gbOperacionesDeProyeccìon";
            this.gbOperacionesDeProyeccìon.Size = new System.Drawing.Size(228, 138);
            this.gbOperacionesDeProyeccìon.TabIndex = 1;
            this.gbOperacionesDeProyeccìon.TabStop = false;
            this.gbOperacionesDeProyeccìon.Text = "Operaciones De Proyección - SELECT";
            // 
            // gbOperaciónesDeSelección
            // 
            this.gbOperaciónesDeSelección.Controls.Add(this.btnSelecciónSimple);
            this.gbOperaciónesDeSelección.Controls.Add(this.btnSelecciónMultiatributo);
            this.gbOperaciónesDeSelección.Controls.Add(this.btnSelecciónPorConvolución);
            this.gbOperaciónesDeSelección.Location = new System.Drawing.Point(239, 259);
            this.gbOperaciónesDeSelección.Name = "gbOperaciónesDeSelección";
            this.gbOperaciónesDeSelección.Size = new System.Drawing.Size(242, 138);
            this.gbOperaciónesDeSelección.TabIndex = 0;
            this.gbOperaciónesDeSelección.TabStop = false;
            this.gbOperaciónesDeSelección.Text = "Operaciónes De Selección - WHERE";
            // 
            // gbOperaciónesAlgebraicas
            // 
            this.gbOperaciónesAlgebraicas.Controls.Add(this.bntUnion);
            this.gbOperaciónesAlgebraicas.Controls.Add(this.btnIntersección);
            this.gbOperaciónesAlgebraicas.Controls.Add(this.btnDiferencia);
            this.gbOperaciónesAlgebraicas.Location = new System.Drawing.Point(487, 259);
            this.gbOperaciónesAlgebraicas.Name = "gbOperaciónesAlgebraicas";
            this.gbOperaciónesAlgebraicas.Size = new System.Drawing.Size(243, 138);
            this.gbOperaciónesAlgebraicas.TabIndex = 0;
            this.gbOperaciónesAlgebraicas.TabStop = false;
            this.gbOperaciónesAlgebraicas.Text = "Operaciónes Algebraicas";
            // 
            // btnProyeccìonSimple
            // 
            this.btnProyeccìonSimple.Location = new System.Drawing.Point(6, 19);
            this.btnProyeccìonSimple.Name = "btnProyeccìonSimple";
            this.btnProyeccìonSimple.Size = new System.Drawing.Size(201, 23);
            this.btnProyeccìonSimple.TabIndex = 2;
            this.btnProyeccìonSimple.Text = "Proyeccìon Simple";
            this.btnProyeccìonSimple.UseVisualStyleBackColor = true;
            // 
            // btnProyeccìonMultiatributo
            // 
            this.btnProyeccìonMultiatributo.Location = new System.Drawing.Point(6, 52);
            this.btnProyeccìonMultiatributo.Name = "btnProyeccìonMultiatributo";
            this.btnProyeccìonMultiatributo.Size = new System.Drawing.Size(201, 23);
            this.btnProyeccìonMultiatributo.TabIndex = 3;
            this.btnProyeccìonMultiatributo.Text = "Proyeccìon Multiatributo";
            this.btnProyeccìonMultiatributo.UseVisualStyleBackColor = true;
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(6, 81);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(200, 23);
            this.btnJuntar.TabIndex = 4;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            // 
            // btnSelecciónSimple
            // 
            this.btnSelecciónSimple.Location = new System.Drawing.Point(25, 23);
            this.btnSelecciónSimple.Name = "btnSelecciónSimple";
            this.btnSelecciónSimple.Size = new System.Drawing.Size(200, 23);
            this.btnSelecciónSimple.TabIndex = 5;
            this.btnSelecciónSimple.Text = "Selección Simple";
            this.btnSelecciónSimple.UseVisualStyleBackColor = true;
            // 
            // btnSelecciónMultiatributo
            // 
            this.btnSelecciónMultiatributo.Location = new System.Drawing.Point(25, 52);
            this.btnSelecciónMultiatributo.Name = "btnSelecciónMultiatributo";
            this.btnSelecciónMultiatributo.Size = new System.Drawing.Size(200, 23);
            this.btnSelecciónMultiatributo.TabIndex = 6;
            this.btnSelecciónMultiatributo.Text = "Selección Multiatributo";
            this.btnSelecciónMultiatributo.UseVisualStyleBackColor = true;
            // 
            // btnSelecciónPorConvolución
            // 
            this.btnSelecciónPorConvolución.Location = new System.Drawing.Point(25, 81);
            this.btnSelecciónPorConvolución.Name = "btnSelecciónPorConvolución";
            this.btnSelecciónPorConvolución.Size = new System.Drawing.Size(200, 23);
            this.btnSelecciónPorConvolución.TabIndex = 7;
            this.btnSelecciónPorConvolución.Text = "Selección Por Convolución";
            this.btnSelecciónPorConvolución.UseVisualStyleBackColor = true;
            // 
            // bntUnion
            // 
            this.bntUnion.Location = new System.Drawing.Point(26, 19);
            this.bntUnion.Name = "bntUnion";
            this.bntUnion.Size = new System.Drawing.Size(188, 23);
            this.bntUnion.TabIndex = 8;
            this.bntUnion.Text = "Intersección";
            this.bntUnion.UseVisualStyleBackColor = true;
            // 
            // btnIntersección
            // 
            this.btnIntersección.Location = new System.Drawing.Point(26, 52);
            this.btnIntersección.Name = "btnIntersección";
            this.btnIntersección.Size = new System.Drawing.Size(188, 23);
            this.btnIntersección.TabIndex = 9;
            this.btnIntersección.Text = "Intersección";
            this.btnIntersección.UseVisualStyleBackColor = true;
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(26, 81);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(188, 23);
            this.btnDiferencia.TabIndex = 10;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            // 
            // frmBaseDatosOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 409);
            this.Controls.Add(this.gbOperaciónesDeSelección);
            this.Controls.Add(this.gbOperaciónesAlgebraicas);
            this.Controls.Add(this.gbOperacionesDeProyeccìon);
            this.Controls.Add(this.dgvBaseDeOperaciones);
            this.Name = "frmBaseDatosOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseDatosOperaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseDeOperaciones)).EndInit();
            this.gbOperacionesDeProyeccìon.ResumeLayout(false);
            this.gbOperaciónesDeSelección.ResumeLayout(false);
            this.gbOperaciónesAlgebraicas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBaseDeOperaciones;
        private System.Windows.Forms.GroupBox gbOperacionesDeProyeccìon;
        private System.Windows.Forms.Button btnProyeccìonSimple;
        private System.Windows.Forms.Button btnProyeccìonMultiatributo;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.GroupBox gbOperaciónesDeSelección;
        private System.Windows.Forms.Button btnSelecciónSimple;
        private System.Windows.Forms.Button btnSelecciónMultiatributo;
        private System.Windows.Forms.Button btnSelecciónPorConvolución;
        private System.Windows.Forms.GroupBox gbOperaciónesAlgebraicas;
        private System.Windows.Forms.Button bntUnion;
        private System.Windows.Forms.Button btnIntersección;
        private System.Windows.Forms.Button btnDiferencia;
    }
}