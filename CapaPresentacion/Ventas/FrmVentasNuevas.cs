﻿using SistemaGDL.CapaIntegracion;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmVentasNuevas : Form
    {
        int id_usuario;
        int id_customer;//variable local para registrar el usuario
        int id_lastbill;
        double tax;
        string usuario;
        double precio = 0;
        string cargo;
        string f1 = "";
        public static int cont_fila = 0;
        public static double total;
        public static double subtotal;
        DateTime fecha = DateTime.Now;
        double staticprice;
        int id_cliente;
        public static double iva;
        private DataTable dtVentas = new DataTable();
        private DataSet dsVentas = new DataSet();
        public FrmVentasNuevas(int id_usuario,int id_customer, int id_lastbill,string usuario, string cargo, int id_cliente)
        {
            InitializeComponent();
            this.id_usuario = id_usuario;
            this.id_customer = id_customer;
            this.id_lastbill = id_lastbill;
            this.usuario = usuario;
            this.id_cliente = id_cliente;
            this.cargo = cargo;
            this.tax = 0.0635;
        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            CargarFactura();
            CargarDatosCliente();
            CalcularTotales();
            label16.Text= fecha.ToString("d");
        }
        public Double amount()
        {
            double amount = double.Parse(txtPrice.Text);
            //for (int i = 0; i <= dgv_ventas.RowCount - 1; i++)
            //{
            //    amount = amount + Convert.ToDouble(dgv_ventas.Rows[i].Cells[3].Value);
            //}
            return amount;
        }
        private void CargarFactura()
        {

            using (GestorVenta bills = new GestorVenta())
            {
                dgv_ventas.DataSource = bills.ConsultarVentaE(id_lastbill);

                dgv_ventas.Columns["id_bill"].Visible = false;
                dgv_ventas.Columns["fecha"].HeaderText = "fecha";
                dgv_ventas.Columns["details"].HeaderText = "details";
                dgv_ventas.Columns["servicePrice"].HeaderText = "servicePrice";
                dgv_ventas.Columns["amount"].HeaderText = "amount";

            }
        }
        private void CargarDatosCliente()
        {
            using (GestorCliente customer = new GestorCliente())
            {
                label21.Text = (string)customer.ConsultarCliente(id_customer).Tables[0].Rows[0][0];
                label23.Text = (string)customer.ConsultarCliente(id_customer).Tables[0].Rows[0][1];
                label25.Text = (string)customer.ConsultarCliente(id_customer).Tables[0].Rows[0][2];
                staticprice = (double)customer.ConsultarCliente(id_customer).Tables[0].Rows[0][3];
            }
        }

       
        
        private void FrmFacturacion_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Escape)
            //{
            //    this.Close();
            //}
            //else if (e.KeyCode == Keys.F1)
            //{
            //    BuscarProducto();
            //}
            //else if (e.KeyCode == Keys.F5)
            //{
            //    RealizarVenta();
            //}
            //else if (e.KeyCode == Keys.F6)
            //{
            //    AgregarNombreProducto();
            //}
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
            //try
            //{
            //    FrmBuscarProducto producto = new FrmBuscarProducto(id_usuario, nombre, cargo);
            //    producto.ShowDialog();
            //    if (!(producto.CodigoProducto == ""))
            //    {
            //        txt_codigoProducto.Text = producto.CodigoProducto;
            //        btn_AgregarNombre.Focus();
            //    }
            //    producto.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "btn_buscarProducto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txt_codigoProducto.Text = "";
            //}
        }

        private void btn_realizarVenta_Click(object sender, EventArgs e)
        {
            RealizarVenta();
        }

        private void RealizarVenta()
        {
            //try
            //{
            //    FrmCobrar cobrar = new FrmCobrar(id_usuario, nombre, cargo, total);
            //    cobrar.ShowDialog();
            //    if (cobrar.Imprimir)
            //    {
            //        abono = cobrar.Abono;
            //        saldo = cobrar.Saldo;
            //        efectivo = cobrar.Efectivo;
            //        tarjeta = cobrar.Tarjeta;
            //        Cobrar();
            //    }
            //    cobrar.Dispose();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "btn_realizarVenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    saldo = 0;
            //}
            //GuardarVenta();
            //GuardarDetalleVenta();
            //LimpiarCampos();
        }

        private void Cobrar()
        {
            //creamos una instancia de la clase CreaTicket para imprimir los recibos

            //ticket.AbreCajon(); //para abrir el cajón del dinero

        //    //agregamos datos del encabezado 
        //    ticket.TextoCentro("OPTICA SANTA MARTA");
        //    ticket.TextoCentro("Comprometidos por tu Salud Visual");
        //    ticket.TextoCentro("Exámenes de la Vista por Computadora");
        //    ticket.TextoCentro("Dr. Guillermo Romero Mendoza");
        //    ticket.TextoCentro("Cédula: 4 0193 0824");
        //    ticket.TextoCentro("Teléfono: 2783-30-21");
        //    ticket.TextoCentro("Entrada Principal a ciudad Neilly");
        //    ticket.TextoIzquierda("");
        //    ticket.LineasGuion();
        //    //agregamos numero de recibo y fecha
        //    ticket.TextoIzquierda("");
        //    fecha = DateTime.Now.ToShortDateString();
        //    hora = DateTime.Now.ToShortTimeString();
        //    ticket.TextoIzquierda("RECIBO N° " + numRecibo);
        //    ticket.TextoExtremos("Fecha: " + fecha, "Hora: " + hora);
        //    //agregamos nombre del usuario
        //    ticket.TextoIzquierda("Le atendió: " + lbl_usuario.Text);
        //    ticket.TextoIzquierda("");
        //    //agregamos nombre del cliente
        //    ticket.TextoIzquierda("Cliente: " + txt_nombreCliente.Text);
        //    ticket.LineasAsteriscos();

        //    //agregamos el encabezado de la tabla
        //    ticket.EncabezadoVenta(); //NOMBRE CANT PRECIO IMPORTE

        //    //agregamos los articulos de la tabla
        //    foreach (DataGridViewRow fila in dgv_ventas.Rows)
        //    {
        //        //agregamos el nombre, la cantidad, el precio y total
        //        string nombr = Convert.ToString(fila.Cells[1].Value);
        //        string canti = Convert.ToString(fila.Cells[2].Value);
        //        string precio = Convert.ToString(fila.Cells[4].Value);
        //        string total = Convert.ToString(fila.Cells[5].Value);

        //        ticket.AgregaArticulo(nombr, canti, precio, total);

        //    }

        //    ticket.TextoIzquierda("");
        //    ticket.LineasIgual();
        //    //agregamos los totales de la venta
        //    ticket.AgregarTotales("Subtotal.....", lbl_subtotal.Text);
        //    ticket.AgregarTotales("IVA..........", lbl_iva.Text);
        //    ticket.AgregarTotales("Total........", lbl_total.Text);
        //    ticket.TextoIzquierda("");
        //    ticket.AgregarTotales("Efectivo.....", efectivo.ToString());
        //    ticket.AgregarTotales("Tarjeta.....", tarjeta.ToString());
        //    ticket.AgregarTotales("Saldo.......", saldo.ToString());

        //    //texto final 
        //    ticket.TextoIzquierda("");
        //    ticket.TextoCentro("Gracias por su compra");
        //    //ticket.CortaTicket(); //corta el ticket
        //    ticket.ImprimirTicket("Microsoft XPS Document Writer"); //nombre de la impresora
        }

        /// <summary>
        /// Guardamos la venta en la base de datos
        /// </summary>
        private void GuardarVenta()
        {
            //int id_pago = 0;    //variable que almacena la forma de pago 1 = efectivo, 2 = tarjeta y 3 = ambos
            //if (efectivo > 0)
            //{
            //    id_pago = 1;
            //}
            //else if (tarjeta > 0)
            //{
            //    id_pago = 2;
            //}
            //else if (tarjeta > 0 && efectivo > 0 )
            //{
            //    id_pago = 3;
            //}
            //try
            //{
            //    using (GestorVenta venta = new GestorVenta())
            //    {
            //        venta.InsertarVenta(id_cliente, id_usuario, fecha, id_pago, saldo, "A");
            //    }
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show("Error " + e);
            //}
        }

        private void GuardarDetalleVenta()
        {
            //string fecha = DateTime.Now.ToShortDateString();
            //try
            //{
            //    using (GestorVenta venta = new GestorVenta())
            //    {
            //        dsVentas = venta.ConsultarUltimoVenta();
            //        dtVentas = this.dsVentas.Tables[0];

            //        foreach (DataGridViewRow fila in dgv_ventas.Rows)
            //        {
            //            //agregamos la cantidad, el precio y subtotal
            //            string codProd = Convert.ToString(fila.Cells[0].Value);
            //            int canti = Convert.ToInt32(fila.Cells[2].Value);
            //            string tipo = Convert.ToString(fila.Cells[3].Value);
            //            double prec = Convert.ToDouble(fila.Cells[4].Value);
            //            double subt = Convert.ToDouble(fila.Cells[5].Value);
            //            if (tipo.Equals("GRAVADO"))
            //            {
            //                subtotal = subt * 0.13 + subt;
            //            }
            //            else
            //            {
            //                subtotal = subt;
            //            }
            //            venta.InsertarDetalleVenta(numRecibo, codProd, canti, prec, subtotal, "A");
            //            subtotal = 0;
            //        }
            //    }
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show("Error " + e);
            //}
        }

        private void LimpiarCampos()
        {
           
            radioButton1.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            txtDetails.Text = "";
            txtPrice.Text = "";
            txtPrice.Enabled = true;
            txtGuys.Text = "0";
            txtPriceH.Text = "0";
            txtHours.Text = "0";
            textUnits.Text = "0";
            textUnitPrice.Text = "0";
            txtGuys.Enabled = false;
            txtGuys.ReadOnly = true;
            txtHours.Enabled = false;
            txtHours.ReadOnly = true;
            txtPriceH.Enabled = false;
            txtPriceH.ReadOnly = true;

            textUnits.Enabled = false;
            textUnits.ReadOnly = true;
            textUnitPrice.Enabled = false;
            textUnitPrice.ReadOnly = true;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            f1 = Date.Value.ToString("MM-dd-yyyy");
                    
            try
            {
                if (radioButton1.Checked)
                {

                    precio = double.Parse(txtPrice.Text);

                }
                else
                {
                    precio = double.Parse(txtPrice.Text);
                }
            }
            catch (Exception o) {
                MessageBox.Show("Ingresar un Precio");
            }
            using (GestorVenta insertbills = new GestorVenta())
            {
                double amount = precio;

                if (txtGuys.Text != "0" && txtHours.Text != "0")
                {
                    insertbills.InsertarVenta(id_lastbill, f1, txtDetails.Text + " Guys: " + txtGuys.Text + " Hours: " + txtHours.Text, precio, amount);

                } else if (txtGuys.Text == "0" && txtHours.Text == "0" && textUnitPrice.Text !="0" && textUnits.Text != "0") {
                    insertbills.InsertarVenta(id_lastbill, f1, txtDetails.Text +" Units: " + textUnits.Text, Double.Parse(textUnitPrice.Text), amount);

                    
                }
                else {
                    insertbills.InsertarVenta(id_lastbill, f1, txtDetails.Text, precio, amount);

                }

                MessageBox.Show("Sirve", caption: "Alerta", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                CargarFactura();
                CalcularTotales();
                LimpiarCampos();
             }
        }
        /// <summary>
        /// Calcula el total sumando todos los subtotales y el impuesto
        /// </summary>
        private void CalcularTotales()
        {

            double total = 0;
         
            for (int i = 0; i <= dgv_ventas.RowCount - 1; i++)
            {
                total = total + Convert.ToDouble(dgv_ventas.Rows[i].Cells[4].Value);
            }
            lbl_iva.Text = (total * tax).ToString("f2");
            lbl_subtotal.Text = total.ToString();
            lbl_total.Text = Convert.ToString(total + (total * tax));
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

        private void button1_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            using (GestorVenta insertnewsavebills = new GestorVenta())
            {
                f1 = fecha.ToString("MM/dd/yyyy");
                

                insertnewsavebills.InsertNewSaveBills(id_customer, f1, id_lastbill);
                MessageBox.Show("Saved successfully", caption: "Alerta", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                frmBill volver = new frmBill(id_usuario,usuario,cargo,id_customer);
                volver.Show();
                this.SetVisibleCore(false);
            }
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBill volver = new frmBill(id_usuario, usuario, cargo, id_customer);
            volver.Show();
            this.SetVisibleCore(false);
        }

        private void btnExpediente_Click(object sender, EventArgs e)
        {
            if (txtDetails.Text != "" && txtPrice.Text != "")
            {
                f1 = Date.Value.ToString("MM-dd-yyyy");
                using (GestorVenta laVenta = new GestorVenta())
                {
                    if (txtGuys.Text != "0" && txtHours.Text != "0")
                    {
                        laVenta.ModifyBill(int.Parse(label1.Text), int.Parse(label27.Text), f1, txtDetails.Text + " Guys: " + txtGuys.Text + " Hours: " + txtHours.Text, double.Parse(txtPrice.Text), amount());
                        MessageBox.Show("Modify successful", caption: "Alerta", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                    }
                    else if (txtGuys.Text == "0" && txtHours.Text == "0" && textUnitPrice.Text != "0" && textUnits.Text != "0")
                    {
                        laVenta.ModifyBill(int.Parse(label1.Text), int.Parse(label27.Text), f1, txtDetails.Text + " Units: " + textUnits.Text, double.Parse(txtPrice.Text), amount());
                        MessageBox.Show("Modify successful", caption: "Alerta", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                    }
                    else
                    {
                        laVenta.ModifyBill(int.Parse(label1.Text), int.Parse(label27.Text), f1, txtDetails.Text, double.Parse(txtPrice.Text), amount());
                        MessageBox.Show("Modify successful", caption: "Alerta", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);

                    }
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

        private void dgv_ventas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String Day = dgv_ventas.CurrentRow.Cells[1].Value.ToString();
            string[] fech;
            fech = Day.Split('-');
            string Fec = "";
            foreach (string i in fech)
            {
                Fec = fech[1] + "-" + fech[0] + "-" + fech[2];
            }
            if (label1.Text != "") {
                label1.Text = dgv_ventas.CurrentRow.Cells[3].Value.ToString();
            }
            
            label27.Text = dgv_ventas.CurrentRow.Cells[0].Value.ToString();
            Date.Text = Fec;
            txtDetails.Text = dgv_ventas.CurrentRow.Cells[2].Value.ToString();
            txtPrice.Text = dgv_ventas.CurrentRow.Cells[3].Value.ToString();
            btnExpediente.Visible = true;
            label26.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtPrice.Enabled = false;
            precio = staticprice;
            txtPrice.Text = staticprice.ToString();




        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            Guardar();
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
                frmReport reporte = new frmReport(dgv_ventas, subtotal, tax, total, nombre, apellido, id_usuario, usuario, cargo, id_cliente,label25.Text);
                reporte.Show();
                this.SetVisibleCore(false);
            }
            catch (Exception j) {
                MessageBox.Show(j.ToString());
            }
         
        }

        private void txt_Price_KeyUp(object sender, KeyEventArgs e)
        {
        }



        private void txt_Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_KeyUp(object sender, KeyEventArgs e)
        {
            
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

        private void txtPrice_Validating(object sender, System.ComponentModel.CancelEventArgs e)
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

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void txtPriceH_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void txtPriceH_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void txtPriceH_KeyUp(object sender, KeyEventArgs e)
        {
            Decimal price = 0;
            Decimal priceH = 0;
            int hours = 0;
            try
            {
                hours = Convert.ToInt32(txtHours.Text);
                priceH = Decimal.Parse(txtPriceH.Text);
                price = hours * priceH;
                txtPrice.Text = price.ToString();
            }
            catch
            {
                MessageBox.Show("Debe introducir solo numeros");
                txtPrice.Text = price.ToString();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textUnitPrice_KeyUp(object sender, KeyEventArgs e)
        {
            Decimal price = 0;
            Decimal priceU = 0;
            int unit = 0;
            try
            {
                unit = Convert.ToInt32(textUnits.Text);
                priceU = Decimal.Parse(textUnitPrice.Text);
                price = unit * priceU;
                txtPrice.Text = price.ToString();
            }
            catch
            {
                MessageBox.Show("Debe introducir solo numeros");
                txtPrice.Text = price.ToString();
            }
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void textUnits_TextChanged(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton4.Checked = false;

            txtGuys.Enabled = true;
            txtGuys.ReadOnly = false;
            txtHours.Enabled = true;
            txtHours.ReadOnly = false;
            txtPriceH.Enabled = true;
            txtPriceH.ReadOnly = false;

            textUnits.Enabled = false;
            textUnits.ReadOnly = true;
            textUnitPrice.Enabled = false;
            textUnitPrice.ReadOnly = true;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton3.Checked = false;

            txtGuys.Enabled = false;
            txtGuys.ReadOnly = true;
            txtHours.Enabled = false;
            txtHours.ReadOnly = true;
            txtPriceH.Enabled = false;
            txtPriceH.ReadOnly = true;

            textUnits.Enabled = true;
            textUnits.ReadOnly = false;
            textUnitPrice.Enabled = true;
            textUnitPrice.ReadOnly = false;
        }

        private void textUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
