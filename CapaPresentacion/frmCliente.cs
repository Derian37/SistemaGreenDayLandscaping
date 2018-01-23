using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoOptica.CapaIntegracion;


namespace CapaPresentacion
{
    public partial class frmCliente : Form
    {

        DataTable dtCliente = new DataTable();
        DataSet dsCliente = new DataSet();

        string usuario;
        string cargo;
        int id_usuario;

        public frmCliente(int id_usuario, string nombre, string cargo)
        {
            this.id_usuario = id_usuario;
            usuario = nombre;
            this.cargo = cargo;
            InitializeComponent();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal(id_usuario, usuario, cargo);
            principal.Show();
            this.SetVisibleCore(false);
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            CargarGridCliente();
            //CargarComboCliente();
            //CargarComboOjo();
            //defecto();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtLatName.Text != ""  && txtTelephone.Text != "" && txtAddress.Text != "" && txtPostalCode.Text != "")
            {
                using (GestorCliente elCliente = new GestorCliente())
                {
                    elCliente.InsertarCliente(txtName.Text, txtLatName.Text, txtTelephone.Text, txtAddress.Text, txtPostalCode.Text);
                }
            }
            else
            {
                MessageBox.Show("¡ Debe rellenar todos los espacios ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            CargarGridCliente();
            //CargarComboCliente();
            //CargarComboOjo();
            defecto();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtLatName.Text != "" && txtAddress.Text != "" && txtTelephone.Text != "" && txtPostalCode.Text != "")
            {
                using (GestorCliente elCliente = new GestorCliente())
                {
                    elCliente.ModificarCliente(int.Parse(lblCode.Text.ToString()), txtName.Text, txtLatName.Text, txtTelephone.Text, txtAddress.Text, txtPostalCode.Text);
                }
            }
            else
            {
                MessageBox.Show("¡ Debe rellenar todos los espacios ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            CargarGridCliente();
            defecto();

        }

        /* private void btnInactivar_Click(object sender, EventArgs e)
         {
             if (cbxCliente.SelectedItem != null)
             {
                 using (GestorCliente elCliente = new GestorCliente())
                 {
                     elCliente.InactivarCliente(int.Parse(cbxCliente.SelectedValue.ToString()));
                 }
             }
             else
             {
                 MessageBox.Show("¡ Debe Seleccionar un Estudiante ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }
         }*/

        private void defecto()
        {
            //txtBuscar.Text = null;

        }

        /*private void CargarComboOjo()

        {
            try
            {
                using (GestorGeneral elGestorOjo = new GestorGeneral())
                {

                    cbxOjo.DataSource = elGestorOjo.ListarOjo();
                    cbxOjo.ValueMember = "id_ojo";
                    cbxOjo.DisplayMember = "tipo";
                }

            }

            catch (Exception e)
            {
                MessageBox.Show("Error de SQL: " + e.Message);
            }

        }*/

        private void CargarGridCliente()
        {
            using (GestorCliente elCliente = new GestorCliente())
            {
                dgvCliente.DataSource = elCliente.ListarCliente();
                dgvCliente.Columns["code"].Visible = false;
                dgvCliente.Columns["name"].HeaderText = "Name";
                dgvCliente.Columns["lastName"].HeaderText = "Last Name";
                dgvCliente.Columns["telephone"].HeaderText = "Telephone";
                dgvCliente.Columns["address"].HeaderText = "Address";
                dgvCliente.Columns["postalCode"].HeaderText = "Postal Code";


            }
        }

        /*private void CargarComboCliente()
        {
            try
            {
                using (GestorCliente elCliente = new GestorCliente())
                {
                    cbxCliente.DataSource = elCliente.ListarCliente();
                    cbxCliente.ValueMember = "id_cliente";
                    cbxCliente.DisplayMember = "cedula";
                }

            }

            catch (Exception e)
            {
                MessageBox.Show("Error de SQL: " + e.Message);
            }

        }*/

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //if (txtBuscar.Text != "")
            //{



            //    if (txtBuscar.Text != null)
            //    {

            //        using (GestorCliente Cliente = new GestorCliente())
            //        {
            //            this.dsCliente = Cliente.ConsultarClienteCedula(txtBuscar.Text);
            //            this.dtCliente = this.dsCliente.Tables[0];

            //        }
                    CargarGridCliente();
                    // CargarComboCliente();
                    //CargarComboOjo();
                    // defecto();
            //    }
            //    else
            //    {
            //        MessageBox.Show("¡ Debe insertar una cedula ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //    }

            //    CargarDatosCliente();
            //}
            //else
            //{
            //    MessageBox.Show("¡ Debe insertar una cedula ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //}
        }



        private void CargarDatosCliente()
        {
            //cbxCliente.SelectedValue = this.dtCliente.Rows[0]["id_cliente"].ToString();
            //txtCedula.Text = this.dtCliente.Rows[0]["cedula"].ToString();
            //txtNombre.Text = this.dtCliente.Rows[0]["nombre"].ToString();
            //txtApellido1.Text = this.dtCliente.Rows[0]["apellido1"].ToString();
            //txtApellido2.Text = this.dtCliente.Rows[0]["apellido2"].ToString();
            //txtDireccion.Text = this.dtCliente.Rows[0]["direccion"].ToString();
            //txtTelefono.Text = this.dtCliente.Rows[0]["telefono"].ToString();
            //txtDeuda.Text = this.dtCliente.Rows[0]["deuda"].ToString();

        }

        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblDeuda_Click(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbxDatos_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCode.Text= dgvCliente.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvCliente.CurrentRow.Cells[1].Value.ToString();
            txtLatName.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString();
            txtTelephone.Text = dgvCliente.CurrentRow.Cells[3].Value.ToString();
            txtAddress.Text = dgvCliente.CurrentRow.Cells[4].Value.ToString();
            txtPostalCode.Text = dgvCliente.CurrentRow.Cells[5].Value.ToString();
        }

        /* private void cbxOjo_SelectedIndexChanged(object sender, EventArgs e)
         {

         }*/
    }
}
