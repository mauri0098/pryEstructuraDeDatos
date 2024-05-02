using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDeDatos
{
    public partial class frmEstructuraDeDatos_Cola : Form
    {
        public frmEstructuraDeDatos_Cola()
        {
            InitializeComponent();
        }
        clsCola fila = new clsCola();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo obj = new clsNodo();
            obj.Codigo = Convert.ToInt32(txtCodigo.Text);
            obj.Nombre = txtNombre.Text;
            obj.Tramite = txtTramite.Text;
            fila.Agregar(obj);
            fila.Recorrer(dgvGrilla);
            fila.Recorrer(lstCola);
            fila.Recorrer();
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (fila.Primero != null)
            {
                lblCodigo.Text = fila.Primero.Codigo.ToString();
                lblNombre2.Text = fila.Primero.Nombre;
                lblTramite.Text = fila.Primero.Tramite;
                fila.Eliminar();
                fila.Recorrer(dgvGrilla);
                fila.Recorrer(lstCola);
                fila.Recorrer();


            }
            else
            {
                lblCodigo.Text = "";//que limpia esto preguntar 
                lblNombre2.Text = "";
                lblTramite.Text = "";

            }
        }
    }
}
