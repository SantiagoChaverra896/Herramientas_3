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
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.lblCategoria = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.IdProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtDetalleProducto = new System.Windows.Forms.RichTextBox();
            this.TxtRutaImagen = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.TxtCantidadStock = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtPrecioVenta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtprecioc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtcodigorefe = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtCodigoReferencia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtproducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtNombreProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTitulo.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(554, 44);
            this.pnlTitulo.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(155, 11);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(246, 19);
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
            this.pnlContenedor.Controls.Add(this.IdProducto);
            this.pnlContenedor.Controls.Add(this.TxtDetalleProducto);
            this.pnlContenedor.Controls.Add(this.TxtRutaImagen);
            this.pnlContenedor.Controls.Add(this.cboEmpleado);
            this.pnlContenedor.Controls.Add(this.TxtCantidadStock);
            this.pnlContenedor.Controls.Add(this.TxtPrecioVenta);
            this.pnlContenedor.Controls.Add(this.txtprecioc);
            this.pnlContenedor.Controls.Add(this.txtcodigorefe);
            this.pnlContenedor.Controls.Add(this.TxtCodigoReferencia);
            this.pnlContenedor.Controls.Add(this.txtproducto);
            this.pnlContenedor.Controls.Add(this.TxtNombreProducto);
            this.pnlContenedor.Location = new System.Drawing.Point(0, 47);
            this.pnlContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(678, 408);
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
            this.lblCategoria.Location = new System.Drawing.Point(248, 17);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(74, 19);
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
            this.materialLabel3.Location = new System.Drawing.Point(248, 86);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(144, 19);
            this.materialLabel3.TabIndex = 14;
            this.materialLabel3.Text = "Detalle del producto";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(251, 292);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(99, 33);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(97, 292);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(99, 33);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // IdProducto
            // 
            this.IdProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IdProducto.Depth = 0;
            this.IdProducto.Hint = "";
            this.IdProducto.Location = new System.Drawing.Point(14, 14);
            this.IdProducto.Margin = new System.Windows.Forms.Padding(2);
            this.IdProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.PasswordChar = '\0';
            this.IdProducto.SelectedText = "";
            this.IdProducto.SelectionLength = 0;
            this.IdProducto.SelectionStart = 0;
            this.IdProducto.Size = new System.Drawing.Size(179, 23);
            this.IdProducto.TabIndex = 12;
            this.IdProducto.Text = "Id Producto";
            this.IdProducto.UseSystemPasswordChar = false;
            // 
            // TxtDetalleProducto
            // 
            this.TxtDetalleProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtDetalleProducto.Location = new System.Drawing.Point(251, 122);
            this.TxtDetalleProducto.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDetalleProducto.Name = "TxtDetalleProducto";
            this.TxtDetalleProducto.Size = new System.Drawing.Size(201, 139);
            this.TxtDetalleProducto.TabIndex = 9;
            this.TxtDetalleProducto.Text = "";
            // 
            // TxtRutaImagen
            // 
            this.TxtRutaImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtRutaImagen.Depth = 0;
            this.TxtRutaImagen.Hint = "Ruta Imagen";
            this.TxtRutaImagen.Location = new System.Drawing.Point(251, 47);
            this.TxtRutaImagen.Margin = new System.Windows.Forms.Padding(2);
            this.TxtRutaImagen.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtRutaImagen.Name = "TxtRutaImagen";
            this.TxtRutaImagen.PasswordChar = '\0';
            this.TxtRutaImagen.SelectedText = "";
            this.TxtRutaImagen.SelectionLength = 0;
            this.TxtRutaImagen.SelectionStart = 0;
            this.TxtRutaImagen.Size = new System.Drawing.Size(191, 23);
            this.TxtRutaImagen.TabIndex = 7;
            this.TxtRutaImagen.UseSystemPasswordChar = false;
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(358, 18);
            this.cboEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(94, 21);
            this.cboEmpleado.TabIndex = 5;
            this.cboEmpleado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cboEmpleado.SelectedValueChanged += new System.EventHandler(this.cboEmpleado_SelectedValueChanged);
            // 
            // TxtCantidadStock
            // 
            this.TxtCantidadStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtCantidadStock.Depth = 0;
            this.TxtCantidadStock.Hint = "Cantidad Stock";
            this.TxtCantidadStock.Location = new System.Drawing.Point(14, 239);
            this.TxtCantidadStock.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCantidadStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCantidadStock.Name = "TxtCantidadStock";
            this.TxtCantidadStock.PasswordChar = '\0';
            this.TxtCantidadStock.SelectedText = "";
            this.TxtCantidadStock.SelectionLength = 0;
            this.TxtCantidadStock.SelectionStart = 0;
            this.TxtCantidadStock.Size = new System.Drawing.Size(201, 23);
            this.TxtCantidadStock.TabIndex = 4;
            this.TxtCantidadStock.UseSystemPasswordChar = false;
            // 
            // TxtPrecioVenta
            // 
            this.TxtPrecioVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPrecioVenta.Depth = 0;
            this.TxtPrecioVenta.Hint = "Precio Venta";
            this.TxtPrecioVenta.Location = new System.Drawing.Point(14, 202);
            this.TxtPrecioVenta.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPrecioVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPrecioVenta.Name = "TxtPrecioVenta";
            this.TxtPrecioVenta.PasswordChar = '\0';
            this.TxtPrecioVenta.SelectedText = "";
            this.TxtPrecioVenta.SelectionLength = 0;
            this.TxtPrecioVenta.SelectionStart = 0;
            this.TxtPrecioVenta.Size = new System.Drawing.Size(201, 23);
            this.TxtPrecioVenta.TabIndex = 3;
            this.TxtPrecioVenta.UseSystemPasswordChar = false;
            // 
            // txtprecioc
            // 
            this.txtprecioc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtprecioc.Depth = 0;
            this.txtprecioc.Hint = "Precio Compra";
            this.txtprecioc.Location = new System.Drawing.Point(12, 175);
            this.txtprecioc.Margin = new System.Windows.Forms.Padding(2);
            this.txtprecioc.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtprecioc.Name = "txtprecioc";
            this.txtprecioc.PasswordChar = '\0';
            this.txtprecioc.SelectedText = "";
            this.txtprecioc.SelectionLength = 0;
            this.txtprecioc.SelectionStart = 0;
            this.txtprecioc.Size = new System.Drawing.Size(203, 23);
            this.txtprecioc.TabIndex = 2;
            this.txtprecioc.UseSystemPasswordChar = false;
            // 
            // txtcodigorefe
            // 
            this.txtcodigorefe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcodigorefe.Depth = 0;
            this.txtcodigorefe.Hint = "Código Referencia";
            this.txtcodigorefe.Location = new System.Drawing.Point(11, 83);
            this.txtcodigorefe.Margin = new System.Windows.Forms.Padding(2);
            this.txtcodigorefe.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcodigorefe.Name = "txtcodigorefe";
            this.txtcodigorefe.PasswordChar = '\0';
            this.txtcodigorefe.SelectedText = "";
            this.txtcodigorefe.SelectionLength = 0;
            this.txtcodigorefe.SelectionStart = 0;
            this.txtcodigorefe.Size = new System.Drawing.Size(201, 23);
            this.txtcodigorefe.TabIndex = 1;
            this.txtcodigorefe.UseSystemPasswordChar = false;
            // 
            // TxtCodigoReferencia
            // 
            this.TxtCodigoReferencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtCodigoReferencia.Depth = 0;
            this.TxtCodigoReferencia.Hint = "Código Referencia";
            this.TxtCodigoReferencia.Location = new System.Drawing.Point(14, 83);
            this.TxtCodigoReferencia.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCodigoReferencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCodigoReferencia.Name = "TxtCodigoReferencia";
            this.TxtCodigoReferencia.PasswordChar = '\0';
            this.TxtCodigoReferencia.SelectedText = "";
            this.TxtCodigoReferencia.SelectionLength = 0;
            this.TxtCodigoReferencia.SelectionStart = 0;
            this.TxtCodigoReferencia.Size = new System.Drawing.Size(179, 23);
            this.TxtCodigoReferencia.TabIndex = 1;
            this.TxtCodigoReferencia.UseSystemPasswordChar = false;
            // 
            // txtproducto
            // 
            this.txtproducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtproducto.Depth = 0;
            this.txtproducto.Hint = "Nombre Producto";
            this.txtproducto.Location = new System.Drawing.Point(14, 47);
            this.txtproducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtproducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.PasswordChar = '\0';
            this.txtproducto.SelectedText = "";
            this.txtproducto.SelectionLength = 0;
            this.txtproducto.SelectionStart = 0;
            this.txtproducto.Size = new System.Drawing.Size(201, 23);
            this.txtproducto.TabIndex = 0;
            this.txtproducto.UseSystemPasswordChar = false;
            this.txtproducto.Click += new System.EventHandler(this.TxtNombreProducto_Click_1);
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtNombreProducto.Depth = 0;
            this.TxtNombreProducto.Hint = "Nombre Producto";
            this.TxtNombreProducto.Location = new System.Drawing.Point(17, 47);
            this.TxtNombreProducto.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombreProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.PasswordChar = '\0';
            this.TxtNombreProducto.SelectedText = "";
            this.TxtNombreProducto.SelectionLength = 0;
            this.TxtNombreProducto.SelectionStart = 0;
            this.TxtNombreProducto.Size = new System.Drawing.Size(179, 23);
            this.TxtNombreProducto.TabIndex = 0;
            this.TxtNombreProducto.UseSystemPasswordChar = false;
            this.TxtNombreProducto.Click += new System.EventHandler(this.TxtNombreProducto_Click_1);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 775);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1571, 172);
            this.panel1.TabIndex = 0;
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // frmEditarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 404);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEditarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Productos";
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
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCodigoReferencia;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtNombreProducto;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtCantidadStock;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtPrecioVenta;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.RichTextBox TxtDetalleProducto;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtRutaImagen;
        private MaterialSkin.Controls.MaterialSingleLineTextField IdProducto;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lblCategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtprecioc;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtcodigorefe;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtproducto;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}