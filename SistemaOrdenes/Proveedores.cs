using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOrdenes
{
    class Proveedores : Conexion
    {
        static int id_proveedor;
        string proveedor;
        string direccion;
        string rfc;
        string telefono;
        string contacto;
        string correo;
        string extension;

        public int Id_proveedor { get => id_proveedor; set => id_proveedor = value; }
        public string Proveedor { get => proveedor; set => proveedor = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Rfc { get => rfc; set => rfc = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Contacto { get => contacto; set => contacto = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Extension { get => extension; set => extension = value; }
    }
}
