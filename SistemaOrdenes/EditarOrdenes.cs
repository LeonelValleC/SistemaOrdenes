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
    public partial class EditarOrdenes : MetroFramework.Forms.MetroForm
    {
        Orden orden = new Orden();
        DetalleOrden detalle = new DetalleOrden();
        Usuarios user = new Usuarios();
        Convertir convertir = new Convertir();
        public EditarOrdenes()
        {
            InitializeComponent();
        }

        private void LoadDetalles()
        {
            lbl_Orden.Text = orden.ReturnValue("select orden from tb_Ordenes where id_orden = " + orden.Id_orden);
            lbl_usuario.Text = user.GetUserName();
        }

        private void EditarOrdenes_Load(object sender, EventArgs e)
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

            dg_Detalle.DataSource = detalle.LlenarDG("select id_dordenes ,cantidad, descripcion, punitario from tb_DetalleOrdenes where id_orden = " + orden.Id_orden).Tables[0];
            dg_Detalle.Columns[0].Visible = false;

            try
            {
                var leer = orden.Leer("Select * from tb_Ordenes where id_orden = '" + orden.Id_orden + "'");

                if (leer.Read() == true)
                {
                    txt_Subtotal.Text = leer["subtotal"].ToString();
                    txt_Total.Text = leer["total"].ToString();
                    txt_Usoen.Text = leer["parauso"].ToString();
                    txt_Unidad.Text = leer["unidad"].ToString();
                    txt_IVA.Text = leer["iva"].ToString();
                    txt_Obra.Text = leer["obra"].ToString();
                    txt_Almacen.Text = leer["almacen"].ToString();
                    cb_Depto.SelectedValue = int.Parse(leer["id_depto"].ToString());
                    cb_Maquina.SelectedValue = int.Parse(leer["id_maquina"].ToString());
                    cb_Proveedor.SelectedValue = int.Parse(leer["id_proveedor"].ToString());
                    cb_Vehiculo.SelectedValue = int.Parse(leer["id_vehiculo"].ToString());
                }
                else
                {
                    TextBoxClear();
                }
                detalle.Cerrar();
            }
            catch (System.InvalidOperationException)
            {
                detalle.Cerrar();
                throw;
            }
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

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Cantidad.Text) && !string.IsNullOrEmpty(txt_PUnitario.Text) && !string.IsNullOrEmpty(txt_Descripcion.Text))
            {

                if (cb_IVA.SelectedItem != null)
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
                }
                else
                    MessageBox.Show("Seleccione un IVA");

                loadDG();
                txt_Cantidad.Text = "";
                txt_Descripcion.Text = "";
                txt_Unidad.Text = "";
            }
            else
                MessageBox.Show("Ingrese un nuevo articulo!", "ERROR!");
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (detalle.Id_detalle >= 1)
            {
                detalle.Crud("delete tb_DetalleOrdenes where id_dordenes = " + detalle.Id_detalle);
                loadDG();
            }
        }

        private void loadDG()
        {
            dg_Detalle.DataSource = detalle.LlenarDG("select id_dordenes ,cantidad, descripcion, punitario from tb_DetalleOrdenes where id_orden = " + orden.Id_orden).Tables[0];
            dg_Detalle.Columns[0].Visible = false;
        }

        private void btn_GuardarOrden_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_Usoen.Text) && cb_Proveedor.SelectedItem != null)
            {
                orden.Crud("update tb_Ordenes set id_depto = '" + cb_Depto.SelectedValue + "' , id_proveedor = '" + cb_Proveedor.SelectedValue + "' , id_maquina = '" + cb_Maquina.SelectedValue + "' , id_vehiculo = '" + cb_Vehiculo.SelectedValue +
                    "' , parauso = '" + txt_Usoen.Text + "' , unidad = '" + txt_Unidad.Text + "' , obra = '" + txt_Obra.Text + "' , almacen = '" + txt_Almacen.Text + "' , subtotal = '" + txt_Subtotal.Text + "' , iva = '" + txt_IVA.Text + "' , total = '"
                    + txt_Total.Text + "' , letra = '" + convertir.enletras(txt_Total.Text).ToUpper() + "' where id_orden = " + orden.Id_orden);
                TextBoxClear();
                MessageBox.Show("Orden Actualizada!");
            }
            else
                MessageBox.Show("Ingrese un Proveedor y Para uno en", "ERROR!");
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            TextBoxClear();
        }

        private void EditarOrdenes_FormClosed(object sender, FormClosedEventArgs e)
        {
            BusquedaOrdenes busqueda = new BusquedaOrdenes();
            busqueda.Show();
            //this.Close();
        }

        private void dg_Detalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dg_Detalle.Rows[e.RowIndex];
                detalle.Id_detalle = int.Parse(row.Cells["id_dordenes"].Value.ToString());
            }
        }
    }
}
