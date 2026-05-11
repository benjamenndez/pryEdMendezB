using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEdMendezB
{
    public partial class frmMeses : Form
    {
        public frmMeses()
        {
            InitializeComponent();
        }



        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchi = "Meses.csv";
            x.Grabar(txtNombre.Text);
            x.Recorrer(lstMeses);


            txtNombre.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchi = ("Careras.csv");
            x.BorrarTodo();
            x.Recorrer(lstMeses);

            txtNombre.Text = "";
        }

        private void frmMeses_Load(object sender, EventArgs e)
        {
            btnGrabar.Enabled = false;
        }
        private void ValidarDatos()
        {
            if (txtNombre.Text != "" && txtNombre.Text != "")
            {
                btnGrabar.Enabled = true;
            }
            else
            {
                btnGrabar.Enabled = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }
    }
}
