using System;
using System.Collections.Generic;
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
        public void Agregar(clsNodo Nuevo){
            Nuevo.Izquierdo = null;
            Nuevo.Derecho = null;
            if (Raiz == null)
            {
                Raiz = Nuevo;



            }
            else
            {
                clsNodo NodoPadre = Raiz; //ant
                clsNodo Aux = Raiz;
                while (Aux!= null)
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
            Grilla.Rows.Add(Raiz.Codigo);
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

    }
}
