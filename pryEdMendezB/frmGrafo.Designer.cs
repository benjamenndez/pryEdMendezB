namespace pryEdMendezB
{
    partial class frmGrafo
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
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.cmbOrigenC = new System.Windows.Forms.ComboBox();
            this.cmbDestinoC = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecioR = new System.Windows.Forms.Label();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblOrigenConsulta = new System.Windows.Forms.Label();
            this.lblDestinoC = new System.Windows.Forms.Label();
            this.lblPrecioC = new System.Windows.Forms.Label();
            this.gpbCargaDatos = new System.Windows.Forms.GroupBox();
            this.gpbConsultaDatos = new System.Windows.Forms.GroupBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.cmbDesde = new System.Windows.Forms.ComboBox();
            this.btnListarDestino = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.btnListarOrigenes = new System.Windows.Forms.Button();
            this.btnVerViajes = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbListarViajes = new System.Windows.Forms.GroupBox();
            this.pbGrafo = new System.Windows.Forms.PictureBox();
            this.gpbCargaDatos.SuspendLayout();
            this.gpbConsultaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrafo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(13, 31);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(41, 13);
            this.lblOrigen.TabIndex = 0;
            this.lblOrigen.Text = "Origen:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(13, 70);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(43, 13);
            this.lblDestino.TabIndex = 1;
            this.lblDestino.Text = "Destino";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(13, 107);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(95, 22);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(121, 21);
            this.cmbOrigen.TabIndex = 3;
            this.cmbOrigen.SelectedIndexChanged += new System.EventHandler(this.cmbOrigen_SelectedIndexChanged);
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(93, 62);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(121, 21);
            this.cmbDestino.TabIndex = 4;
            this.cmbDestino.SelectedIndexChanged += new System.EventHandler(this.cmbDestino_SelectedIndexChanged);
            // 
            // cmbOrigenC
            // 
            this.cmbOrigenC.FormattingEnabled = true;
            this.cmbOrigenC.Location = new System.Drawing.Point(95, 25);
            this.cmbOrigenC.Name = "cmbOrigenC";
            this.cmbOrigenC.Size = new System.Drawing.Size(121, 21);
            this.cmbOrigenC.TabIndex = 5;
            this.cmbOrigenC.SelectedIndexChanged += new System.EventHandler(this.cmbOrigenC_SelectedIndexChanged);
            // 
            // cmbDestinoC
            // 
            this.cmbDestinoC.FormattingEnabled = true;
            this.cmbDestinoC.Location = new System.Drawing.Point(95, 61);
            this.cmbDestinoC.Name = "cmbDestinoC";
            this.cmbDestinoC.Size = new System.Drawing.Size(121, 21);
            this.cmbDestinoC.TabIndex = 6;
            this.cmbDestinoC.SelectedIndexChanged += new System.EventHandler(this.cmbDestinoC_SelectedIndexChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(93, 100);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 20);
            this.txtPrecio.TabIndex = 7;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // lblPrecioR
            // 
            this.lblPrecioR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrecioR.Location = new System.Drawing.Point(95, 97);
            this.lblPrecioR.Name = "lblPrecioR";
            this.lblPrecioR.Size = new System.Drawing.Size(121, 25);
            this.lblPrecioR.TabIndex = 8;
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Location = new System.Drawing.Point(16, 150);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(97, 29);
            this.btnBorrarTodo.TabIndex = 9;
            this.btnBorrarTodo.Text = "Borrar Todo";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(119, 150);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(97, 28);
            this.btnCargar.TabIndex = 10;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(15, 149);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(96, 29);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(120, 149);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(96, 29);
            this.btnBorrar.TabIndex = 12;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lblOrigenConsulta
            // 
            this.lblOrigenConsulta.AutoSize = true;
            this.lblOrigenConsulta.Location = new System.Drawing.Point(12, 33);
            this.lblOrigenConsulta.Name = "lblOrigenConsulta";
            this.lblOrigenConsulta.Size = new System.Drawing.Size(41, 13);
            this.lblOrigenConsulta.TabIndex = 13;
            this.lblOrigenConsulta.Text = "Origen:";
            // 
            // lblDestinoC
            // 
            this.lblDestinoC.AutoSize = true;
            this.lblDestinoC.Location = new System.Drawing.Point(13, 69);
            this.lblDestinoC.Name = "lblDestinoC";
            this.lblDestinoC.Size = new System.Drawing.Size(43, 13);
            this.lblDestinoC.TabIndex = 14;
            this.lblDestinoC.Text = "Destino";
            // 
            // lblPrecioC
            // 
            this.lblPrecioC.AutoSize = true;
            this.lblPrecioC.Location = new System.Drawing.Point(13, 109);
            this.lblPrecioC.Name = "lblPrecioC";
            this.lblPrecioC.Size = new System.Drawing.Size(40, 13);
            this.lblPrecioC.TabIndex = 15;
            this.lblPrecioC.Text = "Precio:";
            // 
            // gpbCargaDatos
            // 
            this.gpbCargaDatos.Controls.Add(this.btnCargar);
            this.gpbCargaDatos.Controls.Add(this.lblOrigen);
            this.gpbCargaDatos.Controls.Add(this.lblDestino);
            this.gpbCargaDatos.Controls.Add(this.lblPrecio);
            this.gpbCargaDatos.Controls.Add(this.cmbOrigen);
            this.gpbCargaDatos.Controls.Add(this.cmbDestino);
            this.gpbCargaDatos.Controls.Add(this.txtPrecio);
            this.gpbCargaDatos.Controls.Add(this.btnBorrarTodo);
            this.gpbCargaDatos.Location = new System.Drawing.Point(261, 27);
            this.gpbCargaDatos.Name = "gpbCargaDatos";
            this.gpbCargaDatos.Size = new System.Drawing.Size(232, 184);
            this.gpbCargaDatos.TabIndex = 17;
            this.gpbCargaDatos.TabStop = false;
            this.gpbCargaDatos.Text = "Carga de Datos";
            // 
            // gpbConsultaDatos
            // 
            this.gpbConsultaDatos.Controls.Add(this.btnBorrar);
            this.gpbConsultaDatos.Controls.Add(this.lblPrecioC);
            this.gpbConsultaDatos.Controls.Add(this.cmbOrigenC);
            this.gpbConsultaDatos.Controls.Add(this.lblDestinoC);
            this.gpbConsultaDatos.Controls.Add(this.cmbDestinoC);
            this.gpbConsultaDatos.Controls.Add(this.lblOrigenConsulta);
            this.gpbConsultaDatos.Controls.Add(this.lblPrecioR);
            this.gpbConsultaDatos.Controls.Add(this.btnConsultar);
            this.gpbConsultaDatos.Location = new System.Drawing.Point(499, 27);
            this.gpbConsultaDatos.Name = "gpbConsultaDatos";
            this.gpbConsultaDatos.Size = new System.Drawing.Size(232, 184);
            this.gpbConsultaDatos.TabIndex = 18;
            this.gpbConsultaDatos.TabStop = false;
            this.gpbConsultaDatos.Text = "Consulta de Datos";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(21, 257);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 19;
            this.lblDesde.Text = "Desde:";
            // 
            // cmbDesde
            // 
            this.cmbDesde.FormattingEnabled = true;
            this.cmbDesde.Location = new System.Drawing.Point(68, 254);
            this.cmbDesde.Name = "cmbDesde";
            this.cmbDesde.Size = new System.Drawing.Size(121, 21);
            this.cmbDesde.TabIndex = 11;
            this.cmbDesde.SelectedIndexChanged += new System.EventHandler(this.cmbDesde_SelectedIndexChanged);
            // 
            // btnListarDestino
            // 
            this.btnListarDestino.Location = new System.Drawing.Point(205, 254);
            this.btnListarDestino.Name = "btnListarDestino";
            this.btnListarDestino.Size = new System.Drawing.Size(110, 21);
            this.btnListarDestino.TabIndex = 11;
            this.btnListarDestino.Text = "Listar Destinos";
            this.btnListarDestino.UseVisualStyleBackColor = true;
            this.btnListarDestino.Click += new System.EventHandler(this.btnListarDestino_Click);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(325, 257);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 20;
            this.lblHasta.Text = "Hasta:";
            // 
            // cmbHasta
            // 
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(367, 254);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(121, 21);
            this.cmbHasta.TabIndex = 21;
            this.cmbHasta.SelectedIndexChanged += new System.EventHandler(this.cmbHasta_SelectedIndexChanged);
            // 
            // btnListarOrigenes
            // 
            this.btnListarOrigenes.Location = new System.Drawing.Point(501, 251);
            this.btnListarOrigenes.Name = "btnListarOrigenes";
            this.btnListarOrigenes.Size = new System.Drawing.Size(110, 24);
            this.btnListarOrigenes.TabIndex = 22;
            this.btnListarOrigenes.Text = "Listar Origenes";
            this.btnListarOrigenes.UseVisualStyleBackColor = true;
            this.btnListarOrigenes.Click += new System.EventHandler(this.btnListarOrigenes_Click);
            // 
            // btnVerViajes
            // 
            this.btnVerViajes.Location = new System.Drawing.Point(615, 251);
            this.btnVerViajes.Name = "btnVerViajes";
            this.btnVerViajes.Size = new System.Drawing.Size(110, 24);
            this.btnVerViajes.TabIndex = 23;
            this.btnVerViajes.Text = "Ver todos los viajes";
            this.btnVerViajes.UseVisualStyleBackColor = true;
            this.btnVerViajes.Click += new System.EventHandler(this.btnVerViajes_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(24, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(691, 227);
            this.dataGridView1.TabIndex = 24;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Origen";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cordoba";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mendoza";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Santa Fe";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Buenos Aires";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Salta";
            this.Column6.Name = "Column6";
            // 
            // gpbListarViajes
            // 
            this.gpbListarViajes.Location = new System.Drawing.Point(12, 230);
            this.gpbListarViajes.Name = "gpbListarViajes";
            this.gpbListarViajes.Size = new System.Drawing.Size(719, 314);
            this.gpbListarViajes.TabIndex = 25;
            this.gpbListarViajes.TabStop = false;
            this.gpbListarViajes.Text = "Listar Viajes";
            // 
            // pbGrafo
            // 
            this.pbGrafo.BackgroundImage = global::pryEdMendezB.Properties.Resources.Sin_título_1;
            this.pbGrafo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbGrafo.Image = global::pryEdMendezB.Properties.Resources.Sin_título_1;
            this.pbGrafo.Location = new System.Drawing.Point(12, 34);
            this.pbGrafo.Name = "pbGrafo";
            this.pbGrafo.Size = new System.Drawing.Size(243, 177);
            this.pbGrafo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGrafo.TabIndex = 16;
            this.pbGrafo.TabStop = false;
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 556);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVerViajes);
            this.Controls.Add(this.btnListarOrigenes);
            this.Controls.Add(this.cmbHasta);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.btnListarDestino);
            this.Controls.Add(this.cmbDesde);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.pbGrafo);
            this.Controls.Add(this.gpbCargaDatos);
            this.Controls.Add(this.gpbConsultaDatos);
            this.Controls.Add(this.gpbListarViajes);
            this.Name = "frmGrafo";
            this.Text = "frmGrafo";
            this.Load += new System.EventHandler(this.frmGrafo_Load);
            this.gpbCargaDatos.ResumeLayout(false);
            this.gpbCargaDatos.PerformLayout();
            this.gpbConsultaDatos.ResumeLayout(false);
            this.gpbConsultaDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrafo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.ComboBox cmbOrigenC;
        private System.Windows.Forms.ComboBox cmbDestinoC;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecioR;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label lblOrigenConsulta;
        private System.Windows.Forms.Label lblDestinoC;
        private System.Windows.Forms.Label lblPrecioC;
        private System.Windows.Forms.PictureBox pbGrafo;
        private System.Windows.Forms.GroupBox gpbCargaDatos;
        private System.Windows.Forms.GroupBox gpbConsultaDatos;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.ComboBox cmbDesde;
        private System.Windows.Forms.Button btnListarDestino;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.Button btnListarOrigenes;
        private System.Windows.Forms.Button btnVerViajes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox gpbListarViajes;
    }
}