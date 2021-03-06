﻿using System;
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
    public class GestorReportes : servicio, IDisposable
    {
        public GestorReportes() { }

        public void Dispose()
        {
        }

        public DataSet ReporteDia(string fecha)
        {
            using (ServicioReporte reporte = new ServicioReporte())
                return reporte.ReporteDia(fecha);
        }

        public DataSet ReporteSemanal(string fecha1, string fecha2)
        {
            using (ServicioReporte reporte = new ServicioReporte())
                return reporte.ReporteSemanal(fecha1, fecha2);
        }

        public DataSet ReporteMensual(string fecha1, string fecha2)
        {
            using (ServicioReporte reporte = new ServicioReporte())
                return reporte.ReporteMensual(fecha1, fecha2);
        }
    }
}
