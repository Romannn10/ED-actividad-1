using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEDPrimerProyecto
{
    internal class clsArbolBinario
    {
        private Nodo Inicio;
        public Nodo Raiz 
        {
            get { return Inicio; }
            set
            {
                Inicio = value;
            }
        }
        public void Agregar(Nodo nvo) 
        {
            nvo.Izquierdo = null;
            nvo.Derecho = null;
            if (Raiz == null)
            {
                Raiz = nvo;
            }
            else
            {
                Nodo NodoPadre = Raiz;
                Nodo Aux = Raiz;
                while (Aux != null)
                {
                    NodoPadre = Aux;
                    if (nvo.Codigo <= Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;  
                    }
                }
                if (nvo.Codigo <= NodoPadre.Codigo)
                {
                    NodoPadre.Izquierdo = nvo;
                }
                else
                {
                    NodoPadre.Derecho = nvo;
                }
            }
        }


        //RECORRER LISTA
        public void Recorrer(ListBox Lista) 
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
            
        }
        public void InOrdenAsc(ListBox lst, Nodo R) 
        {
            if (R.Izquierdo != null) InOrdenAsc(lst, R.Izquierdo);  //I
            lst.Items.Add(R.Codigo); //R
            if (R.Derecho != null) InOrdenAsc(lst, R.Derecho); //D
            
        }
        public void RecorrerDes(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenDes(Lista, Raiz);

        }

        public void InOrdenDes(ListBox lst, Nodo R)
        {
            if (R.Derecho != null) InOrdenAsc(lst, R.Derecho); //D
            lst.Items.Add(R.Codigo); //R
            if (R.Izquierdo != null) InOrdenAsc(lst, R.Izquierdo);  //I

        }
        public void RecorrerPre(ListBox Lista)
        {
            Lista.Items.Clear();
            PreOrden(Lista, Raiz);

        }

        public void PreOrden(ListBox lst, Nodo R)
        {
            lst.Items.Add(R.Codigo); //R
            if (R.Izquierdo != null) InOrdenAsc(lst, R.Izquierdo);  //I
            if (R.Derecho != null) InOrdenAsc(lst, R.Derecho); //D

        }
        public void RecorrerPost(ListBox Lista)
        {
            Lista.Items.Clear();
            PostOrden(Lista, Raiz);

        }
        public void PostOrden(ListBox lst, Nodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(lst, R.Izquierdo);  //I
            if (R.Derecho != null) InOrdenAsc(lst, R.Derecho); //D
            lst.Items.Add(R.Codigo); //R

        }

        //RECORRER COMBO
        public void Recorrer(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenAsc(Combo, Raiz);

        }
        public void InOrdenAsc(ComboBox cmb, Nodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(cmb, R.Izquierdo);  //I
            cmb.Items.Add(R.Codigo); //R
            if (R.Derecho != null) InOrdenAsc(cmb, R.Derecho); //D

        }
        public void RecorrerDes(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenDes(Combo, Raiz);

        }

        public void InOrdenDes(ComboBox cmb, Nodo R)
        {
            if (R.Derecho != null) InOrdenAsc(cmb, R.Derecho); //D
            cmb.Items.Add(R.Codigo); //R
            if (R.Izquierdo != null) InOrdenAsc(cmb, R.Izquierdo);  //I

        }
        public void RecorrerPre(ComboBox Combo)
        {
            Combo.Items.Clear();
            PreOrden(Combo, Raiz);

        }

        public void PreOrden(ComboBox cmb, Nodo R)
        {
            cmb.Items.Add(R.Codigo); //R
            if (R.Izquierdo != null) InOrdenAsc(cmb, R.Izquierdo);  //I
            if (R.Derecho != null) InOrdenAsc(cmb, R.Derecho); //D

        }
        public void RecorrerPost(ComboBox Combo)
        {
            Combo.Items.Clear();
            PostOrden(Combo, Raiz);

        }
        public void PostOrden(ComboBox cmb, Nodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(cmb, R.Izquierdo);  //I
            if (R.Derecho != null) InOrdenAsc(cmb, R.Derecho); //D
            cmb.Items.Add(R.Codigo); //R

        }

        //RECORRER GRILLA

        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);

        }
        public void InOrdenAsc(DataGridView Grl, Nodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Grl, R.Izquierdo);  //I
            Grl.Rows.Add(R.Codigo, R.Tramite, R.Nombre); //R
            if (R.Derecho != null) InOrdenAsc(Grl, R.Derecho); //D

        }
        public void RecorrerDes(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenDes(Grilla, Raiz);

        }
        public void InOrdenDes(DataGridView Grl, Nodo R)
        {
            if (R.Derecho != null) InOrdenAsc(Grl, R.Derecho); //D
            Grl.Rows.Add(R.Codigo, R.Tramite, R.Nombre); //R
            if (R.Izquierdo != null) InOrdenAsc(Grl, R.Izquierdo);  //I

        }
        public void RecorrerPre(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrden(Grilla, Raiz);

        }
        public void PreOrden(DataGridView Grl, Nodo R)
        {
            Grl.Rows.Add(R.Codigo, R.Tramite, R.Nombre); //R
            if (R.Izquierdo != null) InOrdenAsc(Grl, R.Izquierdo);  //I
            if (R.Derecho != null) InOrdenAsc(Grl, R.Derecho); //D

        }
        public void RecorrerPost(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrden(Grilla, Raiz);

        }
        public void PostOrden(DataGridView Grl, Nodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Grl, R.Izquierdo);  //I
            if (R.Derecho != null) InOrdenAsc(Grl, R.Derecho); //D
            Grl.Rows.Add(R.Codigo, R.Tramite, R.Nombre); //R

        }

        //RECORRER TREEVIEW

        public void Recorrer(TreeView tv)
        {
            tv.Nodes.Clear();
            InOrdenAsc(tv, Raiz);

        }

        public void InOrdenAsc(TreeView tv, Nodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(tv, R.Izquierdo);  //I
            tv.Nodes.Add(R.Codigo.ToString()); //R
            if (R.Derecho != null) InOrdenAsc(tv, R.Derecho); //D

        }
        public void RecorrerDes(TreeView tv)
        {
            tv.Nodes.Clear();
            InOrdenDes(tv, Raiz);

        }
        public void InOrdenDes(TreeView tv, Nodo R)
        {
            if (R.Derecho != null) InOrdenAsc(tv, R.Derecho); //D
            tv.Nodes.Add(R.Codigo.ToString()); //R
            if (R.Izquierdo != null) InOrdenAsc(tv, R.Izquierdo);  //I

        }
        public void RecorrerPre(TreeView tv)
        {
            tv.Nodes.Clear();
            PreOrden(tv.Nodes, Raiz);

        }
        public void PreOrden(TreeNodeCollection NodoPadre, Nodo R)
        {
            TreeNode NuevoNodo = NodoPadre.Add(R.Codigo.ToString()); //R
            if (R.Izquierdo != null) PreOrden(NuevoNodo.Nodes, R.Izquierdo);  //I
            if (R.Derecho != null) PreOrden(NuevoNodo.Nodes, R.Derecho); //D

        }
        public void RecorrerPost(TreeView tv)
        {
            tv.Nodes.Clear();
            PostOrden(tv, Raiz);

        }
        public void PostOrden(TreeView tv, Nodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(tv, R.Izquierdo);  //I
            if (R.Derecho != null) InOrdenAsc(tv, R.Derecho); //D
            tv.Nodes.Add(R.Codigo.ToString()); //R

        }

        //STREAMWRITER

        public void Recorrer(StreamWriter StreamWriter)
        {
            InOrdenAsc(StreamWriter, Raiz);
            
        }

        public void InOrdenAsc(StreamWriter StreamWriter, Nodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(StreamWriter, R.Izquierdo);
            StreamWriter.Write(R.Codigo);
            StreamWriter.Write(" ; ");
            StreamWriter.Write(R.Nombre);
            StreamWriter.Write(" ; ");
            StreamWriter.Write(R.Tramite);
            StreamWriter.Write("\n");
            if (R.Derecho != null) InOrdenAsc(StreamWriter, R.Derecho);
        }


        public void RecorrerDes(StreamWriter StreamWriter)
        {
            
            InOrdenDesc(StreamWriter, Raiz);
        }

        public void InOrdenDesc(StreamWriter StreamWriter, Nodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(StreamWriter, R.Derecho);
            StreamWriter.Write(R.Codigo);
            StreamWriter.Write(" ; ");
            StreamWriter.Write(R.Nombre);
            StreamWriter.Write(" ; ");
            StreamWriter.Write(R.Tramite);
            StreamWriter.Write("\n");
            if (R.Derecho != null) InOrdenAsc(StreamWriter, R.Izquierdo);
        }

        public void RecorrerPre(StreamWriter StreamWriter)
        {
            
            PreOrden(StreamWriter, Raiz);
        }

        public void PreOrden(StreamWriter StreamWriter, Nodo R)
        {
            StreamWriter.Write(R.Codigo);
            StreamWriter.Write(" ; ");
            StreamWriter.Write(R.Nombre);
            StreamWriter.Write(" ; ");
            StreamWriter.Write(R.Tramite);
            StreamWriter.Write("\n");
            if (R.Derecho != null) InOrdenAsc(StreamWriter, R.Izquierdo);
            if (R.Izquierdo != null) InOrdenAsc(StreamWriter, R.Derecho);
        }

        public void RecorrerPost(StreamWriter StreamWriter)
        {
            
            PostOrden(StreamWriter, Raiz);
        }

        public void PostOrden(StreamWriter StreamWriter, Nodo R)
        {
            if (R.Derecho != null) InOrdenAsc(StreamWriter, R.Izquierdo);
            if (R.Izquierdo != null) InOrdenAsc(StreamWriter, R.Derecho);
            StreamWriter.Write(R.Codigo);
            StreamWriter.Write(" ; ");
            StreamWriter.Write(R.Nombre);
            StreamWriter.Write(" ; ");
            StreamWriter.Write(R.Tramite);
            StreamWriter.Write("\n");
        }


        public Nodo[] Nodos = new Nodo[100];
        private Int32 i = 0;
        public void Equilibrar() 
        {
            i = 0;
            CargarVectorInOrden(Raiz);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }
        private void CargarVectorInOrden(Nodo NodoPadre) 
        {
            if (NodoPadre.Izquierdo != null)
            {
                CargarVectorInOrden(NodoPadre.Izquierdo);
            }
            Nodos[i] = NodoPadre;
            i++;
            if (NodoPadre.Derecho != null)
            {
                CargarVectorInOrden(NodoPadre.Derecho);
            }
        }
        private void EquilibrarArbol(Int32 ini , Int32 fin) 
        {
            Int32 m = (ini + fin) / 2;
            if (ini<= fin)
            {
                Agregar(Nodos[m]);
                EquilibrarArbol(ini, m - 1);
                EquilibrarArbol(m + 1, fin);
            }
        }
        public void Eliminar(int Nodo)
        {
            Nodo NodoEliminar = Raiz;
            i = 0;
            CargarVectorEliminar(NodoEliminar, Nodo);
            Raiz = null;
            if (i > 0)
            {
                EquilibrarArbol(0, i - 1);
            }
        }

        public void CargarVectorEliminar(Nodo NodoPadre, int Codigo)
        {
            if (NodoPadre.Izquierdo != null)
            {
                CargarVectorEliminar(NodoPadre.Izquierdo, Codigo);
            }
            if (NodoPadre.Codigo != Codigo)
            {
                Nodos[i] = NodoPadre;
                i++;
            }
            if (NodoPadre.Derecho != null)
            {
                CargarVectorEliminar(NodoPadre.Derecho, Codigo);
            }

        }


        

        public void Buscar(Int32 Codigo)
        {
            Nodo aux = Raiz;
            while (aux != null && aux.Codigo != Codigo)
            {
                if (Codigo < aux.Codigo)
                {
                    aux = aux.Izquierdo;
                }
                else
                {
                    aux = aux.Derecho;
                }
            }
        }

    }
}
