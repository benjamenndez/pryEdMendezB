using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//libreria para procesar archivos
using System.IO;
namespace pryEdMendezB
{
    internal class clsArchivo
    {
        //campo
        public string NomArchi = "Colores.txt";
    
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
    }
}
