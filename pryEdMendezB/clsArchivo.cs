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
        public void recorrer(ComboBox cmbDatos)
        {
            cmbDatos.Items.Clear();
            String DatoLeido = "";
            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                //aca van las lineas de codigo que hagan falta
                cmbDatos.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();



        }
        public void recorrer(DataGridView dgvDatos)
        {


            dgvDatos.Rows.Clear();
            String DatoLeido = "";
            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                //aca van las lineas de codigo que hagan falta
                dgvDatos.Rows.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();

        }

    }
}
