namespace CapaPresentacion
{
    partial class frmReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporte));
            this.crv_Report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crv_Report
            // 
            this.crv_Report.ActiveViewIndex = -1;
            this.crv_Report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Report.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Report.Location = new System.Drawing.Point(0, 31);
            this.crv_Report.Name = "crv_Report";
            this.crv_Report.ShowCloseButton = false;
            this.crv_Report.ShowCopyButton = false;
            this.crv_Report.ShowGotoPageButton = false;
            this.crv_Report.ShowGroupTreeButton = false;
            this.crv_Report.ShowLogo = false;
            this.crv_Report.ShowParameterPanelButton = false;
            this.crv_Report.Size = new System.Drawing.Size(737, 470);
            this.crv_Report.TabIndex = 0;
            this.crv_Report.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
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
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(737, 28);
            this.menuStrip1.TabIndex = 95;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 501);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.crv_Report);
            this.Name = "frmReporte";
            this.Text = "frmReporte";
            this.Load += new System.EventHandler(this.frmReporte_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Report;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}