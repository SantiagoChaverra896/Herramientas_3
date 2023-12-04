namespace Pantallas_Sistema_facturación
{
    partial class frmEditarRolEmpleados
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
            this.txtDescripcionRol = new System.Windows.Forms.RichTextBox();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombreRol = new MaterialSkin.Controls.MaterialSingleLineTextField();
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
            this.pnlTitulo.Size = new System.Drawing.Size(666, 77);
            this.pnlTitulo.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(232, 42);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(187, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ROL DE EMPLEADOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.txtDescripcionRol);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.materialSingleLineTextField2);
            this.panel1.Controls.Add(this.txtNombreRol);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 77);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 249);
            this.panel1.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(355, 190);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(132, 41);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtDescripcionRol
            // 
            this.txtDescripcionRol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescripcionRol.Location = new System.Drawing.Point(110, 80);
            this.txtDescripcionRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcionRol.Name = "txtDescripcionRol";
            this.txtDescripcionRol.Size = new System.Drawing.Size(452, 95);
            this.txtDescripcionRol.TabIndex = 2;
            this.txtDescripcionRol.Text = "";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(195, 190);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(132, 41);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(111, 39);
            this.materialSingleLineTextField2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(375, 28);
            this.materialSingleLineTextField2.TabIndex = 1;
            this.materialSingleLineTextField2.Text = "Descripción detallada Rol";
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreRol.Depth = 0;
            this.txtNombreRol.Hint = "Nombre Rol";
            this.txtNombreRol.Location = new System.Drawing.Point(111, 3);
            this.txtNombreRol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreRol.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.PasswordChar = '\0';
            this.txtNombreRol.SelectedText = "";
            this.txtNombreRol.SelectionLength = 0;
            this.txtNombreRol.SelectionStart = 0;
            this.txtNombreRol.Size = new System.Drawing.Size(215, 28);
            this.txtNombreRol.TabIndex = 0;
            this.txtNombreRol.UseSystemPasswordChar = false;
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // frmEditarRolEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 326);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEditarRolEmpleados";
            this.Text = "frmRolEmpleados";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmEditarRolEmpleados_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreRol;
        private System.Windows.Forms.RichTextBox txtDescripcionRol;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}