namespace Pantallas_Sistema_facturación
{
    partial class frmFacturas
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
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboEstadoFactura = new System.Windows.Forms.ComboBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.NroFactura = new System.Windows.Forms.TextBox();
            this.comboEmpleado = new System.Windows.Forms.ComboBox();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.txtTotal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtIva = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDescuento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDetalleFac = new System.Windows.Forms.RichTextBox();
            this.btnELIMINAR = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1108, 46);
            this.pnlTitulo.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(423, 15);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(263, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ADMINISTRACIÓN FACTURAS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.comboEstadoFactura);
            this.panel1.Controls.Add(this.materialLabel6);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.NroFactura);
            this.panel1.Controls.Add(this.comboEmpleado);
            this.panel1.Controls.Add(this.comboCliente);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.txtIva);
            this.panel1.Controls.Add(this.txtDescuento);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Location = new System.Drawing.Point(198, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 292);
            this.panel1.TabIndex = 4;
            // 
            // comboEstadoFactura
            // 
            this.comboEstadoFactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboEstadoFactura.FormattingEnabled = true;
            this.comboEstadoFactura.Location = new System.Drawing.Point(330, 122);
            this.comboEstadoFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboEstadoFactura.Name = "comboEstadoFactura";
            this.comboEstadoFactura.Size = new System.Drawing.Size(229, 24);
            this.comboEstadoFactura.TabIndex = 12;
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(325, 94);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(137, 24);
            this.materialLabel6.TabIndex = 11;
            this.materialLabel6.Text = "Estado Factura";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Location = new System.Drawing.Point(330, 61);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(229, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(325, 30);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(137, 24);
            this.materialLabel5.TabIndex = 9;
            this.materialLabel5.Text = "Fecha Registro";
            // 
            // NroFactura
            // 
            this.NroFactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NroFactura.Location = new System.Drawing.Point(132, 42);
            this.NroFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NroFactura.Name = "NroFactura";
            this.NroFactura.Size = new System.Drawing.Size(168, 22);
            this.NroFactura.TabIndex = 8;
            // 
            // comboEmpleado
            // 
            this.comboEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboEmpleado.FormattingEnabled = true;
            this.comboEmpleado.Location = new System.Drawing.Point(132, 122);
            this.comboEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboEmpleado.Name = "comboEmpleado";
            this.comboEmpleado.Size = new System.Drawing.Size(168, 24);
            this.comboEmpleado.TabIndex = 7;
            // 
            // comboCliente
            // 
            this.comboCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(132, 82);
            this.comboCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(168, 24);
            this.comboCliente.TabIndex = 6;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotal.Depth = 0;
            this.txtTotal.Hint = "Total Factura";
            this.txtTotal.Location = new System.Drawing.Point(16, 242);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.Size = new System.Drawing.Size(243, 28);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.UseSystemPasswordChar = false;
            // 
            // txtIva
            // 
            this.txtIva.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIva.Depth = 0;
            this.txtIva.Hint = "Total IVA";
            this.txtIva.Location = new System.Drawing.Point(16, 203);
            this.txtIva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIva.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIva.Name = "txtIva";
            this.txtIva.PasswordChar = '\0';
            this.txtIva.SelectedText = "";
            this.txtIva.SelectionLength = 0;
            this.txtIva.SelectionStart = 0;
            this.txtIva.Size = new System.Drawing.Size(243, 28);
            this.txtIva.TabIndex = 4;
            this.txtIva.UseSystemPasswordChar = false;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescuento.Depth = 0;
            this.txtDescuento.Hint = "Descuento";
            this.txtDescuento.Location = new System.Drawing.Point(16, 165);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescuento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.PasswordChar = '\0';
            this.txtDescuento.SelectedText = "";
            this.txtDescuento.SelectionLength = 0;
            this.txtDescuento.SelectionStart = 0;
            this.txtDescuento.Size = new System.Drawing.Size(243, 28);
            this.txtDescuento.TabIndex = 3;
            this.txtDescuento.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 120);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(96, 24);
            this.materialLabel4.TabIndex = 2;
            this.materialLabel4.Text = "Empleado";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 80);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(68, 24);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "Cliente";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 40);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(109, 24);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Nro Factura";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(806, 103);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(132, 33);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(806, 352);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(132, 33);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(198, 341);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 128);
            this.panel2.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtDetalleFac);
            this.groupBox1.Location = new System.Drawing.Point(9, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(574, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DETALLE FACTURA";
            // 
            // txtDetalleFac
            // 
            this.txtDetalleFac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDetalleFac.Location = new System.Drawing.Point(14, 26);
            this.txtDetalleFac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDetalleFac.Name = "txtDetalleFac";
            this.txtDetalleFac.Size = new System.Drawing.Size(554, 91);
            this.txtDetalleFac.TabIndex = 0;
            this.txtDetalleFac.Text = "";
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnELIMINAR.Depth = 0;
            this.btnELIMINAR.Location = new System.Drawing.Point(806, 153);
            this.btnELIMINAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnELIMINAR.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Primary = true;
            this.btnELIMINAR.Size = new System.Drawing.Size(132, 33);
            this.btnELIMINAR.TabIndex = 9;
            this.btnELIMINAR.Text = "ELIMINAR";
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click);
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 474);
            this.Controls.Add(this.btnELIMINAR);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmFacturas";
            this.Text = "frmFacturas";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmFacturas_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox comboEstadoFactura;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.TextBox NroFactura;
        private System.Windows.Forms.ComboBox comboEmpleado;
        private System.Windows.Forms.ComboBox comboCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTotal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIva;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescuento;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtDetalleFac;
        private MaterialSkin.Controls.MaterialRaisedButton btnELIMINAR;
    }
}