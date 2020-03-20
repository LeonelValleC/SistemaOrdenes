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
    public partial class Search : MetroFramework.Forms.MetroForm
    {
        Orden orden = new Orden();
        private DataView filtro;

        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            this.filtro = orden.Leer_Datos("select m.modelo as Model, s.sim, mo.Serialnumber as 'Serial Number', mo.scanmodem as 'Modem Number' , mo.scansim as 'Sim Number', c.caja as Box, o.orden as WorkOrder, mo.fecharegistro as DateScan, p.pallette, o.Revision as Rev, o.RevisionFirmware as Firmware, op.numeroempleado as Employee from tb_Operador op ,tb_ModeloOrden mo, tb_Orden o, tb_caja c, tb_Pallette p, tb_Modelo m, tb_SIM s where mo.id_orden = o.id_orden and mo.id_caja = c.id_caja and c.id_pallette = p.id_pallette and o.id_operador = op.id_operador and o.id_modelo = m.id_modelo and o.id_sim = s.id_sim", "tb_ModeloOrden.id_modeloOrden, tb_ModeloOrden.scanmodem, tb_ModeloOrden.scansim , tb_ModeloOrden.fecharegistro, tb_ModeloOrden.id_orden , tb_Orden.orden, tb_caja.caja , tb_pallette.pellette, tb_pallette.id_pellette");
            this.dg_buscar.DataSource = filtro;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
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
                if (cb_filtro.Text == "Vehiculo")
                {
                    int id = int.Parse(orden.ReturnID("select id_vehiculo from tb_Vehiculos where noecon = '" + txt_buscar.Text + "'"));
                    salida_datos = "select o.id_orden, o.orden, o.total, o.fecha, o.estado, d.nombre as 'Departamento', v.noecon as 'Vehiculo', m.noecon as 'Maquina' from tb_Ordenes o join tb_Departamentos d on o.id_depto = d.id_depto join tb_Proveedores p on o.id_proveedor = p.id_proveedor join tb_Vehiculos v on o.id_vehiculo = v.id_vehiculo join tb_Maquinas m on o.id_maquina = m.id_maquina where v.id_vehiculo = " + id;

                }
                if (cb_filtro.Text == "Maquina")
                {
                    int id = int.Parse(orden.ReturnID("select id_maquina from tb_Maquinas where noecon = '" + txt_buscar.Text + "'"));
                    salida_datos = "select o.id_orden, o.orden, o.total, o.fecha, o.estado, d.nombre as 'Departamento', v.noecon as 'Vehiculo', m.noecon as 'Maquina' from tb_Ordenes o join tb_Departamentos d on o.id_depto = d.id_depto join tb_Proveedores p on o.id_proveedor = p.id_proveedor join tb_Vehiculos v on o.id_vehiculo = v.id_vehiculo join tb_Maquinas m on o.id_maquina = m.id_maquina where m.id_maquina = " + id;

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

    }
}
