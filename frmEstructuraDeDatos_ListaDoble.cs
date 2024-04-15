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

            clsNodo obj = new clsNodo();
            obj.Codigo = Convert.ToInt32(txtCodigo.Text);
            obj.Nombre = txtNombre.Text;
            obj.Tramite = txtTramite.Text;

            // Determine order based on radio button
            if (rdAsendente.Checked)
            {
                listaDoble.Agregar(obj); // Add in ascending order
            }
            else if (rdDesendente.Checked)
            {
                listaDoble.Agregar(obj); // Add in descending order (assuming you have a method for this)
            }

            listaDoble.Recorer(dgvGrilla); // Update DataGridView
        }









    }
    
}
