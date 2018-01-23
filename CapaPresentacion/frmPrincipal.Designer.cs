namespace CapaPresentacion
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GrpPrincipal = new System.Windows.Forms.GroupBox();
            this.pctUsuario = new System.Windows.Forms.PictureBox();
            this.lbl_usuarioCargo = new System.Windows.Forms.Label();
            this.lbl_usuarioNombre = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.btnControlTrabajo = new System.Windows.Forms.Button();
            this.lblVeterinario = new System.Windows.Forms.Label();
            this.GrpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "LastName de Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cargo:";
            // 
            // GrpPrincipal
            // 
            this.GrpPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpPrincipal.AutoSize = true;
            this.GrpPrincipal.BackColor = System.Drawing.Color.AliceBlue;
            this.GrpPrincipal.Controls.Add(this.btnControlTrabajo);
            this.GrpPrincipal.Controls.Add(this.lblVeterinario);
            this.GrpPrincipal.Location = new System.Drawing.Point(55, 116);
            this.GrpPrincipal.Name = "GrpPrincipal";
            this.GrpPrincipal.Size = new System.Drawing.Size(1091, 574);
            this.GrpPrincipal.TabIndex = 11;
            this.GrpPrincipal.TabStop = false;
            this.GrpPrincipal.Enter += new System.EventHandler(this.GrpPrincipal_Enter);
            // 
            // pctUsuario
            // 
            this.pctUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pctUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctUsuario.BackgroundImage")));
            this.pctUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctUsuario.Location = new System.Drawing.Point(11, 36);
            this.pctUsuario.Name = "pctUsuario";
            this.pctUsuario.Size = new System.Drawing.Size(45, 42);
            this.pctUsuario.TabIndex = 6;
            this.pctUsuario.TabStop = false;
            // 
            // lbl_usuarioCargo
            // 
            this.lbl_usuarioCargo.AutoSize = true;
            this.lbl_usuarioCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuarioCargo.Location = new System.Drawing.Point(212, 61);
            this.lbl_usuarioCargo.Name = "lbl_usuarioCargo";
            this.lbl_usuarioCargo.Size = new System.Drawing.Size(0, 20);
            this.lbl_usuarioCargo.TabIndex = 14;
            // 
            // lbl_usuarioNombre
            // 
            this.lbl_usuarioNombre.AutoSize = true;
            this.lbl_usuarioNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuarioNombre.Location = new System.Drawing.Point(212, 37);
            this.lbl_usuarioNombre.Name = "lbl_usuarioNombre";
            this.lbl_usuarioNombre.Size = new System.Drawing.Size(0, 20);
            this.lbl_usuarioNombre.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1211, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrip_usuarios});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.configuraciónToolStripMenuItem.Text = "Configurar";
            // 
            // toolstrip_usuarios
            // 
            this.toolstrip_usuarios.Name = "toolstrip_usuarios";
            this.toolstrip_usuarios.Size = new System.Drawing.Size(119, 22);
            this.toolstrip_usuarios.Text = "Usuarios";
            this.toolstrip_usuarios.Click += new System.EventHandler(this.toolstrip_usuarios_Click);
            // 
            // btnControlTrabajo
            // 
            this.btnControlTrabajo.AutoSize = true;
            this.btnControlTrabajo.BackColor = System.Drawing.Color.Transparent;
            this.btnControlTrabajo.BackgroundImage = global::CapaPresentacion.Properties.Resources.user_icon;
            this.btnControlTrabajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnControlTrabajo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnControlTrabajo.FlatAppearance.BorderSize = 0;
            this.btnControlTrabajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControlTrabajo.Location = new System.Drawing.Point(49, 30);
            this.btnControlTrabajo.Name = "btnControlTrabajo";
            this.btnControlTrabajo.Size = new System.Drawing.Size(108, 112);
            this.btnControlTrabajo.TabIndex = 20;
            this.btnControlTrabajo.UseVisualStyleBackColor = false;
            this.btnControlTrabajo.Click += new System.EventHandler(this.btnControlTrabajo_Click_1);
            // 
            // lblVeterinario
            // 
            this.lblVeterinario.AutoSize = true;
            this.lblVeterinario.BackColor = System.Drawing.Color.Transparent;
            this.lblVeterinario.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeterinario.Location = new System.Drawing.Point(45, 145);
            this.lblVeterinario.Name = "lblVeterinario";
            this.lblVeterinario.Size = new System.Drawing.Size(117, 22);
            this.lblVeterinario.TabIndex = 19;
            this.lblVeterinario.Text = "Add Customers";
            // 
            // frmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1211, 696);
            this.Controls.Add(this.lbl_usuarioNombre);
            this.Controls.Add(this.lbl_usuarioCargo);
            this.Controls.Add(this.GrpPrincipal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctUsuario);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Green Day Landscaping";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipalLoad);
            this.GrpPrincipal.ResumeLayout(false);
            this.GrpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GrpPrincipal;
        private System.Windows.Forms.Label lbl_usuarioCargo;
        private System.Windows.Forms.Label lbl_usuarioNombre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolstrip_usuarios;
        private System.Windows.Forms.Button btnControlTrabajo;
        private System.Windows.Forms.Label lblVeterinario;
    }
}