﻿namespace CapaPresentacion
{
    partial class FrmVentasModificar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentasModificar));
            this.dgv_ventas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.lbl_iva = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtGuys = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtPriceH = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.btnExpediente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.btn_Print = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.textUnits = new System.Windows.Forms.TextBox();
            this.textUnitPrice = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_ventas
            // 
            this.dgv_ventas.AllowUserToAddRows = false;
            this.dgv_ventas.AllowUserToDeleteRows = false;
            this.dgv_ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ventas.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ventas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ventas.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_ventas.Location = new System.Drawing.Point(12, 208);
            this.dgv_ventas.Name = "dgv_ventas";
            this.dgv_ventas.ReadOnly = true;
            this.dgv_ventas.Size = new System.Drawing.Size(1346, 367);
            this.dgv_ventas.TabIndex = 1;
            this.dgv_ventas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ventas_CellClick);
            this.dgv_ventas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ventas_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1144, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tax:   $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1108, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Due: $";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1104, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sub-total:   $";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Details:";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.MenuText;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(12, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(265, 24);
            this.label12.TabIndex = 35;
            this.label12.Text = "         DATE";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.MenuText;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(268, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(455, 24);
            this.label13.TabIndex = 36;
            this.label13.Text = "     DETAILS";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.MenuText;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(723, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(255, 24);
            this.label14.TabIndex = 37;
            this.label14.Text = "UNIT PRICE";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.MenuText;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(972, 208);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(386, 24);
            this.label17.TabIndex = 39;
            this.label17.Text = "AMOUNT";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_subtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subtotal.Location = new System.Drawing.Point(1215, 14);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(116, 30);
            this.lbl_subtotal.TabIndex = 45;
            this.lbl_subtotal.Text = "0";
            this.lbl_subtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_iva
            // 
            this.lbl_iva.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_iva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_iva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_iva.Location = new System.Drawing.Point(1215, 50);
            this.lbl_iva.Name = "lbl_iva";
            this.lbl_iva.Size = new System.Drawing.Size(116, 30);
            this.lbl_iva.TabIndex = 46;
            this.lbl_iva.Text = "0";
            this.lbl_iva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_total
            // 
            this.lbl_total.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_total.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(1215, 86);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(118, 30);
            this.lbl_total.TabIndex = 47;
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Agregar.Image = global::CapaPresentacion.Properties.Resources.agregar_min;
            this.btn_Agregar.Location = new System.Drawing.Point(730, 32);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(77, 63);
            this.btn_Agregar.TabIndex = 34;
            this.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(639, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "29 Aiken ST UNIT 2B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(614, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 20);
            this.label8.TabIndex = 50;
            this.label8.Text = "Address: Norwalk,CT06851";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(614, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "Tele.Phone: (203 515 6157)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(583, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(334, 20);
            this.label10.TabIndex = 52;
            this.label10.Text = "E-mail: greendaylandscaoingllc@gmail.com";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1207, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 20);
            this.label15.TabIndex = 53;
            this.label15.Text = "Date:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1253, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 20);
            this.label16.TabIndex = 54;
            this.label16.Text = "Fecha";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 191);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 20);
            this.label18.TabIndex = 55;
            this.label18.Text = "Price: $";
            // 
            // Date
            // 
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(82, 18);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(128, 26);
            this.Date.TabIndex = 57;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 20);
            this.label19.TabIndex = 58;
            this.label19.Text = "Date:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.lbl_total);
            this.groupBox1.Controls.Add(this.lbl_iva);
            this.groupBox1.Controls.Add(this.lbl_subtotal);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDetails);
            this.groupBox1.Controls.Add(this.btnExpediente);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Date);
            this.groupBox1.Controls.Add(this.btn_Agregar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Location = new System.Drawing.Point(12, 581);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1342, 214);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Controls.Add(this.txtGuys);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.txtHours);
            this.groupBox3.Controls.Add(this.label31);
            this.groupBox3.Controls.Add(this.txtPriceH);
            this.groupBox3.Location = new System.Drawing.Point(365, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(155, 193);
            this.groupBox3.TabIndex = 120;
            this.groupBox3.TabStop = false;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(47, 135);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(53, 20);
            this.label30.TabIndex = 118;
            this.label30.Text = "Price:";
            // 
            // txtGuys
            // 
            this.txtGuys.Enabled = false;
            this.txtGuys.Location = new System.Drawing.Point(29, 54);
            this.txtGuys.Name = "txtGuys";
            this.txtGuys.ReadOnly = true;
            this.txtGuys.Size = new System.Drawing.Size(100, 26);
            this.txtGuys.TabIndex = 113;
            this.txtGuys.Text = "0";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(47, 83);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(60, 20);
            this.label29.TabIndex = 117;
            this.label29.Text = "Hours:";
            // 
            // txtHours
            // 
            this.txtHours.Enabled = false;
            this.txtHours.Location = new System.Drawing.Point(29, 106);
            this.txtHours.Name = "txtHours";
            this.txtHours.ReadOnly = true;
            this.txtHours.Size = new System.Drawing.Size(100, 26);
            this.txtHours.TabIndex = 114;
            this.txtHours.Text = "0";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(47, 26);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(53, 20);
            this.label31.TabIndex = 116;
            this.label31.Text = "Guys:";
            // 
            // txtPriceH
            // 
            this.txtPriceH.Enabled = false;
            this.txtPriceH.Location = new System.Drawing.Point(29, 157);
            this.txtPriceH.Name = "txtPriceH";
            this.txtPriceH.ReadOnly = true;
            this.txtPriceH.Size = new System.Drawing.Size(100, 26);
            this.txtPriceH.TabIndex = 115;
            this.txtPriceH.Text = "0";
            this.txtPriceH.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPriceH_KeyUp);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(188, 187);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(117, 24);
            this.radioButton1.TabIndex = 100;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Static Price";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(82, 185);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 26);
            this.txtPrice.TabIndex = 97;
            this.txtPrice.Text = "0";
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            this.txtPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPrice_KeyUp);
            this.txtPrice.Validated += new System.EventHandler(this.txtPrice_Validated);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(739, 95);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(68, 22);
            this.label26.TabIndex = 75;
            this.label26.Text = "Modify";
            this.label26.Visible = false;
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(82, 53);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(271, 124);
            this.txtDetails.TabIndex = 96;
            // 
            // btnExpediente
            // 
            this.btnExpediente.BackColor = System.Drawing.Color.Transparent;
            this.btnExpediente.BackgroundImage = global::CapaPresentacion.Properties.Resources.modificar;
            this.btnExpediente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExpediente.FlatAppearance.BorderSize = 0;
            this.btnExpediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpediente.Location = new System.Drawing.Point(730, 29);
            this.btnExpediente.Name = "btnExpediente";
            this.btnExpediente.Size = new System.Drawing.Size(77, 63);
            this.btnExpediente.TabIndex = 74;
            this.btnExpediente.UseVisualStyleBackColor = false;
            this.btnExpediente.Visible = false;
            this.btnExpediente.Click += new System.EventHandler(this.btnExpediente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(753, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Add";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 98;
            this.label1.Visible = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(365, 40);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(0, 20);
            this.label27.TabIndex = 99;
            this.label27.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.btn_Print);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(12, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1342, 171);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(1274, 142);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(44, 20);
            this.label28.TabIndex = 105;
            this.label28.Text = "Print";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(88, 122);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(50, 20);
            this.label25.TabIndex = 60;
            this.label25.Text = "Date:";
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Print.BackgroundImage = global::CapaPresentacion.Properties.Resources.print_64;
            this.btn_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Print.Location = new System.Drawing.Point(1254, 79);
            this.btn_Print.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(77, 63);
            this.btn_Print.TabIndex = 104;
            this.btn_Print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(18, 122);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(81, 20);
            this.label24.TabIndex = 59;
            this.label24.Text = "Address: ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(88, 75);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(50, 20);
            this.label23.TabIndex = 58;
            this.label23.Text = "Date:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(18, 75);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(93, 20);
            this.label22.TabIndex = 57;
            this.label22.Text = "Last name:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(88, 33);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 20);
            this.label21.TabIndex = 56;
            this.label21.Text = "Date:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(18, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 20);
            this.label20.TabIndex = 55;
            this.label20.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(545, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(405, 39);
            this.label6.TabIndex = 2;
            this.label6.Text = "Green Day Landscaping";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 33);
            this.menuStrip1.TabIndex = 95;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.volverToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("volverToolStripMenuItem.Image")));
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(101, 29);
            this.volverToolStripMenuItem.Text = "Volver";
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton4);
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Controls.Add(this.label33);
            this.groupBox4.Controls.Add(this.textUnits);
            this.groupBox4.Controls.Add(this.textUnitPrice);
            this.groupBox4.Location = new System.Drawing.Point(540, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(155, 193);
            this.groupBox4.TabIndex = 121;
            this.groupBox4.TabStop = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(132, 14);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(17, 16);
            this.radioButton4.TabIndex = 120;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(17, 134);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(98, 20);
            this.label32.TabIndex = 118;
            this.label32.Text = "  Unit Price:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(43, 27);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(53, 20);
            this.label33.TabIndex = 117;
            this.label33.Text = "Units:";
            // 
            // textUnits
            // 
            this.textUnits.Enabled = false;
            this.textUnits.Location = new System.Drawing.Point(21, 53);
            this.textUnits.Name = "textUnits";
            this.textUnits.ReadOnly = true;
            this.textUnits.Size = new System.Drawing.Size(100, 26);
            this.textUnits.TabIndex = 114;
            this.textUnits.Text = "0";
            // 
            // textUnitPrice
            // 
            this.textUnitPrice.Enabled = false;
            this.textUnitPrice.Location = new System.Drawing.Point(21, 157);
            this.textUnitPrice.Name = "textUnitPrice";
            this.textUnitPrice.ReadOnly = true;
            this.textUnitPrice.Size = new System.Drawing.Size(100, 26);
            this.textUnitPrice.TabIndex = 115;
            this.textUnitPrice.Text = "0";
            this.textUnitPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textUnitPrice_KeyUp);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(132, 14);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(17, 16);
            this.radioButton2.TabIndex = 121;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // FrmVentasModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources._52869_1920_1080;
            this.ClientSize = new System.Drawing.Size(1370, 828);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_ventas);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(0, 50);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVentasModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " System Green Day Landscaping";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmVentas_FormClosing);
            this.Load += new System.EventHandler(this.FrmFacturacion_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmFacturacion_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_ventas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.Label lbl_iva;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
        private System.Windows.Forms.Button btnExpediente;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtGuys;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtPriceH;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox textUnits;
        private System.Windows.Forms.TextBox textUnitPrice;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}