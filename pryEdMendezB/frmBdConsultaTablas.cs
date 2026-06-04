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
    public partial class frmBdConsultaTablas : Form
    {
        public frmBdConsultaTablas()
        {
            InitializeComponent();
        }

        private void frmBdConsultaTablas_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsBaseDatos bd = new clsBaseDatos();
            bd.Listar(cmbTabla.Text, dgvTablaCta);
        }
    }
}
