using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEDPrimerProyecto
{
    internal class Cola
    {
        public Nodo Primero;
        public Nodo Ultimo;

        public void Agregar(Nodo nuevo) 
        {
            if (Primero == null)
            {
                Primero = nuevo;
                Ultimo= nuevo;
            }
            else
            {
                Ultimo.Siguiente = nuevo;
                Ultimo = nuevo;
            }
        }
    }
}
