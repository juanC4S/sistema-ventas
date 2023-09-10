namespace SisVentas.Presentacion
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.Pnl_opciones = new System.Windows.Forms.Panel();
            this.btn_cerrarsesion = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btn_empresa = new System.Windows.Forms.Button();
            this.Pnl_titulo = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.Pnl_barraestado = new System.Windows.Forms.Panel();
            this.lblDescripcion_ru = new System.Windows.Forms.Label();
            this.lbl_nombre_us = new System.Windows.Forms.Label();
            this.Pnl_contenido = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnFamilias = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.Pnl_opciones.SuspendLayout();
            this.Pnl_titulo.SuspendLayout();
            this.Pnl_barraestado.SuspendLayout();
            this.Pnl_contenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_opciones
            // 
            this.Pnl_opciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(128)))), ((int)(((byte)(167)))));
            this.Pnl_opciones.Controls.Add(this.btn_cerrarsesion);
            this.Pnl_opciones.Controls.Add(this.btnUsuarios);
            this.Pnl_opciones.Controls.Add(this.btn_empresa);
            this.Pnl_opciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnl_opciones.Location = new System.Drawing.Point(647, 0);
            this.Pnl_opciones.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_opciones.Name = "Pnl_opciones";
            this.Pnl_opciones.Size = new System.Drawing.Size(267, 511);
            this.Pnl_opciones.TabIndex = 0;
            // 
            // btn_cerrarsesion
            // 
            this.btn_cerrarsesion.Location = new System.Drawing.Point(63, 453);
            this.btn_cerrarsesion.Name = "btn_cerrarsesion";
            this.btn_cerrarsesion.Size = new System.Drawing.Size(103, 23);
            this.btn_cerrarsesion.TabIndex = 1;
            this.btn_cerrarsesion.Text = "Cerrar sesion";
            this.btn_cerrarsesion.UseVisualStyleBackColor = true;
            this.btn_cerrarsesion.Click += new System.EventHandler(this.btn_cerrarsesion_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(45, 86);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(75, 23);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btn_empresa
            // 
            this.btn_empresa.Location = new System.Drawing.Point(45, 42);
            this.btn_empresa.Name = "btn_empresa";
            this.btn_empresa.Size = new System.Drawing.Size(75, 23);
            this.btn_empresa.TabIndex = 0;
            this.btn_empresa.Text = "Empresa";
            this.btn_empresa.UseVisualStyleBackColor = true;
            // 
            // Pnl_titulo
            // 
            this.Pnl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(61)))), ((int)(((byte)(155)))));
            this.Pnl_titulo.Controls.Add(this.lbl_titulo);
            this.Pnl_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_titulo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_titulo.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_titulo.Name = "Pnl_titulo";
            this.Pnl_titulo.Size = new System.Drawing.Size(647, 130);
            this.Pnl_titulo.TabIndex = 1;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_titulo.Location = new System.Drawing.Point(208, 39);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(209, 25);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Sistema de Ventas";
            // 
            // Pnl_barraestado
            // 
            this.Pnl_barraestado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(225)))), ((int)(((byte)(243)))));
            this.Pnl_barraestado.Controls.Add(this.lblDescripcion_ru);
            this.Pnl_barraestado.Controls.Add(this.lbl_nombre_us);
            this.Pnl_barraestado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_barraestado.Location = new System.Drawing.Point(0, 391);
            this.Pnl_barraestado.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_barraestado.Name = "Pnl_barraestado";
            this.Pnl_barraestado.Size = new System.Drawing.Size(647, 120);
            this.Pnl_barraestado.TabIndex = 2;
            // 
            // lblDescripcion_ru
            // 
            this.lblDescripcion_ru.AutoSize = true;
            this.lblDescripcion_ru.Location = new System.Drawing.Point(60, 62);
            this.lblDescripcion_ru.Name = "lblDescripcion_ru";
            this.lblDescripcion_ru.Size = new System.Drawing.Size(86, 19);
            this.lblDescripcion_ru.TabIndex = 9;
            this.lblDescripcion_ru.Text = "Rol usuario:";
            // 
            // lbl_nombre_us
            // 
            this.lbl_nombre_us.AutoSize = true;
            this.lbl_nombre_us.Location = new System.Drawing.Point(60, 27);
            this.lbl_nombre_us.Name = "lbl_nombre_us";
            this.lbl_nombre_us.Size = new System.Drawing.Size(63, 19);
            this.lbl_nombre_us.TabIndex = 8;
            this.lbl_nombre_us.Text = "Usuario:";
            // 
            // Pnl_contenido
            // 
            this.Pnl_contenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.Pnl_contenido.Controls.Add(this.btnReportes);
            this.Pnl_contenido.Controls.Add(this.btnVentas);
            this.Pnl_contenido.Controls.Add(this.btnCompras);
            this.Pnl_contenido.Controls.Add(this.btnClientes);
            this.Pnl_contenido.Controls.Add(this.btnProveedores);
            this.Pnl_contenido.Controls.Add(this.btnFamilias);
            this.Pnl_contenido.Controls.Add(this.btnProductos);
            this.Pnl_contenido.Controls.Add(this.btnEmpresa);
            this.Pnl_contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_contenido.Location = new System.Drawing.Point(0, 130);
            this.Pnl_contenido.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_contenido.Name = "Pnl_contenido";
            this.Pnl_contenido.Size = new System.Drawing.Size(647, 261);
            this.Pnl_contenido.TabIndex = 3;
            // 
            // btnReportes
            // 
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.ImageKey = "contabilidad.png";
            this.btnReportes.ImageList = this.imageList1;
            this.btnReportes.Location = new System.Drawing.Point(523, 131);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(4);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(107, 106);
            this.btnReportes.TabIndex = 7;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "empresa.png");
            this.imageList1.Images.SetKeyName(1, "724package_100522.png");
            this.imageList1.Images.SetKeyName(2, "1455554314_line-15_icon-icons.com_53330.png");
            this.imageList1.Images.SetKeyName(3, "proveedor.png");
            this.imageList1.Images.SetKeyName(4, "shoppaymentorderbuy-33_icon-icons.com_73869.png");
            this.imageList1.Images.SetKeyName(5, "punto-de-venta.png");
            this.imageList1.Images.SetKeyName(6, "comunidad.png");
            this.imageList1.Images.SetKeyName(7, "contabilidad.png");
            // 
            // btnVentas
            // 
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.ImageKey = "punto-de-venta.png";
            this.btnVentas.ImageList = this.imageList1;
            this.btnVentas.Location = new System.Drawing.Point(348, 131);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(4);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(107, 106);
            this.btnVentas.TabIndex = 6;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVentas.UseVisualStyleBackColor = true;
            // 
            // btnCompras
            // 
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompras.ImageKey = "shoppaymentorderbuy-33_icon-icons.com_73869.png";
            this.btnCompras.ImageList = this.imageList1;
            this.btnCompras.Location = new System.Drawing.Point(180, 131);
            this.btnCompras.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(107, 106);
            this.btnCompras.TabIndex = 5;
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCompras.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.ImageKey = "comunidad.png";
            this.btnClientes.ImageList = this.imageList1;
            this.btnClientes.Location = new System.Drawing.Point(13, 131);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(107, 106);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnProveedores
            // 
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedores.ImageKey = "proveedor.png";
            this.btnProveedores.ImageList = this.imageList1;
            this.btnProveedores.Location = new System.Drawing.Point(523, 8);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(107, 106);
            this.btnProveedores.TabIndex = 3;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProveedores.UseVisualStyleBackColor = true;
            // 
            // btnFamilias
            // 
            this.btnFamilias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFamilias.ImageKey = "1455554314_line-15_icon-icons.com_53330.png";
            this.btnFamilias.ImageList = this.imageList1;
            this.btnFamilias.Location = new System.Drawing.Point(348, 8);
            this.btnFamilias.Margin = new System.Windows.Forms.Padding(4);
            this.btnFamilias.Name = "btnFamilias";
            this.btnFamilias.Size = new System.Drawing.Size(107, 106);
            this.btnFamilias.TabIndex = 2;
            this.btnFamilias.Text = "Familias Productos";
            this.btnFamilias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFamilias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFamilias.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.ImageKey = "724package_100522.png";
            this.btnProductos.ImageList = this.imageList1;
            this.btnProductos.Location = new System.Drawing.Point(180, 8);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(4);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(107, 106);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProductos.UseVisualStyleBackColor = true;
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpresa.ImageKey = "empresa.png";
            this.btnEmpresa.ImageList = this.imageList1;
            this.btnEmpresa.Location = new System.Drawing.Point(13, 8);
            this.btnEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(107, 106);
            this.btnEmpresa.TabIndex = 0;
            this.btnEmpresa.Text = "Empresa";
            this.btnEmpresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEmpresa.UseVisualStyleBackColor = true;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 511);
            this.Controls.Add(this.Pnl_contenido);
            this.Controls.Add(this.Pnl_barraestado);
            this.Controls.Add(this.Pnl_titulo);
            this.Controls.Add(this.Pnl_opciones);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Ventas ver.1.0";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.Pnl_opciones.ResumeLayout(false);
            this.Pnl_titulo.ResumeLayout(false);
            this.Pnl_titulo.PerformLayout();
            this.Pnl_barraestado.ResumeLayout(false);
            this.Pnl_barraestado.PerformLayout();
            this.Pnl_contenido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_opciones;
        private System.Windows.Forms.Panel Pnl_titulo;
        private System.Windows.Forms.Panel Pnl_barraestado;
        private System.Windows.Forms.Panel Pnl_contenido;
        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnFamilias;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Label lbl_nombre_us;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lblDescripcion_ru;
        private System.Windows.Forms.Button btn_cerrarsesion;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btn_empresa;
    }
}