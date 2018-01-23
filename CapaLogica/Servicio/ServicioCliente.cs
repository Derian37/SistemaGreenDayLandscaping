using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Librerias MySql
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
//Bibliotecas del sistema
using ProyectoOptica.CapaConexion;
using CapaLogica.LogicaNegocio;

namespace CapaLogica.Servicio
{
    public class ServicioCliente : servicio, IDisposable
    {
        private string respuesta;
        private MySqlCommand miComando;

        public ServicioCliente()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }

        public void Dispose()
        {

        }

        public string InsertarCliente(Cliente elCliente)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor Insert_Customers");

            miComando.CommandText = "Insert_Customers";

            miComando.Parameters.Add("@name", MySqlDbType.VarChar);
            miComando.Parameters["@name"].Value = elCliente.Name;

            miComando.Parameters.Add("@lastName", MySqlDbType.VarChar);
            miComando.Parameters["@lastName"].Value = elCliente.LastName;

            miComando.Parameters.Add("@telephone", MySqlDbType.VarChar);
            miComando.Parameters["@telephone"].Value = elCliente.Telephone;

            miComando.Parameters.Add("@address", MySqlDbType.VarChar);
            miComando.Parameters["@address"].Value = elCliente.Address;

            miComando.Parameters.Add("@postalCode", MySqlDbType.Int32);
            miComando.Parameters["@postalCode"].Value = elCliente.PostalCode;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion";

            Console.WriteLine(respuesta);
            Console.WriteLine("FIN Gestor Insertar Cliente");

            return respuesta;

        }

        public string ModificarCliente(Cliente elCliente)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor Costum_Customers");

            miComando.CommandText = "Costum_Customers";

            miComando.Parameters.Add("@code", MySqlDbType.VarChar);
            miComando.Parameters["@code"].Value = elCliente.Code;

            miComando.Parameters.Add("@name", MySqlDbType.VarChar);
            miComando.Parameters["@name"].Value = elCliente.Name;

            miComando.Parameters.Add("@lastName", MySqlDbType.VarChar);
            miComando.Parameters["@lastName"].Value = elCliente.LastName;

            miComando.Parameters.Add("@telephone", MySqlDbType.VarChar);
            miComando.Parameters["@telephone"].Value = elCliente.Telephone;

            miComando.Parameters.Add("@address", MySqlDbType.VarChar);
            miComando.Parameters["@address"].Value = elCliente.Address;

            miComando.Parameters.Add("@postalCode", MySqlDbType.Int32);
            miComando.Parameters["@postalCode"].Value = elCliente.PostalCode;


            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor modificar_cliente");

            return respuesta;
        }
        public string InactivarCliente(Cliente elCliente)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor InactivarCliente");

            miComando.CommandText = "InactivarCliente";

            miComando.Parameters.Add("@code", MySqlDbType.Int16);
            miComando.Parameters["@code"].Value = elCliente.Code;


            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "se ha realizado correctamente la inactivacion";

            Console.WriteLine(respuesta);
            Console.WriteLine("FIN Gestor Inactivar Estudiante ");
            return respuesta;
        }



        public string ConsultarCliente(Cliente elCliente)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor consultar_cliente");

            miComando.CommandText = "consultar_cliente";

            miComando.Parameters.Add("@id_client", MySqlDbType.Int16);
            miComando.Parameters["@id_client"].Value = elCliente.Code;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion";

            Console.WriteLine(respuesta);
            Console.WriteLine("FIN Gestor consultar_cliente");

            return respuesta;
        }

        public DataSet ConsultarCliente(int Id_cliente)
        {

            miComando.CommandText = "consultar_cliente";

            miComando.Parameters.AddWithValue("@id_client", MySqlDbType.Int16);
            miComando.Parameters["@id_client"].Value = Id_cliente;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public DataSet ConsultarClienteCedula(string cedula)
        {

            miComando.CommandText = "consultar_clienteCedula";

            miComando.Parameters.AddWithValue("@ced", MySqlDbType.Int16);
            miComando.Parameters["@ced"].Value = cedula;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }


        public string ListarCliente(Cliente elCliente)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor listar_cliente");

            miComando.CommandText = "listar_cliente";

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion";

            Console.WriteLine(respuesta);
            Console.WriteLine("FIN Gestor listar_cliente");

            return respuesta;
        }
        //Metodo Listar Usuario
        public DataTable ListarCliente()
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor list_customers");

            miComando.CommandText = "list_customers";

            DataSet elCliente = new DataSet();
            this.abrirConexion();
            elCliente = this.seleccionarInformacion(miComando);
            DataTable miTablaDatos = elCliente.Tables[0];

            return miTablaDatos;
        }

        public DataTable ListarClienteSinTarjeta()
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor listarClienteSinTarjeta");

            miComando.CommandText = "listarClienteSinTarjeta";

            DataSet elCliente = new DataSet();
            this.abrirConexion();
            elCliente = this.seleccionarInformacion(miComando);
            DataTable miTablaDatos = elCliente.Tables[0];

            return miTablaDatos;
        }

    }
}
