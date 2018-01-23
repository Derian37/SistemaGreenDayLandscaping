using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaBitacora.CapaConexion;
using SistemaBitacora.CapaLogica.Servicio;
using SistemaBitacora.CapaLogica.LogicaNegocio;
using System.Data;
/// <summary>
/// SistemaBitacora.CapaIntegracion
/// </summary>
namespace SistemaBitacora.CapaIntegracion
{
    /// <summary>
    /// Clase encargada de realizar el enalze de las funciones o metodos del sistema con los de la Base de datos.
    /// </summary>
    public class GestorRegistro : servicio, IDisposable

    {
        /// <summary>
        /// Constructor Vacio.
        /// </summary>
        public GestorRegistro() { }

        /// <summary>
        /// Metodo encargado de liberár mas rápido la memoria.
        /// </summary>
        public void Dispose() { }

        /// <summary>
        /// Función de tipo string encargada de enlazar datos al servicio encargado de insertar o guardar en la base de datos.
        /// </summary>
        /// <param name="detalle">Parametro de tipo string</param>
        /// <param name="monto">Parametro de tipo float</param>
        /// <param name="fecha">Parametro de tipo DateTime</param>
        /// <param name="estado">Parametro de tipo string</param>
        /// <returns>Un Registro nuevo guardado en la Base de datos</returns>
        public string InsertarRegistro(string detalle, float monto, DateTime fecha, string estado)
        {
            CapaLogica.LogicaNegocio.Registro nuevoRegistro = new Registro(detalle, monto, fecha, estado);
            using (ServicioRegistro elRegistro = new ServicioRegistro())
                return elRegistro.InsertarRegistro(nuevoRegistro);
        }
        /// <summary>
        ///  Función de tipo string encargada de enlazar datos al servicio encargado de modificar en la base de datos.
        /// </summary>
        /// <param name="id_registro">Parametro de tipo entero</param>
        /// <param name="detalle">Parametro de tipo string</param>
        /// <param name="monto">Parametro de tipo float</param>
        /// <param name="fecha">Parametro de tipo DateTime</param>
        /// <param name="estado">Parametro de tipo string</param>
        /// <returns>Un Registro Modificado</returns>
        public string ModificarTarjeta(int id_registro,string detalle, float monto, DateTime fecha, string estado)
        {
            CapaLogica.LogicaNegocio.Registro modificaRegistro = new Registro(id_registro, detalle, monto, fecha, estado);
            using (ServicioRegistro elRegistro = new ServicioRegistro())
                return elRegistro.ModificarRegistro(modificaRegistro);
        }

        /// <summary>
        /// Función de tipo DataSet encargada de enlazar datos al servicio encargado de realizar una consulta a la base de datos.
        /// </summary>
        /// <param name="fecha1">Parametro de tipo string</param>
        /// <param name="fecha2">Parametro de tipo string</param>
        /// <param name="detalle">Parametro de tipo string</param>
        /// <returns>Un DataSet con datos de la consulta</returns>
        public DataSet ConsultarRegistro(string fecha1, string fecha2, string detalle)
        {

            using (ServicioRegistro elRegistro = new ServicioRegistro())
                return elRegistro.ConsultarRegistro(fecha1, fecha2, detalle);
        }

        /// <summary>
        /// Función de tipo DataSet encargada de enlazar datos al servicio encargado de realizar una consulta a la base de datos.
        /// </summary>
        /// <param name="fecha1">Parametro de tipo string</param>
        /// <param name="fecha2">Parametro de tipo string</param>
        /// <returns>Un DataSet con datos de la consulta</returns>
        public DataSet ConsultarRegistroOtros(string fecha1, string fecha2)
        {

            using (ServicioRegistro elRegistro = new ServicioRegistro())
                return elRegistro.ConsultarRegistroOtros(fecha1, fecha2);
        }

        /// <summary>
        /// Función de tipo DataSet encargada de enlazar datos al servicio encargado de realizar una consulta a la base de datos.
        /// </summary>
        /// <param name="detalle">Parametro de tipo string</param>
        /// <returns>Un DataSet con datos de la consulta</returns>
        public DataSet ConsultarDetalle(string detalle)
        {

            using (ServicioRegistro elRegistro = new ServicioRegistro())
                return elRegistro.ConsultarDetalle(detalle);
        }

        /// <summary>
        /// Metodo Listar Registros de la base de datos de tipo datatable.
        /// </summary>
        /// <returns>Un DataTable con datos de la consulta</returns>
        public DataTable ListarRegistro()
        {
            using (ServicioRegistro elRegistro = new ServicioRegistro())
                return elRegistro.ListarRegistro();
        }

        /// <summary>
        /// Metodo Listar Registros Eliminados de tipo datatable
        /// </summary>
        /// <returns>Un DataTable con datos de la consulta</returns>
        public DataTable ListarRegistroEliminado()
        {
            using (ServicioRegistro elRegistro = new ServicioRegistro())
                return elRegistro.ListarRegistroEliminado();
        }
        /// <summary>
        /// Metodo EliminarDato se encarga de enlazar al servicio encargado de eliminar los datos "eliminados" de la base de datos.
        /// </summary>
        /// <returns></returns>
        public string EliminarDato()
        {
            using (ServicioRegistro elRegistro = new ServicioRegistro())
                return elRegistro.EliminarDato();
        }
        /// <summary>
        /// Metodo que se encarga de enlazar al servicio que esta encargado vacia la base de datos, dejando la bitacora totalmente de fabrica.
        /// </summary>
        /// <returns></returns>
        public string VaciarBaseDatos() {
            using (ServicioRegistro elRegistro = new ServicioRegistro())
                return elRegistro.VaciarBaseDatos();
        }
    }
}
