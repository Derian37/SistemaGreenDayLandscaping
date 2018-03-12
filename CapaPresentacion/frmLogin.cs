using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGDL.CapaConexion;
using SistemaGDL.CapaIntegracion;
using SistemaGDL.CapaLogica.Servicio;


namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
       // int id_usuario;
        int user;
        string name;
        DataTable dtUsuario = new DataTable();
        DataSet dsUsuario = new DataSet();

        public frmLogin()
        {
            InitializeComponent();
        }

        public frmLogin(int id_usuario)
        {
            //this.id_usuario = id_usuario;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            CargarComboUsuario();
        }

        private void CargarComboUsuario()
        {
            try
            {
                using (GestorUsuario elGestorUsuario = new GestorUsuario())
                {
                    cbx_usuario_nombre.DataSource = elGestorUsuario.ListarUsuarios();
                    cbx_usuario_nombre.ValueMember = "id_user";
                    cbx_usuario_nombre.DisplayMember = "name";
                    user =  int.Parse(cbx_usuario_nombre.SelectedValue.ToString());
               

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error de SQL: " + e.Message);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string password = "";
           
            try
            {
                using (GestorUsuario elGestorUsuario = new GestorUsuario())
                {
                    password =  (string) elGestorUsuario.ConfirmPassword(user).Tables[0].Rows[0][0].ToString();

                }

                if (txt_usuario_Contrasena.Text == password)
                {
                    name = cbx_usuario_nombre.Text.ToString();
                    frmPrincipal principal = new frmPrincipal(user, name, "Desarrollador");
                    principal.Show();
                    this.SetVisibleCore(false);
                }
                else {
                    MessageBox.Show("La contraseña no coincide!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            catch (Exception i) {
                MessageBox.Show("La contraseña no coincide!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
    
            
        }

        private void txt_usuario_Contrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
    }
    

