using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOrdenes
{
    class Usuarios : Conexion
    {
        static int id_user;
        string password;
        static string nivel;
        bool activo;
        string nombre;
        string apellido;
        string correo;
        string usuario;

        public int Id_user { get => id_user; set => id_user = value; }
        public string Password { get => password; set => password = value; }
        public bool Activo { get => activo; set => activo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Niveles { get => nivel; set => nivel = value; }
        public string Usuario { get => usuario; set => usuario = value; }

        public int Login(string user, string password)
        {
            //int id = -1;
            ////SqlCommand cmd = new SqlCommand("select * from tb_Usuario where username='" + user + "' and password='" + password + "'", Con1);
            //using (SqlCommand cmd = new SqlCommand("select id_usuario from tb_Usuario where username='" + user + "' and password='" + password + "'", Con1))
            //{
            //    Con1.Open();
            //    //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    //DataSet ds = new DataSet();
            //    //da.Fill(ds);

            //    if (cmd.ExecuteScalar() != null)
            //        id = int.Parse(cmd.ExecuteScalar().ToString());
            //}

            id_user = int.Parse(ReturnID("select id_usuario from tb_Usuarios where usuario='" + user + "' and password='" + password + "'"));
            //Con1.Close();

            return id_user;
        }

        public string GetUserName()
        {
            string username;

            username = ReturnValue("select usuario from tb_Usuarios where id_usuario = " + id_user);

            return username;
        }

        

        public string GetNivel(int id_usuario)
        {
            Nivel nivel = new Nivel();

            //Niveles = int.Parse(users.ReturnID("select id_nivel from tb_Usuarios where id_usuario = " + id_user));

            nivel.Niveles = ReturnValue("select n.nivel from tb_Usuarios u join tb_Nivel n on n.id_nivel = u.id_nivel where u.id_usuario = " + id_usuario);

            return nivel.Niveles;
        }
    }
}
