using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOrdenes
{
    public partial class AgregarProveedor : MetroFramework.Forms.MetroForm
    {
        Proveedores proveedores = new Proveedores();
        public AgregarProveedor()
        {
            InitializeComponent();
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txt_Proveedor.Text)))
            {
                if (!(proveedores.Exists("select COUNT(*) from tb_Proveedores where nombre = '" + txt_Proveedor.Text + "'")))
                {
                    proveedores.Crud("insert into tb_Proveedores(nombre,direccion,rfc,extension,telefono,contacto,correo) values('" + txt_Proveedor.Text + "','" + txt_Direccion.Text + "','" + txt_RFC.Text + "','" + txt_Ext.Text + "','" + txt_Telefono.Text + "','" + txt_Contacto.Text + "','" + txt_Correo.Text + "')");
                    MessageBox.Show("Nuevo Proveedor agregado!");
                    TextBoxClear();
                }
                else
                    MessageBox.Show("Este Proveedor ya esta registrado!");
            }
            else { MessageBox.Show("Ingrese el nombre del Proveedor!", "ERROR!"); }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            TextBoxClear();
        }
        private void TextBoxClear()
        {
            txt_Contacto.Text = "";
            txt_Correo.Text = "";
            txt_Direccion.Text = "";
            txt_Ext.Text = "";
            txt_Proveedor.Text = "";
            txt_RFC.Text = "";
            txt_Telefono.Text = "";

        }

        private void AgregarProveedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Catalogos cat = new Catalogos();
            cat.Show();
        }
    }
}
