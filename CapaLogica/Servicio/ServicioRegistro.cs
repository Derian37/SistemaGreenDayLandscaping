using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using SistemaBitacora.CapaConexion;
using SistemaBitacora.CapaLogica.LogicaNegocio;
/// <summary>
/// SistemaBitacora.CapaLogica.Servicio
/// </summary>
namespace SistemaBitacora.CapaLogica.Servicio
{
    /// <summary>
    /// Clase que suministra los servicios al gestor de Registro,
    /// esta clase contiene enlaze directo con la base de datos 
    /// y los procedimientos almacenados.
    /// </summary>
    public class ServicioRegistro : servicio, IDisposable
    {
        #region
        private string respuesta;
        private MySqlCommand miComando;
        #endregion

        /// <summary>
        /// Constructor de la clase ServicioRegistro.
        /// </summary>
        public ServicioRegistro()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }
        /// <summary>
        ///  Metodo encargado de liberár mas rápido la memoria.
        /// </summary>
        public void Dispose()
        {

        }
        /// <summary>
        /// Función de tipo string encargada de insertar o guardar en la base de datos.
        /// </summary>
        /// <param name="elRegistro">Parametro de tipo objeto Registro que trae los atributos necesarios</param>
        /// <returns>Retorna el procedimiento almacenado Completado</returns>
        public string InsertarRegistro(Registro elRegistro)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor insertar_registro");

            miComando.CommandText = "insertar_registro";

            miComando.Parameters.Add("@detalle", MySqlDbType.VarChar);
            miComando.Parameters["@detalle"].Value = elRegistro.Detalle;

            miComando.Parameters.Add("@monto", MySqlDbType.Float);
            miComando.Parameters["@monto"].Value = elRegistro.Monto;

            miComando.Parameters.Add("@fecha", MySqlDbType.DateTime);
            miComando.Parameters["@fecha"].Value = elRegistro.Fecha;

            miComando.Parameters.Add("@estado", MySqlDbType.VarChar);
            miComando.Parameters["@estado"].Value = elRegistro.Estado;

           respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion";

            Console.WriteLine(respuesta);
            Console.WriteLine("FIN Gestor Insertar Tarjeta");

