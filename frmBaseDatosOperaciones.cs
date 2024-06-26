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
    public partial class frmBaseDatosOperaciones : Form
    {
        public frmBaseDatosOperaciones()
        {
            InitializeComponent();
        }
            clsBasedeDatos bases = new clsBasedeDatos();    

        private void btnProyeccìonSimple_Click(object sender, EventArgs e)
        {
            String sql = "select Titulo from Libro order by Titulo desc";

            bases.Listar1(dgvBaseDeOperaciones, sql);

        }

        private void btnProyeccìonMultiatributo_Click(object sender, EventArgs e)
        {
            String sql = "select IdLibro ,Titulo from Libro order by IdLibro asc";

            bases.Listar1(dgvBaseDeOperaciones, sql);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {

            String sql = "SELECT A.IdAutor ,  L.Titulo " +
                         "FROM Libro L " +
                        "INNER JOIN Autor A ON L.IdAutor = A.IdAutor "; 

            bases.Listar1(dgvBaseDeOperaciones, sql);
        }

        private void btnSelecciónSimple_Click(object sender, EventArgs e)
        {
            String sql = "select * from Libro where IdLibro <= 10";

            bases.Listar1(dgvBaseDeOperaciones, sql);
        }

        private void btnSelecciónMultiatributo_Click(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM Libro WHERE IdLibro <= 10 AND Precio < 500";

            bases.Listar1(dgvBaseDeOperaciones, sql);

        }

        private void btnSelecciónPorConvolución_Click(object sender, EventArgs e)
        {
            String sql = "SELECT * " +
                "FROM (SELECT * FROM Libro as T1 WHERE T1.IdIdioma > 5) " +
                "as T2 WHERE T2.IdAutor > 10";
            bases.Listar1(dgvBaseDeOperaciones, sql);



        }

        private void bntUnion_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * FROM Libro WHERE IdAutor = 2 " +
                "UNION " +
                "SELECT* FROM Libro WHERE IdAutor = 5 " +
                "UNION " +
                "SELECT* FROM Libro WHERE IdAutor = 3";
            bases.Listar1(dgvBaseDeOperaciones, varSQL);
        }

        private void btnIntersección_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * FROM Libro WHERE IdIdioma " +
                "IN " +
                "(SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma < 5)";
            bases.Listar1(dgvBaseDeOperaciones, varSQL);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT * FROM Libro WHERE IdIdioma " +
                "NOT IN " +
                "(SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma< 5)";
            bases.Listar1(dgvBaseDeOperaciones, varSQL);
        }
    }   
}
