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
    public partial class frmEstructuraDeDatos_Pila : Form
    {
        public frmEstructuraDeDatos_Pila()
        {
            InitializeComponent();
        }
        clsPila Pila = new clsPila();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo obj = new clsNodo();
            obj.Codigo = Convert.ToInt32(txtCodigo.Text);
            obj.Nombre = txtNombre.Text;
            obj.Tramite = txtTramite.Text;
            Pila.Agregar(obj);
            Pila.Recorrer(dgvGrilla);
            Pila.Recorrer(lstPila);
            Pila.Recorrer();
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Pila.Primero != null)
            {
                lblCodigo2.Text = Pila.Primero.Codigo.ToString();
                lblNombre2.Text = Pila.Primero.Nombre;
                lblTramite2.Text = Pila.Primero.Tramite;
                Pila.Eliminar();
                Pila.Recorrer(dgvGrilla);
                Pila.Recorrer();


            }
            else
            {
                lblCodigo2.Text = "";
                lblNombre2.Text = "";
                lblTramite2.Text = "";
            }
        }
    }
}