            return respuesta;

        }

        /// <summary>
        /// Función de tipo string encargada de modificar un registro en la base de datos.
        /// </summary>
        /// <param name="elRegistro">Parametro de tipo objeto Registro que trae los atributos necesarios</param>
        /// <returns>Retorna el procedimiento almacenado Completado</returns>
        public string ModificarRegistro(Registro elRegistro)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor modifica_registro");

            miComando.CommandText = "modifica_registro";

            miComando.Parameters.Add("@id_registro", MySqlDbType.Int64);
            miComando.Parameters["@id_registro"].Value = elRegistro.Id_registro;

            miComando.Parameters.Add("@detalle", MySqlDbType.VarChar);
            miComando.Parameters["@detalle"].Value = elRegistro.Detalle;

            miComando.Parameters.Add("@monto", MySqlDbType.Float);
            miComando.Parameters["@monto"].Value = elRegistro.Monto;

            miComando.Parameters.Add("@fecha", MySqlDbType.Date);
            miComando.Parameters["@fecha"].Value = elRegistro.Fecha;

            miComando.Parameters.Add("@estado", MySqlDbType.VarChar);
            miComando.Parameters["@estado"].Value = elRegistro.Estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor modificar_registro");

            return respuesta;
        }

        /// <summary>
        /// Función de tipo DataSet encargada de realizar una consulta a la base de datos.
        /// </summary>
        /// <param name="fecha1">Parametro de tipo string</param>
        /// <param name="fecha2">Parametro de tipo string</param>
        /// <param name="detalle">Parametro de tipo string</param>
        /// <returns>Un DataSet con datos de la consulta</returns>
        public DataSet ConsultarRegistro(string fecha1, string fecha2, string detalle)
        {        
            miComando = new MySqlCommand();

            miComando.CommandText = "consulta_registro";
            miComando.Parameters.Add("@fechone", MySqlDbType.VarChar, 48).Value = fecha1;
            miComando.Parameters.Add("@fechtwo", MySqlDbType.VarChar, 48).Value = fecha2;
            miComando.Parameters.Add("@det", MySqlDbType.VarChar, 48).Value = detalle;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;


        }

        /// <summary>
        /// Función de tipo DataSet encargada de realizar una consulta a la base de datos.
        /// </summary>
        /// <param name="fecha1">Parametro de tipo string</param>
        /// <param name="fecha2">Parametro de tipo string</param>
        /// <returns>Un DataSet con datos de la consulta</returns>
        public DataSet ConsultarRegistroOtros(string fecha1, string fecha2)
        {
            miComando = new MySqlCommand();

            miComando.CommandText = "consulta_registroOtros";
            miComando.Parameters.Add("@fechone", MySqlDbType.VarChar, 48).Value = fecha1;
            miComando.Parameters.Add("@fechtwo", MySqlDbType.VarChar, 48).Value = fecha2;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;


        }

        /// <summary>
        /// Función de tipo DataSet encargada de realizar una consulta a la base de datos para realizar la funcion de filtro.
        /// </summary>
        /// <param name="detalle">Parametro de tipo string</param>
        /// <returns>Un DataSet con datos de la consulta</returns>
        public DataSet ConsultarDetalle(string detalle)
        {
            miComando = new MySqlCommand();

            miComando.CommandText = "consulta_detalle";
            miComando.Parameters.Add("@det", MySqlDbType.VarChar, 48).Value = detalle;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;


        }

        /// <summary>
        /// Metodo Listar Registros de la base de datos de tipo string.
        /// </summary>
        /// <param name="elRegistro">Parametro de tipo objeto Registro que trae los atributos necesarios</param>
        /// <returns>Un DataTable con datos de la consulta</returns>
        public string ListarRegistro(Registro elRegistro)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor listar_registro");

            miComando.CommandText = "listar_registro";

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion";

            Console.WriteLine(respuesta);
            Console.WriteLine("FIN Gestor listar_registro");

            return respuesta;
        }

        /// <summary>
        /// Metodo Listar Registros de la base de datos de tipo datatable.
        /// </summary>
        /// <returns>Un DataTable con datos de la consulta</returns>
        public DataTable ListarRegistro()
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor listar_registro");

            miComando.CommandText = "listar_registro";

            DataSet elRegistro = new DataSet();
            this.abrirConexion();
            elRegistro = this.seleccionarInformacion(miComando);
            DataTable miTablaDatos = elRegistro.Tables[0];

            return miTablaDatos;
        }

        /// <summary>
        /// Metodo Listar Registros de la base de datos de tipo datatable.
        /// </summary>
        /// <returns>Un DataTable con datos de la consulta</returns>
        public DataTable ListarRegistroEliminado()
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor listar_registro_eliminado");

            miComando.CommandText = "listar_registro_eliminado";

            DataSet elRegistro = new DataSet();
            this.abrirConexion();
            elRegistro = this.seleccionarInformacion(miComando);
            DataTable miTablaDatos = elRegistro.Tables[0];

            return miTablaDatos;
        }
        /// <summary>
        /// Metodo EliminarDato se encarga de eliminar los datos "eliminados" de la base de datos.
        /// </summary>
        /// <returns></returns>
        public string EliminarDato()
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor eliminar_registros");

            miComando.CommandText = "eliminar_registros";

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se han borrado los datos de la base de datos correctamente";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor eliminar_registros");

            return respuesta;
        }
        /// <summary>
        /// Metodo que se encarga de vaciar la base de datos, dejando la bitacora totalmente de fabrica.
        /// </summary>
        /// <returns></returns>
        public string VaciarBaseDatos()
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor vaciar_registro");

            miComando.CommandText = "vaciar_registro";

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se han borrado todos los datos de la base de datos correctamente";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor vaciar_registro");

            return respuesta;
        }
        
    }
}
