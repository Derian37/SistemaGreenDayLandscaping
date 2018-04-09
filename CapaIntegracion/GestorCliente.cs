using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SistemaGDL.CapaConexion;
using CapaLogica.LogicaNegocio;
using CapaLogica.Servicio;

namespace SistemaGDL.CapaIntegracion
{
    public class GestorCliente : servicio, IDisposable

    {
        public GestorCliente() { }

        public void Dispose() { }

        public string InsertarCliente(string name, string lastname, string telephone, string address, string postalCode, Double staticPrice)
        {
            Cliente nuevoCliente = new Cliente( name,  lastname,  telephone,  address,  postalCode, staticPrice);
            using (ServicioCliente elCliente = new ServicioCliente())
                return elCliente.InsertarCliente(nuevoCliente);
        }
        public string InsertSaveBills(int id_cliente)
        {
            Cliente nuevoCliente = new Cliente(id_cliente);
            using (ServicioCliente elCliente = new ServicioCliente())
                return elCliente.InsertSaveBills(nuevoCliente);
        }

        public string ModificarCliente(int code, string name, string lastname, string telephone, string address, string postalCode,Double staticPrice)
        {
            Cliente nuevoCliente = new Cliente(code, name, lastname, telephone, address, postalCode, staticPrice);
            using (ServicioCliente elCliente = new ServicioCliente())
                return elCliente.ModificarCliente(nuevoCliente);
        }

        public string ListarCliente(int id_cliente)

        {
            Cliente nuevoCliente = new Cliente();

            using (ServicioCliente elCliente = new ServicioCliente())
                return elCliente.ListarCliente(nuevoCliente);
        }
        public DataSet ConsultarCliente(int id_cliente)
        {
            using (ServicioCliente elCliente = new ServicioCliente())
                return elCliente.ConsultarCliente(id_cliente);
        }

        public DataSet ConsultarClienteCedula(string cedula)
        {
            using (ServicioCliente elCliente = new ServicioCliente())
                return elCliente.ConsultarClienteCedula(cedula);
        }

        public DataTable ListarCliente()
        {
            using (ServicioCliente elCliente = new ServicioCliente())
                return elCliente.ListarCliente();
        }

        public DataTable ListarClienteSinTarjeta(int id_cliente)
        {
            using (ServicioCliente elCliente = new ServicioCliente())
                return elCliente.ListarClienteSinTarjeta(id_cliente);
        }

        public DataSet GetLastCustomer()
        {
            using (ServicioCliente elCliente = new ServicioCliente())
                return elCliente.GetLastCustomer();
        }

        public DataSet GetBillByDate(int id_cliente,string Fecha1, string Fecha2)
        {
            using (ServicioCliente elCliente = new ServicioCliente())
                return elCliente.GetBillByDate(id_cliente,  Fecha1,  Fecha2);
        }
        public DataTable GetLastBill(int id_cliente)
        {
            using (ServicioCliente elCliente = new ServicioCliente())
                return elCliente.GetLastBill(id_cliente);
        }
        

    }
}
