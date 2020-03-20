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
    public partial class AgregarDepartamento : MetroFramework.Forms.MetroForm
    {
        Departamento depto = new Departamento();
        public AgregarDepartamento()
        {
            InitializeComponent();
        }

        private void AgregarDepartamento_Load(object sender, EventArgs e)
        {

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txt_Depto.Text)))
            {
                if (!(depto.Exists("select COUNT(*) from tb_Departamentos where nombre = '" + txt_Depto.Text + "'")))
                {
                    depto.Crud("insert into tb_Departamentos(nombre,encargado) values('" + txt_Depto.Text + "','" + txt_Encargado.Text + "')");
                    MessageBox.Show("Nuevo Departamento agregado!");
                    TextBoxClear();
                }
                else
                    MessageBox.Show("Este Departamento ya esta registrado!");
            }
            else { MessageBox.Show("Ingrese el nombre del Departamento!", "ERROR!"); }
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

        private void AgregarDepartamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            Catalogos cat = new Catalogos();
            cat.Show();
        }
    }
}
