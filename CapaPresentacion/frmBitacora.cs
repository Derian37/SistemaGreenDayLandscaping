using System;
using System.Data;
using System.Windows.Forms;
using SistemaBitacora.CapaIntegracion;
using MySql.Data.MySqlClient;

namespace CapaPresentacion
{
    public partial class frmBitacora : Form
    {
        DataTable dtBitacora = new DataTable();
        DataSet dsBitacora = new DataSet();
        bool bandera =false;

        public frmBitacora()
        {
           
            InitializeComponent();
        }
         void FrmProductosLoad(object sender, EventArgs e)
        {

           Ejecutar();
           cargarGridProductos();
           
        }
        public void Ejecutar()
        {
        
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.Port = 3306;
            builder.UserID = "root";
            builder.Password = "1234";
            MySqlConnection conn = new MySqlConnection(builder.ToString());

            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "CREATE DATABASE IF NOT EXISTS `bd_registro` /*!40100 DEFAULT CHARACTER SET latin1 */; USE `bd_registro`;" +
                             "CREATE TABLE bd_registro.registro ( id_registro int(11) NOT NULL AUTO_INCREMENT," +
                                                      "detalle varchar(50) DEFAULT NULL," +
                                                      "monto float DEFAULT NULL," +
                                                      "fecha date DEFAULT NULL," +
                                                      "estado varchar(50) DEFAULT NULL, " +
                                                      "PRIMARY KEY(id_registro));" +
                            "DELIMITER // CREATE DEFINER =`root`@`localhost` PROCEDURE bd_registro.consulta_detalle(IN `det` VARCHAR(50)) BEGIN SELECT registro.id_registro,registro.detalle, registro.monto, registro.fecha, registro.estado FROM registro WHERE detalle = det; END// \n DELIMITER; " +
                            "DELIMITER // CREATE DEFINER =`root`@`localhost` PROCEDURE bd_registro.consulta_registro(IN `fechone` VARCHAR(50),     IN `fechtwo` VARCHAR(50),     IN `det` VARCHAR(50) )BEGIN SELECT registro.detalle, registro.monto, registro.fecha, registro.estado FROM registro WHERE registro.fecha BETWEEN fechone AND fechtwo AND registro.estado != 'Eliminado'AND registro.detalle = 'DEPOSITO SOMOS VOZ'ORDER BY id_registro DESC;END//  DELIMITER; " +
                            "DELIMITER // CREATE DEFINER =`root`@`localhost` PROCEDURE bd_registro.consulta_registroOtros( IN `fechone` VARCHAR(50),IN `fechtwo` VARCHAR(50)) BEGIN SELECT registro.detalle, registro.monto, registro.fecha, registro.estado FROM registro WHERE registro.fecha BETWEEN fechone AND fechtwo AND registro.estado != 'Eliminado' AND registro.detalle != 'DEPOSITO SOMOS VOZ' ORDER BY id_registro DESC;END//  DELIMITER; " +
                            "DELIMITER // CREATE DEFINER =`root`@`localhost` PROCEDURE bd_registro.eliminar_registros() BEGIN DELETE FROM registro WHERE registro.estado = 'Eliminado'; END//  DELIMITER; " +
                            "DELIMITER // CREATE DEFINER=`root`@`localhost` PROCEDURE  bd_registro.insertar_registro(	IN `detalle` VARCHAR(50),	IN `monto` FLOAT, 	IN `fecha` DATE,	IN `estado` VARCHAR(50))BEGIN INSERT INTO registro (registro.detalle,registro.monto,registro.fecha,registro.estado) VALUES(detalle,monto,fecha,estado); END// DELIMITER; " +
                            "DELIMITER // CREATE DEFINER=`root`@`localhost` PROCEDURE bd_registro.listar_registro() BEGIN	SELECT * FROM registro	WHERE registro.estado != 'Eliminado'	ORDER BY id_registro DESC; END// DELIMITER; " +
                            "DELIMITER // CREATE DEFINER =`root`@`localhost` PROCEDURE bd_registro.listar_registro_eliminado() BEGIN SELECT* FROM registro WHERE registro.estado = 'Eliminado' ORDER BY id_registro DESC; END//  DELIMITER; " +
                            "DELIMITER // CREATE DEFINER =`root`@`localhost` PROCEDURE bd_registro.modifica_registro(IN `id_registro` INT,IN `detalle` VARCHAR(50),IN `monto` FLOAT,IN `fecha` DATE,IN `estado` VARCHAR(50)) BEGIN UPDATE registro SET registro.detalle = detalle,registro.monto = monto,registro.fecha = fecha, registro.estado = estado WHERE registro.id_registro = id_registro; END// DELIMITER; " +
                            "DELIMITER // CREATE DEFINER =`root`@`localhost` PROCEDURE bd_registro.Test(IN `Param1` DATE,IN `Param2` DATE) BEGIN SELECT registro.detalle, registro.monto, registro.fecha, registro.estado FROM registro; END// DELIMITER; " +
                            "DELIMITER // CREATE DEFINER =`root`@`localhost` PROCEDURE bd_registro.vaciar_registro() BEGIN DELETE FROM registro; ALTER TABLE registro AUTO_INCREMENT = 0; END// DELIMITER; ";

                MySqlScript script = new MySqlScript(conn, sql);


                int count = script.Execute();

                Console.WriteLine("Executed " + count + " statement(s).");
                Console.WriteLine("Delimiter: " + script.Delimiter);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();
            Console.WriteLine("Done.");
        }
        private void btn_volver_Click(object sender, EventArgs e)
        {
            frmConsulta frm_Reporte = new frmConsulta();
            frm_Reporte.Show();
            this.SetVisibleCore(false);
        }

