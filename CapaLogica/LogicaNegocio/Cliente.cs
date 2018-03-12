using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaLogica.LogicaNegocio
{

    public class Cliente
    {
        #region ATRIBUTOS
        private int code;
        private string name;
        private string lastName;
        private string telephone;
        private string address;
        private string postalCode;
        private double staticPrice;




        public int Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Address { get => address; set => address = value; }
        public string PostalCode { get => postalCode; set => postalCode = value; }
        public double StaticPrice { get => staticPrice; set => staticPrice = value; }


        #endregion ATRIBUTOS

        public Cliente()
        {
        }

        public Cliente(string name, string lastname, string telephone, string address, string postalCode,double staticPrice)
        {
            Name = name;
            LastName = lastname;
            Telephone = telephone;
            Address = address;
            PostalCode = postalCode;
            StaticPrice = staticPrice;



        }

        public Cliente(int code, string name, string lastname, string telephone, string address, string postalCode, double staticPrice)
        {
            Code = code;
            Name = name;
            LastName = lastname;
            Telephone = telephone;
            Address = address;
            PostalCode = postalCode;
            StaticPrice = staticPrice;
        }

        public Cliente(int code)
        {
            this.Code = code;
        }


    }
}