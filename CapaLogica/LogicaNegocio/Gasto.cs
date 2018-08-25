
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.LogicaNegocio
{
    /// <summary>
    /// Description of Gasto.
    /// </summary>

    public class Gasto
    {
        #region ATRIBUTOS
        private int id_expense;
        private DateTime fecha;
        private string detalle;
        private string total;
   


        #endregion ATRIBUTOS

        #region CONSTRUCTOR
        public Gasto()
        {
        }
        public Gasto(int id_expense, DateTime fecha, string detalle, string total)
        {
            Id_expense = id_expense;
            Fecha = fecha;
            Detalle = detalle;
            Total = total;
        }

        public Gasto(DateTime fecha, string detalle, string total)
        {
            Fecha = fecha;
            Detalle = detalle;
            Total = total;
        }
        public Gasto(int id_expense)
        {
            Id_expense = id_expense;
           
        }


        //constructor para el procedimiento almacenado de insertar



        #endregion CONSTRUCTOR

        #region get y set


        public int Id_expense { get => id_expense; set => id_expense = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        public string Total { get => total; set => total = value; }

        #endregion get y set


    }

}