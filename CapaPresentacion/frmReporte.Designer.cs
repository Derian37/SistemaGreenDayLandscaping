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
            this.crv_Report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_Report
            // 
            this.crv_Report.ActiveViewIndex = -1;
            this.crv_Report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Report.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_Report.Location = new System.Drawing.Point(0, 0);
            this.crv_Report.Name = "crv_Report";
            this.crv_Report.ShowCloseButton = false;
            this.crv_Report.ShowCopyButton = false;
            this.crv_Report.ShowGotoPageButton = false;
            this.crv_Report.ShowGroupTreeButton = false;
            this.crv_Report.ShowLogo = false;
            this.crv_Report.ShowParameterPanelButton = false;
            this.crv_Report.Size = new System.Drawing.Size(737, 501);
            this.crv_Report.TabIndex = 0;
            this.crv_Report.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 501);
            this.Controls.Add(this.crv_Report);
            this.Name = "frmReporte";
            this.Text = "frmReporte";
            this.Load += new System.EventHandler(this.frmReporte_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Report;
    }
}