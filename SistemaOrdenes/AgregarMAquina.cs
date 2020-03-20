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
    public partial class AgregarMaquina : MetroFramework.Forms.MetroForm
    {
        Departamento depto = new Departamento();
        Maquina maquina = new Maquina();
        public AgregarMaquina()
        {
            InitializeComponent();
        }

        private void AgregarMaquina_Load(object sender, EventArgs e)
        {
            cb_Depto.DataSource = depto.FillCB("select * from tb_Departamentos");
            cb_Depto.DisplayMember = "nombre";
            cb_Depto.ValueMember = "id_depto";
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txt_NoEconomico.Text)))
            {
                if (!(maquina.Exists("select COUNT(*) from tb_Maquinas where noecon = '" + txt_NoEconomico.Text + "'")))
                {
                    maquina.Crud("insert into tb_Maquinas(noecon,marca,linea,tipo,modelo,usuario,placas,numserie,motor,llantas,color,id_depto) values('" +
                        txt_NoEconomico.Text + "','" + txt_Marca.Text + "','" + txt_Linea.Text + "','" + txt_Tipo.Text + "','" + txt_Modelo.Text + "','" + txt_Usario.Text + "','" + txt_Placas.Text +
                        "','" + txt_NoSerie.Text + "','" + txt_Motor.Text + "','" + txt_Llantas.Text + "','" + txt_Color.Text + "','" + cb_Depto.SelectedValue + "')");
                    MessageBox.Show("Nueva Maquina agregado!");
                    TextBoxClear();
                }
                else
                    MessageBox.Show("Esta tb_Maquina ya esta registrado!");
            }
            else { MessageBox.Show("Ingrese el nombre de la Maquina!", "ERROR!"); }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            TextBoxClear();
        }

        private void TextBoxClear()
        {
            txt_Color.Text = "";
            txt_Linea.Text = "";
            txt_Llantas.Text = "";
            txt_Marca.Text = "";
            txt_Modelo.Text = "";
            txt_NoEconomico.Text = "";
            txt_NoSerie.Text = "";
            txt_Placas.Text = "";
            txt_Tipo.Text = "";
            txt_Usario.Text = "";
            txt_Motor.Text = "";
            cb_Depto.SelectedItem = null;
        }

        private void AgregarMaquina_FormClosed(object sender, FormClosedEventArgs e)
        {
            Catalogos cat = new Catalogos();
            cat.Show();
        }
    }
}
