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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo objClientes = new clsArchivo();
            objClientes.NomArchi = "frmClientes.csv";
            objClientes.Grabar(txtCodigo.Text, txtNombre.Text, txtDeuda.Text);
            objClientes.Recorrer(Grilla);
            ValidarDatos();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            clsArchivo X = new clsArchivo();
            X.NomArchi = "Clientes.CSV";
            if (File.Exists(X.NomArchi)) X.Recorrer(Grilla);
            btnGrabar.Enabled = false;
        }
        private void ValidarDatos()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtDeuda.Text != "")
            {
                btnGrabar.Enabled = true;
            }
            else
            {
                btnGrabar.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtDeuda_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }
    }
}
