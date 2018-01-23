namespace CapaPresentacion
{
    partial class frmBitacora
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBitacora));
            this.grb_menuProducto = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Monto = new System.Windows.Forms.TextBox();
            this.lbl_agregarProducto = new System.Windows.Forms.Label();
            this.lblDuenno_nombre = new System.Windows.Forms.Label();
            this.txt_Detalle = new System.Windows.Forms.TextBox();
            this.btnInsertarProducto = new System.Windows.Forms.Button();
            this.lbl_eliminarProducto = new System.Windows.Forms.Label();
            this.dgvDepositos = new System.Windows.Forms.DataGridView();
            this.gbx_datosProducto = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_guardarProducto = new System.Windows.Forms.Label();
            this.btn_guardarProducto = new System.Windows.Forms.Button();
            this.txt_ModificaMonto = new System.Windows.Forms.TextBox();
            this.btn_EliminarProducto = new System.Windows.Forms.Button();
            this.txt_ModificarDetalle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recuperarEliminadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recuperarEliminadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vaciarBitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grb_menuProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepositos)).BeginInit();
            this.gbx_datosProducto.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_menuProducto
            // 
            this.grb_menuProducto.BackColor = System.Drawing.Color.Transparent;
            this.grb_menuProducto.Controls.Add(this.radioButton2);
            this.grb_menuProducto.Controls.Add(this.radioButton1);
            this.grb_menuProducto.Controls.Add(this.dateTimePicker1);
            this.grb_menuProducto.Controls.Add(this.label7);
            this.grb_menuProducto.Controls.Add(this.label5);
            this.grb_menuProducto.Controls.Add(this.txt_Monto);
            this.grb_menuProducto.Controls.Add(this.lbl_agregarProducto);
            this.grb_menuProducto.Controls.Add(this.lblDuenno_nombre);
            this.grb_menuProducto.Controls.Add(this.txt_Detalle);
            this.grb_menuProducto.Controls.Add(this.btnInsertarProducto);
            this.grb_menuProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grb_menuProducto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_menuProducto.Location = new System.Drawing.Point(60, 33);
            this.grb_menuProducto.Margin = new System.Windows.Forms.Padding(4);
            this.grb_menuProducto.Name = "grb_menuProducto";
            this.grb_menuProducto.Padding = new System.Windows.Forms.Padding(4);
            this.grb_menuProducto.Size = new System.Drawing.Size(418, 239);
            this.grb_menuProducto.TabIndex = 64;
            this.grb_menuProducto.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(76, 78);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 23);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Otros";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(76, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(99, 23);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Somos Voz";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(95, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 161);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 75;
            this.label7.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 73;
            this.label5.Text = "Monto: ₡";
            // 
            // txt_Monto
            // 
            this.txt_Monto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_Monto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txt_Monto.BackColor = System.Drawing.Color.White;
            this.txt_Monto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Monto.Location = new System.Drawing.Point(95, 118);
            this.txt_Monto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Monto.Name = "txt_Monto";
            this.txt_Monto.Size = new System.Drawing.Size(190, 26);
            this.txt_Monto.TabIndex = 3;
            this.txt_Monto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Monto_KeyPress);
            // 
            // lbl_agregarProducto
            // 
            this.lbl_agregarProducto.Location = new System.Drawing.Point(334, 205);
            this.lbl_agregarProducto.Name = "lbl_agregarProducto";
            this.lbl_agregarProducto.Size = new System.Drawing.Size(72, 23);
            this.lbl_agregarProducto.TabIndex = 69;
            this.lbl_agregarProducto.Text = "Agregar";
            // 
            // lblDuenno_nombre
            // 
            this.lblDuenno_nombre.AutoSize = true;
            this.lblDuenno_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lblDuenno_nombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDuenno_nombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuenno_nombre.Location = new System.Drawing.Point(5, 30);
            this.lblDuenno_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuenno_nombre.Name = "lblDuenno_nombre";
            this.lblDuenno_nombre.Size = new System.Drawing.Size(63, 19);
            this.lblDuenno_nombre.TabIndex = 59;
            this.lblDuenno_nombre.Text = "Detalle:";
            // 
            // txt_Detalle
            // 
            this.txt_Detalle.BackColor = System.Drawing.Color.White;
            this.txt_Detalle.Enabled = false;
            this.txt_Detalle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Detalle.Location = new System.Drawing.Point(148, 75);
            this.txt_Detalle.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Detalle.Name = "txt_Detalle";
            this.txt_Detalle.Size = new System.Drawing.Size(190, 26);
            this.txt_Detalle.TabIndex = 58;
            // 
            // btnInsertarProducto
            // 
            this.btnInsertarProducto.BackgroundImage = global::CapaPresentacion.Properties.Resources.guardar;
            this.btnInsertarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsertarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertarProducto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnInsertarProducto.Location = new System.Drawing.Point(338, 144);
            this.btnInsertarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertarProducto.Name = "btnInsertarProducto";
            this.btnInsertarProducto.Size = new System.Drawing.Size(62, 57);
            this.btnInsertarProducto.TabIndex = 5;
            this.btnInsertarProducto.Text = " ";
            this.btnInsertarProducto.UseVisualStyleBackColor = true;
            this.btnInsertarProducto.Click += new System.EventHandler(this.btnInsertarProducto_Click);
            // 
            // lbl_eliminarProducto
            // 
            this.lbl_eliminarProducto.Location = new System.Drawing.Point(474, 100);
            this.lbl_eliminarProducto.Name = "lbl_eliminarProducto";
            this.lbl_eliminarProducto.Size = new System.Drawing.Size(67, 23);
            this.lbl_eliminarProducto.TabIndex = 70;
            this.lbl_eliminarProducto.Text = "Eliminar";
            // 
            // dgvDepositos
            // 
            this.dgvDepositos.AllowUserToAddRows = false;
            this.dgvDepositos.AllowUserToDeleteRows = false;
            this.dgvDepositos.AllowUserToResizeColumns = false;
            this.dgvDepositos.AllowUserToResizeRows = false;
            this.dgvDepositos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepositos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDepositos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDepositos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvDepositos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepositos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDepositos.Location = new System.Drawing.Point(60, 312);
            this.dgvDepositos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDepositos.MultiSelect = false;
            this.dgvDepositos.Name = "dgvDepositos";
            this.dgvDepositos.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            this.dgvDepositos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDepositos.RowTemplate.ReadOnly = true;
            this.dgvDepositos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDepositos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepositos.Size = new System.Drawing.Size(1185, 348);
            this.dgvDepositos.TabIndex = 65;
            this.dgvDepositos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            this.dgvDepositos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellDoubleClick);
            // 
            // gbx_datosProducto
            // 
            this.gbx_datosProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbx_datosProducto.Controls.Add(this.button1);
            this.gbx_datosProducto.Controls.Add(this.comboBox1);
            this.gbx_datosProducto.Controls.Add(this.dateTimePicker2);
            this.gbx_datosProducto.Controls.Add(this.label1);
            this.gbx_datosProducto.Controls.Add(this.label2);
            this.gbx_datosProducto.Controls.Add(this.label3);
            this.gbx_datosProducto.Controls.Add(this.lbl_guardarProducto);
            this.gbx_datosProducto.Controls.Add(this.btn_guardarProducto);
            this.gbx_datosProducto.Controls.Add(this.lbl_eliminarProducto);
            this.gbx_datosProducto.Controls.Add(this.txt_ModificaMonto);
            this.gbx_datosProducto.Controls.Add(this.btn_EliminarProducto);
            this.gbx_datosProducto.Controls.Add(this.txt_ModificarDetalle);
            this.gbx_datosProducto.Controls.Add(this.label4);
            this.gbx_datosProducto.Controls.Add(this.id);
            this.gbx_datosProducto.Enabled = false;
            this.gbx_datosProducto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_datosProducto.Location = new System.Drawing.Point(547, 34);
            this.gbx_datosProducto.Name = "gbx_datosProducto";
            this.gbx_datosProducto.Size = new System.Drawing.Size(610, 240);
            this.gbx_datosProducto.TabIndex = 68;
            this.gbx_datosProducto.TabStop = false;
            this.gbx_datosProducto.Text = "Modificar";
            this.gbx_datosProducto.Visible = false;
            this.gbx_datosProducto.Enter += new System.EventHandler(this.gbx_datosProducto_Enter);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::CapaPresentacion.Properties.Resources.cerrar_min;
            this.button1.Location = new System.Drawing.Point(564, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 34);
            this.button1.TabIndex = 87;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Activo",
            "Desactivo"});
            this.comboBox1.Location = new System.Drawing.Point(104, 167);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.AllowDrop = true;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(104, 117);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(173, 26);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 83;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 82;
            this.label2.Text = "Monto: ₡";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 81;
            this.label3.Text = "Detalle:";
            // 
            // lbl_guardarProducto
            // 
            this.lbl_guardarProducto.AutoSize = true;
            this.lbl_guardarProducto.Location = new System.Drawing.Point(474, 181);
            this.lbl_guardarProducto.Name = "lbl_guardarProducto";
            this.lbl_guardarProducto.Size = new System.Drawing.Size(75, 19);
            this.lbl_guardarProducto.TabIndex = 80;
            this.lbl_guardarProducto.Text = "Modificar";
            this.lbl_guardarProducto.Click += new System.EventHandler(this.lbl_guardarProducto_Click);
            // 
            // btn_guardarProducto
            // 
            this.btn_guardarProducto.BackgroundImage = global::CapaPresentacion.Properties.Resources.guardar;
            this.btn_guardarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardarProducto.FlatAppearance.BorderSize = 0;
            this.btn_guardarProducto.Location = new System.Drawing.Point(478, 128);
            this.btn_guardarProducto.Name = "btn_guardarProducto";
            this.btn_guardarProducto.Size = new System.Drawing.Size(57, 50);
            this.btn_guardarProducto.TabIndex = 79;
            this.btn_guardarProducto.UseVisualStyleBackColor = true;
            this.btn_guardarProducto.Click += new System.EventHandler(this.btn_guardarProducto_Click);
            // 
            // txt_ModificaMonto
            // 
            this.txt_ModificaMonto.Location = new System.Drawing.Point(104, 85);
            this.txt_ModificaMonto.Name = "txt_ModificaMonto";
            this.txt_ModificaMonto.Size = new System.Drawing.Size(251, 26);
            this.txt_ModificaMonto.TabIndex = 8;
            this.txt_ModificaMonto.TextChanged += new System.EventHandler(this.txt_ModificaMonto_TextChanged);
            this.txt_ModificaMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ModificaMonto_KeyPress);
            // 
            // btn_EliminarProducto
            // 
            this.btn_EliminarProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarProducto.BackgroundImage")));
            this.btn_EliminarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EliminarProducto.FlatAppearance.BorderSize = 0;
            this.btn_EliminarProducto.Location = new System.Drawing.Point(478, 47);
            this.btn_EliminarProducto.Name = "btn_EliminarProducto";
            this.btn_EliminarProducto.Size = new System.Drawing.Size(59, 50);
            this.btn_EliminarProducto.TabIndex = 61;
            this.btn_EliminarProducto.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_EliminarProducto.UseVisualStyleBackColor = true;
            this.btn_EliminarProducto.Click += new System.EventHandler(this.Btn_EliminarProductoClick);
            // 
            // txt_ModificarDetalle
            // 
            this.txt_ModificarDetalle.Location = new System.Drawing.Point(104, 50);
            this.txt_ModificarDetalle.Name = "txt_ModificarDetalle";
            this.txt_ModificarDetalle.Size = new System.Drawing.Size(251, 26);
            this.txt_ModificarDetalle.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 72;
            this.label4.Text = "Estado:";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(497, 67);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(21, 19);
            this.id.TabIndex = 85;
            this.id.Text = "id";
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.BackColor = System.Drawing.Color.White;
            this.txt_Buscar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Buscar.Location = new System.Drawing.Point(142, 282);
            this.txt_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(190, 26);
            this.txt_Buscar.TabIndex = 6;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.Location = new System.Drawing.Point(60, 283);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 25);
            this.btn_buscar.TabIndex = 71;
            this.btn_buscar.Text = " Buscar:";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(682, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 19);
            this.label6.TabIndex = 72;
            this.label6.Text = "Cantidad de Datos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(814, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 19);
            this.label8.TabIndex = 73;
            this.label8.Text = "0";
            // 
            // btn_volver
            // 
            this.btn_volver.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btn_volver.Image = ((System.Drawing.Image)(resources.GetObject("btn_volver.Image")));
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(106, 24);
            this.btn_volver.Text = "Consultar";
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(195, 24);
            this.toolStripMenuItem1.Text = "Recuperar Eliminados";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 19);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // recuperarEliminadosToolStripMenuItem
            // 
            this.recuperarEliminadosToolStripMenuItem.Name = "recuperarEliminadosToolStripMenuItem";
            this.recuperarEliminadosToolStripMenuItem.Size = new System.Drawing.Size(133, 19);
            this.recuperarEliminadosToolStripMenuItem.Text = "Recuperar Eliminados";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1169, 30);
            this.menuStrip1.TabIndex = 74;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem,
            this.recuperarEliminadosToolStripMenuItem1,
            this.vaciarBitacoraToolStripMenuItem});
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.toolStripMenuItem4.Image = global::CapaPresentacion.Properties.Resources.settings_4;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(133, 24);
            this.toolStripMenuItem4.Tag = "Herramientas";
            this.toolStripMenuItem4.Text = "Herramientas";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultarToolStripMenuItem.Image")));
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // recuperarEliminadosToolStripMenuItem1
            // 
            this.recuperarEliminadosToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("recuperarEliminadosToolStripMenuItem1.Image")));
            this.recuperarEliminadosToolStripMenuItem1.Name = "recuperarEliminadosToolStripMenuItem1";
            this.recuperarEliminadosToolStripMenuItem1.Size = new System.Drawing.Size(236, 24);
            this.recuperarEliminadosToolStripMenuItem1.Text = "Recuperar Eliminados";
            this.recuperarEliminadosToolStripMenuItem1.Click += new System.EventHandler(this.recuperarEliminadosToolStripMenuItem1_Click);
            // 
            // vaciarBitacoraToolStripMenuItem
            // 
            this.vaciarBitacoraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vaciarBitacoraToolStripMenuItem.Image")));
            this.vaciarBitacoraToolStripMenuItem.Name = "vaciarBitacoraToolStripMenuItem";
            this.vaciarBitacoraToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.vaciarBitacoraToolStripMenuItem.Text = "Vaciar Bitacora";
            this.vaciarBitacoraToolStripMenuItem.Click += new System.EventHandler(this.vaciarBitacoraToolStripMenuItem_Click);
            // 
            // frmBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1169, 681);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.gbx_datosProducto);
            this.Controls.Add(this.dgvDepositos);
            this.Controls.Add(this.grb_menuProducto);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBitacora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitacora";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProductos_FormClosing);
            this.Load += new System.EventHandler(this.FrmProductosLoad);
            this.grb_menuProducto.ResumeLayout(false);
            this.grb_menuProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepositos)).EndInit();
            this.gbx_datosProducto.ResumeLayout(false);
            this.gbx_datosProducto.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lbl_agregarProducto;
        private System.Windows.Forms.Label lbl_eliminarProducto;

        #endregion

        private System.Windows.Forms.GroupBox grb_menuProducto;
        public System.Windows.Forms.Button btnInsertarProducto;
        private System.Windows.Forms.Label lblDuenno_nombre;
        private System.Windows.Forms.TextBox txt_Detalle;
        private System.Windows.Forms.DataGridView dgvDepositos;
        private System.Windows.Forms.GroupBox gbx_datosProducto;
        private System.Windows.Forms.TextBox txt_ModificaMonto;
        private System.Windows.Forms.TextBox txt_ModificarDetalle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_EliminarProducto;
        private System.Windows.Forms.Button btn_guardarProducto;
        private System.Windows.Forms.Label lbl_guardarProducto;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Monto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ToolStripMenuItem btn_volver;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recuperarEliminadosToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recuperarEliminadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vaciarBitacoraToolStripMenuItem;
    }
}