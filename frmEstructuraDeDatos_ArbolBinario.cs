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
    public partial class frmEstructuraDeDatos_ArbolBinario : Form
    {
        public frmEstructuraDeDatos_ArbolBinario()
        {
            InitializeComponent();
        }
        ClsArbolBinario Arbol = new ClsArbolBinario();  
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            Arbol.Agregar(objNodo);

           

            Arbol.RecorrerInOrderDataGrid(dgvGrilla);
            Arbol.Recorrertree(tvwArbolBinario);
            Arbol.RecorrerInOrderCombo(cbEliminar);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

        }

        private void rbInOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (rdInOrden.Checked == true)
            {
                Arbol.RecorrerInOrderDataGrid(dgvGrilla);
                Arbol.RecorrerInOrderCombo(cbEliminar);
                Arbol.RecorrerInOrderStreamWriter();
            }
        }

        private void rdPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPreOrden.Checked == true)
            {
                Arbol.RecorrerPreOrden(dgvGrilla);
                Arbol.Recorrertree(tvwArbolBinario);
                Arbol.RecorrerPreOrden();
               

                
            }
        }

        private void rdOrdenDesendente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdOrdenDesendente.Checked==true)
            {
                Arbol.RecorrerDescGrilla(dgvGrilla);
                Arbol.RecorrerComboDesc(cbEliminar);
                Arbol.RecorrerInOrdenDesc();
            }
        }

        private void rdPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPostOrden.Checked ==  true)
            {
                Arbol.RecorrerPostOrdenGrilla(dgvGrilla);
                Arbol.RecorrerPostOrden();
         

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           btnEliminar.Enabled = false;
            if (cbEliminar.SelectedIndex != -1)
            {
                Int32 x = Convert.ToInt32(cbEliminar.Text);
                Arbol.Eliminar(x);
                Arbol.RecorrerInOrderDataGrid(dgvGrilla);
                Arbol.Recorrertree(tvwArbolBinario);
                Arbol.RecorrerInOrderCombo(cbEliminar); 
               
            }
            else
            {
                
                MessageBox.Show("Falta Selecionar Elemento ");
            }

        }

        private void cbEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEliminar.SelectedIndex ==cbEliminar.Items.Count -1)
            {
                btnEliminar.Enabled = false;
            }
            else
            {
                btnEliminar.Enabled = true;
            }
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            Arbol.Equilibrar();
            Arbol.RecorrerInOrderDataGrid(dgvGrilla);
            Arbol.Recorrertree(tvwArbolBinario);
            Arbol.RecorrerInOrderCombo(cbEliminar);
            Arbol.RecorrerInOrderStreamWriter();




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
