namespace CapaPresentacion
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtLatName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.gbxDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeuda.Location = new System.Drawing.Point(407, 101);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(97, 15);
            this.lblDeuda.TabIndex = 35;
            this.lblDeuda.Text = "Postal Code";
            this.lblDeuda.Click += new System.EventHandler(this.lblDeuda_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(27, 100);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 15);
            this.lblTelefono.TabIndex = 34;
            this.lblTelefono.Text = "Address";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(774, 32);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(83, 15);
            this.lblDireccion.TabIndex = 33;
            this.lblDireccion.Text = "Telephone";
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido1.Location = new System.Drawing.Point(404, 33);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(80, 15);
            this.lblApellido1.TabIndex = 31;
            this.lblApellido1.Text = "Last Name";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(27, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(45, 15);
            this.lblNombre.TabIndex = 30;
            this.lblNombre.Text = "Name";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostalCode.Location = new System.Drawing.Point(549, 96);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(190, 26);
            this.txtPostalCode.TabIndex = 28;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(169, 96);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(190, 26);
            this.txtAddress.TabIndex = 27;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephone.Location = new System.Drawing.Point(904, 29);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(190, 26);
            this.txtTelephone.TabIndex = 26;
            this.txtTelephone.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // txtLatName
            // 
            this.txtLatName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLatName.Location = new System.Drawing.Point(549, 28);
            this.txtLatName.Name = "txtLatName";
            this.txtLatName.Size = new System.Drawing.Size(190, 26);
            this.txtLatName.TabIndex = 24;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(169, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 26);
            this.txtName.TabIndex = 23;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1309, 28);
            this.menuStrip1.TabIndex = 75;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.volverToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("volverToolStripMenuItem.Image")));
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.volverToolStripMenuItem.Text = "Volver";
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvCliente.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(47, 363);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.Size = new System.Drawing.Size(1233, 321);
            this.dgvCliente.TabIndex = 76;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick);
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.Cancel);
            this.gbxDatos.Controls.Add(this.comboBox1);
            this.gbxDatos.Controls.Add(this.label4);
            this.gbxDatos.Controls.Add(this.label3);
            this.gbxDatos.Controls.Add(this.button1);
            this.gbxDatos.Controls.Add(this.label1);
            this.gbxDatos.Controls.Add(this.txtName);
            this.gbxDatos.Controls.Add(this.lblNombre);
            this.gbxDatos.Controls.Add(this.txtLatName);
            this.gbxDatos.Controls.Add(this.lblApellido1);
            this.gbxDatos.Controls.Add(this.txtTelephone);
            this.gbxDatos.Controls.Add(this.btnGuardar);
            this.gbxDatos.Controls.Add(this.lblDireccion);
            this.gbxDatos.Controls.Add(this.lblDeuda);
            this.gbxDatos.Controls.Add(this.txtAddress);
            this.gbxDatos.Controls.Add(this.txtPostalCode);
            this.gbxDatos.Controls.Add(this.lblTelefono);
            this.gbxDatos.Controls.Add(this.lblCode);
            this.gbxDatos.Controls.Add(this.btnModificar);
            this.gbxDatos.Controls.Add(this.label2);
            this.gbxDatos.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatos.Location = new System.Drawing.Point(47, 57);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(1233, 270);
            this.gbxDatos.TabIndex = 80;
            this.gbxDatos.TabStop = false;
            this.gbxDatos.Enter += new System.EventHandler(this.gbxDatos_Enter);
            // 
            // Cancel
            // 
            this.Cancel.BackgroundImage = global::CapaPresentacion.Properties.Resources.delete_64;
            this.Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cancel.Location = new System.Drawing.Point(1192, 11);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(41, 36);
            this.Cancel.TabIndex = 49;
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Visible = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "e";
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "00",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100"});
            this.comboBox1.Location = new System.Drawing.Point(904, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 48;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(774, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 15);
            this.label4.TabIndex = 47;
            this.label4.Text = "Static Price     $ ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(927, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "View the Bills";
            this.label3.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CapaPresentacion.Properties.Resources.siguiente;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(948, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 58);
            this.button1.TabIndex = 45;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1069, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Save New Customer";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::CapaPresentacion.Properties.Resources.guardar;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(1105, 178);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(62, 58);
            this.btnGuardar.TabIndex = 39;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(810, 178);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(0, 17);
            this.lblCode.TabIndex = 44;
            this.lblCode.Visible = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = global::CapaPresentacion.Properties.Resources.modificar;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Location = new System.Drawing.Point(1105, 178);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(62, 59);
            this.btnModificar.TabIndex = 41;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1069, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Modify Customer";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 81;
            this.label5.Text = "Customers:";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1309, 696);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Green Day Landscaping";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCliente_FormClosing);
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtLatName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label5;
    }
}