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
    public partial class EditarDepartamento : MetroFramework.Forms.MetroForm
    {
        Departamento depto = new Departamento();
        public EditarDepartamento()
        {
            InitializeComponent();
        }

        private void EditarDepartamento_Load(object sender, EventArgs e)
        {
            try
            {
                var leer = depto.Leer("Select * from tb_Departamentos where id_depto = '" + depto.Id_depto + "'");

                if (leer.Read() == true)
                {
                    txt_Depto.Text = leer["nombre"].ToString();
                    txt_Encargado.Text = leer["encargado"].ToString();
                }
                else
                {
                    txt_Depto.Text = "";
                    txt_Encargado.Text = "";
                }
                depto.Cerrar();
            }
            catch (System.InvalidOperationException)
            {
                depto.Cerrar();
                throw;
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            TextBoxClear();
        }

        private void TextBoxClear()
        {
            txt_Depto.Text = "";
            txt_Encargado.Text = "";
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txt_Depto.Text)))
            {

                depto.Crud("UPDATE tb_Departamentos set nombre='" + txt_Depto.Text + "', encargado = '" + txt_Encargado.Text + "' where id_depto = " + depto.Id_depto);
                MessageBox.Show("Nuevo Proveedor agregado!");
                TextBoxClear();

            }
            else { MessageBox.Show("Ingrese el nombre del Departamento!", "ERROR!"); }
        }

        private void EditarDepartamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            Catalogos cat = new Catalogos();
            cat.Show();
        }
    }
}

