namespace ManageShop
{
    partial class Reportfrm
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
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Report1 = new ManageShop.Report();
            this.crystalReportViewer3 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Report2 = new ManageShop.Report();
            this.SuspendLayout();
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = 0;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer2.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.ReportSource = this.Report1;
            this.crystalReportViewer2.Size = new System.Drawing.Size(630, 308);
            this.crystalReportViewer2.TabIndex = 0;
            // 
            // crystalReportViewer3
            // 
            this.crystalReportViewer3.ActiveViewIndex = 0;
            this.crystalReportViewer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer3.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer3.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer3.Name = "crystalReportViewer3";
            this.crystalReportViewer3.ReportSource = this.Report2;
            this.crystalReportViewer3.Size = new System.Drawing.Size(630, 308);
            this.crystalReportViewer3.TabIndex = 1;
            // 
            // Reportfrm
            // 
            this.ClientSize = new System.Drawing.Size(630, 308);
            this.Controls.Add(this.crystalReportViewer3);
            this.Controls.Add(this.crystalReportViewer2);
            this.Name = "Reportfrm";
            this.Load += new System.EventHandler(this.Reportfrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private Report Report1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer3;
        private Report Report2;
    }
}