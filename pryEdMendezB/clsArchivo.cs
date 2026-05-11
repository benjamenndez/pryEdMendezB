using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//libreria para procesar archivos
using System.IO;
using System.Windows.Forms;
namespace pryEdMendezB
{
    internal class clsArchivo
    {
        //campo
        public string NomArchi = "";
    
        public void Grabar()
        {
            //abrir archivo para escritura
            StreamWriter AD = new StreamWriter(NomArchi);
            AD.WriteLine("Hola");
            AD.Close();


        }

        public void Grabar(String Dato)
        {
            //abrir archivo para escritura
            StreamWriter AD = new StreamWriter(NomArchi, true);
            AD.WriteLine(Dato);
            AD.Close();


        }

        public void Grabar(String Dato1, String Dato2, String Dato3)
        {
            StreamWriter AD = new StreamWriter(NomArchi, true); //Ab
            AD.Write(Dato1); // escribir el contenido de la variable
            AD.Write(";");
            AD.Write(Dato2); //escribir contenido de variable
            AD.Write(";");
            AD.WriteLine(Dato3);
            AD.Close(); //cerrar AD

        }
        public void Recorrer(ListBox lstDatos)
        { 
            lstDatos.Items.Clear();
            String DatoLeido = "";
            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                //aca van las lineas de codigo que hagan falta
                lstDatos.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close ();
        
        
        
        }
        public void Recorrer(ComboBox cmbDatos)
        {
            String DatoLeido;
            cmbDatos.Items.Clear();
            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                //aca van las lineas de codigo que hagan falta
                cmbDatos.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            cmbDatos.SelectedIndex = 0;
            AD.Close();



        }
        public void Recorrer(DataGridView dgvDatos)
        {

            String DatoLeido;
            dgvDatos.Rows.Clear();
            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                //aca van las lineas de codigo que hagan falta
                dgvDatos.Rows.Add(DatoLeido.Split(';'));
                DatoLeido = AD.ReadLine();
            }
            AD.Close();

        }
        public void BorrarTodo()
        {
            StreamWriter AD = new StreamWriter(NomArchi, false); //abrir y pisa el que existe
            AD.Close(); //cerrar AD
        }
        

            

    }
}
