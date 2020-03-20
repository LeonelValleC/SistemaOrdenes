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
    public partial class EditarProveedor : MetroFramework.Forms.MetroForm
    {
        private readonly Proveedores proveedor = new Proveedores();
        public EditarProveedor()
        {
            InitializeComponent();
        }

        private void EditarProveedor_Load(object sender, EventArgs e)
        {
            try
            {
                var leer = proveedor.Leer("Select * from tb_Proveedores where id_proveedor = '" + proveedor.Id_proveedor + "'");

                if (leer.Read() == true)
                {
                    txt_Contacto.Text = leer["contacto"].ToString();
                    txt_Correo.Text = leer["correo"].ToString();
                    txt_Direccion.Text = leer["direccion"].ToString();
                    txt_Ext.Text = leer["extension"].ToString();
                    txt_Proveedor.Text = leer["nombre"].ToString();
                    txt_RFC.Text = leer["rfc"].ToString();
                    txt_Telefono.Text = leer["telefono"].ToString();
                }
                else
                {
                    txt_Telefono.Text = "";
                    txt_RFC.Text = "";
                    txt_Proveedor.Text = "";
                    txt_Contacto.Text = "";
                    txt_Correo.Text = "";
                    txt_Direccion.Text = "";
                    txt_Ext.Text = "";
                }
                proveedor.Cerrar();
            }
            catch (System.InvalidOperationException)
            {
                proveedor.Cerrar();
                throw;
            }
        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
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

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txt_Proveedor.Text)))
            {
               
                    proveedor.Crud("UPDATE tb_Proveedores set nombre='" + txt_Proveedor.Text + "', direccion = '" + txt_Direccion.Text + "', rfc = '" + txt_RFC.Text + "', telefono ='" + txt_Telefono.Text + "', contacto ='" + txt_Correo.Text + "' , extension ='" + txt_Ext.Text + "' where id_proveedor = " + proveedor.Id_proveedor);
                    MessageBox.Show("Nuevo Proveedor agregado!");
                    TextBoxClear();
               
            }
            else { MessageBox.Show("Ingrese el nombre del Proveedor!", "ERROR!"); }
        }

        private void EditarProveedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Catalogos cat = new Catalogos();
            cat.Show();
        }
    }
}
