namespace Pantallas_Sistema_facturación
{
    partial class frmInformes
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
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnExcel = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnPdf = new MaterialSkin.Controls.MaterialRadioButton();
            this.rBtnPantalla = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.fechaFin = new System.Windows.Forms.DateTimePicker();
            this.fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pnlContenedor.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.richTextBox1);
            this.pnlContenedor.Controls.Add(this.btnSalir);
            this.pnlContenedor.Controls.Add(this.btnActualizar);
            this.pnlContenedor.Controls.Add(this.btnExcel);
            this.pnlContenedor.Controls.Add(this.btnPdf);
            this.pnlContenedor.Controls.Add(this.rBtnPantalla);
            this.pnlContenedor.Controls.Add(this.materialLabel5);
            this.pnlContenedor.Controls.Add(this.fechaFin);
            this.pnlContenedor.Controls.Add(this.fechaInicio);
            this.pnlContenedor.Controls.Add(this.materialLabel4);
            this.pnlContenedor.Controls.Add(this.comboBox2);
            this.pnlContenedor.Controls.Add(this.materialLabel3);
            this.pnlContenedor.Controls.Add(this.comboBox1);
            this.pnlContenedor.Controls.Add(this.materialLabel2);
            this.pnlContenedor.Location = new System.Drawing.Point(0, 84);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(949, 593);
            this.pnlContenedor.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox1.BackColor = System.Drawing.SystemColors.GrayText;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(86, 247);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(802, 160);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(556, 172);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(148, 51);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(272, 172);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(148, 51);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcel.AutoSize = true;
            this.btnExcel.Depth = 0;
            this.btnExcel.Font = new System.Drawing.Font("Roboto", 10F);
            this.btnExcel.Location = new System.Drawing.Point(561, 124);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(0);
            this.btnExcel.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btnExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Ripple = true;
            this.btnExcel.Size = new System.Drawing.Size(80, 30);
            this.btnExcel.TabIndex = 10;
            this.btnExcel.TabStop = true;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // btnPdf
            // 
            this.btnPdf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPdf.AutoSize = true;
            this.btnPdf.Depth = 0;
            this.btnPdf.Font = new System.Drawing.Font("Roboto", 10F);
            this.btnPdf.Location = new System.Drawing.Point(449, 124);
            this.btnPdf.Margin = new System.Windows.Forms.Padding(0);
            this.btnPdf.MouseLocation = new System.Drawing.Point(-1, -1);
            this.btnPdf.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Ripple = true;
            this.btnPdf.Size = new System.Drawing.Size(69, 30);
            this.btnPdf.TabIndex = 9;
            this.btnPdf.TabStop = true;
            this.btnPdf.Text = "PDF";
            this.btnPdf.UseVisualStyleBackColor = true;
            // 
            // rBtnPantalla
            // 
            this.rBtnPantalla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rBtnPantalla.AutoSize = true;
            this.rBtnPantalla.Depth = 0;
            this.rBtnPantalla.Font = new System.Drawing.Font("Roboto", 10F);
            this.rBtnPantalla.Location = new System.Drawing.Point(287, 124);
            this.rBtnPantalla.Margin = new System.Windows.Forms.Padding(0);
            this.rBtnPantalla.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rBtnPantalla.MouseState = MaterialSkin.MouseState.HOVER;
            this.rBtnPantalla.Name = "rBtnPantalla";
            this.rBtnPantalla.Ripple = true;
            this.rBtnPantalla.Size = new System.Drawing.Size(133, 30);
            this.rBtnPantalla.TabIndex = 8;
            this.rBtnPantalla.TabStop = true;
            this.rBtnPantalla.Text = "En pantalla";
            this.rBtnPantalla.UseVisualStyleBackColor = true;
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(372, 65);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(69, 27);
            this.materialLabel5.TabIndex = 7;
            this.materialLabel5.Text = "F-FIN:";
            // 
            // fechaFin
            // 
            this.fechaFin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fechaFin.Location = new System.Drawing.Point(451, 65);
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.Size = new System.Drawing.Size(178, 26);
            this.fechaFin.TabIndex = 6;
            // 
            // fechaInicio
            // 
            this.fechaInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fechaInicio.Location = new System.Drawing.Point(163, 65);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(178, 26);
            this.fechaInicio.TabIndex = 5;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(58, 65);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(98, 27);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "F-INICIO:";
            this.materialLabel4.Click += new System.EventHandler(this.materialLabel4_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(705, 20);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(146, 28);
            this.comboBox2.TabIndex = 3;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(533, 20);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(165, 27);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "ORDENAR POR:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(311, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(54, 21);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(251, 27);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "SELECCIONE INFORME :";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(295, 20);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(468, 27);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "GENERADOR DE INFORMES DE FACTURACIÓN";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.materialLabel1);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(949, 78);
            this.pnlTitulo.TabIndex = 4;
            // 
            // frmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 709);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInformes";
            this.Text = "frmInformes";
            this.Load += new System.EventHandler(this.frmInformes_Load);
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlContenedor;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.PrintDialog printDialog1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ComboBox comboBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialRadioButton btnExcel;
        private MaterialSkin.Controls.MaterialRadioButton btnPdf;
        private MaterialSkin.Controls.MaterialRadioButton rBtnPantalla;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.DateTimePicker fechaFin;
        private System.Windows.Forms.DateTimePicker fechaInicio;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Panel pnlTitulo;
    }
}