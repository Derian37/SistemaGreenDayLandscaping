﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

/// <summary>
/// SistemaBitacora.CapaConexion
/// </summary>
namespace SistemaBitacora.CapaConexion
{
    /// <summary>
    /// Clase Servicio encargada de realizar la Conexion con la Base de Datos.
    /// </summary>
    public class servicio
    {
        #region
        protected MySqlConnection conexion;
        protected MySqlCommand cmd;
        #endregion

        /// <summary>
        /// Constructor de la clase Servicio.
        /// </summary>
        public servicio()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "1234";
            builder.Database = "bd_registro";
            conexion = new MySqlConnection(builder.ToString());
        }

        /// <summary>
        /// Metodo encarado de abrir una conexion.
        /// </summary>
        protected void abrirConexion()
        {
            conexion.Open();
        }


        /// <summary>
        /// Metodo encarado de cerrar la conexion.
        /// </summary>
        protected void cerrarConexion()
        {
            conexion.Close();
        }


        /// <summary>
        /// Metodo encarado de ejecutar la sentencia que se le envie.
        /// </summary>
        /// <param name="sentencia">Parametro de tipo string</param>
        /// <returns></returns>
        protected string ejecutaSentencia(string sentencia)
        {
            MySqlCommand comando = conexion.CreateCommand();
            comando.CommandText = sentencia;
            try
            {
                this.abrirConexion();
                comando.ExecuteScalar();
            }
            catch (Exception Error)
            {
                this.cerrarConexion();
                return Error.Message;
            }

            this.cerrarConexion();
            return "";

        }
        /// <summary>
        ///  Metodo encarado dela sentencia que se le envie de tipo MySqlCommand.
        /// </summary>
        /// <param name="comando">Parametro de tipo MySqlCommand</param>
        /// <returns></returns>
        protected string ejecutaSentencia(MySqlCommand comando)
        {
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandTimeout = 6000;

            try
            {
                this.abrirConexion();
                comando.ExecuteScalar();
            }
            catch (Exception Error)
            {
                this.cerrarConexion();
                return Error.Message;
            }
            this.cerrarConexion();
            return "";
        }

        /// <summary>
        /// Metodo encarado de selecciona la informacion que se le solicite dependiendo de la sentencia.
        /// </summary>
        /// <param name="sentencia">Parametro de tipo string</param>
        /// <returns>Un DataSet con la informacion que retorna la sentencia</returns>
        protected DataSet seleccionarInformacion(string sentencia)
        {
            DataSet miDataSet = new DataSet();
            MySqlCommand miSqlCommand = conexion.CreateCommand();

            miSqlCommand.CommandText = sentencia;
            MySqlDataAdapter miSqlDataAdapter = new MySqlDataAdapter();

            miSqlDataAdapter.SelectCommand = miSqlCommand;
            miSqlDataAdapter.Fill(miDataSet);

            return miDataSet;
        }

        /// <summary>
        /// Metodo encarado de seleccionar la informacion que se le solicite dependiendo del comando MySQL
        /// </summary>
        /// <param name="comando">Parametro de tipo MySqlCommand</param>
        /// <returns>Un DataSet con la informacion que retorna la sentencia</returns>
        public DataSet seleccionarInformacion(MySqlCommand comando)
        {
            DataSet miDataSet = new DataSet();
            MySqlDataAdapter miSqlDataAdapter = new MySqlDataAdapter();
            comando.CommandTimeout = 2000;
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            miSqlDataAdapter.SelectCommand = comando;
            miSqlDataAdapter.Fill(miDataSet);

            return miDataSet;
        }
    }
}