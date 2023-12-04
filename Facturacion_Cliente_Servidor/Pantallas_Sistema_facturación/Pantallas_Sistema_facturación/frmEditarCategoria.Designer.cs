namespace Pantallas_Sistema_facturación
{
    partial class frmEditarCategoria
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
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.txtIdCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombreCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Titulo = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(323, -262);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(152, 24);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "EDITAR CLIENTE";
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdCategoria.Depth = 0;
            this.txtIdCategoria.Hint = "Id Categoría";
            this.txtIdCategoria.Location = new System.Drawing.Point(86, 54);
            this.txtIdCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.PasswordChar = '\0';
            this.txtIdCategoria.SelectedText = "";
            this.txtIdCategoria.SelectionLength = 0;
            this.txtIdCategoria.SelectionStart = 0;
            this.txtIdCategoria.Size = new System.Drawing.Size(371, 28);
            this.txtIdCategoria.TabIndex = 1;
            this.txtIdCategoria.UseSystemPasswordChar = false;
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombreCategoria.Depth = 0;
            this.txtNombreCategoria.Hint = "Nombre Categoría";
            this.txtNombreCategoria.Location = new System.Drawing.Point(94, 114);
            this.txtNombreCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.PasswordChar = '\0';
            this.txtNombreCategoria.SelectedText = "";
            this.txtNombreCategoria.SelectionLength = 0;
            this.txtNombreCategoria.SelectionStart = 0;
            this.txtNombreCategoria.Size = new System.Drawing.Size(541, 28);
            this.txtNombreCategoria.TabIndex = 2;
            this.txtNombreCategoria.UseSystemPasswordChar = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(205, 166);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(132, 41);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(380, 166);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(132, 41);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Titulo);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 57);
            this.panel1.TabIndex = 11;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Depth = 0;
            this.Titulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Titulo.Location = new System.Drawing.Point(223, 14);
            this.Titulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(252, 24);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "CATEGORIA DE PRODUCTOS";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtIdCategoria);
            this.panel2.Controls.Add(this.txtNombreCategoria);
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnActualizar);
            this.panel2.Location = new System.Drawing.Point(2, 59);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 272);
            this.panel2.TabIndex = 12;
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // frmEditarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 289);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEditarCategoria";
            this.Text = "frmEditarCategoria";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmEditarCategoria_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdCategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreCategoria;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel Titulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}