using System;
using System.Data;
using System.Windows.Forms;
using SistemaBitacora.CapaIntegracion;
using System.Collections;

namespace CapaPresentacion
{
    public partial class frmConsulta : Form
    {
        string f1 = "";
        string f2 = "";
        string detalle = "";
        DataTable dtRegistro = new DataTable();
        DataSet dsRegistro = new DataSet();
     

        public frmConsulta()
        {
            InitializeComponent();
        }

   



        private void button1_Click(object sender, EventArgs e)
        {
          
            f1 = dtp_MesInicio.Text;
            f2 = dtp_MesFin.Text;
            if (radioButton1.Checked == true)
            {
                detalle = "DEPOSITO SOMOS VOZ";
            }
            if (radioButton2.Checked == true) {
                detalle = radioButton2.Text;
            }
            ConsultaMes(f1,f2,detalle);
        }

        private void ConsultaMes(string f1, string f2,string detalle)
        {
            try
            {
                string Fecha1 = "";
                string Fecha2 = "";
                string[] fechone;
                string[] fechtwo;

                f1 = f1.Replace("/", "-");
                f2 = f2.Replace("/", "-");
                fechone = f1.Split('-');
                fechtwo = f2.Split('-');

                foreach (string i in fechone)
                {
                    Fecha1 = fechone[2] + "-" + fechone[1] + "-" + fechone[0];
                }
                foreach (string i in fechtwo)
                {
                    Fecha2 = fechtwo[2] + "-" + fechtwo[1] + "-" + fechtwo[0];
                }
                using (GestorRegistro registro = new GestorRegistro())
                {
                    if (radioButton1.Checked == true)
                    {
                        this.dsRegistro = registro.ConsultarRegistro(Fecha1, Fecha2, detalle);

                    }
                    if (radioButton2.Checked == true)
                    {
                        this.dsRegistro = registro.ConsultarRegistroOtros(Fecha1, Fecha2);

                    }
                    this.dtRegistro = this.dsRegistro.Tables[0];

                    dgvDepositos.DataSource = this.dtRegistro;
                    dgvDepositos.Columns["detalle"].HeaderText = "Detalle";
                    dgvDepositos.Columns["monto"].HeaderText = "Monto";
                    dgvDepositos.Columns["fecha"].HeaderText = "Fecha";
                    dgvDepositos.Columns["estado"].HeaderText = "Estado";

                }
            }catch(Exception e)
            {
                MessageBox.Show("Debe elegir que consultar.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                Console.WriteLine(e);
            }
            Total();
            Limpiar();
        }

        private void Limpiar()
        {
            detalle = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            frmBitacora  frm_Principal = new frmBitacora();
            frm_Principal.Show();
            this.SetVisibleCore(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            f1 = fecha.ToString("yyyy-01-01");
            f2 = fecha.ToString("yyyy-12-31");
            if (radioButton3.Checked == true)
            {
                detalle = radioButton3.Text;
            }
            if (radioButton4.Checked == true)
            {
                detalle = radioButton4.Text;
            }
            ConsultaAnual(f1,f2, detalle);
        }

        private void ConsultaAnual(string f1, string f2, string detalle)
        {
            try{
                using (GestorRegistro registro = new GestorRegistro())
                {
                    if (radioButton3.Checked == true)
                    {
                        this.dsRegistro = registro.ConsultarRegistro(f1, f2, detalle);

                    }
                    if (radioButton4.Checked == true)
                    {
                        this.dsRegistro = registro.ConsultarRegistroOtros(f1, f2);

                    }
                    this.dtRegistro = this.dsRegistro.Tables[0];

                    dgvDepositos.DataSource = this.dtRegistro;
                    dgvDepositos.Columns["detalle"].HeaderText = "Detalle";
                    dgvDepositos.Columns["monto"].HeaderText = "Monto";
                    dgvDepositos.Columns["fecha"].HeaderText = "Fecha";
                    dgvDepositos.Columns["estado"].HeaderText = "Estado";

                }
            }catch(Exception e)
            {
                MessageBox.Show("Debe elegir que consultar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine(e);
            }
            Total();
            Limpiar();
        }

        private void Total()
        {
            Double suma=0;
            try
            {
                foreach (DataGridViewRow row in dgvDepositos.Rows)
                {
                    suma += Double.Parse(row.Cells["Monto"].Value.ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            textBox1.Text = suma.ToString();
            label5.Text = dgvDepositos.RowCount.ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void Imprimir()
        {
            if (textBox1.Text != "")
            {
                frmReporte reporte = new frmReporte(dgvDepositos, textBox1.Text, label5.Text);
                reporte.Show();
                this.SetVisibleCore(false);
            }
            else
            {
                MessageBox.Show("Debe eligir datos que desea Imprimir", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void frmConsulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }
}
