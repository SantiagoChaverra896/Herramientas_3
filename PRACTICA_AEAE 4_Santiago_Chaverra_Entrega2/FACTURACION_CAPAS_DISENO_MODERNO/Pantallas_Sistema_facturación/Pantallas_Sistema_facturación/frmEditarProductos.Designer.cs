namespace Pantallas_Sistema_facturación
{
    partial class frmEditarProductos
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
            this.txtIdProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.lblCategoria = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.TxtDetalleProducto = new System.Windows.Forms.RichTextBox();
            this.TxtRutaImagen = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TxtCantidadStock = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtPrecioVenta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtPrecioCompra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtCodigoReferencia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtNombreProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTitulo.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdProducto.Depth = 0;
            this.txtIdProducto.Hint = "Id Producto";
            this.txtIdProducto.Location = new System.Drawing.Point(19, 17);
            this.txtIdProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.PasswordChar = '\0';
            this.txtIdProducto.SelectedText = "";
            this.txtIdProducto.SelectionLength = 0;
            this.txtIdProducto.SelectionStart = 0;
            this.txtIdProducto.Size = new System.Drawing.Size(239, 28);
            this.txtIdProducto.TabIndex = 12;
            this.txtIdProducto.UseSystemPasswordChar = false;
            this.txtIdProducto.Click += new System.EventHandler(this.txtIdProducto_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(739, 106);
            this.pnlTitulo.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(281, 21);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(306, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ADMINISTRACIÓN DE PRODUCTOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Click += new System.EventHandler(this.materialLabel1_Click_1);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.lblCategoria);
            this.pnlContenedor.Controls.Add(this.materialLabel3);
            this.pnlContenedor.Controls.Add(this.btnSalir);
            this.pnlContenedor.Controls.Add(this.btnActualizar);
            this.pnlContenedor.Controls.Add(this.txtIdProducto);
            this.pnlContenedor.Controls.Add(this.TxtDetalleProducto);
            this.pnlContenedor.Controls.Add(this.TxtRutaImagen);
            this.pnlContenedor.Controls.Add(this.comboBox1);
            this.pnlContenedor.Controls.Add(this.TxtCantidadStock);
            this.pnlContenedor.Controls.Add(this.TxtPrecioVenta);
            this.pnlContenedor.Controls.Add(this.TxtPrecioCompra);
            this.pnlContenedor.Controls.Add(this.TxtCodigoReferencia);
            this.pnlContenedor.Controls.Add(this.TxtNombreProducto);
            this.pnlContenedor.Location = new System.Drawing.Point(0, 58);
            this.pnlContenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(904, 502);
            this.pnlContenedor.TabIndex = 4;
            this.pnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenedor_Paint);
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Depth = 0;
            this.lblCategoria.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCategoria.Location = new System.Drawing.Point(331, 21);
            this.lblCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(91, 24);
            this.lblCategoria.TabIndex = 15;
            this.lblCategoria.Text = "Categoría";
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(331, 106);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(180, 24);
            this.materialLabel3.TabIndex = 14;
            this.materialLabel3.Text = "Detalle del producto";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(335, 360);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(132, 41);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(130, 360);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(132, 41);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // TxtDetalleProducto
            // 
            this.TxtDetalleProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtDetalleProducto.Location = new System.Drawing.Point(335, 150);
            this.TxtDetalleProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDetalleProducto.Name = "TxtDetalleProducto";
            this.TxtDetalleProducto.Size = new System.Drawing.Size(266, 170);
            this.TxtDetalleProducto.TabIndex = 9;
            this.TxtDetalleProducto.Text = "";
            // 
            // TxtRutaImagen
            // 
            this.TxtRutaImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtRutaImagen.Depth = 0;
            this.TxtRutaImagen.Hint = "Ruta Imagen";
            this.TxtRutaImagen.Location = new System.Drawing.Point(335, 58);
            this.TxtRutaImagen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtRutaImagen.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtRutaImagen.Name = "TxtRutaImagen";
            this.TxtRutaImagen.PasswordChar = '\0';
            this.TxtRutaImagen.SelectedText = "";
            this.TxtRutaImagen.SelectionLength = 0;
            this.TxtRutaImagen.SelectionStart = 0;
            this.TxtRutaImagen.Size = new System.Drawing.Size(255, 28);
            this.TxtRutaImagen.TabIndex = 7;
            this.TxtRutaImagen.UseSystemPasswordChar = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(477, 22);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // TxtCantidadStock
            // 
            this.TxtCantidadStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtCantidadStock.Depth = 0;
            this.TxtCantidadStock.Hint = "Cantidad Stock";
            this.TxtCantidadStock.Location = new System.Drawing.Point(19, 294);
            this.TxtCantidadStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCantidadStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCantidadStock.Name = "TxtCantidadStock";
            this.TxtCantidadStock.PasswordChar = '\0';
            this.TxtCantidadStock.SelectedText = "";
            this.TxtCantidadStock.SelectionLength = 0;
            this.TxtCantidadStock.SelectionStart = 0;
            this.TxtCantidadStock.Size = new System.Drawing.Size(268, 28);
            this.TxtCantidadStock.TabIndex = 4;
            this.TxtCantidadStock.UseSystemPasswordChar = false;
            // 
            // TxtPrecioVenta
            // 
            this.TxtPrecioVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPrecioVenta.Depth = 0;
            this.TxtPrecioVenta.Hint = "Precio Venta";
            this.TxtPrecioVenta.Location = new System.Drawing.Point(19, 248);
            this.TxtPrecioVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPrecioVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPrecioVenta.Name = "TxtPrecioVenta";
            this.TxtPrecioVenta.PasswordChar = '\0';
            this.TxtPrecioVenta.SelectedText = "";
            this.TxtPrecioVenta.SelectionLength = 0;
            this.TxtPrecioVenta.SelectionStart = 0;
            this.TxtPrecioVenta.Size = new System.Drawing.Size(268, 28);
            this.TxtPrecioVenta.TabIndex = 3;
            this.TxtPrecioVenta.UseSystemPasswordChar = false;
            // 
            // TxtPrecioCompra
            // 
            this.TxtPrecioCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPrecioCompra.Depth = 0;
            this.TxtPrecioCompra.Hint = "Precio Compra";
            this.TxtPrecioCompra.Location = new System.Drawing.Point(19, 202);
            this.TxtPrecioCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtPrecioCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPrecioCompra.Name = "TxtPrecioCompra";
            this.TxtPrecioCompra.PasswordChar = '\0';
            this.TxtPrecioCompra.SelectedText = "";
            this.TxtPrecioCompra.SelectionLength = 0;
            this.TxtPrecioCompra.SelectionStart = 0;
            this.TxtPrecioCompra.Size = new System.Drawing.Size(242, 28);
            this.TxtPrecioCompra.TabIndex = 2;
            this.TxtPrecioCompra.UseSystemPasswordChar = false;
            // 
            // TxtCodigoReferencia
            // 
            this.TxtCodigoReferencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtCodigoReferencia.Depth = 0;
            this.TxtCodigoReferencia.Hint = "Código Referencia";
            this.TxtCodigoReferencia.Location = new System.Drawing.Point(19, 102);
            this.TxtCodigoReferencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCodigoReferencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCodigoReferencia.Name = "TxtCodigoReferencia";
            this.TxtCodigoReferencia.PasswordChar = '\0';
            this.TxtCodigoReferencia.SelectedText = "";
            this.TxtCodigoReferencia.SelectionLength = 0;
            this.TxtCodigoReferencia.SelectionStart = 0;
            this.TxtCodigoReferencia.Size = new System.Drawing.Size(239, 28);
            this.TxtCodigoReferencia.TabIndex = 1;
            this.TxtCodigoReferencia.UseSystemPasswordChar = false;
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtNombreProducto.Depth = 0;
            this.TxtNombreProducto.Hint = "Nombre Producto";
            this.TxtNombreProducto.Location = new System.Drawing.Point(22, 58);
            this.TxtNombreProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNombreProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.PasswordChar = '\0';
            this.TxtNombreProducto.SelectedText = "";
            this.TxtNombreProducto.SelectionLength = 0;
            this.TxtNombreProducto.SelectionStart = 0;
            this.TxtNombreProducto.Size = new System.Drawing.Size(239, 28);
            this.TxtNombreProducto.TabIndex = 0;
            this.TxtNombreProducto.UseSystemPasswordChar = false;
            this.TxtNombreProducto.Click += new System.EventHandler(this.TxtNombreProducto_Click_1);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(4, 954);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2095, 211);
            this.panel1.TabIndex = 0;
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // frmEditarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 497);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEditarProductos";
            this.Text = "frmEditarProductos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private System.Windows.Forms.Panel pnlContenedor;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtPrecioCompra;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCodigoReferencia;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtNombreProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCantidadStock;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtPrecioVenta;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox TxtDetalleProducto;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtRutaImagen;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lblCategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIdProducto;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}