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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TxtCantidadStock = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtPrecioVenta = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtPrecioCompra = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtCodigoReferencia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TxtNombreProducto = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pnlTitulo.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(831, 67);
            this.pnlTitulo.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(233, 17);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(355, 27);
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
            this.pnlContenedor.Controls.Add(this.comboBox1);
            this.pnlContenedor.Controls.Add(this.TxtCantidadStock);
            this.pnlContenedor.Controls.Add(this.TxtPrecioVenta);
            this.pnlContenedor.Controls.Add(this.materialSingleLineTextField3);
            this.pnlContenedor.Controls.Add(this.TxtPrecioCompra);
            this.pnlContenedor.Controls.Add(this.materialSingleLineTextField2);
            this.pnlContenedor.Controls.Add(this.TxtCodigoReferencia);
            this.pnlContenedor.Controls.Add(this.materialSingleLineTextField1);
            this.pnlContenedor.Controls.Add(this.TxtNombreProducto);
            this.pnlContenedor.Location = new System.Drawing.Point(0, 73);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1017, 627);
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
            this.lblCategoria.Location = new System.Drawing.Point(372, 26);
            this.lblCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(106, 27);
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
            this.materialLabel3.Location = new System.Drawing.Point(372, 133);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(206, 27);
            this.materialLabel3.TabIndex = 14;
            this.materialLabel3.Text = "Detalle del producto";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.Depth = 0;
            this.btnSalir.Location = new System.Drawing.Point(377, 450);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(148, 51);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Location = new System.Drawing.Point(146, 450);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(148, 51);
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
            this.IdProducto.Location = new System.Drawing.Point(21, 21);
            this.IdProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.PasswordChar = '\0';
            this.IdProducto.SelectedText = "";
            this.IdProducto.SelectionLength = 0;
            this.IdProducto.SelectionStart = 0;
            this.IdProducto.Size = new System.Drawing.Size(269, 32);
            this.IdProducto.TabIndex = 12;
            this.IdProducto.Text = "Id Producto";
            this.IdProducto.UseSystemPasswordChar = false;
            // 
            // TxtDetalleProducto
            // 
            this.TxtDetalleProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtDetalleProducto.Location = new System.Drawing.Point(377, 187);
            this.TxtDetalleProducto.Name = "TxtDetalleProducto";
            this.TxtDetalleProducto.Size = new System.Drawing.Size(299, 212);
            this.TxtDetalleProducto.TabIndex = 9;
            this.TxtDetalleProducto.Text = "";
            // 
            // TxtRutaImagen
            // 
            this.TxtRutaImagen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtRutaImagen.Depth = 0;
            this.TxtRutaImagen.Hint = "Ruta Imagen";
            this.TxtRutaImagen.Location = new System.Drawing.Point(377, 73);
            this.TxtRutaImagen.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtRutaImagen.Name = "TxtRutaImagen";
            this.TxtRutaImagen.PasswordChar = '\0';
            this.TxtRutaImagen.SelectedText = "";
            this.TxtRutaImagen.SelectionLength = 0;
            this.TxtRutaImagen.SelectionStart = 0;
            this.TxtRutaImagen.Size = new System.Drawing.Size(287, 32);
            this.TxtRutaImagen.TabIndex = 7;
            this.TxtRutaImagen.UseSystemPasswordChar = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(537, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 28);
            this.comboBox1.TabIndex = 5;
            // 
            // TxtCantidadStock
            // 
            this.TxtCantidadStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtCantidadStock.Depth = 0;
            this.TxtCantidadStock.Hint = "Cantidad Stock";
            this.TxtCantidadStock.Location = new System.Drawing.Point(21, 367);
            this.TxtCantidadStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCantidadStock.Name = "TxtCantidadStock";
            this.TxtCantidadStock.PasswordChar = '\0';
            this.TxtCantidadStock.SelectedText = "";
            this.TxtCantidadStock.SelectionLength = 0;
            this.TxtCantidadStock.SelectionStart = 0;
            this.TxtCantidadStock.Size = new System.Drawing.Size(302, 32);
            this.TxtCantidadStock.TabIndex = 4;
            this.TxtCantidadStock.UseSystemPasswordChar = false;
            // 
            // TxtPrecioVenta
            // 
            this.TxtPrecioVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPrecioVenta.Depth = 0;
            this.TxtPrecioVenta.Hint = "Precio Venta";
            this.TxtPrecioVenta.Location = new System.Drawing.Point(21, 310);
            this.TxtPrecioVenta.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPrecioVenta.Name = "TxtPrecioVenta";
            this.TxtPrecioVenta.PasswordChar = '\0';
            this.TxtPrecioVenta.SelectedText = "";
            this.TxtPrecioVenta.SelectionLength = 0;
            this.TxtPrecioVenta.SelectionStart = 0;
            this.TxtPrecioVenta.Size = new System.Drawing.Size(302, 32);
            this.TxtPrecioVenta.TabIndex = 3;
            this.TxtPrecioVenta.UseSystemPasswordChar = false;
            // 
            // TxtPrecioCompra
            // 
            this.TxtPrecioCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPrecioCompra.Depth = 0;
            this.TxtPrecioCompra.Hint = "Precio Compra";
            this.TxtPrecioCompra.Location = new System.Drawing.Point(21, 253);
            this.TxtPrecioCompra.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtPrecioCompra.Name = "TxtPrecioCompra";
            this.TxtPrecioCompra.PasswordChar = '\0';
            this.TxtPrecioCompra.SelectedText = "";
            this.TxtPrecioCompra.SelectionLength = 0;
            this.TxtPrecioCompra.SelectionStart = 0;
            this.TxtPrecioCompra.Size = new System.Drawing.Size(272, 32);
            this.TxtPrecioCompra.TabIndex = 2;
            this.TxtPrecioCompra.UseSystemPasswordChar = false;
            // 
            // TxtCodigoReferencia
            // 
            this.TxtCodigoReferencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtCodigoReferencia.Depth = 0;
            this.TxtCodigoReferencia.Hint = "Código Referencia";
            this.TxtCodigoReferencia.Location = new System.Drawing.Point(21, 128);
            this.TxtCodigoReferencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtCodigoReferencia.Name = "TxtCodigoReferencia";
            this.TxtCodigoReferencia.PasswordChar = '\0';
            this.TxtCodigoReferencia.SelectedText = "";
            this.TxtCodigoReferencia.SelectionLength = 0;
            this.TxtCodigoReferencia.SelectionStart = 0;
            this.TxtCodigoReferencia.Size = new System.Drawing.Size(269, 32);
            this.TxtCodigoReferencia.TabIndex = 1;
            this.TxtCodigoReferencia.UseSystemPasswordChar = false;
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtNombreProducto.Depth = 0;
            this.TxtNombreProducto.Hint = "Nombre Producto";
            this.TxtNombreProducto.Location = new System.Drawing.Point(25, 73);
            this.TxtNombreProducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.PasswordChar = '\0';
            this.TxtNombreProducto.SelectedText = "";
            this.TxtNombreProducto.SelectionLength = 0;
            this.TxtNombreProducto.SelectionStart = 0;
            this.TxtNombreProducto.Size = new System.Drawing.Size(269, 32);
            this.TxtNombreProducto.TabIndex = 0;
            this.TxtNombreProducto.UseSystemPasswordChar = false;
            this.TxtNombreProducto.Click += new System.EventHandler(this.TxtNombreProducto_Click_1);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(5, 1193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2357, 264);
            this.panel1.TabIndex = 0;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "Nombre Producto";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(21, 73);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(302, 32);
            this.materialSingleLineTextField1.TabIndex = 0;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            this.materialSingleLineTextField1.Click += new System.EventHandler(this.TxtNombreProducto_Click_1);
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "Código Referencia";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(17, 128);
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(302, 32);
            this.materialSingleLineTextField2.TabIndex = 1;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField3
            // 
            this.materialSingleLineTextField3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.materialSingleLineTextField3.Depth = 0;
            this.materialSingleLineTextField3.Hint = "Precio Compra";
            this.materialSingleLineTextField3.Location = new System.Drawing.Point(17, 253);
            this.materialSingleLineTextField3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField3.Name = "materialSingleLineTextField3";
            this.materialSingleLineTextField3.PasswordChar = '\0';
            this.materialSingleLineTextField3.SelectedText = "";
            this.materialSingleLineTextField3.SelectionLength = 0;
            this.materialSingleLineTextField3.SelectionStart = 0;
            this.materialSingleLineTextField3.Size = new System.Drawing.Size(305, 32);
            this.materialSingleLineTextField3.TabIndex = 2;
            this.materialSingleLineTextField3.UseSystemPasswordChar = false;
            // 
            // frmEditarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 621);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmEditarProductos";
            this.Text = "frmEditarProductos";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
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
        private MaterialSkin.Controls.MaterialSingleLineTextField IdProducto;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lblCategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField3;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
    }
}