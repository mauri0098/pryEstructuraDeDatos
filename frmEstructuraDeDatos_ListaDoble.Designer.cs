namespace pryEstructuraDeDatos
{
    partial class frmEstructuraDeDatos_ListaDoble
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
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.lst = new System.Windows.Forms.ListBox();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRAMITE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbElementoEliminar = new System.Windows.Forms.GroupBox();
            this.gbListarDatos = new System.Windows.Forms.GroupBox();
            this.rdDesendente = new System.Windows.Forms.RadioButton();
            this.rdAsendente = new System.Windows.Forms.RadioButton();
            this.cbEliminar = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.gbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.gbElementoEliminar.SuspendLayout();
            this.gbListarDatos.SuspendLayout();
            this.gbNuevoElemento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbListado
            // 
            this.gbListado.Controls.Add(this.lst);
            this.gbListado.Controls.Add(this.dgvGrilla);
            this.gbListado.Location = new System.Drawing.Point(3, 235);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(673, 210);
            this.gbListado.TabIndex = 20;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado en una lista y una grilla";
            // 
            // lst
            // 
            this.lst.FormattingEnabled = true;
            this.lst.Location = new System.Drawing.Point(6, 19);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(224, 186);
            this.lst.TabIndex = 15;
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.Nombre,
            this.TRAMITE});
            this.dgvGrilla.Location = new System.Drawing.Point(236, 18);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(427, 186);
            this.dgvGrilla.TabIndex = 14;
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "código";
            this.CODIGO.Name = "CODIGO";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // TRAMITE
            // 
            this.TRAMITE.HeaderText = "Tramite";
            this.TRAMITE.Name = "TRAMITE";
            // 
            // gbElementoEliminar
            // 
            this.gbElementoEliminar.Controls.Add(this.gbListarDatos);
            this.gbElementoEliminar.Controls.Add(this.cbEliminar);
            this.gbElementoEliminar.Controls.Add(this.btnEliminar);
            this.gbElementoEliminar.Controls.Add(this.lblCodigo2);
            this.gbElementoEliminar.Location = new System.Drawing.Point(464, 5);
            this.gbElementoEliminar.Name = "gbElementoEliminar";
            this.gbElementoEliminar.Size = new System.Drawing.Size(212, 227);
            this.gbElementoEliminar.TabIndex = 21;
            this.gbElementoEliminar.TabStop = false;
            this.gbElementoEliminar.Text = "Elemento a eliminar";
            // 
            // gbListarDatos
            // 
            this.gbListarDatos.Controls.Add(this.rdDesendente);
            this.gbListarDatos.Controls.Add(this.rdAsendente);
            this.gbListarDatos.Location = new System.Drawing.Point(6, 121);
            this.gbListarDatos.Name = "gbListarDatos";
            this.gbListarDatos.Size = new System.Drawing.Size(196, 100);
            this.gbListarDatos.TabIndex = 11;
            this.gbListarDatos.TabStop = false;
            this.gbListarDatos.Text = "Listar Datos";
            // 
            // rdDesendente
            // 
            this.rdDesendente.AutoSize = true;
            this.rdDesendente.Location = new System.Drawing.Point(6, 45);
            this.rdDesendente.Name = "rdDesendente";
            this.rdDesendente.Size = new System.Drawing.Size(83, 17);
            this.rdDesendente.TabIndex = 1;
            this.rdDesendente.TabStop = true;
            this.rdDesendente.Text = "Desendente";
            this.rdDesendente.UseVisualStyleBackColor = true;
            this.rdDesendente.CheckedChanged += new System.EventHandler(this.rdDesendente_CheckedChanged);
            // 
            // rdAsendente
            // 
            this.rdAsendente.AutoSize = true;
            this.rdAsendente.Location = new System.Drawing.Point(6, 19);
            this.rdAsendente.Name = "rdAsendente";
            this.rdAsendente.Size = new System.Drawing.Size(76, 17);
            this.rdAsendente.TabIndex = 0;
            this.rdAsendente.TabStop = true;
            this.rdAsendente.Text = "Asendente";
            this.rdAsendente.UseVisualStyleBackColor = true;
            this.rdAsendente.CheckedChanged += new System.EventHandler(this.rdAsendente_CheckedChanged);
            // 
            // cbEliminar
            // 
            this.cbEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEliminar.FormattingEnabled = true;
            this.cbEliminar.Location = new System.Drawing.Point(75, 26);
            this.cbEliminar.Name = "cbEliminar";
            this.cbEliminar.Size = new System.Drawing.Size(115, 21);
            this.cbEliminar.TabIndex = 10;
            this.cbEliminar.SelectedIndexChanged += new System.EventHandler(this.cbEliminar_SelectedIndexChanged);
            this.cbEliminar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbEliminar_KeyPress);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(29, 59);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(161, 35);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Location = new System.Drawing.Point(26, 29);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo2.TabIndex = 3;
            this.lblCodigo2.Text = "Código:";
            // 
            // gbNuevoElemento
            // 
            this.gbNuevoElemento.Controls.Add(this.btnAgregar);
            this.gbNuevoElemento.Controls.Add(this.txtTramite);
            this.gbNuevoElemento.Controls.Add(this.txtNombre);
            this.gbNuevoElemento.Controls.Add(this.txtCodigo);
            this.gbNuevoElemento.Controls.Add(this.lblTramite);
            this.gbNuevoElemento.Controls.Add(this.lblNombre);
            this.gbNuevoElemento.Controls.Add(this.lblCodigo);
            this.gbNuevoElemento.Location = new System.Drawing.Point(239, 5);
            this.gbNuevoElemento.Name = "gbNuevoElemento";
            this.gbNuevoElemento.Size = new System.Drawing.Size(219, 227);
            this.gbNuevoElemento.TabIndex = 22;
            this.gbNuevoElemento.TabStop = false;
            this.gbNuevoElemento.Text = "Nuevo Elemento";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(28, 157);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(160, 35);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(88, 102);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(88, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(123, 38);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(65, 20);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(13, 106);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(45, 13);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Trámite:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(13, 41);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryEstructuraDeDatos.Properties.Resources._0_F7Qnr7Zs_dobles_s_;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // frmEstructuraDeDatos_ListaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbElementoEliminar);
            this.Controls.Add(this.gbNuevoElemento);
            this.Name = "frmEstructuraDeDatos_ListaDoble";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura De Datos_ListaDoble";
            this.Load += new System.EventHandler(this.frmEstructuraDeDatos_ListaDoble_Load);
            this.gbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.gbElementoEliminar.ResumeLayout(false);
            this.gbElementoEliminar.PerformLayout();
            this.gbListarDatos.ResumeLayout(false);
            this.gbListarDatos.PerformLayout();
            this.gbNuevoElemento.ResumeLayout(false);
            this.gbNuevoElemento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRAMITE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbElementoEliminar;
        private System.Windows.Forms.ComboBox cbEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.GroupBox gbNuevoElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox gbListarDatos;
        private System.Windows.Forms.RadioButton rdDesendente;
        private System.Windows.Forms.RadioButton rdAsendente;
    }
}