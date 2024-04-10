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
    public partial class frmEstructuraDeDatos_ListaSimple : Form
    {
        public frmEstructuraDeDatos_ListaSimple()
        {
            InitializeComponent();
        }
        clsListaSimple simple = new clsListaSimple();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo obj = new clsNodo();
            obj.Codigo = Convert.ToInt32(txtCodigo.Text);
            obj.Nombre = txtNombre.Text;
            obj.Tramite = txtTramite.Text;
            simple.Agregar(obj);
            simple.Recorrer(dgvGrilla);
            simple.Recorrer(lst);
            simple.Recorrer(cbEliminar);
            simple.Recorrer();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (simple.Primero != null)
            {
                Int32 x = Convert.ToInt32(cbEliminar.Text);
                simple .Eliminar(x);
                simple.Recorrer(dgvGrilla);
                simple.Recorrer(lst);
                simple.Recorrer(cbEliminar);
                simple.Recorrer();

            }
            else
            {
                MessageBox.Show("La Lista Esta Vacia");
            }
            btnEliminar.Enabled = false;
        }

        private void frmEstructuraDeDatos_ListaSimple_Load(object sender, EventArgs e)
        {

        }
    }
}