        void Btn_buscarProductoClick(object sender, EventArgs e)
        {
   
        }

        private void CargarDatosProducto()
        {
        }

        private void btnInsertarProducto_Click(object sender, EventArgs e)
        {
            Guardar();
            LimpiarCampos();
        }

        private void Guardar()
        {
            try
            {
                using (GestorRegistro registro = new GestorRegistro())
                {
                    if (radioButton1.Checked == true)
                    {
                        try
                        {
                            registro.InsertarRegistro("DEPOSITO SOMOS VOZ", float.Parse(txt_Monto.Text), dateTimePicker1.Value, "Activo");
                            MessageBox.Show("Datos registrados satisfactoriamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargarGridProductos();
                            LimpiarCampos();
                        }
                        catch (Exception a) {
                            MessageBox.Show("Debe llenar todos los datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Console.WriteLine(a);
                        }
                    }
                    if (radioButton2.Checked == true)
                    {
                        try { 
                        registro.InsertarRegistro(txt_Detalle.Text.ToUpper(), float.Parse(txt_Monto.Text), dateTimePicker1.Value, "Activo");
                        MessageBox.Show("Datos registrados satisfactoriamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarGridProductos();
                        LimpiarCampos();
                    }catch (Exception a){
                        MessageBox.Show("Debe llenar todos los datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Console.WriteLine(a);
                        }
                    }
                }
            }
            catch (Exception i)
            {
                MessageBox.Show("Debe llenar todos los datos", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine(i);
            }
        }

        void Btn_EditarProductoClick(object sender, EventArgs e)
        {
        
        }
        private void btn_guardarProducto_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void Modificar()
        {
            try
            {
                using (GestorRegistro registro = new GestorRegistro())
                {
                    registro.ModificarTarjeta(int.Parse(id.Text), txt_ModificarDetalle.Text.ToUpper(), float.Parse(txt_ModificaMonto.Text), dateTimePicker2.Value, comboBox1.Text);
                }
                cargarGridProductos();
                LimpiarCampos();
                MessageBox.Show("Dato modificado satisfactoriamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbx_datosProducto.Visible = false;
                gbx_datosProducto.Enabled = false;
            }
            catch (Exception i)
            {
                MessageBox.Show("Debe llenar todos los datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine(i);
            }
        }

        void Btn_EliminarProductoClick(object sender, EventArgs e)
        {
            Eliminar();

        }

        private void Eliminar()
        {
            try
            {
                using (GestorRegistro registro = new GestorRegistro())
                {
                    registro.ModificarTarjeta(int.Parse(id.Text), txt_ModificarDetalle.Text.ToUpper(), float.Parse(txt_ModificaMonto.Text), dateTimePicker2.Value, "Eliminado");
                }
                cargarGridProductos();
                LimpiarCampos();
                MessageBox.Show("Dato eliminado satisfactoriamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbx_datosProducto.Visible = false;
                gbx_datosProducto.Enabled = false;
            }
            catch (Exception i)
            {
                MessageBox.Show("Debe llenar todos los datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine(i);
            }
        }

        private void cargarGridProductos()
        {
            using (GestorRegistro registro = new GestorRegistro())
            {
                dgvDepositos.DataSource = registro.ListarRegistro();

                dgvDepositos.Columns["id_registro"].Visible = false;
                dgvDepositos.Columns["detalle"].HeaderText = "Detalle";
                dgvDepositos.Columns["monto"].HeaderText = "Monto";
                dgvDepositos.Columns["fecha"].HeaderText = "Fecha";
                dgvDepositos.Columns["estado"].HeaderText = "Estado";
      
            }
            label8.Text = dgvDepositos.RowCount.ToString();
        }
       
        private void LimpiarCampos()
        {
            txt_Detalle.Text = "";
            comboBox1.Text = "";
            txt_ModificaMonto.Text = "";
            txt_ModificarDetalle.Text = "";
            txt_Monto.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gbx_datosProducto.Visible = true;
            gbx_datosProducto.Enabled = true;
            id.Text = dgvDepositos.CurrentRow.Cells[0].Value.ToString();
            txt_ModificarDetalle.Text = dgvDepositos.CurrentRow.Cells[1].Value.ToString();
            txt_ModificaMonto.Text = dgvDepositos.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker2.Text = dgvDepositos.CurrentRow.Cells[3].Value.ToString();
            comboBox1.Text = dgvDepositos.CurrentRow.Cells[4].Value.ToString();
         
        }
        

        private void frmProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblBuscar_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            try
            {
                if (txt_Buscar.Text == "")
                {
                    MessageBox.Show("Debe introducir un detalle.", "Aviso", MessageBoxButtons.OK ,MessageBoxIcon.Warning);
                    cargarGridProductos();
                }
                else
                {

                    using (GestorRegistro registro = new GestorRegistro())
                    {

                        this.dsBitacora = registro.ConsultarDetalle(txt_Buscar.Text);
                        this.dtBitacora = this.dsBitacora.Tables[0];
                        dgvDepositos.DataSource = dtBitacora;

                        dgvDepositos.Columns["id_registro"].Visible = false;
                        dgvDepositos.Columns["detalle"].HeaderText = "Detalle";
                        dgvDepositos.Columns["monto"].HeaderText = "Monto";
                        dgvDepositos.Columns["fecha"].HeaderText = "Fecha";
                        dgvDepositos.Columns["estado"].HeaderText = "Estado";

                    }
                    if( dgvDepositos.Rows.Count==0)
                    {
                        MessageBox.Show("Dato no existente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txt_Buscar.Text = "";
                        cargarGridProductos();
                    }
                }
            }
            catch (Exception i)
            {
                MessageBox.Show("Dato no existente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Console.WriteLine(i);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRecuperar frm_Recuperar= new frmRecuperar();
            frm_Recuperar.Show();
            this.SetVisibleCore(false);
        }
       
        
        private void gbx_datosProducto_Enter(object sender, EventArgs e)
        {

        }

        private void txt_Monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_ModificaMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                txt_Detalle.Enabled = true;
            }
            else
            {
                txt_Detalle.Enabled = false;
            }
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulta ir = new frmConsulta();
            ir.Show();
            this.SetVisibleCore(false);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
       
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
   
        }

        private void lbl_guardarProducto_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarGridProductos();
            LimpiarCampos();
            gbx_datosProducto.Visible = false;
            gbx_datosProducto.Enabled = false;
        }

        private void txt_ModificaMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsulta frm_Reporte = new frmConsulta();
            frm_Reporte.Show();
            this.SetVisibleCore(false);
        }

        private void recuperarEliminadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRecuperar frm_Recuperar = new frmRecuperar();
            frm_Recuperar.Show();
            this.SetVisibleCore(false);
        }

        private void vaciarBitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro de Vaciar los datos definitivamente?", "Aviso Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    using (GestorRegistro registro = new GestorRegistro())
                    {
                        registro.VaciarBaseDatos();
                    }
                    cargarGridProductos();
                    MessageBox.Show("Datos borrados satisfactoriamente.", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gbx_datosProducto.Visible = false;
                    gbx_datosProducto.Enabled = false;
                }
                catch (Exception i)
                {
                    MessageBox.Show("No hay datos que borrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Console.WriteLine(i);
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
