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
    public partial class Catalogos : MetroFramework.Forms.MetroForm
    {
        Proveedores proveedores = new Proveedores();
        Maquina maquina = new Maquina();
        Vehiculos vehiculos = new Vehiculos();
        Departamento depto = new Departamento();

        public Catalogos()
        {
            InitializeComponent();
        }

        public static Form IsFormAlreadyOpen(Type formType)
        {
            return Application.OpenForms.Cast<Form>().FirstOrDefault(openForm => openForm.GetType() == formType);
        }

        private void Catalogos_Load(object sender, EventArgs e)
        {
            try
            {
                dg_Proveedor.DataSource = proveedores.LlenarDG("select id_proveedor, nombre, direccion, rfc, telefono, contacto, correo, extension from tb_Proveedores").Tables[0];
                dg_Depto.DataSource = depto.LlenarDG("select id_depto, nombre, encargado from tb_Departamentos").Tables[0];
                dg_Vehiculos.DataSource = vehiculos.LlenarDG("select id_vehiculo, noecon, marca, modelo, linea, color, numserie, bajafecha from tb_Vehiculos").Tables[0];
                dg_Maquinas.DataSource = maquina.LlenarDG("select id_maquina, noecon, marca, modelo, linea, color, numserie, bajafecha from tb_Maquinas").Tables[0];


                dg_Depto.Columns[0].Visible = false;
                dg_Maquinas.Columns[0].Visible = false;
                dg_Proveedor.Columns[0].Visible = false;
                dg_Vehiculos.Columns[0].Visible = false;
            }
            catch { MessageBox.Show("ERROR!", "no se encontro la base de datos!"); }

        }

        private void btn_EditarProveedor_Click(object sender, EventArgs e)
        {
            EditarProveedor EP = new EditarProveedor();
            EP.Show();
            this.Close();
            //Form next;
            //if ((next = IsFormAlreadyOpen(typeof(EditarProveedor))) == null)
            //{
            //    EP.ShowDialog(this);
            //}

            //else
            //{
            //    next.WindowState = FormWindowState.Normal;
            //    next.BringToFront();
            //}
        }

        private void btn_EliminarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (proveedores.Id_proveedor >= 1)
                {
                    proveedores.Crud("delete tb_Proveedores where id_proveedor = " + proveedores.Id_proveedor);
                    Catalogos_Load(sender, e);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No se pudo realizar la accion", "ERROR!");
            }
        }

        private void dg_Proveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dg_Proveedor.Rows[e.RowIndex];
                proveedores.Id_proveedor = int.Parse(row.Cells["id_proveedor"].Value.ToString());
            }
        }

        private void dg_Maquinas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dg_Maquinas.Rows[e.RowIndex];
                maquina.Id_maquina = int.Parse(row.Cells["id_maquina"].Value.ToString());
            }
        }

        private void dg_Depto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dg_Depto.Rows[e.RowIndex];
                depto.Id_depto = int.Parse(row.Cells["id_depto"].Value.ToString());
            }
        }

        private void dg_Vehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dg_Vehiculos.Rows[e.RowIndex];
                vehiculos.Id_vehiculo = int.Parse(row.Cells["id_vehiculo"].Value.ToString());
            }
        }

        private void btn_NuevoVehiculos_Click(object sender, EventArgs e)
        {
            AgregarVehiculo AV = new AgregarVehiculo();
            AV.Show();
            this.Close();
            //Form next;
            //if ((next = IsFormAlreadyOpen(typeof(AgregarVehiculo))) == null)
            //{
            //    AV.ShowDialog(this);
            //}

            //else
            //{
            //    next.WindowState = FormWindowState.Normal;
            //    next.BringToFront();
            //}
        }

        private void btn_NuevoProveedor_Click(object sender, EventArgs e)
        {
            AgregarProveedor AP = new AgregarProveedor();
            AP.Show();
            this.Close();
            //Form next;
            //if ((next = IsFormAlreadyOpen(typeof(AgregarProveedor))) == null)
            //{
            //    try
            //    {
            //        AP.ShowDialog(this);

            //    }
            //    catch (Exception)
            //    {

            //        throw;
            //    }
            //}

            //else
            //{
            //    next.WindowState = FormWindowState.Normal;
            //    next.BringToFront();
            //}
        }

        private void btn_NuevoMaquina_Click(object sender, EventArgs e)
        {
            AgregarMaquina AM = new AgregarMaquina();
            AM.Show();
            this.Close();
            //Form next;
            //if ((next = IsFormAlreadyOpen(typeof(AgregarMaquina))) == null)
            //{
            //    AM.ShowDialog(this);
            //}

            //else
            //{
            //    next.WindowState = FormWindowState.Normal;
            //    next.BringToFront();
            //}
        }

        private void btn_EditarMaquina_Click(object sender, EventArgs e)
        {
            EditarMaquina EM = new EditarMaquina();
            EM.Show();
            this.Close();
            //Form next;
            //if ((next = IsFormAlreadyOpen(typeof(EditarMaquina))) == null)
            //{
            //    EM.ShowDialog(this);
            //}

            //else
            //{
            //    next.WindowState = FormWindowState.Normal;
            //    next.BringToFront();
            //}
        }

        private void btn_EliminarMaquina_Click(object sender, EventArgs e)
        {
            try
            {
                if (maquina.Id_maquina >= 1)
                {
                    maquina.Crud("delete tb_Maquinas where id_maquina = " + maquina.Id_maquina);
                    Catalogos_Load(sender, e);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No se pudo realizar la accion", "ERROR!");
            }
        }

        private void btn_NuevoDepto_Click(object sender, EventArgs e)
        {
            AgregarDepartamento AD = new AgregarDepartamento();
            AD.Show();
            this.Close();
            //Form next;
            //if ((next = IsFormAlreadyOpen(typeof(AgregarDepartamento))) == null)
            //{
            //    AD.ShowDialog(this);
            //}

            //else
            //{
            //    next.WindowState = FormWindowState.Normal;
            //    next.BringToFront();
            //}
        }

        private void btn_EditarDepto_Click(object sender, EventArgs e)
        {
            EditarDepartamento ED = new EditarDepartamento();
            ED.Show();
            this.Close();
            //Form next;
            //if ((next = IsFormAlreadyOpen(typeof(EditarDepartamento))) == null)
            //{
            //    ED.ShowDialog(this);
            //}

            //else
            //{
            //    next.WindowState = FormWindowState.Normal;
            //    next.BringToFront();
            //}
        }

        private void btn_EliminarDepto_Click(object sender, EventArgs e)
        {
            try
            {
                if (depto.Id_depto >= 1)
                {
                    depto.Crud("delete tb_Departamentos where id_depto = " + depto.Id_depto);
                    Catalogos_Load(sender, e);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No se pudo realizar la accion", "ERROR!");
            }
        }

        private void btn_EditarVehiculos_Click(object sender, EventArgs e)
        {
            EditarVehiculo EV = new EditarVehiculo();
            EV.Show();
            this.Close();
            //Form next;
            //if ((next = IsFormAlreadyOpen(typeof(EditarVehiculo))) == null)
            //{
            //    EV.ShowDialog(this);
            //}

            //else
            //{
            //    next.WindowState = FormWindowState.Normal;
            //    next.BringToFront();
            //}
        }

        private void btn_EliminarVehiculos_Click(object sender, EventArgs e)
        {
            try
            {
                if (vehiculos.Id_vehiculo >= 1)
                {
                    vehiculos.Crud("delete tb_Vehiculos where id_vehiculo = " + vehiculos.Id_vehiculo);
                    Catalogos_Load(sender, e);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("No se pudo realizar la accion", "ERROR!");
            }
        }

        private void btn_BuecarProveedor_Click(object sender, EventArgs e)
        {
            if (!(txt_BuscarProveedor.Text == ""))
                SearchProveedor();
            else
                MessageBox.Show("Campo vacio!", "ERROR!");
        }

        private void SearchProveedor()
        {
            string salida_datos = "";
            string[] palabra_busqueda = this.txt_BuscarProveedor.Text.Split(' ');

            foreach (string palabra in palabra_busqueda)
            {

                int id = int.Parse(proveedores.ReturnID("select id_proveedor from tb_Proveedores where nombre = '" + txt_BuscarProveedor.Text + "'"));
                salida_datos = "select id_proveedor, nombre, direccion, rfc, telefono, contacto, correo, extension from tb_Proveedores where id_proveedor = " + id;

                dg_Proveedor.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                dg_Proveedor.RowHeadersVisible = false; // set it to false if not needed
                this.dg_Proveedor.VirtualMode = true;

                DataSet ds = new DataSet();

                ds = proveedores.LlenarDG(salida_datos);
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    //dg_buscar.DataSource = modeloorden.LlenarDG(salida_datos).Tables[0];
                    dg_Proveedor.DataSource = ds.Tables[0];
                    this.dg_Proveedor.Columns[0].Visible = false;
                }
                else
                    MessageBox.Show("No se encontro!");

            }
        }

        private void SearchDepto()
        {
            string salida_datos = "";
            string[] palabra_busqueda = this.txt_BuscarDepto.Text.Split(' ');

            foreach (string palabra in palabra_busqueda)
            {

                int id = int.Parse(depto.ReturnID("select id_depto from tb_Departamentos where nombre = '" + txt_BuscarDepto.Text + "'"));
                salida_datos = "select id_depto, nombre, encargado from tb_Departamentos where id_depto = " + id;

                dg_Depto.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                dg_Depto.RowHeadersVisible = false; // set it to false if not needed
                this.dg_Depto.VirtualMode = true;

                DataSet ds = new DataSet();

                ds = depto.LlenarDG(salida_datos);
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    //dg_buscar.DataSource = modeloorden.LlenarDG(salida_datos).Tables[0];
                    dg_Depto.DataSource = ds.Tables[0];
                    this.dg_Depto.Columns[0].Visible = false;
                }
                else
                    MessageBox.Show("No se encontro!");

            }
        }

        private void SearchVehiculo()
        {
            string salida_datos = "";
            string[] palabra_busqueda = this.txt_BuscarVehiculos.Text.Split(' ');

            foreach (string palabra in palabra_busqueda)
            {

                int id = int.Parse(vehiculos.ReturnID("select id_vehiculo from tb_Vehiculos where noecon = '" + txt_BuscarVehiculos.Text + "'"));
                salida_datos = "select id_vehiculo, noecon, marca, modelo, linea, color, numserie, bajafecha from tb_Vehiculos where id_vehiculo = " + id;

                dg_Vehiculos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                dg_Vehiculos.RowHeadersVisible = false; // set it to false if not needed
                this.dg_Vehiculos.VirtualMode = true;

                DataSet ds = new DataSet();

                ds = vehiculos.LlenarDG(salida_datos);
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    //dg_buscar.DataSource = modeloorden.LlenarDG(salida_datos).Tables[0];
                    dg_Vehiculos.DataSource = ds.Tables[0];
                    this.dg_Vehiculos.Columns[0].Visible = false;
                }
                else
                    MessageBox.Show("No se encontro!");

            }
        }

        private void SearchMaquina()
        {
            string salida_datos = "";
            string[] palabra_busqueda = this.txt_BuscarVehiculos.Text.Split(' ');

            foreach (string palabra in palabra_busqueda)
            {

                int id = int.Parse(maquina.ReturnID("select id_vehiculo from tb_Maquinas where noecon = '" + txt_BuscarVehiculos.Text + "'"));
                salida_datos = "select id_vehiculo, noecon, marca, modelo, linea, color, numserie, bajafecha from tb_Maquinas where id_vehiculo = " + id;

                dg_Maquinas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                dg_Maquinas.RowHeadersVisible = false; // set it to false if not needed
                this.dg_Maquinas.VirtualMode = true;

                DataSet ds = new DataSet();

                ds = maquina.LlenarDG(salida_datos);
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    //dg_buscar.DataSource = modeloorden.LlenarDG(salida_datos).Tables[0];
                    dg_Maquinas.DataSource = ds.Tables[0];
                    this.dg_Maquinas.Columns[0].Visible = false;
                }
                else
                    MessageBox.Show("No se encontro!");

            }
        }

        private void btn_BuscarMaquina_Click(object sender, EventArgs e)
        {
            if (!(txt_BuscarMaquinas.Text == ""))
                SearchMaquina();
            else
                MessageBox.Show("Campo vacio!", "ERROR!");
        }

        private void btn_BuscarDepto_Click(object sender, EventArgs e)
        {
            if (!(txt_BuscarDepto.Text == ""))
                SearchDepto();
            else
                MessageBox.Show("Campo vacio!", "ERROR!");
        }

        private void btn_BuscarVehiculo_Click(object sender, EventArgs e)
        {
            if (!(txt_BuscarVehiculos.Text == ""))
                SearchVehiculo();
            else
                MessageBox.Show("Campo vacio!", "ERROR!");
        }

        private void metroTabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
