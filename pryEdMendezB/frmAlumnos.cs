using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEdMendezB
{
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            clsArchivo objCarrera = new clsArchivo();
            objCarrera.NomArchi = "Carreras.csv";
            if (File.Exists(objCarrera.NomArchi)) objCarrera.Recorrer(dgvAlumnos);
            btnGrabar.Enabled = false;

            clsArchivo objAlumno = new clsArchivo();
            objAlumno.NomArchi = "Alumnos.csv";
            if (File.Exists(objCarrera.NomArchi)) objAlumno.Recorrer(cmbCarrera);
            btnGrabar.Enabled = false;
        }

        public void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo objAlumnos = new clsArchivo();
            objAlumnos.NomArchi = "Alumnos.csv";
            objAlumnos.Grabar(txtCodigo.Text, txtNombre.Text, cmbCarrera.Text);
            objAlumnos.Recorrer(dgvAlumnos);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clsArchivo X = new clsArchivo();
            X.NomArchi = ("Clientes.csv");
            
        }
    }
}
