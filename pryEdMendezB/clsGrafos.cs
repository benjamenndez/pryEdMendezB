using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace pryEdMendezB
{
    internal class clsGrafos
    {
        //Vector 
        private string[] Ciudades = new string[] { "Córdoba", "Mendoza", "Santa Fé", "Buenos Aires", "Salta" };

        //Matriz
        private Decimal[,] Precio = new Decimal[5, 5];

        //Metodos de la matriz 
        public void Agregar(Int32 f, Int32 c, Decimal p)
        {
            Precio[f, c] = p;
        }
        public void Eliminar(Int32 f, Int32 c)
        {
            Precio[f, c] = 0;
        }

        //Función 
        public Decimal Consultar(Int32 f, Int32 c)
        { return Precio[f, c]; }

        public void MostrarDestinos(Int32 f, DataGridView grilla)
        {
            grilla.Rows.Clear();
            grilla.Columns.Clear();
            //Agregar columnas manualmente
            grilla.Columns.Add("Col1", "Destino");
            grilla.Columns.Add("Col2", "Precio");
            grilla.Columns[0].Width = 200; //Ancho de columna
            grilla.Columns[1].Width = 200;
            grilla.Rows.Clear();
            for (Int32 c = 0; c < 5; c++)
            {
                if (Precio[f, c] > 0)
                {
                    grilla.Rows.Add(Ciudades[c], Precio[f, c]);
                }
            }
        }

        public void MostrarOrigenes(Int32 c, DataGridView grilla)
        {
            grilla.Rows.Clear();
            grilla.Columns.Clear();
            //Agregar columnas manualmente
            grilla.Columns.Add("Col1", "Destino");
            grilla.Columns.Add("Col2", "Precio");
            grilla.Columns[0].Width = 200; //Ancho de columna
            grilla.Columns[1].Width = 200;
            grilla.Rows.Clear();
            for (Int32 f = 0; f < 5; f++)
            {
                if (Precio[f, c] > 0)
                {
                    grilla.Rows.Add(Ciudades[f], Precio[f, c]);
                }
            }
        }
        public void MostrarTodo(DataGridView grilla)
        {
            grilla.Rows.Clear();
            grilla.Columns.Clear();
            //Agregar columnas manualmente
            grilla.Columns.Add("NomOrigen", "Origen");
            for (Int32 i = 0; i < 5; i++)
            {
                grilla.Columns.Add("Destino" + i.ToString(), Ciudades[i]);
            }
            for (Int32 f = 0; f < 5; f++)
            {
                grilla.Rows.Add(Ciudades[f]);
                for (Int32 c = 0; c < 5; c++)
                {
                    grilla.Rows[f].Cells[c + 1].Value = Precio[f, c];
                }
            }
        }
        public void MostrarCiudades(ComboBox cmb)
        {
            cmb.Items.Clear();
            for (Int32 i = 0; i < 5; i++)
            {
                cmb.Items.Add(Ciudades[i]);
            }
            cmb.SelectedIndex = 0;
        }
        public void BorrarTodo()
        {
            for (Int32 f = 0; f < 5; f++)
            {
                for (Int32 c = 0; c < 5; c++)
                {
                    Precio[f, c] = 0;
                }
            }
        }
    }
}
