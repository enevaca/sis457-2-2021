
namespace CpMinervaDesktop
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.c1Ribbon1 = new C1.Win.C1Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.C1Ribbon.RibbonApplicationMenu();
            this.ribbonBottomToolBar1 = new C1.Win.C1Ribbon.RibbonBottomToolBar();
            this.ribbonConfigToolBar1 = new C1.Win.C1Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.C1Ribbon.RibbonQat();
            this.tabCatalogos = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup1 = new C1.Win.C1Ribbon.RibbonGroup();
            this.btnCaProducto = new C1.Win.C1Ribbon.RibbonButton();
            this.btnCaProveedor = new C1.Win.C1Ribbon.RibbonButton();
            this.btnCaCliente = new C1.Win.C1Ribbon.RibbonButton();
            this.tabMovimientos = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup2 = new C1.Win.C1Ribbon.RibbonGroup();
            this.btnMoCompra = new C1.Win.C1Ribbon.RibbonButton();
            this.btnMoCaja = new C1.Win.C1Ribbon.RibbonButton();
            this.tabAdministracion = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup3 = new C1.Win.C1Ribbon.RibbonGroup();
            this.btnAdUsuario = new C1.Win.C1Ribbon.RibbonButton();
            this.btnAdEmpleado = new C1.Win.C1Ribbon.RibbonButton();
            this.tabAyuda = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup4 = new C1.Win.C1Ribbon.RibbonGroup();
            this.ribbonButton8 = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonButton9 = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonTopToolBar1 = new C1.Win.C1Ribbon.RibbonTopToolBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ribbonTab1 = new C1.Win.C1Ribbon.RibbonTab();
            this.ribbonGroup5 = new C1.Win.C1Ribbon.RibbonGroup();
            this.btnReProductos = new C1.Win.C1Ribbon.RibbonButton();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.AutoSizeElement = C1.Framework.AutoSizeElement.Width;
            this.c1Ribbon1.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(808, 156);
            this.c1Ribbon1.Tabs.Add(this.tabCatalogos);
            this.c1Ribbon1.Tabs.Add(this.tabMovimientos);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab1);
            this.c1Ribbon1.Tabs.Add(this.tabAdministracion);
            this.c1Ribbon1.Tabs.Add(this.tabAyuda);
            this.c1Ribbon1.TopToolBarHolder = this.ribbonTopToolBar1;
            this.c1Ribbon1.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2007Black;
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            // 
            // ribbonBottomToolBar1
            // 
            this.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.Name = "ribbonQat1";
            // 
            // tabCatalogos
            // 
            this.tabCatalogos.Groups.Add(this.ribbonGroup1);
            this.tabCatalogos.Name = "tabCatalogos";
            this.tabCatalogos.Text = "Catálogos";
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.Items.Add(this.btnCaProducto);
            this.ribbonGroup1.Items.Add(this.btnCaProveedor);
            this.ribbonGroup1.Items.Add(this.btnCaCliente);
            this.ribbonGroup1.LauncherToolTip = "Catálogos Generales";
            this.ribbonGroup1.Name = "ribbonGroup1";
            this.ribbonGroup1.Text = "General";
            // 
            // btnCaProducto
            // 
            this.btnCaProducto.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCaProducto.LargeImage")));
            this.btnCaProducto.Name = "btnCaProducto";
            this.btnCaProducto.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnCaProducto.SmallImage")));
            this.btnCaProducto.Text = "Productos";
            this.btnCaProducto.ToolTip = "Gestión de Productos";
            this.btnCaProducto.Click += new System.EventHandler(this.btnCaProducto_Click);
            // 
            // btnCaProveedor
            // 
            this.btnCaProveedor.LargeImage = global::CpMinervaDesktop.Properties.Resources.provider;
            this.btnCaProveedor.Name = "btnCaProveedor";
            this.btnCaProveedor.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnCaProveedor.SmallImage")));
            this.btnCaProveedor.Text = "Proveedores";
            this.btnCaProveedor.ToolTip = "Gestión de Proveedores";
            // 
            // btnCaCliente
            // 
            this.btnCaCliente.LargeImage = global::CpMinervaDesktop.Properties.Resources.clients;
            this.btnCaCliente.Name = "btnCaCliente";
            this.btnCaCliente.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnCaCliente.SmallImage")));
            this.btnCaCliente.Text = "Clientes";
            this.btnCaCliente.ToolTip = "Gestión de Clientes";
            // 
            // tabMovimientos
            // 
            this.tabMovimientos.Groups.Add(this.ribbonGroup2);
            this.tabMovimientos.Name = "tabMovimientos";
            this.tabMovimientos.Text = "Movimientos";
            // 
            // ribbonGroup2
            // 
            this.ribbonGroup2.Items.Add(this.btnMoCompra);
            this.ribbonGroup2.Items.Add(this.btnMoCaja);
            this.ribbonGroup2.LauncherToolTip = "Compras y Ventas";
            this.ribbonGroup2.Name = "ribbonGroup2";
            this.ribbonGroup2.Text = "Compras y Ventas";
            // 
            // btnMoCompra
            // 
            this.btnMoCompra.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMoCompra.LargeImage")));
            this.btnMoCompra.Name = "btnMoCompra";
            this.btnMoCompra.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnMoCompra.SmallImage")));
            this.btnMoCompra.Text = "Comprar";
            this.btnMoCompra.ToolTip = "Registrar una compra";
            this.btnMoCompra.Click += new System.EventHandler(this.btnMoCompra_Click);
            // 
            // btnMoCaja
            // 
            this.btnMoCaja.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMoCaja.LargeImage")));
            this.btnMoCaja.Name = "btnMoCaja";
            this.btnMoCaja.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnMoCaja.SmallImage")));
            this.btnMoCaja.Text = "Caja";
            this.btnMoCaja.ToolTip = "Atención en Cajas";
            // 
            // tabAdministracion
            // 
            this.tabAdministracion.Groups.Add(this.ribbonGroup3);
            this.tabAdministracion.Name = "tabAdministracion";
            this.tabAdministracion.Text = "Administración";
            // 
            // ribbonGroup3
            // 
            this.ribbonGroup3.Items.Add(this.btnAdUsuario);
            this.ribbonGroup3.Items.Add(this.btnAdEmpleado);
            this.ribbonGroup3.LauncherToolTip = "Administración";
            this.ribbonGroup3.Name = "ribbonGroup3";
            this.ribbonGroup3.Text = "Administración";
            // 
            // btnAdUsuario
            // 
            this.btnAdUsuario.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAdUsuario.LargeImage")));
            this.btnAdUsuario.Name = "btnAdUsuario";
            this.btnAdUsuario.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnAdUsuario.SmallImage")));
            this.btnAdUsuario.Text = "Usuarios";
            this.btnAdUsuario.ToolTip = "Gestión de Usuarios";
            // 
            // btnAdEmpleado
            // 
            this.btnAdEmpleado.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAdEmpleado.LargeImage")));
            this.btnAdEmpleado.Name = "btnAdEmpleado";
            this.btnAdEmpleado.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnAdEmpleado.SmallImage")));
            this.btnAdEmpleado.Text = "Empleados";
            this.btnAdEmpleado.ToolTip = "Gestión de Empleados";
            this.btnAdEmpleado.Click += new System.EventHandler(this.btnAdEmpleado_Click);
            // 
            // tabAyuda
            // 
            this.tabAyuda.Groups.Add(this.ribbonGroup4);
            this.tabAyuda.Name = "tabAyuda";
            this.tabAyuda.Text = "Ayuda";
            // 
            // ribbonGroup4
            // 
            this.ribbonGroup4.Items.Add(this.ribbonButton8);
            this.ribbonGroup4.Items.Add(this.ribbonButton9);
            this.ribbonGroup4.LauncherToolTip = "Ayuda";
            this.ribbonGroup4.Name = "ribbonGroup4";
            this.ribbonGroup4.Text = "Ayuda";
            // 
            // ribbonButton8
            // 
            this.ribbonButton8.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton8.LargeImage")));
            this.ribbonButton8.Name = "ribbonButton8";
            this.ribbonButton8.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton8.SmallImage")));
            this.ribbonButton8.Text = "Manual de Usuario";
            // 
            // ribbonButton9
            // 
            this.ribbonButton9.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton9.LargeImage")));
            this.ribbonButton9.Name = "ribbonButton9";
            this.ribbonButton9.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton9.SmallImage")));
            this.ribbonButton9.Text = "Acerca De";
            this.ribbonButton9.ToolTip = "Acerca De";
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CpMinervaDesktop.Properties.Resources.principal;
            this.pictureBox1.Location = new System.Drawing.Point(0, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(808, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Groups.Add(this.ribbonGroup5);
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Reportes";
            // 
            // ribbonGroup5
            // 
            this.ribbonGroup5.Items.Add(this.btnReProductos);
            this.ribbonGroup5.Name = "ribbonGroup5";
            this.ribbonGroup5.Text = "Lista de Reportes";
            // 
            // btnReProductos
            // 
            this.btnReProductos.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReProductos.LargeImage")));
            this.btnReProductos.Name = "btnReProductos";
            this.btnReProductos.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnReProductos.SmallImage")));
            this.btnReProductos.Text = "Productos";
            this.btnReProductos.ToolTip = "Reporte de Productos";
            this.btnReProductos.Click += new System.EventHandler(this.btnReProductos_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 510);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.c1Ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::: Principal - Minerva :::";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.C1Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.C1Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.C1Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.C1Ribbon.RibbonQat ribbonQat1;
        private C1.Win.C1Ribbon.RibbonTab tabCatalogos;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup1;
        private C1.Win.C1Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.C1Ribbon.RibbonButton btnCaProducto;
        private C1.Win.C1Ribbon.RibbonButton btnCaProveedor;
        private C1.Win.C1Ribbon.RibbonButton btnCaCliente;
        private C1.Win.C1Ribbon.RibbonTab tabMovimientos;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup2;
        private C1.Win.C1Ribbon.RibbonButton btnMoCompra;
        private C1.Win.C1Ribbon.RibbonButton btnMoCaja;
        private C1.Win.C1Ribbon.RibbonTab tabAdministracion;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup3;
        private C1.Win.C1Ribbon.RibbonButton btnAdUsuario;
        private C1.Win.C1Ribbon.RibbonButton btnAdEmpleado;
        private C1.Win.C1Ribbon.RibbonTab tabAyuda;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup4;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton8;
        private C1.Win.C1Ribbon.RibbonButton ribbonButton9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private C1.Win.C1Ribbon.RibbonTab ribbonTab1;
        private C1.Win.C1Ribbon.RibbonGroup ribbonGroup5;
        private C1.Win.C1Ribbon.RibbonButton btnReProductos;
    }
}

