using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDPrimerProyecto
{
    internal class clsListaDoble
    {
        private Nodo Pri;
        private Nodo Ult;

        public Nodo Primero
        {
            get { return Pri; }
            set { Pri = value; }
        }
        public Nodo Ultimo
        {
            get { return Ult; }
            set { Ult = value; }
        }

        public void Agregar(Nodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                if (Nuevo.Codigo < Primero.Codigo)
                {
                    Nuevo.Siguiente = Primero;
                    Primero.anterior = Nuevo;
                    Primero = Nuevo;
                }
                else
                {
                    if (Nuevo.Codigo > Ultimo.Codigo)
                    {
                        Ultimo.Siguiente = Nuevo;
                        Nuevo.anterior = Ultimo;
                        Ultimo = Nuevo;
                    }
                    else
                    {
                        Nodo Aux = Primero;
                        Nodo Ant = Primero;
                        while (Aux.Codigo < Nuevo.Codigo)
                        {
                            Ant = Aux;
                            Aux = Aux.Siguiente;
                        }
                        Ant.Siguiente = Nuevo;
                        Nuevo.Siguiente = Aux;
                        Aux.anterior = Nuevo;
                        Nuevo.anterior = Ant;

                    }
                }
            }

        }
        public void Recorrer(DataGridView grilla)
        {
            Nodo aux = Primero;
            grilla.Rows.Clear();
            while (aux != null)
            {
                grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;

            }
        }
        public void Recorrer(ListBox Lista)
        {
            Nodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void Recorrer(ComboBox Combo)
        {
            Nodo aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
        public void RecorrerDes(DataGridView grilla)
        {
            Nodo aux = Ultimo;
            grilla.Rows.Clear();
            while (aux != null)
            {
                grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.anterior;

            }
        }
        public void RecorrerDes(ListBox Lista)
        {
            Nodo aux = Ultimo;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.anterior;
            }
        }
        public void RecorrerDes(ComboBox Combo)
        {
            Nodo aux = Ultimo;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Codigo);
                aux = aux.anterior;
            }
        }
        public void Eliminar(Int32 Codigo) 
        {       //pregunto si hay un solo dato y lo borro
            if (Primero.Codigo == Codigo && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {   //pregunto si el codigo que quiero borrar es el primero
                //asigno que el siguiente sea el primero y borro el primero
                if (Primero.Codigo == Codigo)
                {
                    Primero = Primero.Siguiente;
                    Primero.anterior = null;
                }
                else
                {   //pregunto si el que quiero borrar es el ultimo
                    //y asigno el anterior como ultimo
                    if (Ultimo.Codigo == Codigo)
                    {
                        Ultimo = Ultimo.anterior;
                        Ultimo.Siguiente = null;
                    }
                    else
                    {   //mientras el codigo a borrar sea menor avanzo
                        //la variable auxiliar marca el dato a borrar
                        //la variable anterior guarda el dato anterior al dato a eliminar
                        Nodo aux = Primero;
                        Nodo ant = Primero;
                        while (aux.Codigo < Codigo)
                        {
                            ant = aux;
                            aux = aux.Siguiente;
                        }
                        aux = aux.Siguiente;
                        ant.Siguiente = aux;
                        aux.anterior = ant;
                    }
                }
            }
        }

    }
}
