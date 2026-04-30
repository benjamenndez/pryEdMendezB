namespace pryEdMendezB
{
    partial class frmPila
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblTramite = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.CodigoResultado = new System.Windows.Forms.Label();
            this.NombreResultado = new System.Windows.Forms.Label();
            this.TramiteResultado = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gpbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.gpbElementoEliminado = new System.Windows.Forms.GroupBox();
            this.lstPila = new System.Windows.Forms.ListBox();
            this.dgvPila = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbListado = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbNuevoElemento.SuspendLayout();
            this.gpbElementoEliminado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(11, 39);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(11, 77);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trámite:";
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Location = new System.Drawing.Point(16, 39);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo2.TabIndex = 3;
            this.lblCodigo2.Text = "Código:";
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Location = new System.Drawing.Point(16, 77);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(47, 13);
            this.lblNombre2.TabIndex = 4;
            this.lblNombre2.Text = "Nombre:";
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(14, 112);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(45, 13);
            this.lblTramite.TabIndex = 5;
            this.lblTramite.Text = "Trámite:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(71, 32);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(71, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(71, 112);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 8;
            // 
            // CodigoResultado
            // 
            this.CodigoResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CodigoResultado.Location = new System.Drawing.Point(99, 34);
            this.CodigoResultado.Name = "CodigoResultado";
            this.CodigoResultado.Size = new System.Drawing.Size(74, 21);
            this.CodigoResultado.TabIndex = 9;
            this.CodigoResultado.Text = "                ";
            // 
            // NombreResultado
            // 
            this.NombreResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NombreResultado.Location = new System.Drawing.Point(73, 72);
            this.NombreResultado.Name = "NombreResultado";
            this.NombreResultado.Size = new System.Drawing.Size(100, 21);
            this.NombreResultado.TabIndex = 10;
            this.NombreResultado.Text = "                ";
            // 
            // TramiteResultado
            // 
            this.TramiteResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TramiteResultado.Location = new System.Drawing.Point(73, 111);
            this.TramiteResultado.Name = "TramiteResultado";
            this.TramiteResultado.Size = new System.Drawing.Size(100, 21);
            this.TramiteResultado.TabIndex = 11;
            this.TramiteResultado.Text = "                ";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(20, 143);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(145, 38);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(20, 143);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(145, 38);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // gpbNuevoElemento
            // 
            this.gpbNuevoElemento.Controls.Add(this.btnAgregar);
            this.gpbNuevoElemento.Controls.Add(this.txtTramite);
            this.gpbNuevoElemento.Controls.Add(this.lblCodigo);
            this.gpbNuevoElemento.Controls.Add(this.lblNombre);
            this.gpbNuevoElemento.Controls.Add(this.label1);
            this.gpbNuevoElemento.Controls.Add(this.txtCodigo);
            this.gpbNuevoElemento.Controls.Add(this.txtNombre);
            this.gpbNuevoElemento.Location = new System.Drawing.Point(206, 22);
            this.gpbNuevoElemento.Name = "gpbNuevoElemento";
            this.gpbNuevoElemento.Size = new System.Drawing.Size(184, 194);
            this.gpbNuevoElemento.TabIndex = 15;
            this.gpbNuevoElemento.TabStop = false;
            this.gpbNuevoElemento.Text = "Nuevo Elemento";
            // 
            // gpbElementoEliminado
            // 
            this.gpbElementoEliminado.Controls.Add(this.btnEliminar);
            this.gpbElementoEliminado.Controls.Add(this.lblCodigo2);
            this.gpbElementoEliminado.Controls.Add(this.CodigoResultado);
            this.gpbElementoEliminado.Controls.Add(this.TramiteResultado);
            this.gpbElementoEliminado.Controls.Add(this.lblNombre2);
            this.gpbElementoEliminado.Controls.Add(this.lblTramite);
            this.gpbElementoEliminado.Controls.Add(this.NombreResultado);
            this.gpbElementoEliminado.Location = new System.Drawing.Point(404, 22);
            this.gpbElementoEliminado.Name = "gpbElementoEliminado";
            this.gpbElementoEliminado.Size = new System.Drawing.Size(184, 194);
            this.gpbElementoEliminado.TabIndex = 16;
            this.gpbElementoEliminado.TabStop = false;
            this.gpbElementoEliminado.Text = "Elemento Eliminado";
            // 
            // lstPila
            // 
            this.lstPila.FormattingEnabled = true;
            this.lstPila.Location = new System.Drawing.Point(12, 240);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(170, 186);
            this.lstPila.TabIndex = 17;
            // 
            // dgvPila
            // 
            this.dgvPila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvPila.Location = new System.Drawing.Point(197, 240);
            this.dgvPila.Name = "dgvPila";
            this.dgvPila.Size = new System.Drawing.Size(383, 186);
            this.dgvPila.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Trámite";
            this.Column3.Name = "Column3";
            // 
            // gpbListado
            // 
            this.gpbListado.Location = new System.Drawing.Point(5, 223);
            this.gpbListado.Name = "gpbListado";
            this.gpbListado.Size = new System.Drawing.Size(585, 216);
            this.gpbListado.TabIndex = 19;
            this.gpbListado.TabStop = false;
            this.gpbListado.Text = "Listado en una Lista y una Grilla";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::pryEdMendezB.Properties.Resources.Pila_de_datos;
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 451);
            this.Controls.Add(this.dgvPila);
            this.Controls.Add(this.lstPila);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpbNuevoElemento);
            this.Controls.Add(this.gpbElementoEliminado);
            this.Controls.Add(this.gpbListado);
            this.Name = "frmPila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPila";
            this.Load += new System.EventHandler(this.frmPila_Load);
            this.gpbNuevoElemento.ResumeLayout(false);
            this.gpbNuevoElemento.PerformLayout();
            this.gpbElementoEliminado.ResumeLayout(false);
            this.gpbElementoEliminado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Label CodigoResultado;
        private System.Windows.Forms.Label NombreResultado;
        private System.Windows.Forms.Label TramiteResultado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gpbNuevoElemento;
        private System.Windows.Forms.GroupBox gpbElementoEliminado;
        private System.Windows.Forms.ListBox lstPila;
        private System.Windows.Forms.DataGridView dgvPila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox gpbListado;
    }
}