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
    public partial class frmBaseDatosRepasoOperaciones : Form
    {
        public frmBaseDatosRepasoOperaciones()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsBasedeDatos objBaseDatos = new clsBasedeDatos();
            string varSQL = "SELECT * FROM Libro ";

            switch (cbOperaciones.SelectedIndex)
            {
                case 0:
                    lblOperacion.Text = $"{cbOperaciones.Text}: Proyección Simple de Nombres de los autores ordenados alfabéticamente de la A a la Z";
                    varSQL = "SELECT Nombre FROM Autor ORDER BY Nombre ASC";
                    objBaseDatos.Listar1(dgvOperaciones, varSQL);
                    break;

                case 1:
                    lblOperacion.Text = $"{cbOperaciones.Text}: Proyección Simple de Nombres de los países ordenados alfabéticamente de la A a la Z";
                    varSQL = "SELECT Nombre FROM Pais ORDER BY Nombre ASC";
                    objBaseDatos.Listar1(dgvOperaciones, varSQL);
                    break;

                case 2:
                    lblOperacion.Text = $"{cbOperaciones.Text}: Proyección Simple de Nombres de los idiomas ordenados alfabéticamente de la Z a la A";
                    varSQL = "SELECT Nombre FROM Idioma ORDER BY Nombre DESC";
                    objBaseDatos.Listar1(dgvOperaciones, varSQL);
                    break;

                case 3:
                    lblOperacion.Text = $"{cbOperaciones.Text}: Proyección Multiatributo de Títulos de los libros con la cantidad de unidades disponibles en inventario";
                    varSQL = "SELECT Titulo, Cantidad FROM Libro";
                    objBaseDatos.Listar1(dgvOperaciones, varSQL);
                    break;

                case 4:
                    lblOperacion.Text = $"{cbOperaciones.Text}: Proyección Multiatributo de Títulos de los libros con su precio de venta";
                    varSQL = "SELECT Titulo, Precio FROM Libro";
                    objBaseDatos.Listar1(dgvOperaciones, varSQL);
                    break;

                case 5:
                    lblOperacion.Text = $"{cbOperaciones.Text}: Proyección Simple de Títulos de los libros ordenados alfabéticamente de la Z a la A";
                    varSQL = "SELECT Titulo FROM Libro ORDER BY Titulo DESC";
                    objBaseDatos.Listar1(dgvOperaciones, varSQL);
                    break;


                case 6:
                    lblOperacion.Text = $"{cbOperaciones.Text}: Unión de libros Decamerón y Diario de un loco";
                    varSQL = "SELECT * FROM Libro WHERE IdLibro = 14 " +
                             "UNION " +
                             "SELECT * FROM Libro WHERE IdLibro = 13";
                    objBaseDatos.Listar1(dgvOperaciones, varSQL);
                    break;


                case 7:
                    lblOperacion.Text = $"{cbOperaciones.Text}: Libros escritos por Ralph Ellison o Jorge Luis Borges";
                    varSQL = "SELECT * FROM Libro WHERE IdAutor = 21 " +
                             "UNION " +
                             "SELECT * FROM Libro WHERE IdAutor = 33";
                    objBaseDatos.Listar1(dgvOperaciones, varSQL);
                    break;

                case 8:
                    lblOperacion.Text = $"{cbOperaciones.Text}: Libros cuyo país de origen es Portugal o Islandia";
                    varSQL = "SELECT * FROM Libro WHERE IdPais IN (SELECT DISTINCT IdPais FROM Libro WHERE IdPais = 22 OR IdPais = 25)";
                    objBaseDatos.Listar1(dgvOperaciones, varSQL);
                    break;
                
                case 9:
                    lblOperacion.Text = $"{cbOperaciones.Text}: Libros en Persa o Francés";
                    varSQL = "SELECT * FROM Libro WHERE IdIdioma = 4 " +
                             "UNION " +
                             "SELECT * FROM Libro WHERE IdIdioma = 11";
                    objBaseDatos.Listar1(dgvOperaciones, varSQL);
                    break;
                
                case 10:
                    lblOperacion.Text = $"{cbOperaciones.Text}: Libros con los nombres de sus respectivos autores";
                    varSQL = "SELECT * " +
                             "FROM Libro, Autor " +
                             "WHERE Libro.IdAutor = Autor.IdAutor";
                    objBaseDatos.Listar1(dgvOperaciones, varSQL);
                    break;
                
                case 11:
                    lblOperacion.Text = cbOperaciones.Text + ": " +
                        "Libros que no hayan sido escritos por Virginia o Carlos";
                    varSQL = "SELECT * FROM Libro WHERE IdAutor " +
                    "NOT IN " +
                    "(SELECT DISTINCT IdIdioma FROM Libro WHERE IdAutor <= 3)";
                    objBaseDatos.Listar1(dgvOperaciones, varSQL);
                    break;
                
                case 12:
                    lblOperacion.Text = $"{cbOperaciones.Text}: Libros con los idiomas en los que fueron escritos";
                    varSQL = "SELECT * " +
                             "FROM Libro, Idioma " +
                             "WHERE Libro.IdIdioma = Idioma.IdIdioma";
                    objBaseDatos.Listar1(dgvOperaciones, varSQL);
                    break;

                case 13:
                    lblOperacion.Text = cbOperaciones.Text + ": " +
                        "Libros que tienen una cantidad de 9 unidades";
                    varSQL = "SELECT * FROM Libro " +
                    "WHERE Cantidad = 9";
                    objBaseDatos.Listar1(dgvOperaciones, varSQL);
                    break;

                case 14:
                    lblOperacion.Text = cbOperaciones.Text + ": " +
                        "Libros que tienen un precio de 741 pesos";
                    varSQL = "SELECT * FROM Libro " +
                    "WHERE Precio = 741";
                    objBaseDatos.Listar1(dgvOperaciones, varSQL);
                    break;

                case 15:
                    lblOperacion.Text = cbOperaciones.Text + ": " +
                        "Libros escritos en 1929";
                    varSQL = "SELECT * FROM Libro " +
                    "WHERE Año = '1929'";
                    objBaseDatos.Listar1(dgvOperaciones, varSQL);
                    break;


                case 16:
                    lblOperacion.Text = $"{cbOperaciones.Text}: Mostrar libros en idioma Persa";
                    varSQL = "SELECT * FROM Libro " +
                             "WHERE IdIdioma = 4";  
                    objBaseDatos.Listar1(dgvOperaciones, varSQL);
                    break;

                case 17:
                    lblOperacion.Text = cbOperaciones.Text + ": " +
                        "Libros que no sean en Inglés, Ruso o Alemán";
                    varSQL = "SELECT * FROM Libro WHERE IdIdioma " +
                    "NOT IN " +
                    "(SELECT DISTINCT IdIdioma FROM Libro WHERE IdIdioma <= 3) ";
                    objBaseDatos.Listar1(dgvOperaciones, varSQL);
                    break;
                
                case 18:
                    lblOperacion.Text = $"{cbOperaciones.Text}: Mostrar libros de Estados Unidos";
                    varSQL = "SELECT * FROM Libro " +
                             "WHERE IdPais = 4";  // Suponiendo que el ID 4 corresponde al idioma Persa
                    objBaseDatos.Listar1(dgvOperaciones, varSQL);
                    break;

                case 19:
                    lblOperacion.Text = $"{cbOperaciones.Text}: Unión de pais China  y Estados Unidos";
                    varSQL = "SELECT * FROM Libro WHERE IdLibro = 4 " +
                             "UNION " +
                             "SELECT * FROM Libro WHERE IdLibro = 11";
                    objBaseDatos.Listar1(dgvOperaciones, varSQL);
                    break;


            }






        }
    }
}
