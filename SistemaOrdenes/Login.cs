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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        Usuarios usuarios = new Usuarios();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Por favor ingrese toda la informacion");
                return;
            }
            usuarios.Id_user = usuarios.Login(txt_usuario.Text, txt_password.Text);
            if (usuarios.Id_user >= 0)
            {

                usuarios.Niveles = usuarios.GetNivel(usuarios.Id_user);
                //MessageBox.Show("Login Successful!");
                Log();                            

            }
            else
            {
                MessageBox.Show("Login Failed!");
            }

        }
        private void Log()
        {
            this.Hide();
            MenuPrincipal fm = new MenuPrincipal();
            fm.Show();
        }
    }
}
