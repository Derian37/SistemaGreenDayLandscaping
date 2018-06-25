using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGDL.CapaIntegracion;

namespace CapaPresentacion
{
    public partial class frmListaClientes : Form
    {
        string f1 = "";
        string f2 = "";
        DataTable dtRegistro = new DataTable();
        DataSet dsRegistro = new DataSet();

        int id_usuario;
        int id_lastbill = 0;
        bool bandera = false;
        string usuario;
        string cargo;
        int id_cliente = 0;
        public frmListaClientes(int id_usuario, string usuario, string cargo, int id_cliente)
        {
            this.id_usuario = id_usuario;
            this.usuario = usuario;
            this.cargo = cargo;
            this.id_cliente = id_cliente;
            InitializeComponent();
        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            CargarGridCliente();
            CargarUltimoIdBill();
           
        }

        private void CargarUltimoIdBill()
        {
            try
            {
                using (GestorCliente elCliente = new GestorCliente())
                {
                    id_lastbill = int.Parse(elCliente.GetLastBill(id_cliente).Rows[0][0].ToString());
                }
            }
            catch (Exception l) {
               
                Console.Write(l);
                MessageBox.Show("Este cliente no posee registros");
            }
        }

        private void CargarGridCliente()
        {
            using (GestorCliente elCliente = new GestorCliente())
            {
                dgvCliente.DataSource = elCliente.ListarClienteSinTarjeta(id_cliente);
                dgvCliente.Columns["id_bill"].Visible = false;
                dgvCliente.Columns["name"].HeaderText = "Name";
                dgvCliente.Columns["details"].HeaderText = "Details" ;
                dgvCliente.Columns["fecha"].HeaderText = "Date";

            }
        }
         private void btnExpediente_Click(object sender, EventArgs e)
        {
            if (bandera == true)
            {
                try
                {
                    bandera = false;
                    FrmVentasModificar FrmVentasModificar = new FrmVentasModificar(id_usuario, id_cliente, int.Parse(label_id.Text), usuario,cargo, id_cliente);
                    FrmVentasModificar.Show();
                    this.SetVisibleCore(false);
                }
                catch (Exception u)
                {
                    Console.Write(u);
                  
                }
            }
            else {
                MessageBox.Show("No ha elegido un cliente", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void grbInformacion_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmListaClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente cust = new frmCliente(id_usuario,usuario,cargo);
            cust.Show();
            this.SetVisibleCore(false);
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bandera = true;
            label_id.Text = dgvCliente.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString();
            textBox2.Text = dgvCliente.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dgvCliente.CurrentRow.Cells[1].Value.ToString();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmVentasModificar FrmVentasModificar = new FrmVentasModificar(id_usuario, id_cliente,id_lastbill,usuario,cargo, id_cliente);
            FrmVentasModificar.Show();
            this.SetVisibleCore(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox5.Text != "")
                {
                    using (GestorVenta venta = new GestorVenta())
                    {
                        venta.InsertarNewVenta(id_cliente, id_usuario, DateTime.Parse("2018-02-01").ToString(), textBox5.Text);
                        CargarUltimoIdBill();
                    }
                  
                    FrmVentasNuevas FrmVentasNuevas = new FrmVentasNuevas(id_usuario, id_cliente, id_lastbill, usuario, cargo, id_cliente);
                    FrmVentasNuevas.Show();
                    this.SetVisibleCore(false);
                }
                else
                {
                    MessageBox.Show("No ha llenado el campo de detalle", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            catch (Exception o) {
                Console.Write(o);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            f1 = dateTimePicker1.Value.ToString("dd/MM/yyyy"); ;
            f2 = dateTimePicker2.Value.ToString("dd/MM/yyyy"); ;
            consultafecha(f1, f2);
        }

        private void consultafecha(string f1, string f2)
        {
            string Fecha1 = "";
            string Fecha2 = "";
            string[] fechone;
            string[] fechtwo;

            f1 = f1.Replace(" ", "-");
            f2 = f2.Replace(" ", "-");
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

            using (GestorCliente customer = new GestorCliente())
            {
                this.dsRegistro = customer.GetBillByDate(int.Parse(id_cliente.ToString()), Fecha1, Fecha2);
                this.dtRegistro = this.dsRegistro.Tables[0];
                dgvCliente.DataSource = dtRegistro;
                dgvCliente.Columns["id_saveBills"].Visible = false;
                dgvCliente.Columns["name"].HeaderText = "Name";
                dgvCliente.Columns["details"].HeaderText = "Details";
                dgvCliente.Columns["fecha"].HeaderText = "Date";

            }
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            CargarGridCliente();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bandera == true)
            {
                try
                {
                    bandera = false;
                    FrmVentasModificar FrmVentasModificar = new FrmVentasModificar(id_usuario, id_cliente, int.Parse(label_id.Text), usuario, cargo, id_cliente);
                    FrmVentasModificar.Show();
                    this.SetVisibleCore(false);
                }
                catch (Exception u)
                {
                    Console.Write(u);

                }
            }
            else
            {
                MessageBox.Show("No ha elegido un cliente", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
