using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using System.Data;
using ProyectoOptica.CapaConexion;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSeleccionarInformacion()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "1234";
            builder.Database = "bd_registro";

            MySqlCommand comando = new MySqlCommand();
            comando.CommandTimeout = 2000;
            comando.Connection = new MySqlConnection(builder.ToString());
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "consulta_registro";
            comando.Parameters.AddWithValue("@fechone", new DateTime(2017, 11, 01));            
            comando.Parameters.AddWithValue("@fechtwo", new DateTime(2017, 11, 30));
            

            Servicio srv = new Servicio();
            DataSet ds = new DataSet();
            ds= srv.seleccionarInformacion(comando);
        }
        [TestMethod]
        public void TestInformacion()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "1234";
            builder.Database = "bd_registro";

            MySqlCommand comando = new MySqlCommand();
            comando.CommandTimeout = 2000;
            comando.Connection = new MySqlConnection(builder.ToString());
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "Test";

            comando.Parameters.AddWithValue("@Param1", MySqlDbType.Date);
            comando.Parameters["@Param1"].Value = new DateTime(2017, 11, 01);
            comando.Parameters.AddWithValue("@Param2", MySqlDbType.Date);
            comando.Parameters["@fechtwo"].Value = new DateTime(2017, 11, 30);


            Servicio srv = new Servicio();
            DataSet ds = new DataSet();
            ds = srv.seleccionarInformacion(comando);
        }


        [TestMethod]
        public void TesTraerInformacion()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "1234";
            builder.Database = "bd_registro";

            MySqlCommand comando = new MySqlCommand();
            comando.CommandTimeout = 2000;
            comando.Connection = new MySqlConnection(builder.ToString());
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT registro.detalle, registro.monto, registro.fecha, registro.estado FROM registro";

            Servicio srv = new Servicio();
            DataSet ds = new DataSet();
            ds = srv.seleccionarInformacion(comando);
        }
    }
}
