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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        clsCola ColaEspera = new clsCola(); //GLOBAL

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Persona = new clsNodo();
            Persona.Codigo = Convert.ToInt32(txtCodigo.Text);
            Persona.Nombre = txtNombre.Text;
            Persona.Tramite = txtTramite.Text;

            ColaEspera.Agregar(Persona);
            ColaEspera.Recorrer(dgvListado);
            ColaEspera.Recorrer("Cola.csv");
            ColaEspera.Recorrer(lstListado);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ColaEspera.Primero != null)
            {
                CodigoResultado.Text = ColaEspera.Primero.Codigo.ToString();
                NombreResultado.Text = ColaEspera.Primero.Nombre;
                TramiteResultado.Text = ColaEspera.Primero.Tramite;

                ColaEspera.Eliminar();
                ColaEspera.Recorrer(dgvListado);
                ColaEspera.Recorrer("Cola.csv");
                ColaEspera.Recorrer(lstListado);
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
