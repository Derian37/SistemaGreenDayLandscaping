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
using SistemaGDL.CapaConexion;
using CapaLogica.LogicaNegocio;

namespace CapaLogica.Servicio
{
    public class ServicioCliente : servicio, IDisposable
    {
        private string respuesta;
        private MySqlCommand miComando;
        DateTime fecha = new DateTime();

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

            miComando.Parameters.Add("@staticPrice", MySqlDbType.Double);
            miComando.Parameters["@staticPrice"].Value = elCliente.StaticPrice;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion";

            Console.WriteLine(respuesta);
            Console.WriteLine("FIN Gestor Insertar Cliente");

            return respuesta;

        }

        public string InsertSaveBills(Cliente elCliente)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor Insert_saveBills");

            miComando.CommandText = "Insert_saveBills";

            miComando.Parameters.Add("@id_customer", MySqlDbType.Int32);
            miComando.Parameters["@id_customer"].Value = elCliente.Code;

            miComando.Parameters.Add("@fecha", MySqlDbType.Date);
            miComando.Parameters["@fecha"].Value = fecha.ToString("d");

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

            miComando.Parameters.Add("@staticPrice", MySqlDbType.Double);
            miComando.Parameters["@staticPrice"].Value = elCliente.StaticPrice;


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

            miComando.CommandText = "list_customerbyid";

            miComando.Parameters.AddWithValue("@id_customer", MySqlDbType.Int16);
            miComando.Parameters["@id_customer"].Value = Id_cliente;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public DataSet GetLastCustomer()
        {

            miComando.CommandText = "get_lastcustomer";


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

        public DataTable ListarClienteSinTarjeta(int id_cliente)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor list_savebillsbyid");

            miComando.CommandText = "list_savebillsbyid";
            miComando.Parameters.AddWithValue("@id_customer", MySqlDbType.Int16);
            miComando.Parameters["@id_customer"].Value = id_cliente;

            DataSet laGraduacion = new DataSet();
            this.abrirConexion();
            laGraduacion = this.seleccionarInformacion(miComando);
            DataTable miTablaDatos = laGraduacion.Tables[0];

            return miTablaDatos;
        }

        public DataSet GetBillByDate(int id_cliente, string Fecha1, string Fecha2)
        {
            miComando = new MySqlCommand();

            miComando.CommandText = "get_billbydate";

            miComando.Parameters.Add("@id_customer", MySqlDbType.Int16).Value=id_cliente;
            miComando.Parameters.Add("@fecha1", MySqlDbType.VarChar, 48).Value=Fecha1;
            miComando.Parameters.Add("@fecha2", MySqlDbType.VarChar,48).Value=Fecha2;

            DataSet DataSet = new DataSet();
            this.abrirConexion();
            DataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return DataSet;
        }

        public DataSet GetLastBill(int id_cliente)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor get_lastbill");

            miComando.CommandText = "get_lastbill";
            miComando.Parameters.AddWithValue("@id_customer", MySqlDbType.Int16);
            miComando.Parameters["@id_customer"].Value = id_cliente;

            DataSet DataSet = new DataSet();
            this.abrirConexion();
            DataSet = this.seleccionarInformacion(miComando);
            cerrarConexion();
            return DataSet;
        }

    }
}
