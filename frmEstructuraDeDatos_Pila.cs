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
            try
            {
                clsNodo obj = new clsNodo();
                obj.Codigo = Convert.ToInt32(txtCodigo.Text);
                obj.Nombre = txtNombre.Text;
                obj.Tramite = txtTramite.Text;

                
                if (!string.IsNullOrWhiteSpace(txtNombre.Text) && !txtNombre.Text.All(char.IsLetter))
                {
                    MessageBox.Show("Se debe rellener la casilla de codigo y debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }


                Pila.Agregar(obj);
                Pila.Recorrer(dgvGrilla);
                Pila.Recorrer(lstPila);
                Pila.Recorrer();
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("El código debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                Pila.Recorrer(lstPila);
                Pila.Recorrer();

            }
            else
            {
                lblCodigo2.Text = "";
                lblNombre2.Text = "";
                lblTramite2.Text = "";
            }
        }

        private void frmEstructuraDeDatos_Pila_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            btnAgregar.Enabled = !string.IsNullOrWhiteSpace(txtCodigo.Text);
        }

        private void frmEstructuraDeDatos_Pila_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
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
