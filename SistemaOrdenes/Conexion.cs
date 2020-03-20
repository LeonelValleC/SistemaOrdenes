﻿using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SistemaOrdenes
{
    class Conexion
    {
        private SqlConnection Con; // Obj Conexion

        public Conexion() =>
        Con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["ServerDb"].ConnectionString);
        //Con1 = new SqlConnection(@"Data Source=192.168.4.5\SQLEXPRESS;Initial Catalog=MROInventorydb;User ID=sa;Password=Mexmei15!;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //RESPARLDO
        //Con1 = new SqlConnection(@"Data Source=MEX-W10-9SANKBV\SQLEXPRESS;Initial Catalog=dbsistema;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public SqlConnection Con1 { get => Con; set => Con = value; }

        /// <summary>
        /// Metodo para abrir la conexion con la base de datos
        /// </summary>
        public void Abrir() // Metodo para Abrir la Conexion
        {
            Con1.Open();
        }
        /// <summary>
        /// Metodo para cerrar la conexion con la base de datos
        /// </summary>
        public void Cerrar() // Metodo para Cerrar la Conexion
        {
            Con1.Close();
        }

        /// <summary>
        /// Metodo para llenar una DATAGRIDVIEW
        /// </summary>
        /// <param name="Comando"></param>
        /// <returns></returns>
        public DataSet LlenarDG(string Comando) // Metodo para Ejecutar Comandos
        {
            Abrir();
            DataSet DS = new DataSet(); // Creamos el DataSet que Devolvera el Metodo
            using (SqlDataAdapter CMD = new SqlDataAdapter(selectCommandText: Comando, selectConnection: Con1)) // Creamos un DataAdapter con el Comando y la Conexion
            {
                DS.Dispose();
                CMD.Fill(DS); // Ejecutamos el Comando en la Tabla
            }
            Cerrar();
            return DS; // Regresamos el DataSet
        }


        /// <summary>
        /// Metodo que regresa un valor dependiendo si se encontro en la base de datos, si no es asi regresa 0
        /// </summary>
        /// <param name="comando"></param>
        /// <returns></returns>
        public string ReturnValue(string comando)
        {
            string valor;
            try
            {
                Abrir();
                new SqlCommand(comando, Con1).ExecuteNonQuery();
                valor = new SqlCommand(comando, Con1).ExecuteScalar().ToString();
                if (valor == "")
                    valor = "0";
            }
            catch (Exception)
            {
                valor = "0";
            }
            Cerrar();
            return valor;
        }

        public string ReturnID(string comando)
        {
            string valor;
            try
            {
                Abrir();
                //CMD.ExecuteNonQuery();
                valor = new SqlCommand(comando, Con1).ExecuteScalar().ToString();
                if (valor == "")
                    valor = "0";
            }
            catch (Exception)
            {

                valor = "0";
            }
            Cerrar();
            return valor;
        }

        /// <summary>
        /// Metodo parar altas, baja, consultas y modificaciones
        /// </summary>
        /// <param name="comando"></param>
        public void Crud(string comando)
        {
            Cerrar();
            using (SqlCommand cmd = new SqlCommand(comando, Con1))
            {
                Abrir();
                cmd.ExecuteNonQuery();
            }
            Cerrar();
        }

        /// <summary>
        /// Metodo para leer y comparar los registros con la base de datos
        /// </summary>
        /// <param name="comando"></param>
        /// <returns></returns>
        public SqlDataReader Leer(string comando)
        {
            using (SqlCommand cmd = new SqlCommand(comando, Con1))
            {
                Abrir();
                SqlDataReader leer = cmd.ExecuteReader();
                return leer;
            }
        }

        /// <summary>
        /// Metodo para llenar un   COMBOBOX
        /// </summary>
        /// <param name="comando"></param>
        /// <returns></returns>
        public DataTable FillCB(string comando)
        {
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand(comando, Con1))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

        /// <summary>
        /// Metodo para Leer los datos de la Base de Datos
        /// </summary>
        /// <param name="query"></param>
        /// <param name="tabla"></param>
        /// <returns></returns>
        public DataView Leer_Datos(string query, string tabla)
        {
            DataSet res = new DataSet();

            try
            {
                SqlCommand cmd = new SqlCommand(query, Con1);

                Abrir();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(res, tabla);
                da.Dispose();

                Cerrar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //if (tabla.Contains("tb_Historial") == false)
            //    return ((DataTable)res.Tables["tb_ModeloOrden.id_modeloOrden, tb_ModeloOrden.scanmac, tb_ModeloOrden.scanimei, tb_ModeloOrden.id_orden , tb_Orden.orden, tb_caja.caja, tb_Ensamble.ensamble, tb_Operador.operador"]).DefaultView;
            //else
                return ((DataTable)res.Tables["tb_Usuario, tb_Ordenes, tb_Maquinas, tb_Vehiculos, tb_Departamentos"]).DefaultView;

        }

        /// <summary>
        /// Metodo Para saber si ya existe un registro
        /// </summary>
        /// <param name="comando"></param>
        /// <returns></returns>
        public bool Exists(string comando)
        {
            Cerrar();
            using (SqlCommand cmd = new SqlCommand(comando, Con1))
            {
                Abrir();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                Cerrar();
                if (count == 0)
                    return false;
                else
                    return true;
            }
        }

    } // Fin de la Clase
}

