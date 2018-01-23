using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProyectoOptica.CapaConexion;
using CapaLogica.LogicaNegocio;
using CapaLogica.Servicio;

namespace ProyectoOptica.CapaIntegracion
{
    public class GestorCliente : servicio, IDisposable

    {
        public GestorCliente() { }

        public void Dispose() { }

        public string InsertarCliente(string name, string lastname, string telephone, string address, string postalCode)
        {
            Cliente nuevoCliente = new Cliente( name,  lastname,  telephone,  address,  postalCode);
            using (ServicioCliente elCliente = new ServicioCliente())
                return elCliente.InsertarCliente(nuevoCliente);
        }

        public string ModificarCliente(int code, string name, string lastname, string telephone, string address, string postalCode)
        {
            Cliente nuevoCliente = new Cliente(code, name, lastname, telephone, address, postalCode);
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

        public DataTable ListarClienteSinTarjeta()
        {
            using (ServicioCliente elCliente = new ServicioCliente())
                return elCliente.ListarClienteSinTarjeta();
        }
    }
}
