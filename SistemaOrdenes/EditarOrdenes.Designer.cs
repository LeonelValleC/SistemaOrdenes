namespace SistemaOrdenes
{
    partial class EditarOrdenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarOrdenes));
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_Orden = new System.Windows.Forms.Label();
            this.btn_GuardarOrden = new MetroFramework.Controls.MetroTile();
            this.btn_Limpiar = new MetroFramework.Controls.MetroTile();
            this.cb_IVA = new System.Windows.Forms.ComboBox();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_IVA = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Subtotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Almacen = new System.Windows.Forms.TextBox();
            this.txt_Obra = new System.Windows.Forms.TextBox();
            this.txt_Unidad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_Maquina = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_Vehiculo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Proveedor = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_Depto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Usoen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Eliminar = new MetroFramework.Controls.MetroTile();
            this.btn_Nuevo = new MetroFramework.Controls.MetroTile();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.txt_PUnitario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_Detalle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Detalle)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(738, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 15);
            this.label16.TabIndex = 80;
            this.label16.Text = "Orden:";
            // 
            // lbl_Orden
            // 
            this.lbl_Orden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Orden.AutoSize = true;
            this.lbl_Orden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Orden.Location = new System.Drawing.Point(794, 38);
            this.lbl_Orden.Name = "lbl_Orden";
            this.lbl_Orden.Size = new System.Drawing.Size(51, 13);
            this.lbl_Orden.TabIndex = 79;
            this.lbl_Orden.Text = "ORDEN";
            // 
            // btn_GuardarOrden
            // 
            this.btn_GuardarOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_GuardarOrden.CustomBackground = true;
            this.btn_GuardarOrden.CustomForeColor = true;
            this.btn_GuardarOrden.Location = new System.Drawing.Point(677, 579);
            this.btn_GuardarOrden.Name = "btn_GuardarOrden";
            this.btn_GuardarOrden.Size = new System.Drawing.Size(106, 41);
            this.btn_GuardarOrden.TabIndex = 78;
            this.btn_GuardarOrden.Text = "Guardar";
            this.btn_GuardarOrden.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_GuardarOrden.TileImage = ((System.Drawing.Image)(resources.GetObject("btn_GuardarOrden.TileImage")));
            this.btn_GuardarOrden.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GuardarOrden.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_GuardarOrden.UseMnemonic = false;
            this.btn_GuardarOrden.UseTileImage = true;
            this.btn_GuardarOrden.Click += new System.EventHandler(this.btn_GuardarOrden_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Limpiar.CustomBackground = true;
            this.btn_Limpiar.CustomForeColor = true;
            this.btn_Limpiar.Location = new System.Drawing.Point(814, 579);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(106, 41);
            this.btn_Limpiar.TabIndex = 77;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Limpiar.TileImage = ((System.Drawing.Image)(resources.GetObject("btn_Limpiar.TileImage")));
            this.btn_Limpiar.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Limpiar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_Limpiar.UseMnemonic = false;
            this.btn_Limpiar.UseTileImage = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // cb_IVA
            // 
            this.cb_IVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_IVA.FormattingEnabled = true;
            this.cb_IVA.Location = new System.Drawing.Point(755, 463);
            this.cb_IVA.Name = "cb_IVA";
            this.cb_IVA.Size = new System.Drawing.Size(54, 23);
            this.cb_IVA.TabIndex = 76;
            // 
            // txt_Total
            // 
            this.txt_Total.Location = new System.Drawing.Point(725, 537);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(206, 21);
            this.txt_Total.TabIndex = 75;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(722, 521);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 15);
            this.label15.TabIndex = 74;
            this.label15.Text = "Total";
            // 
            // txt_IVA
            // 
            this.txt_IVA.Location = new System.Drawing.Point(725, 492);
            this.txt_IVA.Name = "txt_IVA";
            this.txt_IVA.ReadOnly = true;
            this.txt_IVA.Size = new System.Drawing.Size(206, 21);
            this.txt_IVA.TabIndex = 73;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(722, 469);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 15);
            this.label14.TabIndex = 72;
            this.label14.Text = "IVA";
            // 
            // txt_Subtotal
            // 
            this.txt_Subtotal.Location = new System.Drawing.Point(725, 424);
            this.txt_Subtotal.Name = "txt_Subtotal";
            this.txt_Subtotal.ReadOnly = true;
            this.txt_Subtotal.Size = new System.Drawing.Size(206, 21);
            this.txt_Subtotal.TabIndex = 71;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(722, 408);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 15);
            this.label13.TabIndex = 70;
            this.label13.Text = "SubTotal";
            // 
            // txt_Almacen
            // 
            this.txt_Almacen.Location = new System.Drawing.Point(453, 575);
            this.txt_Almacen.Name = "txt_Almacen";
            this.txt_Almacen.Size = new System.Drawing.Size(206, 21);
            this.txt_Almacen.TabIndex = 69;
            // 
            // txt_Obra
            // 
            this.txt_Obra.Location = new System.Drawing.Point(453, 515);
            this.txt_Obra.Name = "txt_Obra";
            this.txt_Obra.Size = new System.Drawing.Size(206, 21);
            this.txt_Obra.TabIndex = 68;
            // 
            // txt_Unidad
            // 
            this.txt_Unidad.Location = new System.Drawing.Point(234, 515);
            this.txt_Unidad.Name = "txt_Unidad";
            this.txt_Unidad.Size = new System.Drawing.Size(206, 21);
            this.txt_Unidad.TabIndex = 67;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(453, 559);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 15);
            this.label12.TabIndex = 66;
            this.label12.Text = "Almacen:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(450, 499);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 15);
            this.label11.TabIndex = 65;
            this.label11.Text = "Obra:";
            // 
            // cb_Maquina
            // 
            this.cb_Maquina.FormattingEnabled = true;
            this.cb_Maquina.Location = new System.Drawing.Point(234, 576);
            this.cb_Maquina.Name = "cb_Maquina";
            this.cb_Maquina.Size = new System.Drawing.Size(206, 23);
            this.cb_Maquina.TabIndex = 64;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(231, 559);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 63;
            this.label10.Text = "Maquina:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(231, 499);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 62;
            this.label9.Text = "Unidad:";
            // 
            // cb_Vehiculo
            // 
            this.cb_Vehiculo.FormattingEnabled = true;
            this.cb_Vehiculo.Location = new System.Drawing.Point(13, 576);
            this.cb_Vehiculo.Name = "cb_Vehiculo";
            this.cb_Vehiculo.Size = new System.Drawing.Size(206, 23);
            this.cb_Vehiculo.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 559);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 60;
            this.label4.Text = "Vehiculo:";
            // 
            // cb_Proveedor
            // 
            this.cb_Proveedor.FormattingEnabled = true;
            this.cb_Proveedor.Location = new System.Drawing.Point(10, 81);
            this.cb_Proveedor.Name = "cb_Proveedor";
            this.cb_Proveedor.Size = new System.Drawing.Size(309, 23);
            this.cb_Proveedor.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 58;
            this.label8.Text = "Proveedor";
            // 
            // cb_Depto
            // 
            this.cb_Depto.FormattingEnabled = true;
            this.cb_Depto.Location = new System.Drawing.Point(13, 516);
            this.cb_Depto.Name = "cb_Depto";
            this.cb_Depto.Size = new System.Drawing.Size(206, 23);
            this.cb_Depto.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 499);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 15);
            this.label7.TabIndex = 56;
            this.label7.Text = "Departamento:";
            // 
            // txt_Usoen
            // 
            this.txt_Usoen.Location = new System.Drawing.Point(13, 424);
            this.txt_Usoen.MaxLength = 255;
            this.txt_Usoen.Multiline = true;
            this.txt_Usoen.Name = "txt_Usoen";
            this.txt_Usoen.Size = new System.Drawing.Size(646, 58);
            this.txt_Usoen.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 54;
            this.label5.Text = "Para uso en:";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Eliminar.CustomBackground = true;
            this.btn_Eliminar.CustomForeColor = true;
            this.btn_Eliminar.Location = new System.Drawing.Point(825, 208);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(106, 40);
            this.btn_Eliminar.Style = MetroFramework.MetroColorStyle.White;
            this.btn_Eliminar.TabIndex = 53;
            this.btn_Eliminar.Text = "Borrar";
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Eliminar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_Eliminar.TileImage = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.TileImage")));
            this.btn_Eliminar.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Eliminar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_Eliminar.UseTileImage = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Nuevo.CustomBackground = true;
            this.btn_Nuevo.CustomForeColor = true;
            this.btn_Nuevo.Location = new System.Drawing.Point(10, 208);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(106, 41);
            this.btn_Nuevo.TabIndex = 52;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Nuevo.TileImage = ((System.Drawing.Image)(resources.GetObject("btn_Nuevo.TileImage")));
            this.btn_Nuevo.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Nuevo.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_Nuevo.UseMnemonic = false;
            this.btn_Nuevo.UseTileImage = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 51;
            this.label6.Text = "Usuario:";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.Location = new System.Drawing.Point(564, 36);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(63, 13);
            this.lbl_usuario.TabIndex = 50;
            this.lbl_usuario.Text = "USUARIO";
            // 
            // txt_PUnitario
            // 
            this.txt_PUnitario.Location = new System.Drawing.Point(10, 182);
            this.txt_PUnitario.Name = "txt_PUnitario";
            this.txt_PUnitario.Size = new System.Drawing.Size(79, 21);
            this.txt_PUnitario.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 48;
            this.label3.Text = "Precio Unitario:";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Descripcion.Location = new System.Drawing.Point(142, 144);
            this.txt_Descripcion.MaxLength = 255;
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(517, 58);
            this.txt_Descripcion.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 46;
            this.label2.Text = "Descripcion:";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(10, 144);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(79, 21);
            this.txt_Cantidad.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 44;
            this.label1.Text = "Cantidad:";
            // 
            // dg_Detalle
            // 
            this.dg_Detalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_Detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Detalle.Location = new System.Drawing.Point(10, 254);
            this.dg_Detalle.Name = "dg_Detalle";
            this.dg_Detalle.Size = new System.Drawing.Size(921, 150);
            this.dg_Detalle.TabIndex = 43;
            this.dg_Detalle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_Detalle_CellClick);
            // 
            // EditarOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 646);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lbl_Orden);
            this.Controls.Add(this.btn_GuardarOrden);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.cb_IVA);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_IVA);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_Subtotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_Almacen);
            this.Controls.Add(this.txt_Obra);
            this.Controls.Add(this.txt_Unidad);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cb_Maquina);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_Vehiculo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_Proveedor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_Depto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Usoen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.txt_PUnitario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_Detalle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "EditarOrdenes";
            this.Padding = new System.Windows.Forms.Padding(27, 69, 27, 23);
            this.Text = "EditarOrdenes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditarOrdenes_FormClosed);
            this.Load += new System.EventHandler(this.EditarOrdenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Detalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_Orden;
        private MetroFramework.Controls.MetroTile btn_GuardarOrden;
        private MetroFramework.Controls.MetroTile btn_Limpiar;
        private System.Windows.Forms.ComboBox cb_IVA;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_IVA;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_Subtotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Almacen;
        private System.Windows.Forms.TextBox txt_Obra;
        private System.Windows.Forms.TextBox txt_Unidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_Maquina;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_Vehiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Proveedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_Depto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Usoen;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTile btn_Eliminar;
        private MetroFramework.Controls.MetroTile btn_Nuevo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.TextBox txt_PUnitario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg_Detalle;
    }
}