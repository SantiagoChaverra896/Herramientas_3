namespace Pantallas_Sistema_facturación
{
    partial class frmEmpleados
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
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.datosEmpleado = new System.Windows.Forms.RichTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.comboRolEmpleado = new System.Windows.Forms.ComboBox();
            this.txtEmailEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTelefonoEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDireccionEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDocumentoEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombreEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1313, 48);
            this.pnlTitulo.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(486, 12);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(356, 27);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ADMINISTRACIÓN DE EMPLEADOS\r\n";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.datosEmpleado);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.comboRolEmpleado);
            this.panel1.Controls.Add(this.txtEmailEmpleado);
            this.panel1.Controls.Add(this.txtTelefonoEmpleado);
            this.panel1.Controls.Add(this.txtDireccionEmpleado);
            this.panel1.Controls.Add(this.txtDocumentoEmpleado);
            this.panel1.Controls.Add(this.txtNombreEmpleado);
            this.panel1.Location = new System.Drawing.Point(279, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 420);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(460, 35);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(147, 27);
            this.materialLabel5.TabIndex = 13;
            this.materialLabel5.Text = "Rol Empleado";
            this.materialLabel5.Click += new System.EventHandler(this.materialLabel5_Click);
            // 
            // datosEmpleado
            // 
            this.datosEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datosEmpleado.Location = new System.Drawing.Point(467, 224);
            this.datosEmpleado.Name = "datosEmpleado";
            this.datosEmpleado.Size = new System.Drawing.Size(287, 70);
            this.datosEmpleado.TabIndex = 12;
            this.datosEmpleado.Text = "";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(460, 182);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(223, 27);
            this.materialLabel4.TabIndex = 11;
            this.materialLabel4.Text = "DATOS ADICIONALES";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker2.Location = new System.Drawing.Point(616, 131);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(137, 26);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Location = new System.Drawing.Point(616, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(137, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(460, 131);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(93, 27);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "F. Retiro";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(460, 81);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(108, 27);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "F. Ingreso";
            // 
            // comboRolEmpleado
            // 
            this.comboRolEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboRolEmpleado.FormattingEnabled = true;
            this.comboRolEmpleado.Location = new System.Drawing.Point(616, 37);
            this.comboRolEmpleado.Name = "comboRolEmpleado";
            this.comboRolEmpleado.Size = new System.Drawing.Size(138, 28);
            this.comboRolEmpleado.TabIndex = 6;
            // 
            // txtEmailEmpleado
            // 
            this.txtEmailEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailEmpleado.Depth = 0;
            this.txtEmailEmpleado.Hint = "Email";
            this.txtEmailEmpleado.Location = new System.Drawing.Point(46, 237);
            this.txtEmailEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmailEmpleado.Name = "txtEmailEmpleado";
            this.txtEmailEmpleado.PasswordChar = '\0';
            this.txtEmailEmpleado.SelectedText = "";
            this.txtEmailEmpleado.SelectionLength = 0;
            this.txtEmailEmpleado.SelectionStart = 0;
            this.txtEmailEmpleado.Size = new System.Drawing.Size(300, 32);
            this.txtEmailEmpleado.TabIndex = 4;
            this.txtEmailEmpleado.UseSystemPasswordChar = false;
            // 
            // txtTelefonoEmpleado
            // 
            this.txtTelefonoEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefonoEmpleado.Depth = 0;
            this.txtTelefonoEmpleado.Hint = "Teléfono";
            this.txtTelefonoEmpleado.Location = new System.Drawing.Point(46, 183);
            this.txtTelefonoEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefonoEmpleado.Name = "txtTelefonoEmpleado";
            this.txtTelefonoEmpleado.PasswordChar = '\0';
            this.txtTelefonoEmpleado.SelectedText = "";
            this.txtTelefonoEmpleado.SelectionLength = 0;
            this.txtTelefonoEmpleado.SelectionStart = 0;
            this.txtTelefonoEmpleado.Size = new System.Drawing.Size(300, 32);
            this.txtTelefonoEmpleado.TabIndex = 3;
            this.txtTelefonoEmpleado.UseSystemPasswordChar = false;
            // 
            // txtDireccionEmpleado
            // 
            this.txtDireccionEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDireccionEmpleado.Depth = 0;
            this.txtDireccionEmpleado.Hint = "Dirección";
            this.txtDireccionEmpleado.Location = new System.Drawing.Point(46, 132);
            this.txtDireccionEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDireccionEmpleado.Name = "txtDireccionEmpleado";
            this.txtDireccionEmpleado.PasswordChar = '\0';
            this.txtDireccionEmpleado.SelectedText = "";
            this.txtDireccionEmpleado.SelectionLength = 0;
            this.txtDireccionEmpleado.SelectionStart = 0;
            this.txtDireccionEmpleado.Size = new System.Drawing.Size(300, 32);
            this.txtDireccionEmpleado.TabIndex = 2;
            this.txtDireccionEmpleado.UseSystemPasswordChar = false;
            // 
            // txtDocumentoEmpleado
            // 
            this.txtDocumentoEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDocumentoEmpleado.Depth = 0;
            this.txtDocumentoEmpleado.Hint = "Documento";
            this.txtDocumentoEmpleado.Location = new System.Drawing.Point(46, 83);
            this.txtDocumentoEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDocumentoEmpleado.Name = "txtDocumentoEmpleado";
            this.txtDocumentoEmpleado.PasswordChar = '\0';
            this.txtDocumentoEmpleado.SelectedText = "";
            this.txtDocumentoEmpleado.SelectionLength = 0;
            this.txtDocumentoEmpleado.SelectionStart = 0;
            this.txtDocumentoEmpleado.Size = new System.Drawing.Size(300, 32);
            this.txtDocumentoEmpleado.TabIndex = 1;
            this.txtDocumentoEmpleado.UseSystemPasswordChar = false;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreEmpleado.Depth = 0;
            this.txtNombreEmpleado.Hint = "Nombre Empleado";
            this.txtNombreEmpleado.Location = new System.Drawing.Point(46, 38);
            this.txtNombreEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.PasswordChar = '\0';
            this.txtNombreEmpleado.SelectedText = "";
            this.txtNombreEmpleado.SelectionLength = 0;
            this.txtNombreEmpleado.SelectionStart = 0;
            this.txtNombreEmpleado.Size = new System.Drawing.Size(300, 32);
            this.txtNombreEmpleado.TabIndex = 0;
            this.txtNombreEmpleado.UseSystemPasswordChar = false;
            this.txtNombreEmpleado.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(465, 339);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(172, 51);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(212, 339);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(172, 51);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 490);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmEmpleados";
            this.Text = "frmEmpleados";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox datosEmpleado;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox comboRolEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmailEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefonoEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDireccionEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDocumentoEmpleado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
    }
}