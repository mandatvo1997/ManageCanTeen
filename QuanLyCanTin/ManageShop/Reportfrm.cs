using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageShop
{
    public partial class Reportfrm : Form
    {
        public Reportfrm()
        {
            InitializeComponent();
        }
        String SoPhieu = "";
        public Reportfrm(String sp)
        {
            InitializeComponent();
            SoPhieu = sp;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            String sQuery = @"SELECT * FROM SellingInfo";
            DataTable dt = DataProvider.ExecuteQuery(sQuery, new object[] { SoPhieu });
            this.Report2.SetDataSource(dt);
            this.crystalReportViewer3.ReportSource = Report2;
            this.crystalReportViewer3.Show();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Reportfrm_Load(object sender, EventArgs e)
        {

        }
    }
}
