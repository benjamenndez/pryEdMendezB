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
    public partial class frmBdOperaciones : Form
    {
        public frmBdOperaciones()
        {
            InitializeComponent();
        }
        clsBaseDatos objBaseDatos = new clsBaseDatos();
        private void btnProSimple_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO " +
                "FROM LIBRO " +
                "ORDER BY 1 DESC ";
            objBaseDatos.Listar(dgvOperac, varSQL);
        }

        private void btnProMultiAtributo_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO, AÑO " +
                "FROM LIBRO " +
                "ORDER BY TITULO ASC";
            objBaseDatos.Listar(dgvOperac, varSQL);
        }
    }
}
