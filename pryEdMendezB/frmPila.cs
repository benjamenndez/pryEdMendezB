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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }
        clsPila objPila = new clsPila();
        private void frmPila_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo x = new clsNodo();
            x.Codigo = Convert.ToInt32(txtCodigo.Text);
            x.Nombre = txtNombre.Text;
            x.Tramite = txtTramite.Text;

            objPila.Agregar(x);
            objPila.Recorrer(dgvPila);
            objPila.Recorrer(lstPila);
            objPila.Recorrer("Pila.csv");

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (objPila.Primero != null)
            {
                CodigoResultado.Text = objPila.Primero.Codigo.ToString();
                NombreResultado.Text = objPila.Primero.Nombre;
                TramiteResultado.Text = objPila.Primero.Tramite;

                objPila.Eliminar();
                objPila.Recorrer(dgvPila);
                objPila.Recorrer("Cola.csv");
                objPila.Recorrer(lstPila);
            }
            else
            {
                CodigoResultado.Text = "";
                NombreResultado.Text = "";
                TramiteResultado.Text = "";
            }
        }
    }
}
