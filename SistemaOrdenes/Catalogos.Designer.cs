namespace SistemaOrdenes
{
    partial class Catalogos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalogos));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.btn_BuecarProveedor = new System.Windows.Forms.Button();
            this.btn_EliminarProveedor = new MetroFramework.Controls.MetroTile();
            this.btn_EditarProveedor = new MetroFramework.Controls.MetroTile();
            this.btn_NuevoProveedor = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_BuscarProveedor = new MetroFramework.Controls.MetroTextBox();
            this.dg_Proveedor = new System.Windows.Forms.DataGridView();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btn_BuscarDepto = new System.Windows.Forms.Button();
            this.btn_EliminarDepto = new MetroFramework.Controls.MetroTile();
            this.btn_EditarDepto = new MetroFramework.Controls.MetroTile();
            this.btn_NuevoDepto = new MetroFramework.Controls.MetroTile();
            this.dg_Depto = new System.Windows.Forms.DataGridView();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_BuscarDepto = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.btn_BuscarVehiculo = new System.Windows.Forms.Button();
            this.btn_EliminarVehiculos = new MetroFramework.Controls.MetroTile();
            this.btn_EditarVehiculos = new MetroFramework.Controls.MetroTile();
            this.btn_NuevoVehiculos = new MetroFramework.Controls.MetroTile();
            this.dg_Vehiculos = new System.Windows.Forms.DataGridView();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txt_BuscarVehiculos = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.btn_BuscarMaquina = new System.Windows.Forms.Button();
            this.btn_EliminarMaquina = new MetroFramework.Controls.MetroTile();
            this.btn_EditarMaquina = new MetroFramework.Controls.MetroTile();
            this.btn_NuevoMaquina = new MetroFramework.Controls.MetroTile();
            this.dg_Maquinas = new System.Windows.Forms.DataGridView();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txt_BuscarMaquinas = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Proveedor)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Depto)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Vehiculos)).BeginInit();
            this.metroTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Maquinas)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.metroTabPage4);
            this.metroTabControl1.Location = new System.Drawing.Point(6, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 3;
            this.metroTabControl1.Size = new System.Drawing.Size(782, 375);
            this.metroTabControl1.TabIndex = 0;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btn_BuecarProveedor);
            this.metroTabPage1.Controls.Add(this.btn_EliminarProveedor);
            this.metroTabPage1.Controls.Add(this.btn_EditarProveedor);
            this.metroTabPage1.Controls.Add(this.btn_NuevoProveedor);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.txt_BuscarProveedor);
            this.metroTabPage1.Controls.Add(this.dg_Proveedor);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(774, 336);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Proveedores";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // btn_BuecarProveedor
            // 
            this.btn_BuecarProveedor.Location = new System.Drawing.Point(280, 67);
            this.btn_BuecarProveedor.Name = "btn_BuecarProveedor";
            this.btn_BuecarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btn_BuecarProveedor.TabIndex = 8;
            this.btn_BuecarProveedor.Text = "Buscar";
            this.btn_BuecarProveedor.UseVisualStyleBackColor = true;
            this.btn_BuecarProveedor.Click += new System.EventHandler(this.btn_BuecarProveedor_Click);
            // 
            // btn_EliminarProveedor
            // 
            this.btn_EliminarProveedor.CustomBackground = true;
            this.btn_EliminarProveedor.CustomForeColor = true;
            this.btn_EliminarProveedor.Location = new System.Drawing.Point(661, 36);
            this.btn_EliminarProveedor.Name = "btn_EliminarProveedor";
            this.btn_EliminarProveedor.Size = new System.Drawing.Size(106, 55);
            this.btn_EliminarProveedor.TabIndex = 7;
            this.btn_EliminarProveedor.Text = "Borrar";
            this.btn_EliminarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EliminarProveedor.TileImage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarProveedor.TileImage")));
            this.btn_EliminarProveedor.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EliminarProveedor.UseTileImage = true;
            this.btn_EliminarProveedor.Click += new System.EventHandler(this.btn_EliminarProveedor_Click);
            // 
            // btn_EditarProveedor
            // 
            this.btn_EditarProveedor.CustomBackground = true;
            this.btn_EditarProveedor.CustomForeColor = true;
            this.btn_EditarProveedor.Location = new System.Drawing.Point(528, 35);
            this.btn_EditarProveedor.Name = "btn_EditarProveedor";
            this.btn_EditarProveedor.Size = new System.Drawing.Size(106, 55);
            this.btn_EditarProveedor.TabIndex = 6;
            this.btn_EditarProveedor.Text = "Editar";
            this.btn_EditarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EditarProveedor.TileImage = ((System.Drawing.Image)(resources.GetObject("btn_EditarProveedor.TileImage")));
            this.btn_EditarProveedor.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EditarProveedor.UseTileImage = true;
            this.btn_EditarProveedor.Click += new System.EventHandler(this.btn_EditarProveedor_Click);
            // 
            // btn_NuevoProveedor
            // 
            this.btn_NuevoProveedor.CustomBackground = true;
            this.btn_NuevoProveedor.CustomForeColor = true;
            this.btn_NuevoProveedor.Location = new System.Drawing.Point(399, 35);
            this.btn_NuevoProveedor.Name = "btn_NuevoProveedor";
            this.btn_NuevoProveedor.Size = new System.Drawing.Size(106, 55);
            this.btn_NuevoProveedor.TabIndex = 5;
            this.btn_NuevoProveedor.Text = "Nuevo";
            this.btn_NuevoProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NuevoProveedor.TileImage = ((System.Drawing.Image)(resources.GetObject("btn_NuevoProveedor.TileImage")));
            this.btn_NuevoProveedor.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NuevoProveedor.UseMnemonic = false;
            this.btn_NuevoProveedor.UseTileImage = true;
            this.btn_NuevoProveedor.Click += new System.EventHandler(this.btn_NuevoProveedor_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 46);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Buscar:";
            // 
            // txt_BuscarProveedor
            // 
            this.txt_BuscarProveedor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_BuscarProveedor.CustomBackground = true;
            this.txt_BuscarProveedor.CustomForeColor = true;
            this.txt_BuscarProveedor.Location = new System.Drawing.Point(13, 68);
            this.txt_BuscarProveedor.Name = "txt_BuscarProveedor";
            this.txt_BuscarProveedor.Size = new System.Drawing.Size(252, 23);
            this.txt_BuscarProveedor.TabIndex = 3;
            this.txt_BuscarProveedor.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_BuscarProveedor.UseStyleColors = true;
            // 
            // dg_Proveedor
            // 
            this.dg_Proveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_Proveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_Proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Proveedor.Location = new System.Drawing.Point(13, 98);
            this.dg_Proveedor.Name = "dg_Proveedor";
            this.dg_Proveedor.Size = new System.Drawing.Size(758, 235);
            this.dg_Proveedor.TabIndex = 2;
            this.dg_Proveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Proveedor_CellClick);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btn_BuscarDepto);
            this.metroTabPage2.Controls.Add(this.btn_EliminarDepto);
            this.metroTabPage2.Controls.Add(this.btn_EditarDepto);
            this.metroTabPage2.Controls.Add(this.btn_NuevoDepto);
            this.metroTabPage2.Controls.Add(this.dg_Depto);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.txt_BuscarDepto);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(774, 336);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Departamentos";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // btn_BuscarDepto
            // 
            this.btn_BuscarDepto.Location = new System.Drawing.Point(286, 67);
            this.btn_BuscarDepto.Name = "btn_BuscarDepto";
            this.btn_BuscarDepto.Size = new System.Drawing.Size(75, 23);
            this.btn_BuscarDepto.TabIndex = 11;
            this.btn_BuscarDepto.Text = "Buscar";
            this.btn_BuscarDepto.UseVisualStyleBackColor = true;
            this.btn_BuscarDepto.Click += new System.EventHandler(this.btn_BuscarDepto_Click);
            // 
            // btn_EliminarDepto
            // 
            this.btn_EliminarDepto.CustomBackground = true;
            this.btn_EliminarDepto.CustomForeColor = true;
            this.btn_EliminarDepto.Location = new System.Drawing.Point(672, 36);
            this.btn_EliminarDepto.Name = "btn_EliminarDepto";
            this.btn_EliminarDepto.Size = new System.Drawing.Size(106, 55);
            this.btn_EliminarDepto.TabIndex = 10;
            this.btn_EliminarDepto.Text = "Borrar";
            this.btn_EliminarDepto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EliminarDepto.TileImage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarDepto.TileImage")));
            this.btn_EliminarDepto.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EliminarDepto.UseTileImage = true;
            this.btn_EliminarDepto.Click += new System.EventHandler(this.btn_EliminarDepto_Click);
            // 
            // btn_EditarDepto
            // 
            this.btn_EditarDepto.CustomBackground = true;
            this.btn_EditarDepto.CustomForeColor = true;
            this.btn_EditarDepto.Location = new System.Drawing.Point(539, 35);
            this.btn_EditarDepto.Name = "btn_EditarDepto";
            this.btn_EditarDepto.Size = new System.Drawing.Size(106, 55);
            this.btn_EditarDepto.TabIndex = 9;
            this.btn_EditarDepto.Text = "Editar";
            this.btn_EditarDepto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EditarDepto.TileImage = ((System.Drawing.Image)(resources.GetObject("btn_EditarDepto.TileImage")));
            this.btn_EditarDepto.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EditarDepto.UseTileImage = true;
            this.btn_EditarDepto.Click += new System.EventHandler(this.btn_EditarDepto_Click);
            // 
            // btn_NuevoDepto
            // 
            this.btn_NuevoDepto.CustomBackground = true;
            this.btn_NuevoDepto.CustomForeColor = true;
            this.btn_NuevoDepto.Location = new System.Drawing.Point(410, 35);
            this.btn_NuevoDepto.Name = "btn_NuevoDepto";
            this.btn_NuevoDepto.Size = new System.Drawing.Size(106, 55);
            this.btn_NuevoDepto.TabIndex = 8;
            this.btn_NuevoDepto.Text = "Nuevo";
            this.btn_NuevoDepto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NuevoDepto.TileImage = ((System.Drawing.Image)(resources.GetObject("btn_NuevoDepto.TileImage")));
            this.btn_NuevoDepto.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NuevoDepto.UseMnemonic = false;
            this.btn_NuevoDepto.UseTileImage = true;
            this.btn_NuevoDepto.Click += new System.EventHandler(this.btn_NuevoDepto_Click);
            // 
            // dg_Depto
            // 
            this.dg_Depto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_Depto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_Depto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Depto.Location = new System.Drawing.Point(13, 96);
            this.dg_Depto.Name = "dg_Depto";
            this.dg_Depto.Size = new System.Drawing.Size(765, 233);
            this.dg_Depto.TabIndex = 7;
            this.dg_Depto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Depto_CellClick);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(13, 46);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Buscar:";
            // 
            // txt_BuscarDepto
            // 
            this.txt_BuscarDepto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_BuscarDepto.CustomBackground = true;
            this.txt_BuscarDepto.CustomForeColor = true;
            this.txt_BuscarDepto.Location = new System.Drawing.Point(13, 68);
            this.txt_BuscarDepto.Name = "txt_BuscarDepto";
            this.txt_BuscarDepto.Size = new System.Drawing.Size(252, 23);
            this.txt_BuscarDepto.TabIndex = 5;
            this.txt_BuscarDepto.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_BuscarDepto.UseStyleColors = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.btn_BuscarVehiculo);
            this.metroTabPage3.Controls.Add(this.btn_EliminarVehiculos);
            this.metroTabPage3.Controls.Add(this.btn_EditarVehiculos);
            this.metroTabPage3.Controls.Add(this.btn_NuevoVehiculos);
            this.metroTabPage3.Controls.Add(this.dg_Vehiculos);
            this.metroTabPage3.Controls.Add(this.metroLabel3);
            this.metroTabPage3.Controls.Add(this.txt_BuscarVehiculos);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(774, 336);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Vehiculos";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.Click += new System.EventHandler(this.metroTabPage3_Click);
            // 
            // btn_BuscarVehiculo
            // 
            this.btn_BuscarVehiculo.Location = new System.Drawing.Point(289, 64);
            this.btn_BuscarVehiculo.Name = "btn_BuscarVehiculo";
            this.btn_BuscarVehiculo.Size = new System.Drawing.Size(75, 23);
            this.btn_BuscarVehiculo.TabIndex = 17;
            this.btn_BuscarVehiculo.Text = "Buscar";
            this.btn_BuscarVehiculo.UseVisualStyleBackColor = true;
            this.btn_BuscarVehiculo.Click += new System.EventHandler(this.btn_BuscarVehiculo_Click);
            // 
            // btn_EliminarVehiculos
            // 
            this.btn_EliminarVehiculos.CustomBackground = true;
            this.btn_EliminarVehiculos.CustomForeColor = true;
            this.btn_EliminarVehiculos.Location = new System.Drawing.Point(662, 33);
            this.btn_EliminarVehiculos.Name = "btn_EliminarVehiculos";
            this.btn_EliminarVehiculos.Size = new System.Drawing.Size(106, 55);
            this.btn_EliminarVehiculos.TabIndex = 16;
            this.btn_EliminarVehiculos.Text = "Borrar";
            this.btn_EliminarVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EliminarVehiculos.TileImage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarVehiculos.TileImage")));
            this.btn_EliminarVehiculos.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EliminarVehiculos.UseTileImage = true;
            this.btn_EliminarVehiculos.Click += new System.EventHandler(this.btn_EliminarVehiculos_Click);
            // 
            // btn_EditarVehiculos
            // 
            this.btn_EditarVehiculos.CustomBackground = true;
            this.btn_EditarVehiculos.CustomForeColor = true;
            this.btn_EditarVehiculos.Location = new System.Drawing.Point(529, 32);
            this.btn_EditarVehiculos.Name = "btn_EditarVehiculos";
            this.btn_EditarVehiculos.Size = new System.Drawing.Size(106, 55);
            this.btn_EditarVehiculos.TabIndex = 15;
            this.btn_EditarVehiculos.Text = "Editar";
            this.btn_EditarVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EditarVehiculos.TileImage = ((System.Drawing.Image)(resources.GetObject("btn_EditarVehiculos.TileImage")));
            this.btn_EditarVehiculos.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EditarVehiculos.UseTileImage = true;
            this.btn_EditarVehiculos.Click += new System.EventHandler(this.btn_EditarVehiculos_Click);
            // 
            // btn_NuevoVehiculos
            // 
            this.btn_NuevoVehiculos.CustomBackground = true;
            this.btn_NuevoVehiculos.CustomForeColor = true;
            this.btn_NuevoVehiculos.Location = new System.Drawing.Point(400, 32);
            this.btn_NuevoVehiculos.Name = "btn_NuevoVehiculos";
            this.btn_NuevoVehiculos.Size = new System.Drawing.Size(106, 55);
            this.btn_NuevoVehiculos.TabIndex = 14;
            this.btn_NuevoVehiculos.Text = "Nuevo";
            this.btn_NuevoVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NuevoVehiculos.TileImage = ((System.Drawing.Image)(resources.GetObject("btn_NuevoVehiculos.TileImage")));
            this.btn_NuevoVehiculos.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NuevoVehiculos.UseMnemonic = false;
            this.btn_NuevoVehiculos.UseTileImage = true;
            this.btn_NuevoVehiculos.Click += new System.EventHandler(this.btn_NuevoVehiculos_Click);
            // 
            // dg_Vehiculos
            // 
            this.dg_Vehiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_Vehiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_Vehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Vehiculos.Location = new System.Drawing.Point(13, 102);
            this.dg_Vehiculos.Name = "dg_Vehiculos";
            this.dg_Vehiculos.Size = new System.Drawing.Size(758, 227);
            this.dg_Vehiculos.TabIndex = 13;
            this.dg_Vehiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Vehiculos_CellClick);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(13, 42);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(50, 19);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Buscar:";
            // 
            // txt_BuscarVehiculos
            // 
            this.txt_BuscarVehiculos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_BuscarVehiculos.CustomBackground = true;
            this.txt_BuscarVehiculos.CustomForeColor = true;
            this.txt_BuscarVehiculos.Location = new System.Drawing.Point(13, 64);
            this.txt_BuscarVehiculos.Name = "txt_BuscarVehiculos";
            this.txt_BuscarVehiculos.Size = new System.Drawing.Size(252, 23);
            this.txt_BuscarVehiculos.TabIndex = 11;
            this.txt_BuscarVehiculos.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_BuscarVehiculos.UseStyleColors = true;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.btn_BuscarMaquina);
            this.metroTabPage4.Controls.Add(this.btn_EliminarMaquina);
            this.metroTabPage4.Controls.Add(this.btn_EditarMaquina);
            this.metroTabPage4.Controls.Add(this.btn_NuevoMaquina);
            this.metroTabPage4.Controls.Add(this.dg_Maquinas);
            this.metroTabPage4.Controls.Add(this.metroLabel4);
            this.metroTabPage4.Controls.Add(this.txt_BuscarMaquinas);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(774, 336);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "Maquinas";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            // 
            // btn_BuscarMaquina
            // 
            this.btn_BuscarMaquina.Location = new System.Drawing.Point(288, 65);
            this.btn_BuscarMaquina.Name = "btn_BuscarMaquina";
            this.btn_BuscarMaquina.Size = new System.Drawing.Size(75, 23);
            this.btn_BuscarMaquina.TabIndex = 17;
            this.btn_BuscarMaquina.Text = "Buscar";
            this.btn_BuscarMaquina.UseVisualStyleBackColor = true;
            this.btn_BuscarMaquina.Click += new System.EventHandler(this.btn_BuscarMaquina_Click);
            // 
            // btn_EliminarMaquina
            // 
            this.btn_EliminarMaquina.CustomBackground = true;
            this.btn_EliminarMaquina.CustomForeColor = true;
            this.btn_EliminarMaquina.Location = new System.Drawing.Point(665, 33);
            this.btn_EliminarMaquina.Name = "btn_EliminarMaquina";
            this.btn_EliminarMaquina.Size = new System.Drawing.Size(106, 55);
            this.btn_EliminarMaquina.TabIndex = 16;
            this.btn_EliminarMaquina.Text = "Borrar";
            this.btn_EliminarMaquina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EliminarMaquina.TileImage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarMaquina.TileImage")));
            this.btn_EliminarMaquina.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EliminarMaquina.UseTileImage = true;
            this.btn_EliminarMaquina.Click += new System.EventHandler(this.btn_EliminarMaquina_Click);
            // 
            // btn_EditarMaquina
            // 
            this.btn_EditarMaquina.CustomBackground = true;
            this.btn_EditarMaquina.CustomForeColor = true;
            this.btn_EditarMaquina.Location = new System.Drawing.Point(532, 32);
            this.btn_EditarMaquina.Name = "btn_EditarMaquina";
            this.btn_EditarMaquina.Size = new System.Drawing.Size(106, 55);
            this.btn_EditarMaquina.TabIndex = 15;
            this.btn_EditarMaquina.Text = "Editar";
            this.btn_EditarMaquina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EditarMaquina.TileImage = ((System.Drawing.Image)(resources.GetObject("btn_EditarMaquina.TileImage")));
            this.btn_EditarMaquina.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EditarMaquina.UseTileImage = true;
            this.btn_EditarMaquina.Click += new System.EventHandler(this.btn_EditarMaquina_Click);
            // 
            // btn_NuevoMaquina
            // 
            this.btn_NuevoMaquina.CustomBackground = true;
            this.btn_NuevoMaquina.CustomForeColor = true;
            this.btn_NuevoMaquina.Location = new System.Drawing.Point(403, 32);
            this.btn_NuevoMaquina.Name = "btn_NuevoMaquina";
            this.btn_NuevoMaquina.Size = new System.Drawing.Size(106, 55);
            this.btn_NuevoMaquina.TabIndex = 14;
            this.btn_NuevoMaquina.Text = "Nuevo";
            this.btn_NuevoMaquina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NuevoMaquina.TileImage = ((System.Drawing.Image)(resources.GetObject("btn_NuevoMaquina.TileImage")));
            this.btn_NuevoMaquina.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NuevoMaquina.UseMnemonic = false;
            this.btn_NuevoMaquina.UseTileImage = true;
            this.btn_NuevoMaquina.Click += new System.EventHandler(this.btn_NuevoMaquina_Click);
            // 
            // dg_Maquinas
            // 
            this.dg_Maquinas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_Maquinas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_Maquinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Maquinas.Location = new System.Drawing.Point(13, 108);
            this.dg_Maquinas.Name = "dg_Maquinas";
            this.dg_Maquinas.Size = new System.Drawing.Size(765, 221);
            this.dg_Maquinas.TabIndex = 13;
            this.dg_Maquinas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Maquinas_CellClick);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(13, 43);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(50, 19);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Buscar:";
            // 
            // txt_BuscarMaquinas
            // 
            this.txt_BuscarMaquinas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_BuscarMaquinas.CustomBackground = true;
            this.txt_BuscarMaquinas.CustomForeColor = true;
            this.txt_BuscarMaquinas.Location = new System.Drawing.Point(13, 65);
            this.txt_BuscarMaquinas.Name = "txt_BuscarMaquinas";
            this.txt_BuscarMaquinas.Size = new System.Drawing.Size(252, 23);
            this.txt_BuscarMaquinas.TabIndex = 11;
            this.txt_BuscarMaquinas.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_BuscarMaquinas.UseStyleColors = true;
            // 
            // Catalogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Catalogos";
            this.Text = "Catalogos";
            this.Load += new System.EventHandler(this.Catalogos_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Proveedor)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Depto)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Vehiculos)).EndInit();
            this.metroTabPage4.ResumeLayout(false);
            this.metroTabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Maquinas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroTile btn_NuevoProveedor;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_BuscarProveedor;
        private System.Windows.Forms.DataGridView dg_Proveedor;
        private MetroFramework.Controls.MetroTile btn_EliminarProveedor;
        private MetroFramework.Controls.MetroTile btn_EditarProveedor;
        private MetroFramework.Controls.MetroTile btn_EliminarDepto;
        private MetroFramework.Controls.MetroTile btn_EditarDepto;
        private MetroFramework.Controls.MetroTile btn_NuevoDepto;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_BuscarDepto;
        private MetroFramework.Controls.MetroTile btn_EliminarVehiculos;
        private MetroFramework.Controls.MetroTile btn_EditarVehiculos;
        private MetroFramework.Controls.MetroTile btn_NuevoVehiculos;
        private System.Windows.Forms.DataGridView dg_Vehiculos;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_BuscarVehiculos;
        private MetroFramework.Controls.MetroTile btn_EliminarMaquina;
        private MetroFramework.Controls.MetroTile btn_EditarMaquina;
        private MetroFramework.Controls.MetroTile btn_NuevoMaquina;
        private System.Windows.Forms.DataGridView dg_Maquinas;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txt_BuscarMaquinas;
        private System.Windows.Forms.DataGridView dg_Depto;
        private System.Windows.Forms.Button btn_BuecarProveedor;
        private System.Windows.Forms.Button btn_BuscarVehiculo;
        private System.Windows.Forms.Button btn_BuscarMaquina;
        private System.Windows.Forms.Button btn_BuscarDepto;
    }
}