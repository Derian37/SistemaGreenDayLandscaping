using CapaPresentacion.Reportes;
using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmReport : Form
    {
        DsGDL tempreporte = new DsGDL();
        DataGridView temporal = new DataGridView();
        double subtotal;
        double tax;
        double total;
        string name;
        string lastname;
        int id_usuario;
        string usuario;
        string cargo;
        int id_cliente;
        string address;

        public frmReport(DataGridView NuevoData,double subtotal, double tax, double total,string name, string lastname, int id_usuario, string usuario, string cargo, int id_cliente,string address)
        {
            this.id_usuario = id_usuario;
            this.usuario = usuario;
            this.cargo = cargo;
            this.id_cliente = id_cliente;
            this.temporal = NuevoData;
            this.subtotal = subtotal;
            this.tax = tax;
            this.total = total;
            this.name = name;
            this.lastname = lastname;
            this.address = address;


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
                                                              lastname,
                                                              address});
            }

            Report reporte = new Report();
            reporte.Load("../../Report.rpt");
            reporte.SetDataSource(tempreporte);

            crv_Report.ReportSource = reporte;
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBill cust = new frmBill(id_usuario, usuario, cargo,id_cliente);
            cust.Show();
            this.SetVisibleCore(false);
        }

        private void frmReporte_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
