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
    public partial class EditarMaquina : MetroFramework.Forms.MetroForm
    {
        Departamento depto = new Departamento();
        Maquina maquina = new Maquina();
        public EditarMaquina()
        {
            InitializeComponent();
        }

        private void EditarMaquina_Load(object sender, EventArgs e)
        {
            cb_Depto.DataSource = depto.FillCB("select * from tb_Departamentos");
            cb_Depto.DisplayMember = "nombre";
            cb_Depto.ValueMember = "id_depto";

            try
            {
                var leer = maquina.Leer("Select * from tb_Maquinas where id_maquina = '" + maquina.Id_maquina + "'");

                if (leer.Read() == true)
                {
                    txt_Color.Text = leer["color"].ToString();
                    txt_Linea.Text = leer["linea"].ToString();
                    txt_Llantas.Text = leer["llantas"].ToString();
                    txt_Marca.Text = leer["marca"].ToString();
                    txt_Modelo.Text = leer["modelo"].ToString();
                    txt_NoEconomico.Text = leer["noecon"].ToString();
                    txt_NoSerie.Text = leer["numserie"].ToString();
                    txt_Placas.Text = leer["placas"].ToString();
                    txt_Tipo.Text = leer["tipo"].ToString();
                    txt_Usario.Text = leer["usuario"].ToString();
                    txt_Motor.Text = leer["motor"].ToString();
                    cb_Depto.SelectedItem = leer["id_depto"].ToString();
                }
                else
                {
                    TextBoxClear();
                }
                maquina.Cerrar();
            }
            catch (System.InvalidOperationException)
            {
                maquina.Cerrar();
                throw;
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txt_NoEconomico.Text)))
            {
                maquina.Crud("UPDATE tb_Maquinas set noecon='" + txt_NoEconomico.Text + "', marca = '" + txt_Marca.Text + "', linea = '" + txt_Linea.Text + "', tipo ='" + txt_Tipo.Text + "', modelo ='" + txt_Modelo.Text +
                    "' , usuario ='" + txt_Usario.Text + "' , placas ='" + txt_Placas.Text + "' , numserie ='" + txt_NoSerie.Text + "' , motor ='" + txt_Motor.Text +
                    "' , llantas ='" + txt_Llantas.Text + "' , color ='" + txt_Color.Text + "' , id_depto  ='" + cb_Depto.SelectedValue + "' where id_maquina = " + maquina.Id_maquina);
                MessageBox.Show("Nueva Maquina agregada!");
                TextBoxClear();

            }
            else
                MessageBox.Show("Ingrese el nombre de la Maquina!", "ERROR!");
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

        private void EditarMaquina_FormClosed(object sender, FormClosedEventArgs e)
        {
            Catalogos cat = new Catalogos();
            cat.Show();
        }
    }
}
