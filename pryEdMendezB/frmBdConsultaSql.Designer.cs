namespace pryEdMendezB
{
    partial class frmBdConsultaSql
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.dgvCtaSql = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtaSql)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(545, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 28);
            this.button1.TabIndex = 21;
            this.button1.Text = "Listar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 37);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(613, 137);
            this.textBox1.TabIndex = 20;
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.Location = new System.Drawing.Point(12, 11);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(173, 24);
            this.lblConsulta.TabIndex = 19;
            this.lblConsulta.Text = "Consulta en SQL:";
            // 
            // dgvCtaSql
            // 
            this.dgvCtaSql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCtaSql.Location = new System.Drawing.Point(12, 220);
            this.dgvCtaSql.Name = "dgvCtaSql";
            this.dgvCtaSql.RowHeadersVisible = false;
            this.dgvCtaSql.RowHeadersWidth = 51;
            this.dgvCtaSql.Size = new System.Drawing.Size(612, 194);
            this.dgvCtaSql.TabIndex = 18;
            // 
            // frmBdConsultaSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 425);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.dgvCtaSql);
            this.Name = "frmBdConsultaSql";
            this.Text = "frmBdConsultaSql";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtaSql)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.DataGridView dgvCtaSql;
    }
}