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
    public partial class Reporte : MetroFramework.Forms.MetroForm
    {
        Orden orden = new Orden();
        private DataTable filtro;
        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            //filtro = orden.LlenarDG("select o.orden, o.almacen, o.obra, o.parauso,o.fecha, o.total, o.iva, o.subtotal, o.letra,do.cantidad, do.descripcion, do.punitario as 'PrecioUnitario', p.nombre as 'Proveedor', d.nombre as 'Departamento', u.nombre , u.apellido, m.noecon as 'Maquina', v.noecon as 'Vehiculo', do.costo from tb_Ordenes o join tb_DetalleOrdenes do on o.id_orden = do.id_orden join tb_Departamentos d on d.id_depto = o.id_depto join tb_Proveedores p on p.id_proveedor = o.id_proveedor join tb_Vehiculos v on v.id_vehiculo = o.id_vehiculo join tb_Maquinas m on m.id_maquina = o.id_maquina join tb_Usuarios u on u.id_usuario = o.id_usuario where o.id_orden = " + orden.Id_orden).Tables[0];
            filtro = orden.LlenarDG("select o.orden as 'ORDEN', o.almacen AS 'ALMACEN', o.obra AS 'OBRA', o.parauso,o.fecha, o.total AS 'TOTAL', o.iva AS 'IVA', o.subtotal AS 'SUBTOTAL', o.letra,do.cantidad AS 'CANTIDAD', do.descripcion AS 'DESCRIPCION', do.punitario as 'P.UNITARIO', p.nombre as 'PROVEEDOR', d.nombre as 'DEPARTAMENTO', u.nombre , u.apellido, m.noecon as 'MAQUINA', v.noecon as 'VEHICULO', do.costo AS 'COSTO', dp.nombre as 'DeptoUsuario' from tb_Ordenes o join tb_DetalleOrdenes do on o.id_orden = do.id_orden join tb_Departamentos d on d.id_depto = o.id_depto join tb_Proveedores p on p.id_proveedor = o.id_proveedor join tb_Vehiculos v on v.id_vehiculo = o.id_vehiculo join tb_Maquinas m on m.id_maquina = o.id_maquina join tb_Usuarios u on u.id_usuario = o.id_usuario join tb_Departamentos dp on u.id_depto = dp.id_depto where o.id_orden = " + orden.Id_orden).Tables[0];
            //dataGridView1.DataSource = filtro;
            CreateReport();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void CreateReport()
        {
            SqlDataAdapter dscmd = new SqlDataAdapter();

            DS_Report ds = new DS_Report();

            ds.DataTable1.DataSet.Tables.Add(filtro.Copy());

            CrystalReport1 objRpt = new CrystalReport1();
            objRpt.SetDataSource(ds.Tables[1]);
            crystalReportViewer1.ReportSource = objRpt;
            crystalReportViewer1.Refresh();
        }
    }
}
