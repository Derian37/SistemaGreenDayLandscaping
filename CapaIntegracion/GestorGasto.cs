using System;
using System.Data;
using SistemaGDL.CapaConexion;
using CapaLogica.LogicaNegocio;
using SistemaGDL.CapaLogica.Servicio;

namespace SistemaGDL.CapaIntegracion
{
    public class GestorGasto : servicio, IDisposable
    {
        public GestorGasto() { }

        public void Dispose() { }


        public string InsertarGasto(DateTime fecha, string detalle, string total)
        {
            Gasto nuevoGasto = new Gasto(fecha, detalle, total);
            using (ServicioGasto elGasto = new ServicioGasto())
                return elGasto.InsertarGasto(nuevoGasto);
        }

        public string ModificarGasto(int id_Expense,DateTime fecha, string detalle, string total)
        {
            Gasto modificarProducto = new Gasto(id_Expense, fecha, detalle, total);
            using (ServicioGasto elProducto = new ServicioGasto())
                return elProducto.ModificarProducto(modificarProducto);
        }





        /// <summary>
        /// Metodo Listar Productos
        /// </summary>
        /// <returns></returns>
        public DataTable ListarGastos()
        {
            using (ServicioGasto elGasto = new ServicioGasto())
                return elGasto.ListarProductos();
        }

        public DataSet GetexpenseByDate(string Fecha1, string Fecha2)
        {
            using (ServicioGasto elGasto = new ServicioGasto())
                return elGasto.GetexpenseByDate(Fecha1, Fecha2);
        }





    }
}

