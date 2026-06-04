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
    public partial class frmGrafo : Form
    {
        public frmGrafo()
        {
            InitializeComponent();
        }
        clsGrafos objGrafo = new clsGrafos();
        private void frmGrafo_Load(object sender, EventArgs e)
        {
            objGrafo.MostrarCiudades(cmbOrigen);
            objGrafo.MostrarCiudades(cmbDestino);
            objGrafo.MostrarCiudades(cmbDesde);
            objGrafo.MostrarCiudades(cmbHasta);
            objGrafo.MostrarCiudades(cmbOrigen);
            objGrafo.MostrarCiudades(cmbDestino);

            btnConsultar.Enabled = false;
            btnBorrar.Enabled = false;
            btnListarDestino.Enabled = false;
            btnListarOrigenes.Enabled = false;
            btnVerViajes.Enabled = false;
        }
        private void Limpiar()
        {
            cmbOrigen.SelectedIndex = -1;
            cmbDestino.SelectedIndex = -1;
            txtPrecio.Text = "";
        }
        private void ValidarDatos()
        {
            if (cmbOrigen.Text != "" && cmbDestino.Text != "" && txtPrecio.Text != "")
            {
                btnCargar.Enabled = true;
                btnBorrar.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;
                btnBorrar.Enabled = false;
            }
        }
        private void Validacion()
        {
            if (cmbOrigen.Text != "" && cmbDestino.Text != "")
            {
                btnConsultar.Enabled = true;
                btnBorrar.Enabled = true;
            }
            else
            {
                btnConsultar.Enabled = false;
                btnBorrar.Enabled = false;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números (char.IsDigit) y la tecla de borrar (char.IsControl)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea cualquier otro caracter
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            objGrafo.BorrarTodo();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Int32 f = cmbOrigen.SelectedIndex;
            Int32 c = cmbDestino.SelectedIndex;
            objGrafo.Eliminar(f, c);
            cmbOrigen.SelectedIndex = -1;
            cmbDestino.SelectedIndex = -1;
            lblPrecioR.Text = "";
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Int32 f = cmbOrigen.SelectedIndex;
            Int32 c = cmbDestino.SelectedIndex;
            Decimal p = Convert.ToDecimal(txtPrecio.Text);
            objGrafo.Agregar(f, c, p);
            objGrafo.MostrarTodo(dataGridView1);
            Limpiar();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Int32 f = cmbOrigen.SelectedIndex;
            Int32 c = cmbDestino.SelectedIndex;
            lblPrecioR.Text = Convert.ToString(objGrafo.Consultar(f, c));
        }

        private void btnListarDestino_Click(object sender, EventArgs e)
        {
            Int32 f = cmbDesde.SelectedIndex;
            objGrafo.MostrarDestinos(f, dataGridView1);
        }

        private void btnListarOrigenes_Click(object sender, EventArgs e)
        {
            Int32 c = cmbHasta.SelectedIndex;
            objGrafo.MostrarOrigenes(c, dataGridView1);
        }

        private void btnVerViajes_Click(object sender, EventArgs e)
        {
            objGrafo.MostrarTodo(dataGridView1);
        }

        private void cmbDesde_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDesde.SelectedIndex != -1) btnListarDestino.Enabled = true;
            else btnListarDestino.Enabled = false;

        }

        private void cmbHasta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHasta.SelectedIndex != -1)
            {
                btnListarOrigenes.Enabled = true;
                btnVerViajes.Enabled = true;
            }
            else
            {
                btnListarOrigenes.Enabled = false;
                btnListarOrigenes.Enabled = false;
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void cmbOrigenC_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validacion();
        }

        private void cmbDestinoC_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validacion();
        }

        private void cmbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void cmbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }
    }
}
