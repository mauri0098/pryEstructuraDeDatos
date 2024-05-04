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
        //In Order Asendente 
        public void RecorrerInOrderCombo(ComboBox Lista)
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
        public void RecorrerInOrderDataGrid(DataGridView Grilla)
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
        public void RecorrerInOrderStreamWriter()
        {
            StreamWriter AD = new StreamWriter("ArbolBinarioInOrden.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            RecorrerInOrdenstreamWriter(Raiz, AD);
            AD.Close();
        }

        private void RecorrerInOrdenstreamWriter(clsNodo Raiz, StreamWriter Writer)
        {
            if (Raiz != null)
            {
                RecorrerInOrdenstreamWriter(Raiz.Izquierdo, Writer);
                Writer.Write($"{Raiz.Codigo};{Raiz.Nombre};{Raiz.Tramite}\n");
                RecorrerInOrdenstreamWriter(Raiz.Derecho, Writer);
            }
        }
        
        //In Order Desendiente 
        public void RecorrerDescGrilla(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrderDescGrilla(Grilla, Raiz);
        }
        public void InOrderDescGrilla(DataGridView dgv, clsNodo R)
        {
            if (R.Derecho != null)
            {
                InOrderDescGrilla(dgv, R.Derecho);
            }

            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null)
            {
                InOrderDescGrilla(dgv, R.Izquierdo);
            }
        }
        public void RecorrerComboDesc(ComboBox Lista)
        {
            Lista.Items.Clear();
            InOrderDescCombo(Lista, Raiz);
        }
        public void InOrderDescCombo(ComboBox Lst, clsNodo R)
        {
            if (R.Derecho != null)
            {
                InOrderDescCombo(Lst, R.Derecho);
            }

            Lst.Items.Add(R.Codigo);
            if (R.Izquierdo != null)
            {
                InOrderDescCombo(Lst, R.Izquierdo);
            }
        }
        public void RecorrerInOrdenDescAD()
        {
            StreamWriter AD = new StreamWriter("ArbolBinarioInOrdenDesc.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            InOrdenDescAD(Raiz, AD);
            AD.Close();
        }

        private void InOrdenDescAD(clsNodo R, StreamWriter writer)
        {
            if (R != null)
            {
                InOrdenDescAD(R.Derecho, writer);
                writer.Write($"{R.Codigo};{R.Nombre};{R.Tramite}\n");
                InOrdenDescAD(R.Izquierdo, writer);
            }
        }


        //PRE ORDER
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
        public void RecorrerPreOrden(ComboBox Lista)
        {
            Lista.Items.Clear();
            PreOrden(Lista, Raiz);
        }
        public void PreOrden(ComboBox Lista, clsNodo Raiz)
        {
            Lista.Items.Add(Raiz.Codigo);
            if (Raiz.Izquierdo != null)
            {
                PreOrden(Lista, Raiz.Izquierdo);

            }
            if (Raiz.Derecho != null)
            {
                PreOrden(Lista, Raiz.Derecho);

            }


        }

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
        public void Recorrertree(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode NodoPadre = new TreeNode("Arbol");
            tree.Nodes.Add(NodoPadre);
            preOrden(Raiz, NodoPadre);
            tree.ExpandAll();

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


        //postorden
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
        public void RecorrerPostOrdenGrilla(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrdenGrilla(Grilla, Raiz);
        }
        public void PostOrdenGrilla(DataGridView dgv, clsNodo R)
        {

            if (R.Izquierdo != null)
            {
                PreOrdenGrilla(dgv, R.Izquierdo);
            }
            if (R.Derecho != null)
            {
                PreOrdenGrilla(dgv, R.Derecho);
            }
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }

        public void RecorrerPostOrdenAD()
        {
            StreamWriter AD = new StreamWriter("ArbolBinarioPostOrden.csv", false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Codigo;Nombre;Tramite");
            PostOrdenAD(Raiz, AD);
            AD.Close();
        }

        private void PostOrdenAD(clsNodo R, StreamWriter writer)
        {
            if (R != null)
            {
                PostOrdenAD(R.Izquierdo, writer);
                PostOrdenAD(R.Derecho, writer);
                writer.Write($"{R.Codigo};{R.Nombre};{R.Tramite}\n");
            }
        }


      
        //eliminar
        public clsNodo BuscarCodigo(Int32 cod)
        {
            clsNodo Aux = Raiz;
            while (Aux != null)
            {
                if (cod == Aux.Codigo) break;
                if (cod < Aux.Codigo) Aux = Aux.Izquierdo;
                else Aux = Aux.Derecho;

            }
            return Aux;
        }
        private clsNodo[] Vector = new clsNodo[100];
        private Int32 i = 0;
        public void Equilibrar()
        {
            i = 0;
            GrabarVectorInOrden(Raiz);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }

        public void GrabarVectorInOrden(clsNodo NodoPadre)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo);
            }
            Vector[i] = NodoPadre;
            i = i + 1;
            if (NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho);
            }
        }
        public void EquilibrarArbol(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if (ini <= fin)
            {
                Agregar(Vector[m]);
                EquilibrarArbol(ini, m - 1);
                EquilibrarArbol(m + 1, fin);
            }
        }

        public void Eliminar(Int32 codigo)
        {
            i = 0;
            GrabarVectorInOrden(Raiz, codigo);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }

        public void GrabarVectorInOrden(clsNodo NodoPadre, Int32 Codigo)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo, Codigo);
            }
            if (NodoPadre.Codigo != Codigo)
            {
                Vector[i] = NodoPadre;
                i = i + 1;
            }
            if (NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho, Codigo);
            }
        }
    }

}
