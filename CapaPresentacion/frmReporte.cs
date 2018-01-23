using CapaPresentacion.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmReporte : Form
    {
        DsRegistro tempreporte = new DsRegistro();
        DataGridView temporal = new DataGridView();
        string total = "";
        string cantidad = "";
    
        public frmReporte(DataGridView NuevoData,string total, string cantidad)
        {
            this.total = total;
            this.cantidad = cantidad;
            this.temporal = NuevoData;
            InitializeComponent();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            Reportes();
        }

        private void Reportes()
        {
            int filas = temporal.RowCount;
            for (int i=0; i<= filas-1;i++) {
                tempreporte.Tables[0].Rows.Add(new object[] { temporal[0,i].Value.ToString(),
                                                              temporal[1,i].Value.ToString(),
                                                              temporal[2,i].Value.ToString(),
                                                              temporal[3,i].Value.ToString(),
                                                              total,
                                                              cantidad});
            }
            Reporte report = new Reporte();
            report.Load("../../Reporte.rpt");
            report.SetDataSource(tempreporte);
           
            crv_Saldos.ReportSource = report;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            frmConsulta consulta = new frmConsulta();
            consulta.Show();
            this.SetVisibleCore(false);
        }

        private void frmReporte_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
