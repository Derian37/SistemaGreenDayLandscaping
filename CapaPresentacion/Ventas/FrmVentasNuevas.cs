using SistemaGDL.CapaIntegracion;
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
        string usuario;
        string cargo;
        public static int cont_fila = 0;
        public static double total;
        public static double subtotal;
        DateTime fecha = DateTime.Now;
        double staticprice;
        public static double iva;
        private DataTable dtVentas = new DataTable();
        private DataSet dsVentas = new DataSet();
        public FrmVentasNuevas(int id_usuario,int id_customer, int id_lastbill,string usuario, string cargo)
        {
            InitializeComponent();
            this.id_usuario = id_usuario;
            this.id_customer = id_customer;
            this.id_lastbill = id_lastbill;
            this.usuario = usuario;
            this.cargo = cargo;
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
            for (int i = 0; i <= dgv_ventas.RowCount - 1; i++)
            {
                amount = amount + Convert.ToDouble(dgv_ventas.Rows[i].Cells[3].Value);
            }
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
            txtDetails.Text = "";
            txtPrice.Text = "";
            txtPrice.Enabled = true;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            double precio = 0;

            if (radioButton1.Checked)
            {
               
                precio = staticprice;
            }else
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
                 insertbills.InsertarVenta(id_lastbill, Date.Value,txtDetails.Text, precio, amount);
                
               
                MessageBox.Show("Sirve", caption: "Alerta", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                CargarFactura();
                CalcularTotales();
                LimpiarCampos();
            }



            //int cant = int.Parse(txt_cantidad.Text);
            //if (codigoProd != "" && cant > 0 && cant <= cantidad)
            //{
            //    bool existe = false;
            //    int num_fila = 0;

            //    if (cont_fila == 0)
            //    {
            //        float total = cant * monto;
            //        dgv_ventas.Rows.Add(codigoProd, lbl_nombreProducto.Text, cant, tipo, monto, total);
            //        cont_fila++;
            //    }
            //    else
            //    {
            //        foreach (DataGridViewRow fila in dgv_ventas.Rows)
            //        {
            //            if (Convert.ToString(fila.Cells[0].Value) == codigoProd)
            //            {
            //                existe = true;
            //                num_fila = fila.Index;
            //            }
            //        }
            //        if (existe == true)
            //        {
            //            dgv_ventas.Rows[num_fila].Cells[2].Value = (Convert.ToDouble(txt_cantidad.Text) + Convert.ToDouble(dgv_ventas.Rows[num_fila].Cells[2].Value)).ToString();
            //            double total = Convert.ToDouble(dgv_ventas.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(dgv_ventas.Rows[num_fila].Cells[4].Value);
            //            dgv_ventas.Rows[num_fila].Cells[4].Value = total;
            //        }
            //        else
            //        {
            //            float total = cant * monto;
            //            dgv_ventas.Rows.Add(codigoProd, lbl_nombreProducto.Text, cant, tipo, monto, total);
            //            cont_fila++;
            //        }
            //    }
            //    CalcularTotales();
            //}
            //else if (codigoProd == "")
            //{
            //    MessageBox.Show("Debe agregar un producto primero", caption: "Alerta", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            //    txt_codigoProducto.Focus();
            //}
            //else if (cant == 0)
            //{
            //    MessageBox.Show("Debe agregar una cantidad", caption: "Alerta", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            //    txt_cantidad.Focus();
            //}
            //else if (cant > cantidad)
            //{
            //    MessageBox.Show("Solo hay "+cantidad+" unidades en existencia de ese producto", caption: "Alerta", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            //    txt_cantidad.Focus();
            //}
            //txt_codigoProducto.Text = "";
            //lbl_nombreProducto.Text = "";
            //txt_cantidad.Text = "0";
            //codigoProd = "";
            //monto = 0;
            //cantidad = 0;
            //txt_codigoProducto.Focus();
        }
        /// <summary>
        /// Calcula el total sumando todos los subtotales y el impuesto
        /// </summary>
        private void CalcularTotales()
        {
            double total = 0;
         
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

        private void button1_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            using (GestorVenta insertnewsavebills = new GestorVenta())
            {
                insertnewsavebills.InsertNewSaveBills(id_customer, fecha.Date,id_lastbill);
                MessageBox.Show("Sirve", caption: "Alerta", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                frmListaClientes volver = new frmListaClientes(id_usuario,usuario,cargo,id_customer);
                volver.Show();
                this.SetVisibleCore(false);
            }
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaClientes volver = new frmListaClientes(id_usuario, usuario, cargo, id_customer);
            volver.Show();
            this.SetVisibleCore(false);
        }

        private void btnExpediente_Click(object sender, EventArgs e)
        {
            if (txtDetails.Text != "" && txtPrice.Text != "")
            {
                using (GestorVenta laVenta = new GestorVenta())
                {


                    laVenta.ModifyBill(int.Parse(label1.Text), int.Parse(variable.Text), Date.Value, txtDetails.Text, double.Parse(txtPrice.Text), amount());
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

        private void dgv_ventas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Text = dgv_ventas.CurrentRow.Cells[5].Value.ToString();
            variable.Text = dgv_ventas.CurrentRow.Cells[0].Value.ToString();
            Date.Text = dgv_ventas.CurrentRow.Cells[1].Value.ToString();
            txtDetails.Text = dgv_ventas.CurrentRow.Cells[2].Value.ToString();
            txtPrice.Text = dgv_ventas.CurrentRow.Cells[3].Value.ToString();
            btnExpediente.Visible = true;
            label26.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtPrice.Enabled = false;
        }
    }
}
