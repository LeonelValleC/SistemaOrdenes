using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOrdenes
{
    class Vehiculos : Conexion
    {
        static int id_vehiculo;
        string noEconomico;
        string marca;
        string modelo;
        int depto;
        DateTime fechaBaja;
        string color;
        string placas;
        string linea;

        public int Id_vehiculo { get => id_vehiculo; set => id_vehiculo = value; }
        public string NoEconomico { get => noEconomico; set => noEconomico = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Depto { get => depto; set => depto = value; }
        public DateTime FechaBaja { get => fechaBaja; set => fechaBaja = value; }
        public string Color { get => color; set => color = value; }
        public string Placas { get => placas; set => placas = value; }
        public string Linea { get => linea; set => linea = value; }
    }
}
