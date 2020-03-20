namespace SistemaOrdenes
{
    partial class EditarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarProveedor));
            this.btn_Guardar = new MetroFramework.Controls.MetroTile();
            this.btn_Limpiar = new MetroFramework.Controls.MetroTile();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Ext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Contacto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_RFC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Proveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Guardar.CustomBackground = true;
            this.btn_Guardar.CustomForeColor = true;
            this.btn_Guardar.Location = new System.Drawing.Point(154, 439);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(106, 41);
            this.btn_Guardar.TabIndex = 58;
            this.btn_Guardar.Text = "Editar";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Guardar.TileImage = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.TileImage")));
            this.btn_Guardar.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guardar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_Guardar.UseMnemonic = false;
            this.btn_Guardar.UseTileImage = true;
            this.btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Limpiar.CustomBackground = true;
            this.btn_Limpiar.CustomForeColor = true;
            this.btn_Limpiar.Location = new System.Drawing.Point(285, 439);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(106, 41);
            this.btn_Limpiar.TabIndex = 57;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Limpiar.TileImage = ((System.Drawing.Image)(resources.GetObject("btn_Limpiar.TileImage")));
            this.btn_Limpiar.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Limpiar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_Limpiar.UseMnemonic = false;
            this.btn_Limpiar.UseTileImage = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(127, 345);
            this.txt_Direccion.MaxLength = 255;
            this.txt_Direccion.Multiline = true;
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(308, 60);
            this.txt_Direccion.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Direccion:";
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(127, 262);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(308, 20);
            this.txt_Telefono.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Telefono:";
            // 
            // txt_Ext
            // 
            this.txt_Ext.Location = new System.Drawing.Point(127, 299);
            this.txt_Ext.Name = "txt_Ext";
            this.txt_Ext.Size = new System.Drawing.Size(100, 20);
            this.txt_Ext.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "Ext:";
            // 
            // txt_Contacto
            // 
            this.txt_Contacto.Location = new System.Drawing.Point(127, 179);
            this.txt_Contacto.Name = "txt_Contacto";
            this.txt_Contacto.Size = new System.Drawing.Size(308, 20);
            this.txt_Contacto.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Contacto:";
            // 
            // txt_Correo
            // 
            this.txt_Correo.Location = new System.Drawing.Point(127, 221);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(308, 20);
            this.txt_Correo.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Correo:";
            // 
            // txt_RFC
            // 
            this.txt_RFC.Location = new System.Drawing.Point(127, 138);
            this.txt_RFC.Name = "txt_RFC";
            this.txt_RFC.Size = new System.Drawing.Size(308, 20);
            this.txt_RFC.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "RFC:";
            // 
            // txt_Proveedor
            // 
            this.txt_Proveedor.Location = new System.Drawing.Point(127, 93);
            this.txt_Proveedor.Name = "txt_Proveedor";
            this.txt_Proveedor.Size = new System.Drawing.Size(308, 20);
            this.txt_Proveedor.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Proveedor:";
            // 
            // EditarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 528);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Ext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Contacto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Correo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_RFC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Proveedor);
            this.Controls.Add(this.label1);
            this.Name = "EditarProveedor";
            this.Text = "EditarProveedor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditarProveedor_FormClosed);
            this.Load += new System.EventHandler(this.EditarProveedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btn_Guardar;
        private MetroFramework.Controls.MetroTile btn_Limpiar;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Ext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Contacto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_RFC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Proveedor;
        private System.Windows.Forms.Label label1;
    }
}