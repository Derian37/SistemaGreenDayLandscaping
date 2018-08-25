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

namespace SistemaGDL.CapaLogica.Servicio
{
    /// <summary>
    /// Description of ServicioGasto.
    /// </summary>

    public class ServicioGasto : servicio, IDisposable
    {
        private string respuesta;
        private MySqlCommand miComando;

        public ServicioGasto()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }

        //Este metodo es solicitado por la interface IDisposable
        public void Dispose()
        {

        }

        //Metodo para la SP de insertar producto
        public string InsertarGasto(Gasto elGasto)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor Insert_newexpens");

            miComando.CommandText = "Insert_newexpens";

            miComando.Parameters.Add("@date", MySqlDbType.DateTime);
            miComando.Parameters["@date"].Value = elGasto.Fecha;

            miComando.Parameters.Add("@details", MySqlDbType.VarChar);
            miComando.Parameters["@details"].Value = elGasto.Detalle;

            miComando.Parameters.Add("@amount", MySqlDbType.VarChar);
            miComando.Parameters["@amount"].Value = elGasto.Total;


            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion";

            Console.WriteLine(respuesta);
            Console.WriteLine("FIN Gestor Insert_newexpens");

            return respuesta;

        }

        //metodo para la SP de Modificar Gasto
        public string ModificarProducto(Gasto elGasto)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor modify_expense");

            miComando.CommandText = "modify_expense";


            miComando.Parameters.Add("@id_expense", MySqlDbType.Int32);
            miComando.Parameters["@id_expense"].Value = elGasto.Id_expense;

            miComando.Parameters.Add("@date", MySqlDbType.DateTime);
            miComando.Parameters["@date"].Value = elGasto.Fecha;

            miComando.Parameters.Add("@details", MySqlDbType.VarChar);
            miComando.Parameters["@details"].Value = elGasto.Detalle;

            miComando.Parameters.Add("@amount", MySqlDbType.VarChar);
            miComando.Parameters["@amount"].Value = elGasto.Total;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor modify_expense");

            return respuesta;
        }



        public DataSet GetexpenseByDate(string Fecha1, string Fecha2)
        {
            miComando = new MySqlCommand();

            miComando.CommandText = "get_expbydate";
            miComando.Parameters.Add("@fecha1", MySqlDbType.VarChar, 48).Value = Fecha1;
            miComando.Parameters.Add("@fecha2", MySqlDbType.VarChar, 48).Value = Fecha2;

            DataSet DataSet = new DataSet();
            this.abrirConexion();
            DataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return DataSet;
        }

        //metodo para el SP de Consultar Gasto por codigo
        public DataSet ConsultarProductoCodigo(int id_expense)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor ConsultarProducto");

            miComando.CommandText = "consultar_productoCodigo";

            miComando.Parameters.Add("@id_expense", MySqlDbType.VarChar,128).Value = id_expense;
            //miComando.Parameters["@cod"].Value = cod;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }


        //Metodo Listar Usuario
        public DataTable ListarProductos()
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor list_expenses");

            miComando.CommandText = "list_expenses";

            DataSet elGasto = new DataSet();
            this.abrirConexion();
            elGasto = this.seleccionarInformacion(miComando);
            DataTable miTablaDatos = elGasto.Tables[0];

            return miTablaDatos;
        }
      
    }
}
