using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOrdenes
{
    class Departamento : Conexion
    {
        static int id_depto;
        string departamento;
        string encargado;

        public int Id_depto { get => id_depto; set => id_depto = value; }
        public string Departamentos { get => departamento; set => departamento = value; }
        public string Encargado { get => encargado; set => encargado = value; }
    }
}
