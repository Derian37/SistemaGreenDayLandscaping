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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnControlTrabajo = new System.Windows.Forms.Button();
            this.lblVeterinario = new System.Windows.Forms.Label();
            this.pctUsuario = new System.Windows.Forms.PictureBox();
            this.lbl_usuarioCargo = new System.Windows.Forms.Label();
            this.lbl_usuarioNombre = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GrpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "User:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Area:";
            // 
            // GrpPrincipal
            // 
            this.GrpPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpPrincipal.AutoSize = true;
            this.GrpPrincipal.BackColor = System.Drawing.Color.AliceBlue;
            this.GrpPrincipal.Controls.Add(this.button1);
            this.GrpPrincipal.Controls.Add(this.label3);
            this.GrpPrincipal.Controls.Add(this.btnControlTrabajo);
            this.GrpPrincipal.Controls.Add(this.lblVeterinario);
            this.GrpPrincipal.Location = new System.Drawing.Point(12, 201);
            this.GrpPrincipal.Name = "GrpPrincipal";
            this.GrpPrincipal.Size = new System.Drawing.Size(1187, 483);
            this.GrpPrincipal.TabIndex = 11;
            this.GrpPrincipal.TabStop = false;
            this.GrpPrincipal.Enter += new System.EventHandler(this.GrpPrincipal_Enter);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::CapaPresentacion.Properties.Resources.login;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(227, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 112);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 27);
            this.label3.TabIndex = 21;
            this.label3.Text = "Expenses";
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
            this.btnControlTrabajo.Location = new System.Drawing.Point(58, 30);
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
            this.lblVeterinario.Location = new System.Drawing.Point(59, 145);
            this.lblVeterinario.Name = "lblVeterinario";
            this.lblVeterinario.Size = new System.Drawing.Size(110, 27);
            this.lblVeterinario.TabIndex = 19;
            this.lblVeterinario.Text = "Customers";
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
            this.lbl_usuarioCargo.Size = new System.Drawing.Size(0, 25);
            this.lbl_usuarioCargo.TabIndex = 14;
            // 
            // lbl_usuarioNombre
            // 
            this.lbl_usuarioNombre.AutoSize = true;
            this.lbl_usuarioNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuarioNombre.Location = new System.Drawing.Point(212, 37);
            this.lbl_usuarioNombre.Name = "lbl_usuarioNombre";
            this.lbl_usuarioNombre.Size = new System.Drawing.Size(0, 25);
            this.lbl_usuarioNombre.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1211, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrip_usuarios});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.configuraciónToolStripMenuItem.Text = "Configurar";
            // 
            // toolstrip_usuarios
            // 
            this.toolstrip_usuarios.Name = "toolstrip_usuarios";
            this.toolstrip_usuarios.Size = new System.Drawing.Size(140, 26);
            this.toolstrip_usuarios.Text = "Usuarios";
            this.toolstrip_usuarios.Click += new System.EventHandler(this.toolstrip_usuarios_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(372, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 158);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(175, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(405, 39);
            this.label6.TabIndex = 53;
            this.label6.Text = "Green Day Landscaping";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 17);
            this.label7.TabIndex = 54;
            this.label7.Text = "29 Aiken ST UNIT 3B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 17);
            this.label8.TabIndex = 55;
            this.label8.Text = "Address: Norwalk,CT06851";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(220, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(281, 17);
            this.label10.TabIndex = 57;
            this.label10.Text = "E-mail: greendaylandscaoingllc@gmail.com";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(244, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 17);
            this.label9.TabIndex = 56;
            this.label9.Text = "Tele.Phone: (203 515 6157)";
            // 
            // frmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1211, 696);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}