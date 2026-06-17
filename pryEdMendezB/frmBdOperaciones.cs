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

        private void frmBdOperaciones_Load(object sender, EventArgs e)
        {

        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT Libro.Titulo, Autor.Nombre " +
                "FROM Libro INNER JOIN Autor " +
                "ON Libro.IdAutor = Autor.IdAutor";
            objBaseDatos.Listar(varSql, dgvOperac);
        }

        private void btnSelSimple_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT TITULO " +
                "FROM LIBRO " +
                "WHERE  IDPAIS = 3 ";
            objBaseDatos.Listar(varSql, dgvOperac);
        }

        private void btnSelMultiAtributo_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT TITULO, PRECIO " +
                "FROM LIBRO " +
                "WHERE PRECIO > 400 " +
                "ORDER BY 1 DESC";
            objBaseDatos.Listar(varSql, dgvOperac);
        }

        private void btnConvolucion_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT * " +
                "FROM (SELECT * FROM LIBRO WHERE idIdioma > 1) as X " +
                "WHERE IdPais = 2 ";
            objBaseDatos.Listar(varSql, dgvOperac);
        }

        private void btnUnion_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT *  " +
                "FROM LIBRO " +
                "WHERE IDIDIOMA = 1 " +
                "UNION " +
                "SELECT * " +
                "FROM LIBRO " +
                "WHERE IDIDIOMA = 2";
            objBaseDatos.Listar(varSql, dgvOperac);
        }

        private void btnInterseccion_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT * FROM LIBRO " +
                " WHERE IDIDIOMA = 2 AND " +
                "IDLIBRO IN " +
                " (SELECT IDLIBRO FROM LIBRO WHERE IDPAIS = 3) " +
                " ORDER BY 1 ASC";
            objBaseDatos.Listar(varSql, dgvOperac);
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT * FROM LIBRO " +
                " WHERE IDIDIOMA = 2 AND " +
                "IDIDIOMA NOT IN " +
                " (SELECT IDLIBRO FROM LIBRO WHERE IDPAIS = 3) " +
                " ORDER BY 1 ASC";
            objBaseDatos.Listar(varSql, dgvOperac);
        }
    }
}
