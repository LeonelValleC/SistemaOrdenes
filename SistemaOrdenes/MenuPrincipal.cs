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
    public partial class MenuPrincipal : MetroFramework.Forms.MetroForm
    {
        private readonly Usuarios user = new Usuarios();
        
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        public static Form IsFormAlreadyOpen(Type formType)
        {
            return Application.OpenForms.Cast<Form>().FirstOrDefault(openForm => openForm.GetType() == formType);
        }


        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            //lbl_user.Text = user.ReturnValue("select usuario from tb_Usuarios where id_usuario = " + user.Id_user);

            lbl_user.Text = user.GetUserName();

            if (user.GetNivel(user.Id_user) == "Basico")
            {
                btn_Busqueda.Visible = false;
                Btn_Manto.Visible = false;
            }
            else if (user.GetNivel(user.Id_user) == "Auditor")
            {
                Btn_Manto.Visible = false;
            }
        }

        private void btn_Catalogos_Click(object sender, EventArgs e)
        {
            Catalogos catalogos = new Catalogos();
            catalogos.Show();
            //Form next;
            //if ((next = IsFormAlreadyOpen(typeof(Catalogos))) == null)
            //{
            //    catalogos.ShowDialog(this);
            //}

            //else
            //{
            //    next.WindowState = FormWindowState.Normal;
            //    next.BringToFront();
            //}
        }

        private void btn_ordenes_Click(object sender, EventArgs e)
        {
            BusquedaOrdenes busqueda = new BusquedaOrdenes();
            busqueda.Show();

        }

        private void btn_Busqueda_Click(object sender, EventArgs e)
        {
            Search busquedas = new Search();
            busquedas.Show();
            //Form next;
            //if ((next = IsFormAlreadyOpen(typeof(Busquedas))) == null)
            //{
            //    busquedas.ShowDialog(this);
            //}

            //else
            //{
            //    next.WindowState = FormWindowState.Normal;
            //    next.BringToFront();
            //}
        }

        private void Btn_Manto_Click(object sender, EventArgs e)
        {
            Mantenimiento manto = new Mantenimiento();
            manto.Show();
            //Form next;
            //if ((next = IsFormAlreadyOpen(typeof(Mantenimiento))) == null)
            //{
            //    manto.ShowDialog(this);
            //}

            //else
            //{
            //    next.WindowState = FormWindowState.Normal;
            //    next.BringToFront();
            //}
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();

        }
    }
}
