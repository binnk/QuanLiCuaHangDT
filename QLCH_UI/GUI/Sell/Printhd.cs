using Microsoft.Reporting.WinForms;
using QLCH_UI.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH_UI.GUI.Sell
{
    public partial class Printhd : Form
    {
        string ma;
       
        public Printhd(string mahd)
        {
            InitializeComponent();
            ma = mahd;
            //reportViewer1.Controls.PreviewKeyDown = true;
        }

        private void Printhd_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            // private string connectionSTR = "Data Source=LAPTOP-0096GMC1;Initial Catalog=QL_CHDT;User ID=sa; PassWord=buiminhhuy;";
            ReportDataSource dataSource = ConnectSQL.Instance.Datasoucre(ma);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
        }
    }
}
