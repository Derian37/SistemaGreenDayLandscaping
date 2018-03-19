using CapaPresentacion.Reportes;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmReporte : Form
    {
        DsGDL tempreporte = new DsGDL();
        DataGridView temporal = new DataGridView();
        double subtotal;
        double tax;
        double total;
        string name;
        string lastname;

        public frmReporte(DataGridView NuevoData,double subtotal, double tax, double total,string name, string lastname)
        {
            this.temporal = NuevoData;
            this.subtotal = subtotal;
            this.tax = tax;
            this.total = total;
            this.name = name;
            this.lastname = lastname;


            InitializeComponent();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            Reportes();
        }

        private void Reportes()
        {
            int filas = temporal.RowCount;
            for (int i = 0; i <= filas - 1; i++)
            {
                tempreporte.Tables[0].Rows.Add(new object[] { temporal[1,i].Value.ToString(),
                                                              temporal[2,i].Value.ToString(),
                                                              temporal[3,i].Value.ToString(),
                                                              temporal[4,i].Value.ToString(),
                                                              subtotal,
                                                              tax,
                                                              total,
                                                              name,
                                                              lastname});
            }

            Report reporte = new Report();
            reporte.Load("../../Report.rpt");
            reporte.SetDataSource(tempreporte);

            crv_Report.ReportSource = reporte;
        }
    }
}
