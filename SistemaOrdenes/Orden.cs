using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOrdenes
{
    class Orden : Conexion
    {
        static int id_orden;
        int orden;
        DateTime fecha;
        string almacen;
        string solicito;
        string reviso;
        string autorizo;
        string parauso;
        string obra;
        int id_usuario;
        int id_maquina;
        int id_proveedor;
        int id_depto;
        int id_vehiculo;

        public int Id_orden { get => id_orden; set => id_orden = value; }
        public int Ordenes { get => orden; set => orden = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Almacen { get => almacen; set => almacen = value; }
        public string Solicito { get => solicito; set => solicito = value; }
        public string Reviso { get => reviso; set => reviso = value; }
        public string Autorizo { get => autorizo; set => autorizo = value; }
        public string Parauso { get => parauso; set => parauso = value; }
        public string Obra { get => obra; set => obra = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int Id_maquina { get => id_maquina; set => id_maquina = value; }
        public int Id_proveedor { get => id_proveedor; set => id_proveedor = value; }
        public int Id_depto { get => id_depto; set => id_depto = value; }
        public int Id_vehiculo { get => id_vehiculo; set => id_vehiculo = value; }

        public void NuevaOrden()
        {
            Usuarios usuarios = new Usuarios();
            //int id;
            int last;

            last = int.Parse(ReturnValue("select TOP 1 orden from tb_Ordenes order by id_orden desc"));
            last++;
            id_orden = int.Parse(ReturnID("insert into tb_Ordenes(orden, fecha, id_usuario) values(" + last + " , '" + DateTime.Now + "' , '" + usuarios.Id_user + "'); SELECT SCOPE_IDENTITY();"));

            //return id;
        }
    }
}
