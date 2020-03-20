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
    public partial class RegistroOrdenes : MetroFramework.Forms.MetroForm
    {
        DetalleOrden detalle = new DetalleOrden();
        Orden orden = new Orden();
        Convertir convertir = new Convertir();

        public RegistroOrdenes()
        {
            InitializeComponent();
        }

        private void loadDG()
        {
            dg_Detalle.DataSource = detalle.LlenarDG("select id_dordenes ,cantidad, descripcion, punitario from tb_DetalleOrdenes where id_orden = " + orden.Id_orden).Tables[0];
            dg_Detalle.Columns[0].Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_Depto.DataSource = detalle.FillCB("select * from tb_Departamentos");
            cb_Depto.DisplayMember = "nombre";
            cb_Depto.ValueMember = "id_depto";
            cb_Depto.SelectedIndex = -1;

            cb_IVA.DataSource = detalle.FillCB("select * from tb_IVA");
            cb_IVA.DisplayMember = "iva";
            cb_IVA.ValueMember = "id_iva";
            cb_IVA.SelectedIndex = -1;

            cb_Maquina.DataSource = detalle.FillCB("select * from tb_Maquinas");
            cb_Maquina.DisplayMember = "noecon";
            cb_Maquina.ValueMember = "id_maquina";
            cb_Maquina.SelectedIndex = -1;

            cb_Proveedor.DataSource = detalle.FillCB("select * from tb_Proveedores");
            cb_Proveedor.DisplayMember = "nombre";
            cb_Proveedor.ValueMember = "id_proveedor";
            cb_Proveedor.SelectedIndex = -1;

            cb_Vehiculo.DataSource = detalle.FillCB("select * from tb_Vehiculos");
            cb_Vehiculo.DisplayMember = "noecon";
            cb_Vehiculo.ValueMember = "id_vehiculo";
            cb_Vehiculo.SelectedIndex = -1;
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Cantidad.Text) && !string.IsNullOrEmpty(txt_PUnitario.Text) && !string.IsNullOrEmpty(txt_Descripcion.Text))
            {
                if (orden.Id_orden <= 0)
                {
                    orden.NuevaOrden();
                    lbl_Orden.Visible = true;
                    lbl_Orden.Text = orden.ReturnValue("select orden from tb_Ordenes where id_orden = " + orden.Id_orden);
                    detalle.Crud("insert into tb_DetalleOrdenes(cantidad,descripcion,punitario,id_orden) values('" + txt_Cantidad.Text + "' , '" + txt_Descripcion.Text + "' , '" + txt_PUnitario.Text + "' , '" + orden.Id_orden + "')");
                    txt_Subtotal.Text = detalle.ReturnValue("select SUM(cantidad*punitario) from tb_DetalleOrdenes where id_orden = " + orden.Id_orden);
                    txt_IVA.Text = (double.Parse(txt_Subtotal.Text) * double.Parse(cb_IVA.Text) / 100).ToString();
                    txt_Total.Text = (double.Parse(txt_Subtotal.Text) + double.Parse(txt_IVA.Text)).ToString();
                }
                else
                {
                    detalle.Crud("insert into tb_DetalleOrdenes(cantidad,descripcion,punitario,id_orden) values('" + txt_Cantidad.Text + "' , '" + txt_Descripcion.Text + "' , '" + txt_PUnitario.Text + "' , '" + orden.Id_orden + "')");
                    txt_Subtotal.Text = detalle.ReturnValue("select SUM(cantidad*punitario) from tb_DetalleOrdenes where id_orden = " + orden.Id_orden);
                    txt_IVA.Text = (double.Parse(txt_Subtotal.Text) * double.Parse(cb_IVA.Text) / 100).ToString();
                    txt_Total.Text = (double.Parse(txt_Subtotal.Text) + double.Parse(txt_IVA.Text)).ToString();
                }
                loadDG();
            }
            else
                MessageBox.Show("Ingrese un nuevo articulo!", "ERROR!");
        }



        private void dg_Detalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dg_Detalle.Rows[e.RowIndex];
                detalle.Id_detalle = int.Parse(row.Cells["id_dordenes"].Value.ToString());
            }
        }

        private void btn_GuardarOrden_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Usoen.Text) && cb_Proveedor.SelectedItem != null)
            {
                orden.Crud("update tb_Ordenes set id_depto = '" + cb_Depto.SelectedValue + "' , id_proveedor = '" + cb_Proveedor.SelectedValue + "' , id_maquina = '" + cb_Maquina.SelectedValue + "' , id_vehiculo = '" + cb_Vehiculo.SelectedValue +
                    "' , parauso = '" + txt_Usoen.Text + "' , unidad = '" + txt_Unidad.Text + "' , obra = '" + txt_Obra.Text + "' , almacen = '" + txt_Almacen.Text + "' , subtotal = '" + txt_Subtotal.Text + "' , iva = '" + txt_IVA.Text + "' , total = '"
                    + txt_Total.Text + "' , letra = '" + convertir.enletras(txt_Total.Text).ToUpper() + "' where id_orden = " + orden.Id_orden);
                TextBoxClear();
                MessageBox.Show("Nueva orden creada!");
            }
            else
                MessageBox.Show("Ingrese un Proveedor y Para uno en", "ERROR!");
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (detalle.Id_detalle >= 1)
            {
                detalle.Crud("delete tb_DetalleOrdenes where id_dordenes = " + detalle.Id_detalle);
                loadDG();
            }
        }

        private void txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void txt_PUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void RegistroOrdenes_FormClosed(object sender, FormClosedEventArgs e)
        {
            BusquedaOrdenes busqueda = new BusquedaOrdenes();
            busqueda.Show();
            //this.Close();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            TextBoxClear();
        }

        private void TextBoxClear()
        {
            txt_Almacen.Text = "";
            txt_Cantidad.Text = "";
            txt_Descripcion.Text = "";
            txt_IVA.Text = "";
            txt_Obra.Text = "";
            txt_PUnitario.Text = "";
            txt_Subtotal.Text = "";
            txt_Total.Text = "";
            txt_Unidad.Text = "";
            txt_Usoen.Text = "";
            cb_Depto.SelectedItem = null;
            cb_IVA.SelectedItem = null;
            cb_Maquina.SelectedItem = null;
            cb_Proveedor.SelectedItem = null;
            cb_Vehiculo.SelectedItem = null;

        }

    }
}
