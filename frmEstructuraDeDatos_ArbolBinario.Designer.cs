namespace pryEstructuraDeDatos
{
    partial class frmEstructuraDeDatos_ArbolBinario
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
            this.rdOrdenDesendente = new System.Windows.Forms.RadioButton();
            this.rdInOrden = new System.Windows.Forms.RadioButton();
            this.rdPreOrden = new System.Windows.Forms.RadioButton();
            this.rdPostOrden = new System.Windows.Forms.RadioButton();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRAMITE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbElementoEliminar = new System.Windows.Forms.GroupBox();
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
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.gbElementoEliminar.SuspendLayout();
            this.gbNuevoElemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListado
            // 
            this.gbListado.Controls.Add(this.rdOrdenDesendente);
            this.gbListado.Controls.Add(this.rdInOrden);
            this.gbListado.Controls.Add(this.rdPreOrden);
            this.gbListado.Controls.Add(this.rdPostOrden);
            this.gbListado.Controls.Add(this.dgvGrilla);
            this.gbListado.Location = new System.Drawing.Point(6, 242);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(673, 210);
            this.gbListado.TabIndex = 20;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado del arból";
            // 
            // rdOrdenDesendente
            // 
            this.rdOrdenDesendente.AutoSize = true;
            this.rdOrdenDesendente.Location = new System.Drawing.Point(6, 70);
            this.rdOrdenDesendente.Name = "rdOrdenDesendente";
            this.rdOrdenDesendente.Size = new System.Drawing.Size(135, 17);
            this.rdOrdenDesendente.TabIndex = 29;
            this.rdOrdenDesendente.Text = "In-Orden Descendiente";
            this.rdOrdenDesendente.UseVisualStyleBackColor = true;
            this.rdOrdenDesendente.CheckedChanged += new System.EventHandler(this.rdOrdenDesendente_CheckedChanged);
            // 
            // rdInOrden
            // 
            this.rdInOrden.AutoSize = true;
            this.rdInOrden.Checked = true;
            this.rdInOrden.Location = new System.Drawing.Point(6, 36);
            this.rdInOrden.Name = "rdInOrden";
            this.rdInOrden.Size = new System.Drawing.Size(66, 17);
            this.rdInOrden.TabIndex = 25;
            this.rdInOrden.TabStop = true;
            this.rdInOrden.Text = "In-Orden";
            this.rdInOrden.UseVisualStyleBackColor = true;
            this.rdInOrden.CheckedChanged += new System.EventHandler(this.rbInOrden_CheckedChanged);
            // 
            // rdPreOrden
            // 
            this.rdPreOrden.AutoSize = true;
            this.rdPreOrden.Location = new System.Drawing.Point(6, 105);
            this.rdPreOrden.Name = "rdPreOrden";
            this.rdPreOrden.Size = new System.Drawing.Size(73, 17);
            this.rdPreOrden.TabIndex = 26;
            this.rdPreOrden.Text = "Pre-Orden";
            this.rdPreOrden.UseVisualStyleBackColor = true;
            this.rdPreOrden.CheckedChanged += new System.EventHandler(this.rdPreOrden_CheckedChanged);
            // 
            // rdPostOrden
            // 
            this.rdPostOrden.AutoSize = true;
            this.rdPostOrden.Location = new System.Drawing.Point(6, 137);
            this.rdPostOrden.Name = "rdPostOrden";
            this.rdPostOrden.Size = new System.Drawing.Size(78, 17);
            this.rdPostOrden.TabIndex = 27;
            this.rdPostOrden.Text = "Post-Orden";
            this.rdPostOrden.UseVisualStyleBackColor = true;
            this.rdPostOrden.CheckedChanged += new System.EventHandler(this.rdPostOrden_CheckedChanged);
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
            this.gbElementoEliminar.Controls.Add(this.cbEliminar);
            this.gbElementoEliminar.Controls.Add(this.btnEliminar);
            this.gbElementoEliminar.Controls.Add(this.lblCodigo2);
            this.gbElementoEliminar.Location = new System.Drawing.Point(467, 12);
            this.gbElementoEliminar.Name = "gbElementoEliminar";
            this.gbElementoEliminar.Size = new System.Drawing.Size(202, 135);
            this.gbElementoEliminar.TabIndex = 21;
            this.gbElementoEliminar.TabStop = false;
            this.gbElementoEliminar.Text = "Elemento a eliminar";
            // 
            // cbEliminar
            // 
            this.cbEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEliminar.FormattingEnabled = true;
            this.cbEliminar.Location = new System.Drawing.Point(75, 35);
            this.cbEliminar.Name = "cbEliminar";
            this.cbEliminar.Size = new System.Drawing.Size(115, 21);
            this.cbEliminar.TabIndex = 10;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(20, 70);
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
            this.lblCodigo2.Location = new System.Drawing.Point(17, 38);
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
            this.gbNuevoElemento.Location = new System.Drawing.Point(242, 12);
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
            // btnEquilibrar
            // 
            this.btnEquilibrar.Location = new System.Drawing.Point(487, 169);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(161, 35);
            this.btnEquilibrar.TabIndex = 24;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(6, 5);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(230, 234);
            this.treeView1.TabIndex = 28;
            // 
            // frmEstructuraDeDatos_ArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 459);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.gbElementoEliminar);
            this.Controls.Add(this.gbNuevoElemento);
            this.Name = "frmEstructuraDeDatos_ArbolBinario";
            this.Text = "EstructuraDeDatos_Arbol Binario";
            this.gbListado.ResumeLayout(false);
            this.gbListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.gbElementoEliminar.ResumeLayout(false);
            this.gbElementoEliminar.PerformLayout();
            this.gbNuevoElemento.ResumeLayout(false);
            this.gbNuevoElemento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRAMITE;
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
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.RadioButton rdInOrden;
        private System.Windows.Forms.RadioButton rdPreOrden;
        private System.Windows.Forms.RadioButton rdPostOrden;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RadioButton rdOrdenDesendente;
    }
}