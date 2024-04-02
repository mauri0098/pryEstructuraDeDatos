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
    public partial class frmEstructurasDeDatos : Form
    {
        public frmEstructurasDeDatos()
        {
            InitializeComponent();
        }

        private void repasoDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void datosDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosDeAlumnos alumnos = new frmDatosDeAlumnos();
            alumnos.ShowDialog();

        }
    }
}
