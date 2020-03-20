namespace SistemaOrdenes
{
    partial class AgregarDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarDepartamento));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Depto = new System.Windows.Forms.TextBox();
            this.txt_Encargado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Guardar = new MetroFramework.Controls.MetroTile();
            this.btn_Limpiar = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departamento:";
            // 
            // txt_Depto
            // 
            this.txt_Depto.Location = new System.Drawing.Point(23, 88);
            this.txt_Depto.Name = "txt_Depto";
            this.txt_Depto.Size = new System.Drawing.Size(270, 20);
            this.txt_Depto.TabIndex = 1;
            // 
            // txt_Encargado
            // 
            this.txt_Encargado.Location = new System.Drawing.Point(26, 137);
            this.txt_Encargado.Name = "txt_Encargado";
            this.txt_Encargado.Size = new System.Drawing.Size(270, 20);
            this.txt_Encargado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Encargado:";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Guardar.CustomBackground = true;
            this.btn_Guardar.CustomForeColor = true;
            this.btn_Guardar.Location = new System.Drawing.Point(40, 192);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(106, 41);
            this.btn_Guardar.TabIndex = 44;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Guardar.TileImage = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.TileImage")));
            this.btn_Guardar.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guardar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_Guardar.UseMnemonic = false;
            this.btn_Guardar.UseTileImage = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Limpiar.CustomBackground = true;
            this.btn_Limpiar.CustomForeColor = true;
            this.btn_Limpiar.Location = new System.Drawing.Point(171, 192);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(106, 41);
            this.btn_Limpiar.TabIndex = 43;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Limpiar.TileImage = ((System.Drawing.Image)(resources.GetObject("btn_Limpiar.TileImage")));
            this.btn_Limpiar.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Limpiar.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_Limpiar.UseMnemonic = false;
            this.btn_Limpiar.UseTileImage = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // AgregarDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 271);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.txt_Encargado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Depto);
            this.Controls.Add(this.label1);
            this.Name = "AgregarDepartamento";
            this.Text = "Departamento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AgregarDepartamento_FormClosed);
            this.Load += new System.EventHandler(this.AgregarDepartamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Depto;
        private System.Windows.Forms.TextBox txt_Encargado;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTile btn_Guardar;
        private MetroFramework.Controls.MetroTile btn_Limpiar;
    }
}