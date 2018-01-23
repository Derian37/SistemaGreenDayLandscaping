using System;
using System.Data;
using System.Windows.Forms;
using SistemaBitacora.CapaIntegracion;

namespace CapaPresentacion
{
    public partial class frmRecuperar : Form
    {

        DataTable dtBitacora = new DataTable();
        DataSet dsBitacora = new DataSet();
        public frmRecuperar()
        {
            InitializeComponent();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            frmBitacora frm_Principal = new frmBitacora();
            frm_Principal.Show();
            this.SetVisibleCore(false);
        }

        private void frmRecuperar_Load(object sender, EventArgs e)
        {
            CargarGridProductos();
        }
        private void CargarGridProductos()
        {
            using (GestorRegistro registro = new GestorRegistro())
            {
                dgvProductos.DataSource = registro.ListarRegistroEliminado();

                dgvProductos.Columns["id_registro"].Visible = false;
                dgvProductos.Columns["detalle"].HeaderText = "Detalle";
                dgvProductos.Columns["monto"].HeaderText = "Monto";
                dgvProductos.Columns["fecha"].HeaderText = "Fecha";
                dgvProductos.Columns["estado"].HeaderText = "Estado";

            }
            label8.Text = dgvProductos.RowCount.ToString();
        }

        private void btn_EliminarProducto_Click(object sender, EventArgs e)
        {
            Recuperar();
        }

        private void Recuperar()
        {
            try
            {
                using (GestorRegistro registro = new GestorRegistro())
                {
                    registro.ModificarTarjeta(int.Parse(id.Text), txt_RecuperarDetalle.Text.ToUpper(), float.Parse(txt_RecuperarMonto.Text), dateTimePicker2.Value, "Activo");
                }
                CargarGridProductos();
                MessageBox.Show("Dato Recuperado Satisfactoriamente como (Activo)", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbx_datosProducto.Visible = false;
                gbx_datosProducto.Enabled = false;
            }
            catch (Exception i)
            {
                MessageBox.Show("Debe llenar todos los datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine(i);
            }
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gbx_datosProducto.Visible = true;
            gbx_datosProducto.Enabled = true;
            id.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            txt_RecuperarDetalle.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            txt_RecuperarMonto.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker2.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();

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
                    MessageBox.Show("Debe introducir un detalle.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    CargarGridProductos();
                }
                else
                {

                    using (GestorRegistro registro = new GestorRegistro())
                    {

                        this.dsBitacora = registro.ConsultarDetalle(txt_Buscar.Text);
                        this.dtBitacora = this.dsBitacora.Tables[0];
                        dgvProductos.DataSource = dtBitacora;

                        dgvProductos.Columns["id_registro"].Visible = false;
                        dgvProductos.Columns["detalle"].HeaderText = "Detalle";
                        dgvProductos.Columns["monto"].HeaderText = "Monto";
                        dgvProductos.Columns["fecha"].HeaderText = "Fecha";
                        dgvProductos.Columns["estado"].HeaderText = "Estado";

                    }
                    if (dgvProductos.Rows.Count == 0)
                    {
                        MessageBox.Show("Dato no existente.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        txt_Buscar.Text = "";
                        CargarGridProductos();
                    }
                }
            }
            catch (Exception i)
            {
                MessageBox.Show("Dato No Existente");
                Console.WriteLine(i);
            }
        }

        private void frmRecuperar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void Eliminar()
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro de Eliminar los datos definitivamente", "Aviso Importante", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    using (GestorRegistro registro = new GestorRegistro())
                    {
                        registro.EliminarDato();
                    }
                    CargarGridProductos();
                    MessageBox.Show("Datos borrados satisfactoriamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gbx_datosProducto.Visible = false;
                    gbx_datosProducto.Enabled = false;
                }
                catch (Exception i)
                {
                    MessageBox.Show("No hay datos que borrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.WriteLine(i);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }
    }
}
