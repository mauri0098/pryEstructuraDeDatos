using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDeDatos
{
    internal class clsCola
    {
        //Campos Clase
        private clsNodo pri;
        private clsNodo ult;

        //Propiedades De Clase
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }
        //Metodos de clase 
        public void Agregar(clsNodo Nuevo)
        {

            if (Primero == null) //si en el primero no ahi nadie entonces
            {
                Primero = Nuevo;//el primero pasa a ser el nuevo 
                Ultimo = Nuevo;//y el ultimo 
            }
            else
            {

                Ultimo.Siguiente = Nuevo;//si en el primero ahi alguien entoces el ultimo es el siguente 
                Ultimo = Nuevo;//el ultimo es el nuevo 

            }
        }

        public void Eliminar()
        {
            if (Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {

                Primero = Primero.Siguiente;

            }

        }
        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;

            }
        }
        public void Recorrer(ListBox Lista)
        {
            clsNodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo);
                aux = aux.Siguiente;



            }
        }
        public void Recorrer(ComboBox Combo)
        {
            clsNodo aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer()
        {
            clsNodo aux = Primero;
            StreamWriter AD = new StreamWriter("Cola.csv",false,Encoding.UTF8);
            AD.WriteLine("Lista De Espera/n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            while(aux != null)
            {
                AD.WriteLine(aux.Codigo);
                AD.WriteLine(";");
                AD.WriteLine(aux.Nombre);
                AD.WriteLine(";");
                AD.WriteLine(aux.Tramite);
                aux=aux.Siguiente;
            }
            AD.Close();
        }



    }
}
