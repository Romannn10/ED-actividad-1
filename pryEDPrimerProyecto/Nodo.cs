using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEDPrimerProyecto
{
    internal class Nodo
    {
        private Int32 cod;
        private string Nom;
        private string Tram;
        private Nodo sig;

        public Int32 Codigo 
        {
            get { return cod; }
            set { cod = value; }
        }
        public string Nombre
        { 
            get { return Nom; }
            set { Nom = value; }
        }
        public string Tramite
        {
            get { return Tram; }
            set { Tram = value; }
        }
        public Nodo Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }
    }
}
