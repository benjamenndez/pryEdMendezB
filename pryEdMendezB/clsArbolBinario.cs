using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEdMendezB
{
    internal class clsArbolBinario
    {
        //creo el campo inicial del arbol lo llamo raiz
        private clsNodo Pri;
        //creo la unica propiedad que necesito
        public clsNodo Raiz
        {
            get { return Pri; }
            set { Pri = value; }
        }
        public void Agregar(clsNodo Nvo)
        {
            if (Raiz == null)
            {
                Raiz = Nvo;
            }
            else
            {
                clsNodo P = Raiz; //ant
                clsNodo Aux = Raiz;
                while (Aux != null)
                {
                    P = Aux;
                    if (Nvo.Codigo < Aux.Codigo) Aux = Aux.Izquierdo;
                    else Aux = Aux.Derecho;
                }
                //Afuera del while
                if (Nvo.Codigo < P.Codigo) P.Izquierdo = Nvo;
                else P.Derecho = Nvo;

            }
        }
        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }
        private void InOrdenAsc(DataGridView Dgv, clsNodo R)
        {
            if(R.Izquierdo != null) InOrdenAsc(Dgv, R.Izquierdo);
            {
                Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
                if (R.Derecho != null) InOrdenAsc(Dgv, R.Derecho);
            }
        }
        public void Recorrer(ComboBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }
        private void InOrdenAsc(ComboBox Lst, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Lst, R.Izquierdo);
            {
                Lst.Items.Add(R.Codigo);
                if (R.Derecho != null) InOrdenAsc(Lst, R.Derecho);
            }
        }

    }
    
}
