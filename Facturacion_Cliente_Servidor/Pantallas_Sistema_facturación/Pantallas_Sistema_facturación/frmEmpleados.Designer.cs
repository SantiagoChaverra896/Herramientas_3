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
            this.components = new System.ComponentModel.Container();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.datosEmpleado = new System.Windows.Forms.RichTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.FechaRetiro = new System.Windows.Forms.DateTimePicker();
            this.FechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.comboRolEmpleado = new System.Windows.Forms.ComboBox();
            this.txtEmailEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTelefonoEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDireccionEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDocumentoEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombreEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1167, 38);
            this.pnlTitulo.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(432, 10);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(307, 24);
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
            this.panel1.Controls.Add(this.FechaRetiro);
            this.panel1.Controls.Add(this.FechaIngreso);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.comboRolEmpleado);
            this.panel1.Controls.Add(this.txtEmailEmpleado);
            this.panel1.Controls.Add(this.txtTelefonoEmpleado);
            this.panel1.Controls.Add(this.txtDireccionEmpleado);
            this.panel1.Controls.Add(this.txtDocumentoEmpleado);
            this.panel1.Controls.Add(this.txtNombreEmpleado);
            this.panel1.Location = new System.Drawing.Point(248, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 336);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(413, 271);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(153, 41);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(409, 28);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(129, 24);
            this.materialLabel5.TabIndex = 13;
            this.materialLabel5.Text = "Rol Empleado";
            this.materialLabel5.Click += new System.EventHandler(this.materialLabel5_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(188, 271);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(153, 41);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // datosEmpleado
            // 
            this.datosEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datosEmpleado.Location = new System.Drawing.Point(415, 179);
            this.datosEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datosEmpleado.Name = "datosEmpleado";
            this.datosEmpleado.Size = new System.Drawing.Size(256, 57);
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
            this.materialLabel4.Location = new System.Drawing.Point(409, 146);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(191, 24);
            this.materialLabel4.TabIndex = 11;
            this.materialLabel4.Text = "DATOS ADICIONALES";
            // 
            // FechaRetiro
            // 
            this.FechaRetiro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FechaRetiro.Location = new System.Drawing.Point(548, 105);
            this.FechaRetiro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FechaRetiro.Name = "FechaRetiro";
            this.FechaRetiro.Size = new System.Drawing.Size(122, 22);
            this.FechaRetiro.TabIndex = 10;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FechaIngreso.Location = new System.Drawing.Point(548, 65);
            this.FechaIngreso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.Size = new System.Drawing.Size(122, 22);
            this.FechaIngreso.TabIndex = 9;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(409, 105);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(81, 24);
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
            this.materialLabel2.Location = new System.Drawing.Point(409, 65);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(94, 24);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "F. Ingreso";
            // 
            // comboRolEmpleado
            // 
            this.comboRolEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboRolEmpleado.FormattingEnabled = true;
            this.comboRolEmpleado.Location = new System.Drawing.Point(548, 30);
            this.comboRolEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboRolEmpleado.Name = "comboRolEmpleado";
            this.comboRolEmpleado.Size = new System.Drawing.Size(123, 24);
            this.comboRolEmpleado.TabIndex = 6;
            // 
            // txtEmailEmpleado
            // 
            this.txtEmailEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmailEmpleado.Depth = 0;
            this.txtEmailEmpleado.Hint = "Email";
            this.txtEmailEmpleado.Location = new System.Drawing.Point(41, 190);
            this.txtEmailEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmailEmpleado.Name = "txtEmailEmpleado";
            this.txtEmailEmpleado.PasswordChar = '\0';
            this.txtEmailEmpleado.SelectedText = "";
            this.txtEmailEmpleado.SelectionLength = 0;
            this.txtEmailEmpleado.SelectionStart = 0;
            this.txtEmailEmpleado.Size = new System.Drawing.Size(267, 28);
            this.txtEmailEmpleado.TabIndex = 4;
            this.txtEmailEmpleado.UseSystemPasswordChar = false;
            // 
            // txtTelefonoEmpleado
            // 
            this.txtTelefonoEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefonoEmpleado.Depth = 0;
            this.txtTelefonoEmpleado.Hint = "Teléfono";
            this.txtTelefonoEmpleado.Location = new System.Drawing.Point(41, 146);
            this.txtTelefonoEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefonoEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefonoEmpleado.Name = "txtTelefonoEmpleado";
            this.txtTelefonoEmpleado.PasswordChar = '\0';
            this.txtTelefonoEmpleado.SelectedText = "";
            this.txtTelefonoEmpleado.SelectionLength = 0;
            this.txtTelefonoEmpleado.SelectionStart = 0;
            this.txtTelefonoEmpleado.Size = new System.Drawing.Size(267, 28);
            this.txtTelefonoEmpleado.TabIndex = 3;
            this.txtTelefonoEmpleado.UseSystemPasswordChar = false;
            // 
            // txtDireccionEmpleado
            // 
            this.txtDireccionEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDireccionEmpleado.Depth = 0;
            this.txtDireccionEmpleado.Hint = "Dirección";
            this.txtDireccionEmpleado.Location = new System.Drawing.Point(41, 106);
            this.txtDireccionEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDireccionEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDireccionEmpleado.Name = "txtDireccionEmpleado";
            this.txtDireccionEmpleado.PasswordChar = '\0';
            this.txtDireccionEmpleado.SelectedText = "";
            this.txtDireccionEmpleado.SelectionLength = 0;
            this.txtDireccionEmpleado.SelectionStart = 0;
            this.txtDireccionEmpleado.Size = new System.Drawing.Size(267, 28);
            this.txtDireccionEmpleado.TabIndex = 2;
            this.txtDireccionEmpleado.UseSystemPasswordChar = false;
            // 
            // txtDocumentoEmpleado
            // 
            this.txtDocumentoEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDocumentoEmpleado.Depth = 0;
            this.txtDocumentoEmpleado.Hint = "Documento";
            this.txtDocumentoEmpleado.Location = new System.Drawing.Point(41, 66);
            this.txtDocumentoEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDocumentoEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDocumentoEmpleado.Name = "txtDocumentoEmpleado";
            this.txtDocumentoEmpleado.PasswordChar = '\0';
            this.txtDocumentoEmpleado.SelectedText = "";
            this.txtDocumentoEmpleado.SelectionLength = 0;
            this.txtDocumentoEmpleado.SelectionStart = 0;
            this.txtDocumentoEmpleado.Size = new System.Drawing.Size(267, 28);
            this.txtDocumentoEmpleado.TabIndex = 1;
            this.txtDocumentoEmpleado.UseSystemPasswordChar = false;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreEmpleado.Depth = 0;
            this.txtNombreEmpleado.Hint = "Nombre Empleado";
            this.txtNombreEmpleado.Location = new System.Drawing.Point(41, 30);
            this.txtNombreEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.PasswordChar = '\0';
            this.txtNombreEmpleado.SelectedText = "";
            this.txtNombreEmpleado.SelectionLength = 0;
            this.txtNombreEmpleado.SelectionStart = 0;
            this.txtNombreEmpleado.Size = new System.Drawing.Size(267, 28);
            this.txtNombreEmpleado.TabIndex = 0;
            this.txtNombreEmpleado.UseSystemPasswordChar = false;
            this.txtNombreEmpleado.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 392);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEmpleados";
            this.Text = "frmEmpleados";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox datosEmpleado;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.DateTimePicker FechaRetiro;
        private System.Windows.Forms.DateTimePicker FechaIngreso;
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
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}