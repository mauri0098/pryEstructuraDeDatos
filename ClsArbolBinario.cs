using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDeDatos
{
    internal class ClsArbolBinario
    {
        private clsNodo PrimeroNodo;

        public clsNodo Raiz
        {
            get { return PrimeroNodo; }

            set { PrimeroNodo = value; }
        }
        public void Agregar(clsNodo Nuevo)
        {
            Nuevo.Izquierdo = null;
            Nuevo.Derecho = null;
            if (Raiz == null)
            {
                Raiz = Nuevo;
            }
            else
            {
                clsNodo NodoPadre = Raiz;
                clsNodo Aux = Raiz;
                while (Aux != null)
                {
                    NodoPadre = Aux;
                    if (Nuevo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }
                if (Nuevo.Codigo < NodoPadre.Codigo)
                {
                    NodoPadre.Izquierdo = Nuevo;
                }
                else
                {
                    NodoPadre.Derecho = Nuevo;
                }
            }
        }
        public void Recorrer(ComboBox Lista)
        {
            Lista.Items.Clear();
            inOrden(Lista, Raiz);
        }
        public void inOrden(ComboBox Lista , clsNodo Raiz)
        {
            if (Raiz.Izquierdo != null)
            {
                inOrden(Lista, Raiz.Izquierdo);

            }
            Lista.Items.Add(Raiz.Codigo);
            if (Raiz.Derecho != null)
            {
                inOrden(Lista, Raiz.Derecho);

            }


        }
        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            inOrden(Grilla, Raiz);

        }
        public void inOrden(DataGridView Grilla,clsNodo Raiz)
        {
            if (Raiz.Izquierdo !=null)
            {
                inOrden(Grilla, Raiz.Izquierdo);

            }
            Grilla.Rows.Add(Raiz.Codigo , Raiz.Nombre, Raiz.Tramite);
            if (Raiz.Derecho != null)
            {
                inOrden(Grilla, Raiz.Derecho);

            }


        }
        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode NodoPadre = new TreeNode("Arbol");
            tree.Nodes.Add(NodoPadre);
            preOrden(Raiz, NodoPadre);
            tree.ExpandAll();
            
        }
        
        public void preOrden(clsNodo Raiz, TreeNode nodoTree)
        {
            TreeNode NodoPadre = new TreeNode(Raiz.Codigo.ToString());
            nodoTree.Nodes.Add(NodoPadre);
            if (Raiz.Izquierdo!=null)
            {
                preOrden(Raiz.Izquierdo, NodoPadre);



            }
            if (Raiz.Derecho != null)
            {
                preOrden(Raiz.Derecho, NodoPadre);



            }

        }

        //public void Recorrer2( DataGridView Grilla)
        //{
        //    Grilla.Rows.Clear();
        //   PreOrdenGrilla(Raiz, Grilla);

        //}
        //public void PreOrdenGrilla(clsNodo Raiz, DataGridView Grilla)
        //{

        //    Grilla.Rows.Add(Grilla);
        //    if (Raiz.Izquierdo != null)
        //    {
        //        PreOrdenGrilla(Raiz.Izquierdo, Grilla);
        //    }
        //    if (Raiz.Derecho != null)
        //    {
        //        PreOrdenGrilla(Raiz.Derecho, Grilla);
        //    }
        //}
        //PRE ORDER
        public void PreOrden(clsNodo R, TreeNode NodoTreeView)
        {
            TreeNode NodoPadre = new TreeNode(R.Codigo.ToString());
            NodoTreeView.Nodes.Add(NodoPadre);
            if (R.Izquierdo != null)
            {
                PreOrden(R.Izquierdo, NodoPadre);
            }
            if (R.Derecho != null)
            {
                PreOrden(R.Derecho, NodoPadre);
            }
        }

        public void RecorrerPreOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrdenGrilla(Grilla, Raiz);
        }
        public void PreOrdenGrilla(DataGridView Grilla, clsNodo R)
        {
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null)
            {
                PreOrdenGrilla(Grilla, R.Izquierdo);
            }
            if (R.Derecho != null)
            {
                PreOrdenGrilla(Grilla, R.Derecho);
            }
        }
        public void RecorrerPreOrden()
        {
            StreamWriter AD = new StreamWriter("ArbolBinarioPreOrden.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            RecorrerPreOrdenIO(Raiz, AD);
            AD.Close();
        }

        private void RecorrerPreOrdenIO(clsNodo R, StreamWriter writer)
        {
            if (R != null)
            {
                writer.Write($"{R.Codigo};{R.Nombre};{R.Tramite}\n");
                RecorrerPreOrdenIO(R.Izquierdo, writer);
                RecorrerPreOrdenIO(R.Derecho, writer);
            }
        }



        public void PostOrden(clsNodo Raiz, DataGridView Grilla)
        {

            if (Raiz.Izquierdo != null)
            {
                PostOrden(Raiz.Izquierdo, Grilla);
            }
            if (Raiz.Derecho != null)
            {
                PostOrden(Raiz.Derecho,Grilla);
            }
            Grilla.Rows.Add(Grilla);
        }

    }
}
