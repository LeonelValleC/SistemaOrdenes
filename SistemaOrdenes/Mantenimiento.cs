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
    public partial class Mantenimiento : MetroFramework.Forms.MetroForm
    {
        Usuarios user = new Usuarios();
        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void Mantenimiento_Load(object sender, EventArgs e)
        {
            cb_nivel.DataSource = user.FillCB("select * from tb_Nivel");
            cb_nivel.DisplayMember = "nivel";
            cb_nivel.ValueMember = "id_nivel";
            cb_nivel.SelectedItem = null;

            dataGridView1.DataSource = user.LlenarDG("select us.id_usuario, us.nombre, us.apellido, us.correo, us.usuario, us.password , n.nivel from tb_Usuarios us join tb_Nivel n on n.id_nivel = us.id_nivel").Tables[0];
            dataGridView1.Columns[0].Visible = false;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_nombre.Text) && !string.IsNullOrEmpty(txt_Apellido.Text) && !string.IsNullOrEmpty(txt_Correo.Text) && !string.IsNullOrEmpty(txt_Username.Text) && !string.IsNullOrEmpty(txt_pass.Text))
            {
                user.Crud("insert into tb_Usuarios(nombre,apellido,correo,usuario,password,id_nivel) values('" + txt_nombre.Text + "','" + txt_Apellido.Text + "','" + txt_Correo.Text + "','" + txt_Username.Text + "','" + txt_pass.Text + "','" + cb_nivel.SelectedValue + "')");
                Mantenimiento_Load(sender, e);
            }
            else
                MessageBox.Show("Llene todos los campos");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    user.Id_user = int.Parse(row.Cells["id_usuario"].Value.ToString());
                }
            }
            catch (FormatException )
            {
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_nombre.Text) && !string.IsNullOrEmpty(txt_Apellido.Text) && !string.IsNullOrEmpty(txt_Correo.Text) && !string.IsNullOrEmpty(txt_Username.Text) && !string.IsNullOrEmpty(txt_pass.Text))
            {
                user.Crud("update tb_Usuarios set nombre = '" + txt_nombre.Text + "', apellido = '" + txt_Apellido.Text + "', correo = '" + txt_Correo.Text + "', usuario = '" + txt_Username.Text + "', password = '" + txt_Username.Text + "', id_nivel = '" + cb_nivel.SelectedValue + "' where id_usuario = " + user.Id_user);
                Mantenimiento_Load(sender, e);
            }
            else
                MessageBox.Show("Llene todos los campos");
        }

        private void textEmpty()
        {
            txt_Apellido.Text = "";
            txt_Correo.Text = "";
            txt_nombre.Text = "";
            txt_pass.Text = "";
            txt_Username.Text = "";
            cb_nivel.SelectedItem = null;
        }
    }
}
