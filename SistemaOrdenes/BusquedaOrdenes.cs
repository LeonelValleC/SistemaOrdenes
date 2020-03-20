using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOrdenes
{
    public partial class BusquedaOrdenes : MetroFramework.Forms.MetroForm
    {
        private readonly Orden orden = new Orden();
        private readonly Usuarios user = new Usuarios();
        //private readonly DataTable filtro;
        public BusquedaOrdenes()
        {
            InitializeComponent();
        }

        private void BusquedaOrdenes_Load(object sender, EventArgs e)
        {
            dg_buscar.DataSource = orden.LlenarDG("select o.id_orden, o.orden as 'Orden', o.total as 'Total', o.fecha as 'Fecha', o.estado as 'Estado', d.nombre as 'Departamento', v.noecon as 'Vehiculo', m.noecon as 'Maquina' from tb_Ordenes o join tb_Departamentos d on o.id_depto = d.id_depto join tb_Proveedores p on o.id_proveedor = p.id_proveedor join tb_Vehiculos v on o.id_vehiculo = v.id_vehiculo join tb_Maquinas m on o.id_maquina = m.id_maquina").Tables[0];

            dg_buscar.Columns[0].Visible = false;

            if (user.GetNivel(user.Id_user) == "Basico")
            {
                btn_Aprobar.Visible = false;
                btn_Cancelar.Visible = false;
            }


        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            RegistroOrdenes registroOrdenes = new RegistroOrdenes();
            registroOrdenes.Show();
            this.Close();
        }

        private void btn_EditarOrden_Click(object sender, EventArgs e)
        {
            EditarOrdenes EO = new EditarOrdenes();
            EO.Show();
            this.Close();
        }

        private void dg_buscar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dg_buscar.Rows[e.RowIndex];
                    orden.Id_orden = int.Parse(row.Cells["id_orden"].Value.ToString());
                }

            }
            catch (FormatException )
            {
                //MessageBox.Show("Seleccione u");
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (!(txt_buscar.Text == ""))
                SearchOrden();
            else
                MessageBox.Show("Campo vacio!", "ERROR!");
        }

        private void SearchOrden()
        {
            string salida_datos = "";
            string[] palabra_busqueda = this.txt_buscar.Text.Split(' ');

            foreach (string palabra in palabra_busqueda)
            {
                //Orden
                //Proveedor
                //Departamento
                if (cb_filtro.Text == "Orden")
                {
                    int id = int.Parse(orden.ReturnID("select id_orden from tb_Ordenes where orden = '" + txt_buscar.Text + "'"));
                    salida_datos = "select o.id_orden, o.orden, o.total, o.fecha, o.estado, d.nombre as 'Departamento', v.noecon as 'Vehiculo', m.noecon as 'Maquina' from tb_Ordenes o join tb_Departamentos d on o.id_depto = d.id_depto join tb_Proveedores p on o.id_proveedor = p.id_proveedor join tb_Vehiculos v on o.id_vehiculo = v.id_vehiculo join tb_Maquinas m on o.id_maquina = m.id_maquina where id_orden = " + id;

                }
                if (cb_filtro.Text == "Proveedor")
                {
                    //int id = int.Parse(orden.ReturnID("select id_orden from tb_Ordenes where orden = '" + txt_buscar.Text + "'"));
                    salida_datos = "select o.id_orden, o.orden, o.total, o.fecha, o.estado, d.nombre as 'Departamento', v.noecon as 'Vehiculo', m.noecon as 'Maquina' from tb_Ordenes o join tb_Departamentos d on o.id_depto = d.id_depto join tb_Proveedores p on o.id_proveedor = p.id_proveedor join tb_Vehiculos v on o.id_vehiculo = v.id_vehiculo join tb_Maquinas m on o.id_maquina = m.id_maquina where p.nombre = = " + txt_buscar.Text;

                }
                if (cb_filtro.Text == "Departamento")
                {
                    int id = int.Parse(orden.ReturnID("select id_orden from tb_Ordenes where orden = '" + txt_buscar.Text + "'"));
                    salida_datos = "select o.id_orden, o.orden, o.total, o.fecha, o.estado, d.nombre as 'Departamento', v.noecon as 'Vehiculo', m.noecon as 'Maquina' from tb_Ordenes o join tb_Departamentos d on o.id_depto = d.id_depto join tb_Proveedores p on o.id_proveedor = p.id_proveedor join tb_Vehiculos v on o.id_vehiculo = v.id_vehiculo join tb_Maquinas m on o.id_maquina = m.id_maquina where id_orden = " + id;

                }

                dg_buscar.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                dg_buscar.RowHeadersVisible = false; // set it to false if not needed
                this.dg_buscar.VirtualMode = true;

                DataSet ds = new DataSet();

                ds = orden.LlenarDG(salida_datos);
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    //dg_buscar.DataSource = modeloorden.LlenarDG(salida_datos).Tables[0];
                    dg_buscar.DataSource = ds.Tables[0];
                    this.dg_buscar.Columns[0].Visible = false;
                }
                else
                    MessageBox.Show("No se encontro!");

            }
        }

        private void btn_Aprobar_Click(object sender, EventArgs e)
        {
            if (orden.Id_orden >= 1)
            {
                orden.Crud("update tb_Ordenes set estado = 'AUTORIZADO' where id_orden = " + orden.Id_orden);
                BusquedaOrdenes_Load(sender, e);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (orden.Id_orden >= 1)
            {
                orden.Crud("update tb_Ordenes set estado = 'CANCELADO' where id_orden = " + orden.Id_orden);
                BusquedaOrdenes_Load(sender, e);
            }
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            if (dg_buscar.Rows.Count != 0)
            {
                Reporte r = new Reporte();
                r.Show();
            }
            else
                MessageBox.Show("Realize una busqueda", "ERROR!");
        }



    }
}
