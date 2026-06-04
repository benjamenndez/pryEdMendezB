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
    public partial class frmBdConsultaSql : Form
    {
        public frmBdConsultaSql()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsBaseDatos objBaseDatos = new clsBaseDatos();
            objBaseDatos.Listar(dgvCtaSql, textBox1.Text);
        }
    }
}
