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
        //public void Recorrer(ComboBox Lista)
        //{
           // Lista.Items.Clear();
            //InOrdenAsc(Lista, Raiz);
        //}
        private void InOrdenAsc(ComboBox Lst, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Lst, R.Izquierdo);
            {
                Lst.Items.Add(R.Codigo);
                if (R.Derecho != null) InOrdenAsc(Lst, R.Derecho);
            }
        }
        public void Recorrer(clsNodo[] vector)
        {
            int ind = 0; // Inicializamos el índice en 0
            if (Raiz != null)
            {
                InOrdenAsc(vector, ref ind, Raiz);
            }
        }
        private void InOrdenAsc(clsNodo[] vec, ref int ind, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(vec, ref ind, R.Izquierdo);
            vec[ind] = R;
            ind++;
            if (R.Derecho != null) InOrdenAsc(vec, ref ind, R.Derecho);

        }
        public void RecorrerPreOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrden(Grilla, Raiz);
        }
        private void PreOrden(DataGridView grilla, clsNodo R)
        {
            if (R != null) //Recorrido es raíz, izquierda y derecha
            {
                grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
                PreOrden(grilla, R.Izquierdo);
                PreOrden(grilla, R.Derecho);
            }
        }
        public void RecorrerPostOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrden(Grilla, Raiz);
        }
        //Procedimiento para mostrar en grilla PostOrden
        private void PostOrden(DataGridView grilla, clsNodo R)
        {
            if (R != null) //Recorrido es izquierda, derecha y raíz
            {
                PostOrden(grilla, R.Izquierdo);
                PostOrden(grilla, R.Derecho);
                grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            }
        }
        //Sobrecarga para recorrer el combo box 
        public void Recorrer(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenAsc(Combo, Raiz);
        }
        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode NodoPadre = new TreeNode("Arbol");
            tree.Nodes.Add(NodoPadre);
            PreOrden(Raiz, NodoPadre);
            tree.ExpandAll();

            //que esto se pase a un treeview
        }
        private void PreOrden(clsNodo R, TreeNode nodoTreeView)
        {
            TreeNode NodoPadre = new TreeNode(R.Codigo.ToString());
            nodoTreeView.Nodes.Add(NodoPadre);
            if (R.Izquierdo != null)
            {
                PreOrden(R.Izquierdo, NodoPadre);
            }
            if (R.Derecho != null)
            {
                PreOrden(R.Derecho, NodoPadre);
            }
        }

    }
    
}
