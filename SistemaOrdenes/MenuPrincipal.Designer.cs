namespace SistemaOrdenes
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.btn_Catalogos = new MetroFramework.Controls.MetroTile();
            this.btn_Busqueda = new MetroFramework.Controls.MetroTile();
            this.Btn_Manto = new MetroFramework.Controls.MetroTile();
            this.btn_ordenes = new MetroFramework.Controls.MetroTile();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Catalogos
            // 
            this.btn_Catalogos.Location = new System.Drawing.Point(30, 236);
            this.btn_Catalogos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Catalogos.Name = "btn_Catalogos";
            this.btn_Catalogos.Size = new System.Drawing.Size(297, 247);
            this.btn_Catalogos.TabIndex = 0;
            this.btn_Catalogos.Text = "Catalogos";
            this.btn_Catalogos.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_Catalogos.Click += new System.EventHandler(this.btn_Catalogos_Click);
            // 
            // btn_Busqueda
            // 
            this.btn_Busqueda.Location = new System.Drawing.Point(771, 236);
            this.btn_Busqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Busqueda.Name = "btn_Busqueda";
            this.btn_Busqueda.Size = new System.Drawing.Size(297, 247);
            this.btn_Busqueda.TabIndex = 0;
            this.btn_Busqueda.Text = "Reportes/Busquedas";
            this.btn_Busqueda.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_Busqueda.Click += new System.EventHandler(this.btn_Busqueda_Click);
            // 
            // Btn_Manto
            // 
            this.Btn_Manto.Location = new System.Drawing.Point(1156, 236);
            this.Btn_Manto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Manto.Name = "Btn_Manto";
            this.Btn_Manto.Size = new System.Drawing.Size(297, 247);
            this.Btn_Manto.TabIndex = 0;
            this.Btn_Manto.Text = "Mantenimiento";
            this.Btn_Manto.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Btn_Manto.Click += new System.EventHandler(this.Btn_Manto_Click);
            // 
            // btn_ordenes
            // 
            this.btn_ordenes.Location = new System.Drawing.Point(400, 236);
            this.btn_ordenes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ordenes.Name = "btn_ordenes";
            this.btn_ordenes.Size = new System.Drawing.Size(297, 247);
            this.btn_ordenes.TabIndex = 0;
            this.btn_ordenes.Text = "Administratacion Ordenes";
            this.btn_ordenes.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_ordenes.Click += new System.EventHandler(this.btn_ordenes_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(27, 652);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(95, 17);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cerrar Sesion";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1224, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // lbl_user
            // 
            this.lbl_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.Red;
            this.lbl_user.Location = new System.Drawing.Point(1293, 28);
            this.lbl_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(82, 18);
            this.lbl_user.TabIndex = 3;
            this.lbl_user.Text = "USUARIO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 693);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_Busqueda);
            this.Controls.Add(this.Btn_Manto);
            this.Controls.Add(this.btn_ordenes);
            this.Controls.Add(this.btn_Catalogos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuPrincipal";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btn_Catalogos;
        private MetroFramework.Controls.MetroTile btn_Busqueda;
        private MetroFramework.Controls.MetroTile Btn_Manto;
        private MetroFramework.Controls.MetroTile btn_ordenes;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}