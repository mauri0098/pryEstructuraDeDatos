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
    public partial class frmEstructuraDeDatos_ListaDoble : Form
    {
        public frmEstructuraDeDatos_ListaDoble()
        {
            InitializeComponent();
        }
        clsListaDoble listaDoble = new clsListaDoble();
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            int codigo = Convert.ToInt32(txtCodigo.Text);
            clsNodo Obj = new clsNodo();
            Obj.Codigo = codigo;
            Obj.Nombre = txtNombre.Text;
            Obj.Tramite = txtTramite.Text;
           
            if (!string.IsNullOrWhiteSpace(txtNombre.Text) && !txtNombre.Text.All(char.IsLetter))
            {
                MessageBox.Show("El nombre solo puede contener letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            listaDoble.Agregar(Obj);
            if (rdAsendente.Checked == true)
            {
                
                listaDoble.Recorrer(dgvGrilla);
                listaDoble.Recorrer(lst);
                listaDoble.Recorrer(cbEliminar);
                listaDoble.Recorrer();
            }
            if (rdDesendente.Checked==true)
            {
               
                listaDoble.RecorrerDes(dgvGrilla);
                listaDoble.RecorrerDes(lst);
                listaDoble.RecorrerDes(cbEliminar);
                listaDoble.RecorrerDes();
            }
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;
            if (listaDoble.Primero != null)
            {
                Int32 x = Convert.ToInt32(cbEliminar.Text);
                listaDoble.Eliminar(x);
                listaDoble.Recorrer(dgvGrilla);
                listaDoble.Recorrer(lst);
                listaDoble.Recorrer(cbEliminar);
                listaDoble.Recorrer();

            }
            else
            {
                MessageBox.Show("Seleccione un dato");
            }

        }

        private void rdAsendente_CheckedChanged(object sender, EventArgs e)
        {

            if (rdAsendente.Checked == true)
            {
                listaDoble.Recorrer(dgvGrilla);
                listaDoble.Recorrer(lst);
                listaDoble.Recorrer(cbEliminar);
                listaDoble.Recorrer();
            }


        }

        private void rdDesendente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDesendente.Checked == true)
            {
                listaDoble.RecorrerDes(dgvGrilla);
                listaDoble.RecorrerDes(lst);
                listaDoble.RecorrerDes(cbEliminar);
                listaDoble.RecorrerDes();
            }
           


        }

        private void frmEstructuraDeDatos_ListaDoble_Load(object sender, EventArgs e)
        {
            rdAsendente.Checked = true;
            btnAgregar.Enabled = false;

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            btnAgregar.Enabled = !string.IsNullOrWhiteSpace(txtCodigo.Text);
            
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void cbEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void cbEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEliminar.SelectedIndex == -1)
            {
                btnEliminar.Enabled = false;
            }
            else
            {
                btnEliminar.Enabled = true;
            }
        }
    }
    
}
