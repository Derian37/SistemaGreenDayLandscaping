using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal(id_usuario, usuario, cargo);
            principal.Show();
            this.SetVisibleCore(false);
        }
    }
}
