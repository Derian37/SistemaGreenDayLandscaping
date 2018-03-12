using System;
using System.Data;
//Librerias MySql
using MySql.Data.MySqlClient;
//Bibliotecas del sistema
using SistemaGDL.CapaConexion;
using CapaLogica.LogicaNegocio;

namespace SistemaGDL.CapaLogica.Servicio
{
    /// <summary>
    /// 
    /// </summary>

    public class ServicioVenta : servicio, IDisposable
    {
        private string respuesta;
        private MySqlCommand miComando;

        public ServicioVenta()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }

        //Este metodo es solicitado por la interface IDisposable
        public void Dispose()
        {

        }

        //Metodo para la SP de insertar Venta
        public string InsertarVenta(Venta elVenta)
        {
            miComando = new MySqlCommand();

            Console.WriteLine("Gestor Insert_bills");

            miComando.CommandText = "Insert_bills";

            miComando.Parameters.Add("@id_bill", MySqlDbType.Int16);
            miComando.Parameters["@id_bill"].Value = elVenta.Id_bill;

            miComando.Parameters.Add("@fecha", MySqlDbType.DateTime);
            miComando.Parameters["@fecha"].Value = elVenta.Fecha;

            miComando.Parameters.Add("@details", MySqlDbType.VarChar);
            miComando.Parameters["@details"].Value = elVenta.Modo_pago;

            miComando.Parameters.Add("@servicePrice", MySqlDbType.Double);
            miComando.Parameters["@servicePrice"].Value = elVenta.Saldo;

            miComando.Parameters.Add("@amount", MySqlDbType.Double);
            miComando.Parameters["@amount"].Value = elVenta.Estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion";

            Console.WriteLine(respuesta);
            Console.WriteLine("FIN Gestor Insertar Venta");

            return respuesta;

        }

        //Metodo para la SP de insertar Venta
        public string InsertarNewVenta(Venta elVenta)
        {
            miComando = new MySqlCommand();

            Console.WriteLine("Gestor Insert_newBills");

            miComando.CommandText = "Insert_newBills";

            miComando.Parameters.Add("@id_customer", MySqlDbType.Int16);
            miComando.Parameters["@id_customer"].Value = elVenta.Id_cliente;

            miComando.Parameters.Add("@id_user", MySqlDbType.Int16);
            miComando.Parameters["@id_user"].Value = elVenta.Id_usuario;

            miComando.Parameters.Add("@fecha", MySqlDbType.DateTime);
            miComando.Parameters["@fecha"].Value = elVenta.Fecha;

            miComando.Parameters.Add("@details", MySqlDbType.VarChar);
            miComando.Parameters["@details"].Value = elVenta.Modo_pago;

      
            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion";

            Console.WriteLine(respuesta);
            Console.WriteLine("FIN Gestor Insertar Venta");

            return respuesta;

        }
        //Metodo para la SP de insertar Venta
        public string InsertNewSaveBills(Venta elVenta)
        {
            miComando = new MySqlCommand();

            Console.WriteLine("Gestor Insert_saveBills");

            miComando.CommandText = "Insert_saveBills";

            miComando.Parameters.Add("@id_customer", MySqlDbType.Int16);
            miComando.Parameters["@id_customer"].Value = elVenta.Id_cliente;

            miComando.Parameters.Add("@fecha", MySqlDbType.Date);
            miComando.Parameters["@fecha"].Value = elVenta.Fecha;

            miComando.Parameters.Add("@id_bill", MySqlDbType.Int32);
            miComando.Parameters["@id_bill"].Value = elVenta.Id_bill;


            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion";

            Console.WriteLine(respuesta);
            Console.WriteLine("FIN Gestor Insertar Venta");

            return respuesta;

        }

        public string ModifyBill(Venta Venta)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor modify_bill");

            miComando.CommandText = "modify_bill";

