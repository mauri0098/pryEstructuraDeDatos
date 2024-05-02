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
        string letra = "";
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                string nombre = txtNombre.Text;
                string tramite = txtTramite.Text;

                // Verifica si el nombre contiene caracteres que no son letras
                if (!string.IsNullOrWhiteSpace(nombre) && !nombre.All(char.IsLetter))
                {
                    MessageBox.Show("El nombre solo puede contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Sale del método para evitar que se agregue el nodo
                }

                clsNodo obj = new clsNodo();
                obj.Codigo = codigo;
                obj.Nombre = nombre;
                obj.Tramite = tramite;

                fila.Agregar(obj);
                fila.Recorrer(dgvGrilla);
                fila.Recorrer(lstCola);
                fila.Recorrer();

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
            if (fila.Primero != null)
            {
                lblCodigo.Text = fila.Primero.Codigo.ToString();
                lblNombre.Text = fila.Primero.Nombre;
                lblTramite.Text = fila.Primero.Tramite;
                fila.Eliminar();
                fila.Recorrer(dgvGrilla);
                fila.Recorrer(lstCola);
                fila.Recorrer();


            }
            else
            {
                lblCodigo.Text = "";//que limpia esto preguntar 
                lblNombre.Text = "";
                lblTramite.Text = "";

            }

        }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            btnAgregar.Enabled = !string.IsNullOrWhiteSpace(txtCodigo.Text);
            
        }

        private void frmEstructuraDeDatos_Cola_Load(object sender, EventArgs e)
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
