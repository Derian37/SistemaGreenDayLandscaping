using System;
using System.Data;
using SistemaGDL.CapaConexion;
using CapaLogica.LogicaNegocio;
using SistemaGDL.CapaLogica.Servicio;

namespace SistemaGDL.CapaIntegracion
{
    public class GestorVenta : servicio, IDisposable
    {
        public GestorVenta () { }

        public void Dispose() { }


        public string InsertarVenta(int id_bill, DateTime fecha, string detalle, double saldo, double total)
        {
            Venta nuevaVenta = new Venta(id_bill, fecha, detalle, saldo, total);
            using (ServicioVenta elVenta = new ServicioVenta())
                return elVenta.InsertarVenta(nuevaVenta);
        }

        public string InsertarNewVenta(int id_customer, int id_usuario, DateTime fecha, string detalle)
        {
            Venta nuevaVenta = new Venta(id_customer, id_usuario, fecha, detalle);
            using (ServicioVenta elVenta = new ServicioVenta())
                return elVenta.InsertarNewVenta(nuevaVenta);
        }

        public string InsertNewSaveBills(int id_customer, DateTime fecha, int bill)
        {
            Venta nuevaVenta = new Venta(id_customer, fecha, bill);
            using (ServicioVenta elVenta = new ServicioVenta())
                return elVenta.InsertNewSaveBills(nuevaVenta);
        }

        

        //public string InsertarDetalleVenta(int id_venta, string codigo, int cantidad, double precio, double subtotal, string estado)
        //{
        //    Venta nuevaVenta = new Venta(id_venta, codigo, cantidad, precio, subtotal, estado);
        //    using (ServicioVenta elVenta = new ServicioVenta())
        //        return elVenta.InsertarDetalleVenta(nuevaVenta);
        //}

        public string ModifyBill(int id_Venta, int id_cliente, DateTime fecha,string details, Double price, Double amount)
        {
            Venta Venta = new Venta(id_Venta, id_cliente, fecha,  details,  price,  amount);
            using (ServicioVenta elVenta = new ServicioVenta())
                return elVenta.ModifyBill(Venta);
        }

        /// <summary>
        /// Metodo Consultar Venta
        /// </summary>
        /// <param name="id_Venta"></param>
        /// <returns></returns>
        public DataTable ConsultarVenta(int id_cliente, int last_id)
        {
            using (ServicioVenta elVenta = new ServicioVenta())
                return elVenta.ConsultarVenta(id_cliente,last_id);
        }

        public DataTable ConsultarVentaE(int id_bill)
        {
            using (ServicioVenta elVenta = new ServicioVenta())
                return elVenta.ConsultarVentaE(id_bill);
        }

        /// <summary>
        /// Metodo ConsultarUltimoVenta
        /// </summary>
        /// <returns></returns>
        public DataSet ConsultarUltimoVenta()
        {
            using (ServicioVenta elVenta = new ServicioVenta())
                return elVenta.ConsultarUltimoVenta();
        }

        /// <summary>
        /// Metodo Listar Ventas
        /// </summary>
        /// <returns></returns>
        public DataTable ListarVentas()
        {
            using (ServicioVenta elVenta = new ServicioVenta())
                return elVenta.ListarVentas();
        }
        

    }
}

