namespace SistemaOrdenes
{
    partial class BusquedaOrdenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusquedaOrdenes));
            this.label3 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_generar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.cb_filtro = new System.Windows.Forms.ComboBox();
            this.dg_buscar = new System.Windows.Forms.DataGridView();
            this.btn_Nuevo = new MetroFramework.Controls.MetroTile();
            this.btn_Aprobar = new MetroFramework.Controls.MetroTile();
            this.btn_Cancelar = new MetroFramework.Controls.MetroTile();
            this.btn_EditarOrden = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dg_buscar)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "yyyy/mm/dd";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(562, 60);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_aceptar.TabIndex = 13;
            this.btn_aceptar.Text = "Buscar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_generar
            // 
            this.btn_generar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_generar.Location = new System.Drawing.Point(1134, 118);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(79, 26);
            this.btn_generar.TabIndex = 14;
            this.btn_generar.Text = "Reporte";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Buscar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Filtro:";
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(269, 63);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(287, 20);
            this.txt_buscar.TabIndex = 10;
            // 
            // cb_filtro
            // 
            this.cb_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filtro.FormattingEnabled = true;
            this.cb_filtro.Items.AddRange(new object[] {
            "Orden",
            "Proveedor",
            "Departamento"});
            this.cb_filtro.Location = new System.Drawing.Point(51, 63);
            this.cb_filtro.Name = "cb_filtro";
            this.cb_filtro.Size = new System.Drawing.Size(152, 21);
            this.cb_filtro.TabIndex = 9;
            // 
            // dg_buscar
            // 
            this.dg_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_buscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_buscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dg_buscar.Location = new System.Drawing.Point(14, 150);
            this.dg_buscar.Name = "dg_buscar";
            this.dg_buscar.ReadOnly = true;
            this.dg_buscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_buscar.Size = new System.Drawing.Size(1199, 342);
            this.dg_buscar.TabIndex = 8;
            this.dg_buscar.VirtualMode = true;
            this.dg_buscar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_buscar_CellClick);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Nuevo.CustomBackground = true;
            this.btn_Nuevo.CustomForeColor = true;
            this.btn_Nuevo.Location = new System.Drawing.Point(690, 46);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(106, 55);
            this.btn_Nuevo.TabIndex = 16;
            this.btn_Nuevo.Text = "Nueva \r\nOrden";
            this.btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Nuevo.TileImage = ((System.Drawing.Image)(resources.GetObject("btn_Nuevo.TileImage")));
            this.btn_Nuevo.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Nuevo.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_Nuevo.UseMnemonic = false;
            this.btn_Nuevo.UseTileImage = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Aprobar
            // 
            this.btn_Aprobar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Aprobar.CustomBackground = true;
            this.btn_Aprobar.CustomForeColor = true;
            this.btn_Aprobar.Location = new System.Drawing.Point(16, 498);
            this.btn_Aprobar.Name = "btn_Aprobar";
            this.btn_Aprobar.Size = new System.Drawing.Size(112, 41);
            this.btn_Aprobar.TabIndex = 17;
            this.btn_Aprobar.Text = "Autorizar\r\nOrden";
            this.btn_Aprobar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Aprobar.TileImage = ((System.Drawing.Image)(resources.GetObject("btn_Aprobar.TileImage")));
            this.btn_Aprobar.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Aprobar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_Aprobar.UseMnemonic = false;
            this.btn_Aprobar.UseTileImage = true;
            this.btn_Aprobar.Click += new System.EventHandler(this.btn_Aprobar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Cancelar.CustomBackground = true;
            this.btn_Cancelar.CustomForeColor = true;
            this.btn_Cancelar.Location = new System.Drawing.Point(1097, 498);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(116, 41);
            this.btn_Cancelar.TabIndex = 18;
            this.btn_Cancelar.Text = "Cancelar \r\nOrden";
            this.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancelar.TileImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.TileImage")));
            this.btn_Cancelar.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_Cancelar.UseMnemonic = false;
            this.btn_Cancelar.UseTileImage = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_EditarOrden
            // 
            this.btn_EditarOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_EditarOrden.CustomBackground = true;
            this.btn_EditarOrden.CustomForeColor = true;
            this.btn_EditarOrden.Location = new System.Drawing.Point(823, 46);
            this.btn_EditarOrden.Name = "btn_EditarOrden";
            this.btn_EditarOrden.Size = new System.Drawing.Size(106, 55);
            this.btn_EditarOrden.TabIndex = 19;
            this.btn_EditarOrden.Text = "Editar\r\nOrden";
            this.btn_EditarOrden.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EditarOrden.TileImage = ((System.Drawing.Image)(resources.GetObject("btn_EditarOrden.TileImage")));
            this.btn_EditarOrden.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EditarOrden.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_EditarOrden.UseTileImage = true;
            this.btn_EditarOrden.Click += new System.EventHandler(this.btn_EditarOrden_Click);
            // 
            // BusquedaOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 586);
            this.Controls.Add(this.btn_EditarOrden);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aprobar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.cb_filtro);
            this.Controls.Add(this.dg_buscar);
            this.Name = "BusquedaOrdenes";
            this.Text = "Registro de Ordenes";
            this.Load += new System.EventHandler(this.BusquedaOrdenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_buscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.ComboBox cb_filtro;
        private System.Windows.Forms.DataGridView dg_buscar;
        private MetroFramework.Controls.MetroTile btn_Nuevo;
        private MetroFramework.Controls.MetroTile btn_Aprobar;
        private MetroFramework.Controls.MetroTile btn_Cancelar;
        private MetroFramework.Controls.MetroTile btn_EditarOrden;
    }
}