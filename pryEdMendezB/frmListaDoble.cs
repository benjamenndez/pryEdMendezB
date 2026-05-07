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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ObjDoble.Primero != null)
            {
                Int32 x = Convert.ToInt32(cmbCodigo.Text);
                ObjDoble.Eliminar(x);
                ObjDoble.Recorrer(dgvListaDoble);
                ObjDoble.Recorrer("ListaSimple.csv");
                ObjDoble.Recorrer(lstListaDoble);
                ObjDoble.Recorrer(cmbCodigo);

            }
            else
            {
                MessageBox.Show("La lista esta vacia", "Lista sin datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnEliminar.Enabled = false;
        }

        private void rbAscendente_CheckedChanged(object sender, EventArgs e)
        {
            ObjDoble.Recorrer(dgvListaDoble);
            ObjDoble.Recorrer("ListaSimple.csv");
            ObjDoble.Recorrer(lstListaDoble);
            ObjDoble.Recorrer(cmbCodigo);
        }

        private void rbDescendente_CheckedChanged(object sender, EventArgs e)
        {
            ObjDoble.RecorrerDes(dgvListaDoble);
            ObjDoble.RecorrerDes("ListaSimple.csv");
            ObjDoble.RecorrerDes(lstListaDoble);
            ObjDoble.RecorrerDes(cmbCodigo);
        }
    }
}
