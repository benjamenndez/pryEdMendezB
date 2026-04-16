using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEdMendezB
{
    internal class clsNodo
    {
        //Capos del nodo
        private Int32 cod;
        private string Nom;
        private string Tra;
        private clsNodo Sig;

        //propiedades
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
            get { return Tra; }
            set { Tra = value; }
        }
        public clsNodo Siguiente
        {
            get { return Sig; }
            set { Sig = value; }
        }
    }
}