            miComando.Parameters.Add("@id_billf", MySqlDbType.Int32);
            miComando.Parameters["@id_billf"].Value = Venta.Id_venta;

            miComando.Parameters.Add("@id_bill", MySqlDbType.Int32);
            miComando.Parameters["@id_bill"].Value = Venta.Id_bill;
                        
            miComando.Parameters.Add("@fecha", MySqlDbType.DateTime);
            miComando.Parameters["@fecha"].Value = Venta.Fecha;

            miComando.Parameters.Add("@detalle", MySqlDbType.VarChar);
            miComando.Parameters["@detalle"].Value = Venta.Modo_pago;

            miComando.Parameters.Add("@precio", MySqlDbType.Double);
            miComando.Parameters["@precio"].Value = Venta.Precio;

            miComando.Parameters.Add("@monto", MySqlDbType.Double);
            miComando.Parameters["@monto"].Value = Venta.Saldo;

    

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor modify_bill");

            return respuesta;
        }

        //metodo para la SP de Modificar Venta
        public string InsertarDetalleVenta(Venta elVenta)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor modificar_Venta");

            miComando.CommandText = "insertar_DetalleVenta";

            miComando.Parameters.Add("@id_venta", MySqlDbType.Int16);
            miComando.Parameters["@id_venta"].Value = elVenta.Id_venta;

            miComando.Parameters.Add("@codigo", MySqlDbType.VarChar);
            miComando.Parameters["@codigo"].Value = elVenta.Codigo;

            miComando.Parameters.Add("@cantidad", MySqlDbType.Int16);
            miComando.Parameters["@cantidad"].Value = elVenta.Cantidad;

            miComando.Parameters.Add("@precio", MySqlDbType.Double);
            miComando.Parameters["@precio"].Value = elVenta.Precio;

            miComando.Parameters.Add("@subtotal", MySqlDbType.Double);
            miComando.Parameters["@subtotal"].Value = elVenta.Subtotal;

            miComando.Parameters.Add("@estado", MySqlDbType.VarChar);
            miComando.Parameters["@estado"].Value = elVenta.Estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Modificar Venta");

            return respuesta;
        }


        //metodo para el SP de Consultar Venta 
        public DataTable ConsultarVenta(int id_cliente, int last_id)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor list_Bills");

            miComando.CommandText = "list_Bills";
            miComando.Parameters.AddWithValue("@id_customer", MySqlDbType.Int16);
            miComando.Parameters["@id_customer"].Value = id_cliente;

            miComando.Parameters.AddWithValue("@last_id", MySqlDbType.Int16);
            miComando.Parameters["@last_id"].Value = last_id;

            DataSet laGraduacion = new DataSet();
            this.abrirConexion();
            laGraduacion = this.seleccionarInformacion(miComando);
            DataTable miTablaDatos = laGraduacion.Tables[0];

            return miTablaDatos;
        
        }

        public DataTable ConsultarVentaE(int id_bill)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor get_bill");

            miComando.CommandText = "get_bill";
            miComando.Parameters.AddWithValue("@id_bill", MySqlDbType.Int16);
            miComando.Parameters["@id_bill"].Value = id_bill;

            DataSet laGraduacion = new DataSet();
            this.abrirConexion();
            laGraduacion = this.seleccionarInformacion(miComando);
            DataTable miTablaDatos = laGraduacion.Tables[0];

            return miTablaDatos;

        }

        //metodo para el SP de ConsultarUltimoVenta 
        public DataSet ConsultarUltimoVenta()
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor ConsultarUltimoVenta");

            miComando.CommandText = "consultar_ultimoVenta";

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        //Metodo Listar Usuario
        public DataTable ListarVentas()
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor ListarVentas");

            miComando.CommandText = "listar_Ventas";

            DataSet elVenta = new DataSet();
            this.abrirConexion();
            elVenta = this.seleccionarInformacion(miComando);
            DataTable miTablaDatos = elVenta.Tables[0];

            return miTablaDatos;
        }
    }
}
