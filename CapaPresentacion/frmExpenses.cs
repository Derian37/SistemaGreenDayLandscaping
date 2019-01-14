using System;
using System.Data;
using System.Windows.Forms;
using SistemaGDL.CapaIntegracion;

namespace CapaPresentacion
{
    public partial class frmExpenses : Form
    {
        string usuario;
        string cargo;
        int id_usuario;
        public frmExpenses(int id_usuario, string nombre, string cargo)
        {
            this.id_usuario = id_usuario;
            usuario = nombre;
            this.cargo = cargo;
            InitializeComponent();
        }

        private void frmExpenses_Load(object sender, EventArgs e)
        {
            CargarDataGridView();
            Calucular();

        }
        public void CargarDataGridView() {
            using (GestorGasto elGasto = new GestorGasto()) {
                dgvExpenses.DataSource = elGasto.ListarGastos();
                dgvExpenses.Columns["id_expense"].Visible = false;
                dgvExpenses.Columns["date"].HeaderText = "Date";
                dgvExpenses.Columns["details"].HeaderText = "Detail";
                dgvExpenses.Columns["amount"].HeaderText = "Amount";
            }
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain principal = new frmMain(id_usuario, usuario, cargo);
            principal.Show();
            this.SetVisibleCore(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label19.Text == "")
            {
                Guardar(dateTimePicker1.Value, textBox1.Text, textBox2.Text);

            }
            else {
                Modificar(int.Parse(label19.Text), dateTimePicker1.Value, textBox1.Text, textBox2.Text);
            }
            Limpiar();
            CargarDataGridView();
            Calucular();
        }

        private void Modificar(int id_expense,DateTime fecha, string detalle, string total)
        {
            using (GestorGasto Expense = new GestorGasto())
            {
                Expense.ModificarGasto(id_expense, fecha, detalle, total);
                MessageBox.Show("Save Successfull");
            }
        }

        private void Guardar(DateTime fecha, string detalle, string total)
        {
            using (GestorGasto Expense = new GestorGasto()) {
                Expense.InsertarGasto(fecha,detalle,total);
                MessageBox.Show("Save Successfull");
            }
        }
        private void Limpiar() {
            button3.Enabled = false;
        
            dateTimePicker1.Value = dateTimePicker1.Value;
            label19.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        private void Calucular() {
            Double temporal = 0;
            for(int obj = 0; obj< dgvExpenses.RowCount; obj ++ )
            {
                temporal = temporal + Convert.ToDouble(dgvExpenses.Rows[obj].Cells[3].Value);
            }
            label21.Text = temporal.ToString();
        }
        private void dgvExpenses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label19.Text = dgvExpenses.CurrentRow.Cells[0].Value.ToString();
            dateTimePicker1.Text = dgvExpenses.CurrentRow.Cells[1].Value.ToString();
            textBox1.Text = dgvExpenses.CurrentRow.Cells[2].Value.ToString();
            textBox2.Text = dgvExpenses.CurrentRow.Cells[3].Value.ToString();
            button3.Enabled = true;
            groupBox2.Enabled = true;
            groupBox4.Enabled = false;
            groupBox4.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
            CargarDataGridView();
            Calucular();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            consultafecha(dateTimePicker2.Value.ToString("dd/MM/yyy"), dateTimePicker3.Value.ToString("dd/MM/yyy"));
            Calucular();
            textBox3.Text = label21.Text;
            groupBox4.Visible = true;
            groupBox4.Enabled = true;
            groupBox2.Enabled = false;
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

            using (GestorGasto Gasto = new GestorGasto())
            {
                DataTable dtRegistro = new DataTable();
                DataSet dsRegistro = new DataSet();

                dsRegistro = Gasto.GetexpenseByDate(Fecha1, Fecha2);
                dtRegistro = dsRegistro.Tables[0];
                dgvExpenses.DataSource = dtRegistro;
                dgvExpenses.Columns["id_expense"].Visible = false;
                dgvExpenses.Columns["date"].HeaderText = "Date";
                dgvExpenses.Columns["details"].HeaderText = "Detail";
                dgvExpenses.Columns["amount"].HeaderText = "Amount";

            }
            
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            groupBox4.Enabled = false;
            groupBox4.Visible = false;
            groupBox2.Enabled = true;
            CargarDataGridView();
            Limpiar();
        }

        private void dgvExpenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
