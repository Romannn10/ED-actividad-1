using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public void InOrdenDes(ListBox lst, Nodo R)
        {
            if (R.Derecho != null) InOrdenAsc(lst, R.Derecho); //D
            lst.Items.Add(R.Codigo); //R
            if (R.Izquierdo != null) InOrdenAsc(lst, R.Izquierdo);  //I

        }
        public void PreOrden(ListBox lst, Nodo R)
        {
            lst.Items.Add(R.Codigo); //R
            if (R.Izquierdo != null) InOrdenAsc(lst, R.Izquierdo);  //I
            if (R.Derecho != null) InOrdenAsc(lst, R.Derecho); //D

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
        public void InOrdenDes(ComboBox cmb, Nodo R)
        {
            if (R.Derecho != null) InOrdenAsc(cmb, R.Derecho); //D
            cmb.Items.Add(R.Codigo); //R
            if (R.Izquierdo != null) InOrdenAsc(cmb, R.Izquierdo);  //I

        }
        public void PreOrden(ComboBox cmb, Nodo R)
        {
            cmb.Items.Add(R.Codigo); //R
            if (R.Izquierdo != null) InOrdenAsc(cmb, R.Izquierdo);  //I
            if (R.Derecho != null) InOrdenAsc(cmb, R.Derecho); //D

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
            Grl.Rows.Add(R.Codigo); //R
            if (R.Derecho != null) InOrdenAsc(Grl, R.Derecho); //D

        }
        public void InOrdenDes(DataGridView Grl, Nodo R)
        {
            if (R.Derecho != null) InOrdenAsc(Grl, R.Derecho); //D
            Grl.Rows.Add(R.Codigo); //R
            if (R.Izquierdo != null) InOrdenAsc(Grl, R.Izquierdo);  //I

        }
        public void PreOrden(DataGridView Grl, Nodo R)
        {
            Grl.Rows.Add(R.Codigo); //R
            if (R.Izquierdo != null) InOrdenAsc(Grl, R.Izquierdo);  //I
            if (R.Derecho != null) InOrdenAsc(Grl, R.Derecho); //D

        }
        public void PostOrden(DataGridView Grl, Nodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Grl, R.Izquierdo);  //I
            if (R.Derecho != null) InOrdenAsc(Grl, R.Derecho); //D
            Grl.Rows.Add(R.Codigo); //R

        }

    }
}
