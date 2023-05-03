namespace Gestion
{
    partial class Form2
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAreaEmpresa = new System.Windows.Forms.ComboBox();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.btnLinea = new System.Windows.Forms.Button();
            this.dtgDTG = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDTG)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(35, 44);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Area de la empresa";
            // 
            // cmbAreaEmpresa
            // 
            this.cmbAreaEmpresa.FormattingEnabled = true;
            this.cmbAreaEmpresa.Items.AddRange(new object[] {
            "Contabilidad",
            "Comercio ",
            "Administrativo "});
            this.cmbAreaEmpresa.Location = new System.Drawing.Point(139, 257);
            this.cmbAreaEmpresa.Name = "cmbAreaEmpresa";
            this.cmbAreaEmpresa.Size = new System.Drawing.Size(121, 21);
            this.cmbAreaEmpresa.TabIndex = 3;
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(340, 32);
            this.txtArchivo.Multiline = true;
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(1050, 131);
            this.txtArchivo.TabIndex = 4;
            // 
            // btnLinea
            // 
            this.btnLinea.Location = new System.Drawing.Point(340, 186);
            this.btnLinea.Name = "btnLinea";
            this.btnLinea.Size = new System.Drawing.Size(108, 36);
            this.btnLinea.TabIndex = 5;
            this.btnLinea.Text = "Lianea a Linea";
            this.btnLinea.UseVisualStyleBackColor = true;
            this.btnLinea.Click += new System.EventHandler(this.btnLinea_Click);
            // 
            // dtgDTG
            // 
            this.dtgDTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDTG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cedula,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtgDTG.Location = new System.Drawing.Point(340, 244);
            this.dtgDTG.Name = "dtgDTG";
            this.dtgDTG.Size = new System.Drawing.Size(1050, 154);
            this.dtgDTG.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(340, 426);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 36);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar DataGridView";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(498, 426);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(89, 36);
            this.btnCargar.TabIndex = 8;
            this.btnCargar.Text = "Cargar Archivos";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellido";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Edad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fecha de nacimiento";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Profesion";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Estado civil";
            this.Column6.Name = "Column6";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(38, 66);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 535);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dtgDTG);
            this.Controls.Add(this.btnLinea);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.cmbAreaEmpresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFecha);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDTG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAreaEmpresa;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Button btnLinea;
        private System.Windows.Forms.DataGridView dtgDTG;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}