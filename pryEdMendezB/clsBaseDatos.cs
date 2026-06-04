using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryEdMendezB
{
    internal class clsBaseDatos
    {
        private OleDbConnection conexion = new OleDbConnection(); //Realizamos la conexión     
        private OleDbCommand comando = new OleDbCommand(); //El comando envia una orden       
        private OleDbDataAdapter adaptador = new OleDbDataAdapter(); //El adapter nos trae los datos

        private String CadenaConexion1 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Libreria.mdb"; //Indicamos el tipo de base de datos y donde esta
        private String CadenaConexion2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Libreria.mdb";

        public void Listar(DataGridView grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion1;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Libro";

                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, "Libro");

                grilla.DataSource = null;
                grilla.DataSource = DS.Tables["Libro"];
                conexion.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
        public void Listar(String tabla, DataGridView grilla)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion1;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = tabla;

                DataSet DS = new DataSet();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(DS, tabla);

                grilla.DataSource = null;
                grilla.DataSource = DS.Tables[tabla];
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conexion.Close();
            }
        }
        public void Listar(DataGridView grilla, String varInstruccionSQL)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion1;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = varInstruccionSQL;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, "Resultado");

                grilla.DataSource = null;
                grilla.DataSource = DS.Tables["Resultado"];
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                conexion.Close();
            }
        }
    }
}
