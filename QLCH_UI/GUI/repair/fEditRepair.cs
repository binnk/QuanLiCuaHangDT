using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH_UI
{
    public partial class fEditRepair : Form
    {
        private string masc;
        public fEditRepair(string massc)
        {
            masc = massc;
            InitializeComponent();
            Load(masc);
        }
        
        private void Load(string masc)
        {
            DataTable infor = DAO.SuachuaDAO.Instance.Load_InforSC(masc);
            if (infor.Rows.Count != 1)
                return;
            lb_MD.Text = masc;
            tb_tenmay.Text = infor.Rows[0]["ten_sp"].ToString() ;
            tb_ghichu.Text = infor.Rows[0]["ghi_chu"].ToString() ;
            cb_loai.Text =infor.Rows[0]["loai_sp"].ToString() ;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string fault = BUS.SuachuaBUS.Instance.Check_fault("f", "111", "dfd", tb_tenmay.Text, tb_ghichu.Text);
            if(fault != "")
            {
                lb_fault.Text = fault;
                lb_fault.Visible = true;
            }
            else
            {
                DAO.SuachuaDAO.Instance.Update_SC(masc, tb_tenmay.Text, tb_ghichu.Text, cb_loai.Text);
                this.Close();
            }
        }
    }
}
