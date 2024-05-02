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
            try
            {
                clsNodo obj = new clsNodo();
                obj.Codigo = Convert.ToInt32(txtCodigo.Text);
                obj.Nombre = txtNombre.Text;
                obj.Tramite = txtTramite.Text;


                if (!string.IsNullOrWhiteSpace(txtNombre.Text) && !txtNombre.Text.All(char.IsLetter))
                {
                    MessageBox.Show("El nombre solo puede contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                simple.Agregar(obj);
                simple.Recorrer(dgvGrilla);
                simple.Recorrer(lst);
                simple.Recorrer(cbEliminar);
                simple.Recorrer();
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";

            }
            catch (FormatException)
            {
                MessageBox.Show("Se debe rellener la casilla de codigo y debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
          
        }

        private void frmEstructuraDeDatos_ListaSimple_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
