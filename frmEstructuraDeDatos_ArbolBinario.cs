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

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

            Arbol.Recorrer(dgvGrilla);
            Arbol.Recorrertree(treeView1);
           


        }

        private void rbInOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (rdInOrden.Checked == true)
            {
                Arbol.Recorrer(dgvGrilla);
                Arbol.Recorrer(cbEliminar);
               
                
            }
        }

        private void rdPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPreOrden.Checked == true)
            {
                Arbol.RecorrerPreOrden(dgvGrilla);
                Arbol.Recorrertree(treeView1);
                Arbol.RecorrerPreOrden();
               

                
            }
        }

        private void rdOrdenDesendente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdOrdenDesendente.Checked==true)
            {
                Arbol.RecorrerDescGrilla(dgvGrilla);
                Arbol.RecorrerComboDesc(cbEliminar);
                Arbol.RecorrerInOrdenDescAD();
            }
        }

        private void rdPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPostOrden.Checked ==  true)
            {
                Arbol.RecorrerPostOrdenGrilla(dgvGrilla);
          
             



            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cbEliminar.SelectedIndex != -1)
            {
                Int32 x = Convert.ToInt32(cbEliminar.Text);
                Arbol.Eliminar(x);
                Arbol.Recorrer(dgvGrilla);
                Arbol.Recorrertree(treeView1);
                Arbol.Recorrer(cbEliminar); 

            }
            else
            {
                MessageBox.Show("Falta Selecionar Elemento ");
            }
        }
    }
}
