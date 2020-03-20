using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOrdenes
{
    class DetalleOrden : Conexion
    {
        static int id_detalle;
        int cantidad;
        string descripcion;
        float punitario;
        int id_moneda;
        int id_iva;
        int id_orden;

        public int Id_detalle { get => id_detalle; set => id_detalle = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public float Punitario { get => punitario; set => punitario = value; }
        public int Id_moneda { get => id_moneda; set => id_moneda = value; }
        public int Id_iva { get => id_iva; set => id_iva = value; }
        public int Id_orden { get => id_orden; set => id_orden = value; }
    }
}
