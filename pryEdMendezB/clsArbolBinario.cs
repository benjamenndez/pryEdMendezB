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
        //Campo inicial del arbol se llama raiz
        private clsNodo primerNodo;
        //Propiedad
        public clsNodo Raiz
        {
            get { return primerNodo; }
            set { primerNodo = value; }
        }
        public void Agregar(clsNodo Nuevo)
        {
            if (Raiz == null)
            {
                Raiz = Nuevo;
            }
            else
            {
                clsNodo ant = Raiz;
                clsNodo aux = Raiz;
                while (aux != null)
                {
                    ant = aux;
                    if (Nuevo.Codigo < aux.Codigo) aux = aux.Izquierdo; //Cuando el codigo sea menor a la raiz(que esta en aux) va a ir del lado izquierdo
                    else aux = aux.Derecho; //si el codigo es mayor a la raiz, pasa al lado derecho del arbol
                }
                if (Nuevo.Codigo < ant.Codigo) ant.Izquierdo = Nuevo;
                else ant.Derecho = Nuevo;
            }
        }
        public void Eliminar(Int32 codigo)
        {
            Raiz = EliminarNodo(Raiz, codigo);
        }

        // Método recursivo que busca y elimina el nodo
        private clsNodo EliminarNodo(clsNodo R, Int32 codigo)
        {
            if (R == null)
            {
                MessageBox.Show("El código no existe en el árbol.");
                return null;
            }
            if (codigo < R.Codigo) R.Izquierdo = EliminarNodo(R.Izquierdo, codigo);  // Si el código es menor voy a la izquierda            
            else if (codigo > R.Codigo) R.Derecho = EliminarNodo(R.Derecho, codigo); // Si el código es mayor voy a la derecha

            else
            {
                //nodo hoja, sin hijos
                if (R.Izquierdo == null && R.Derecho == null) return null;

                //solo tiene hijo derecho
                else if (R.Izquierdo == null) return R.Derecho;

                //solo tiene hijo izquierdo
                else if (R.Derecho == null) return R.Izquierdo;

                //tiene dos hijos
                //Busco el sucesor (el menor nodo del subárbol derecho)
                else
                {
                    clsNodo sucesor = BuscarMinimo(R.Derecho);
                    R.Codigo = sucesor.Codigo;
                    R.Nombre = sucesor.Nombre;
                    R.Tramite = sucesor.Tramite;
                    R.Derecho = EliminarNodo(R.Derecho, sucesor.Codigo);
                }
            }
            return R;
        }
        private clsNodo BuscarMinimo(clsNodo R)
        {
            while (R.Izquierdo != null)
                R = R.Izquierdo;
            return R;
        }

        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }

        private void InOrdenAsc(DataGridView dgv, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(dgv, R.Izquierdo); //El recorrido es izquierda, raíz, derecha
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrdenAsc(dgv, R.Derecho);
        }

        //Sobrecarga recorrer para cargar vector
        public void Recorrer(clsNodo[] vector)
        {
            int ind = 0; // Inicializamos el índice en 0
            if (Raiz != null)
            {
                InOrdenAsc(vector, ref ind, Raiz);
            }
        }

        //Metodo recursivo InOrdenAsc para guardar en un vector
        private void InOrdenAsc(clsNodo[] vec, ref int ind, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(vec, ref ind, R.Izquierdo);
            vec[ind] = R;
            ind++;
            if (R.Derecho != null) InOrdenAsc(vec, ref ind, R.Derecho);

        }

        //Recorrer PreOrden
        public void RecorrerPreOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrden(Grilla, Raiz);
        }

        //Procedimiento para mostrar en grilla PreOrden
        private void PreOrden(DataGridView grilla, clsNodo R)
        {
            if (R != null) //Recorrido es raíz, izquierda y derecha
            {
                grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
                PreOrden(grilla, R.Izquierdo);
                PreOrden(grilla, R.Derecho);
            }
        }

        //Recorrer PostOrden
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


        private void InOrdenAsc(ComboBox lst, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(lst, R.Izquierdo);
            lst.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(lst, R.Derecho);
        }

        //Recorrido para mostrar en un tree view
        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode nodoPadre = new TreeNode("Árbol");
            tree.Nodes.Add(nodoPadre);
            PreOrden(Raiz, nodoPadre);
            tree.ExpandAll();
        }

        private void PreOrden(clsNodo R, TreeNode nodoTreeView)
        {
            TreeNode nodoPadre = new TreeNode(R.Codigo.ToString());
            nodoTreeView.Nodes.Add(nodoPadre);
            if (R.Izquierdo != null) PreOrden(R.Izquierdo, nodoPadre);
            if (R.Derecho != null) PreOrden(R.Derecho, nodoPadre);
        }

        //Método equilibrar que consiste en Paso 1: recorrer In-Orden y guardar nodos en vector
        //Paso 2:  Resetear la raíz a null (vaciar el árbol)
        //Re-insertar los nodos desde el vector usando el índice del medio como nueva raíz, y hacerlo recursivamente para cada mitad izquierda y derecha
        public void Equilibrar()
        {
            int cantidad = ContarNodos(Raiz);
            if (cantidad <= 1) return;
            clsNodo[] vector = new clsNodo[cantidad];
            Recorrer(vector);
            Raiz = null;
            InsertarBalanceado(vector, 0, cantidad - 1);
        }
        private int ContarNodos(clsNodo R)
        {
            if (R == null) return 0;
            return 1 + ContarNodos(R.Izquierdo) + ContarNodos(R.Derecho);
        }
        private void InsertarBalanceado(clsNodo[] vector, int inicio, int fin)
        {
            if (inicio > fin) return;

            int medio = (inicio + fin) / 2;

            vector[medio].Izquierdo = null;
            vector[medio].Derecho = null;

            Agregar(vector[medio]);

            InsertarBalanceado(vector, inicio, medio - 1);
            InsertarBalanceado(vector, medio + 1, fin);
        }

    }

}
