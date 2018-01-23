using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// SistemaBitacora.CapaLogica.LogicaNegocio
/// </summary>
namespace SistemaBitacora.CapaLogica.LogicaNegocio
{
    /// <summary>
    /// Clase encargadad de suministrar atributos a los servicios de Registro.
    /// </summary>
    public class Registro
    {
        /// <summary>
        /// Region de Atributos.
        /// </summary>
        #region ATRIBUTOS
        private int id_registro;
        private string detalle;
        private float monto;
        private DateTime fecha;
        private string estado;
        #endregion ATRIBUTOS

        /// <summary>
        /// Constructor de la clase Registro para modificar datos.
        /// </summary>
        /// <param name="id_registro">Parametro de tipo entero</param>
        /// <param name="detalle">Parametro de tipo string</param>
        /// <param name="monto">Parametro de tipo float</param>
        /// <param name="fecha">Parametro de tipo DateTime</param>
        /// <param name="estado">Parametro de tipo string</param>
        public Registro(int id_registro, string detalle, float monto, DateTime fecha, string estado)
        {
            this.Id_registro = id_registro;
            this.Detalle = detalle;
            this.Monto = monto;
            this.Fecha = fecha;
            this.Estado = estado;

        }
        /// <summary>
        /// Constructor de la clase Registro para insertar datos.
        /// </summary>
        /// <param name="detalle">Parametro de tipo string</param>
        /// <param name="monto">Parametro de tipo float</param>
        /// <param name="fecha">Parametro de tipo DateTime</param>
        /// <param name="estado">Parametro de tipo string</param>
        public Registro(string detalle, float monto, DateTime fecha, string estado)
        {
            this.Detalle = detalle;
            this.Monto = monto;
            this.Fecha = fecha;
            this.Estado = estado;
        }
        /// <summary>
        /// Region de de Get y Set.
        /// </summary>
        #region Get y Set
        public int Id_registro { get => id_registro; set => id_registro = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        public float Monto { get => monto; set => monto = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Estado { get => estado; set => estado = value; }
        #endregion Get y Set
    }
}