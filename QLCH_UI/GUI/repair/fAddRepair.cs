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
    public partial class fAddRepair : Form
    {
        private string manv;
        public fAddRepair(string manvv)
        {
            manv = manvv;
            InitializeComponent();
            CB_Loai.Text = "Dienthoai";
            CB_gioitinh.Text = "Nam";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Huy
        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Luu
        private void gunaButton1_Click(object sender, EventArgs e)
        {
            string fault = BUS.SuachuaBUS.Instance.Check_fault(tb_Hoten.Text, tb_SDT.Text, tb_Diachi.Text, Tb_Tenmay.Text, tb_Ghichu.Text);
            if (fault == "")
            {
                string masc = DAO.SuachuaDAO.Instance.Get_MaSC();
                string year = DateTime.Now.Year.ToString();
                string month = DateTime.Now.Month.ToString();
                string day = DateTime.Now.Day.ToString();
                DataTable kh = DAO.SuachuaDAO.Instance.Load_infor_KH(tb_SDT.Text);
                if (kh.Rows.Count == 1)
                {
                    DAO.SuachuaDAO.Instance.Insert_SUA_CHUA(masc, year + "-" + month + "-" + day, kh.Rows[0]["makh"].ToString(), manv, Tb_Tenmay.Text, CB_Loai.Text, tb_Ghichu.Text);
                }
                else
                {
                    //MessageBox.Show(DateTimePicker.Value.ToString());
                    string makh = DAO.SuachuaDAO.Instance.Get_MaKH();
                    DAO.SuachuaDAO.Instance.Insert_KHACH_HANG(makh, tb_Hoten.Text, DateTimePicker.Value.ToString(), tb_Diachi.Text, tb_SDT.Text, CB_gioitinh.Text);
                    DAO.SuachuaDAO.Instance.Insert_SUA_CHUA(masc, year + "-" + month + "-" + day, makh, manv, Tb_Tenmay.Text, CB_Loai.Text, tb_Ghichu.Text);
                }
                this.Close();
            }
           else
            {
                lb_fault.Text = fault;
                lb_fault.Visible = true;
            }
        }
        //tb số điện thoại 
        private void tb_SDT_TextChanged(object sender, EventArgs e)
        {
            DataTable kh = DAO.SuachuaDAO.Instance.Load_infor_KH(tb_SDT.Text);
            if (kh.Rows.Count == 1)
            {
                tb_Diachi.Text = kh.Rows[0]["dia_chi"].ToString() ;
                tb_Hoten.Text = kh.Rows[0]["ten_kh"].ToString();
                CB_gioitinh.Text = kh.Rows[0]["gioi_tinh"].ToString();
                DateTimePicker.Value = DateTime.Parse(kh.Rows[0]["ngay_sinh"].ToString());
            }
        }
    }
}
