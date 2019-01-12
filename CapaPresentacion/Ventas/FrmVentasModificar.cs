using SistemaGDL.CapaIntegracion;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmVentasModificar : Form
    {
        int id_usuario;
        int id_lastbill = 0;
        int id_cliente;
        int id_customer;//variable local para registrar el usuario
        string usuario;
        string cargo;
        public static int cont_fila = 0;
        public static double total;
        public static double subtotal;
        double staticprice;
        double precio = 0;
        string f1 = "";
        DateTime fecha = DateTime.Now;
        public static double iva;
        private DataTable dtVentas = new DataTable();
        private DataSet dsVentas = new DataSet();
        public FrmVentasModificar(int id_usuario,int id_customer, int id_lastbill, string usuario, string cargo,int id_cliente)
        {
            InitializeComponent();
            this.id_usuario = id_usuario;
            this.id_customer = id_customer;
            this.id_lastbill = id_lastbill;
            this.usuario = usuario;
            this.id_cliente = id_cliente;
            this.cargo = cargo;
        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            CargarFactura();
            CargarDatosCliente();
            CalcularTotales();
            label16.Text= fecha.ToString("d");
        }

        private void CargarDatosCliente()
        {
            using (GestorCliente customer = new GestorCliente())
            {
                label21.Text = (string)customer.ConsultarCliente(id_customer).Tables[0].Rows[0][0];
                label23.Text = (string)customer.ConsultarCliente(id_customer).Tables[0].Rows[0][1];
                label25.Text = (string)customer.ConsultarCliente(id_customer).Tables[0].Rows[0][2];
                staticprice= (double)customer.ConsultarCliente(id_customer).Tables[0].Rows[0][3];
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void CargarFactura()
        {
          
            using (GestorVenta bills = new GestorVenta())
            {
                dgv_ventas.DataSource = bills.ConsultarVenta(id_customer,id_lastbill);

                dgv_ventas.Columns["id_billFac"].Visible = false;
                dgv_ventas.Columns["id_bill"].Visible = false;
                dgv_ventas.Columns["fecha"].HeaderText = "fecha";
                dgv_ventas.Columns["details"].HeaderText = "details";
                dgv_ventas.Columns["servicePrice"].HeaderText = "servicePrice";
                dgv_ventas.Columns["amount"].HeaderText = "amount";


            }
        }
        
        private void FrmFacturacion_KeyDown(object sender, KeyEventArgs e)
        {
         
        }

        private void btn_AgregarNombre_Click(object sender, EventArgs e)
        {
            AgregarNombreProducto();
        }

        private void AgregarNombreProducto()
        {
            
        }

        private void btn_buscarProducto_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void BuscarProducto()
        {
     
        }

        private void btn_realizarVenta_Click(object sender, EventArgs e)
        {
            RealizarVenta();
        }

        private void RealizarVenta()
        {
          
        }

       

        /// <summary>
        /// Guardamos la venta en la base de datos
        /// </summary>
        private void GuardarVenta()
        {
          
        }

        private void GuardarDetalleVenta()
        {
           
        }

        private void LimpiarCampos()
        {
            radioButton1.Checked = false;
            txtDetails.Text = "";
            txtPrice.Text = "";
            txtPrice.Enabled = true;
        }

        public Double amount() {
            double amount = double.Parse(txtPrice.Text);
            for (int i = 0; i <= dgv_ventas.RowCount - 1; i++)
            {
                amount = amount + Convert.ToDouble(dgv_ventas.Rows[i].Cells[3].Value);
            }
            return amount;
        }
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            string Fecha1 = "";
            string[] fechone;

            f1 = Date.Value.ToString("dd/MM/yyyy");
            f1 = f1.Replace(" ", "-");
            fechone = f1.Split('-');

            foreach (string i in fechone)
            {
                Fecha1 = fechone[2] + "-" + fechone[1] + "-" + fechone[0];

            }


            if (txtPrice.Text != "" || txtDetails.Text != "")
            {

                if (radioButton1.Checked)
                {
                    
                    precio = double.Parse(txtPrice.Text);
                }
                else
                {
                    precio = double.Parse(txtPrice.Text);
                }
                using (GestorVenta insertbills = new GestorVenta())
                {
                    double amount = precio;
                    for (int i = 0; i <= dgv_ventas.RowCount - 1; i++)
                    {
                        amount = amount + Convert.ToDouble(dgv_ventas.Rows[i].Cells[3].Value);
                    }
                    
                    if (txtGuys.Text != "0" && txtHours.Text != "0")
                    {
                        insertbills.InsertarVenta(id_lastbill, Fecha1, txtDetails.Text + " Guys: " + txtGuys.Text + " Hours: " + txtHours.Text, precio, amount);
                    }
                    else
                    {
                        insertbills.InsertarVenta(id_lastbill, Fecha1, txtDetails.Text, precio, amount);
                    }

                    MessageBox.Show("Sirve", caption: "Alerta", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                    CargarFactura();
                    CalcularTotales();
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("LLenar todos los campos");
            }

        }
        /// <summary>
        /// Calcula el total sumando todos los subtotales y el impuesto
        /// </summary>
        private void CalcularTotales()
        {
            double total = 0;
            double amount = 0;
            for (int i = 0; i <= dgv_ventas.RowCount - 1; i++)
            {
                amount = amount + Convert.ToDouble(dgv_ventas.Rows[i].Cells[3].Value);
                dgv_ventas.Rows[i].Cells[4].Value = amount.ToString();
            }

            for (int i = 0; i <= dgv_ventas.RowCount - 1; i++)
            {
                total = total + Convert.ToDouble(dgv_ventas.Rows[i].Cells[3].Value);
            }
            lbl_total.Text = total.ToString();

          
           
          
        }

        private void FrmVentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dgv_ventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Cuando se borra una foto fila se vuelven a calcular los totales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_ventas_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalcularTotales();
        }

        /// <summary>
        /// Al hacer click en el botón buscar se abre una ventana para buscar el cliente por número de cédula
        /// o buscandolo en el grid 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    FrmBuscarCliente cliente = new FrmBuscarCliente(id_usuario, nombre, cargo);
            //    cliente.ShowDialog();
            //    if (!(cliente.NombreCompleto == ""))
            //    {
            //        txt_nombreCliente.Text = cliente.NombreCompleto;
            //        id_cliente = cliente.Id_cliente;
            //        txt_codigoProducto.Focus();
            //    }
            //    cliente.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "btn_buscarCliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txt_nombreCliente.Text = "";
            //}
            
        }
        /// <summary>
        /// Cierra la ventana al dar click en el botón
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
             frmListaFactura volver = new frmListaFactura(id_usuario,usuario,cargo,id_customer);
                volver.Show();
                this.SetVisibleCore(false);
        }

        private void dgv_ventas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String Day = dgv_ventas.CurrentRow.Cells[1].Value.ToString();
            string[] fech;
            fech = Day.Split('-');
            string Fec= "";
            foreach (string i in fech)
            {
                Fec = fech[1] + "-" + fech[0] + "-" + fech[2];
            }

            label1.Text = dgv_ventas.CurrentRow.Cells[5].Value.ToString();
            label27.Text= dgv_ventas.CurrentRow.Cells[0].Value.ToString();
            Date.Text= Fec;
            txtDetails.Text = dgv_ventas.CurrentRow.Cells[2].Value.ToString();
            txtPrice.Text = dgv_ventas.CurrentRow.Cells[3].Value.ToString();
            btnExpediente.Visible = true;
            label26.Visible = true;
        }

        private void btnExpediente_Click(object sender, EventArgs e)
        {
            f1 = Date.Value.ToString("MM/dd/yyyy");

            if (txtDetails.Text != "" && txtPrice.Text != "")
            {
                using (GestorVenta laVenta = new GestorVenta())
                {
                                    
                    
                    laVenta.ModifyBill(int.Parse(label1.Text),int.Parse(label27.Text), f1, txtDetails.Text, double.Parse(txtPrice.Text), amount());
                    MessageBox.Show("Sirve", caption: "Alerta", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                    CargarFactura();
                    LimpiarCampos();
                    btnExpediente.Visible = false;
                    label26.Visible = false;
                }
             
                
            }
            else
            {
                MessageBox.Show("¡ Debe rellenar todos los espacios ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            CalcularTotales();
            LimpiarCampos();
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void Imprimir()
        {
            double subtotal = double.Parse(lbl_subtotal.Text);
            double tax = double.Parse(lbl_iva.Text);
            double total = double.Parse(lbl_total.Text);
            string nombre = label21.Text;
            string apellido = label23.Text;

            try
            {
                frmReporte reporte = new frmReporte(dgv_ventas, subtotal, tax, total, nombre, apellido,id_usuario,usuario,cargo,id_cliente, label25.Text);
                reporte.Show();
                this.SetVisibleCore(false);
            }
            catch (Exception j)
            {
                MessageBox.Show(j.ToString());
            }
        }

        private void txt_Price_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_Price_KeyUp(object sender, KeyEventArgs e)
        {
           
        }
       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtPrice.Enabled = false;
            precio = staticprice;
          

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_guys_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;

                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;

                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;

                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Debe introducir solo numeros");
                }
            }
            catch (Exception u)
            {
                Console.WriteLine(u);
                MessageBox.Show("Debe introducir solo numeros");
            }
        }

        private void txt_hours_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;

                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;

                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;

                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Debe introducir solo numeros");
                }
            }
            catch (Exception u)
            {
                Console.WriteLine(u);
                MessageBox.Show("Debe introducir solo numeros");
            }
        }

        private void txt_hours_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;

                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;

                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;

                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Debe introducir solo numeros");
                }
            }
            catch (Exception u)
            {
                Console.WriteLine(u);
                MessageBox.Show("Debe introducir solo numeros");
            }
        }

        private void txtPrice_Validated(object sender, EventArgs e)
        {
            Decimal price = 0;
            try
            {
                price = Decimal.Parse(txtPrice.Text);
                txtPrice.Text = price.ToString();
            }
            catch
            {
                MessageBox.Show("Debe introducir solo numeros");
                txtPrice.Text = price.ToString();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
