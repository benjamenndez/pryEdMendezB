using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEdMendezB
{
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }
        clsListaDoble ObjDoble = new clsListaDoble();
        private void frmListaDoble_Load(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NomArchi = "ListaDoble.csv";
            if (File.Exists(x.NomArchi)) x.Recorrer(dgvListaDoble);
            btnAgregar.Enabled = false;
        }
        private void ValidarDatos()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
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

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo x = new clsNodo();
            x.Codigo = Convert.ToInt32(txtCodigo.Text);
            x.Nombre = txtNombre.Text;
            x.Tramite = txtTramite.Text;

            ObjDoble.Agregar(x);
            ObjDoble.Recorrer(dgvListaDoble);
            //Esto no es necesario pero se hrealiza para ver si funciona el programa y el método
            ObjDoble.Recorrer("ListaDoble.csv");
            ObjDoble.Recorrer(lstListaDoble);
            ObjDoble.Recorrer(cmbCodigo);

            //Limpio los controles
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }
    }
}
