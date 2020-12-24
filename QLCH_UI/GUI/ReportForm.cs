using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using QLCH_UI.BUS;
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
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Diagnostics;

namespace QLCH_UI
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            Load();
            Load_Chart_For_Year();
            //MessageBox.Show(datetime1.Value.ToString());
            
        }

        private void Load()
        {
            lb_doanh_thu.Text = BaocaoDAO.Instance.Get_Doanh_thu(Get_Datetime1(),Get_Datetime2());
            lb_hoadon.Text = BaocaoDAO.Instance.Get_So_HD(Get_Datetime1(), Get_Datetime2());
            lb_sanpham.Text = BaocaoDAO.Instance.Get_So_SP(Get_Datetime1(), Get_Datetime2());
            lb_khachhang.Text = BaocaoDAO.Instance.Get_So_KH();
            DataTable kh = BaocaoDAO.Instance.Get_Top_3_KH(Get_Datetime1(), Get_Datetime2());
            //khach hang 1
            comboBox1.Text = "Năm này";
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel6.Visible = true;
            panel7.Visible = true;
            if (kh.Rows.Count > 0)
            {
                lb1_makh.Text = kh.Rows[0]["makh"].ToString();
                lb1_tenkh.Text = kh.Rows[0]["ten_kh"].ToString();
                lb1_doanhthu.Text = Convert.ToDouble(kh.Rows[0]["doanh_thu"]).ToString("#,##0");

            }
            else
            {
                panel5.Visible = false;
            }
            //khach hang 2
            if (kh.Rows.Count > 1)
            {
                lb2_makh.Text = kh.Rows[1]["makh"].ToString();
                lb2_tenkh.Text = kh.Rows[1]["ten_kh"].ToString();
                lb2_doanhthu.Text = Convert.ToDouble(kh.Rows[1]["doanh_thu"]).ToString("#,##0");
            }
            else
            {
                panel6.Visible = false;
            }
            //khach hang 3
            if (kh.Rows.Count > 2)
            {
                lb3_makh.Text = kh.Rows[2]["makh"].ToString();
                lb3_tenkh.Text = kh.Rows[2]["ten_kh"].ToString();
                lb3_doanhthu.Text = Convert.ToDouble(kh.Rows[2]["doanh_thu"]).ToString("#,##0");
            }
            else
            {
                panel7.Visible = false;
            }
            DataTable sp = BaocaoDAO.Instance.Get_Top_4_SP(Get_Datetime1(), Get_Datetime2());
            // san phẩm 1
            if (sp.Rows.Count > 0)
            {
                lb1_tensp.Text = sp.Rows[0]["ten_sp"].ToString();
                lb1_doanhso.Text = sp.Rows[0]["sum"].ToString();
                ptb1_sp.Image = ProductBUS.Instance.ByteToImg(sp.Rows[0]["img"].ToString());

            }
            else
            {
                panel1.Visible = false;
            }
            // sản phẩm 2
            if (sp.Rows.Count > 1)
            {
                lb2_tensp.Text = sp.Rows[1]["ten_sp"].ToString();
                lb2_doanhso.Text = sp.Rows[1]["sum"].ToString();
                ptb2_sp.Image = ProductBUS.Instance.ByteToImg(sp.Rows[1]["img"].ToString());
            }
            else
            {
                panel2.Visible = false;
            }
            // sản phẩm 3
            if (sp.Rows.Count > 2)
            {
                lb3_tensp.Text = sp.Rows[2]["ten_sp"].ToString();
                lb3_doanhso.Text = sp.Rows[2]["sum"].ToString();
                ptb3_sp.Image = ProductBUS.Instance.ByteToImg(sp.Rows[2]["img"].ToString());

            }
            else
            {
                panel3.Visible = false;
            }
            // sản phẩm 4
            if (sp.Rows.Count > 3)
            {

                lb4_tensp.Text = sp.Rows[3]["ten_sp"].ToString();
                lb4_doanhso.Text = sp.Rows[3]["sum"].ToString();
                ptb4_sp.Image = ProductBUS.Instance.ByteToImg(sp.Rows[3]["img"].ToString());
            }
            else
            {
                panel4.Visible = false;
            }
        }
        private string Get_Datetime1()
        {
            string year = datetime1.Value.Year.ToString();
            string month = datetime1.Value.Month.ToString();
            string date = datetime1.Value.Day.ToString();
            return year + "-" + month + "-" + date;
        }
        private string Get_Datetime2()
        {
            string year = datetime2.Value.Year.ToString();
            string month = datetime2.Value.Month.ToString();
            string date = datetime2.Value.Day.ToString();
            return year + "-" + month + "-" + date;
        }

        private void datetime1_ValueChanged(object sender, EventArgs e)
        {
            Load();
        }

        private void datetime2_ValueChanged(object sender, EventArgs e)
        {
            if (datetime1.Value.Month < datetime2.Value.Month)
            { Load(); }
            if(datetime1.Value.Month == datetime2.Value.Month && datetime1.Value.Day < datetime2.Value.Day)
            { Load(); }
            //MessageBox.Show(Get_Datetime2());
        }
        // chart
        private void Load_Chart_For_Year()
        {
            cartesianChart1.AxisX.Clear();
            cartesianChart1.Series.Clear();
            Double[] re = new Double[13] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            DataTable revenue = BaocaoDAO.Instance.Revenue_Year_BH();
            DataTable revenueSC = BaocaoDAO.Instance.Revenue_Year_SC();
            for(int i =0; i< revenue.Rows.Count; i++)
            {
                re[Convert.ToInt32(revenue.Rows[i]["thang"])] = Convert.ToDouble(revenue.Rows[i]["doanh_thu"]);
            }
            for (int i = 0; i < revenueSC.Rows.Count; i++)
            {
                re[Convert.ToInt32(revenueSC.Rows[i]["thang"])] += Convert.ToDouble(revenueSC.Rows[i]["doanh_thu"]);
            }

            cartesianChart1.Series = new LiveCharts.SeriesCollection
            {
                new LineSeries
                {  
                    Title = "Revenue",
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,re[1]),
                        new ObservablePoint(1,re[2]),
                        new ObservablePoint(2,re[3]),
                        new ObservablePoint(3,re[4]),
                        new ObservablePoint(4,re[5]),
                        new ObservablePoint(5,re[6]),
                        new ObservablePoint(6,re[7]),
                        new ObservablePoint(7,re[8]),
                        new ObservablePoint(8,re[9]),
                        new ObservablePoint(9,re[10]),
                        new ObservablePoint(10,re[11]),
                        new ObservablePoint(11,re[12]),
                    },
                    PointGeometrySize =  10
                }
            };
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                MinValue =0,
                MinRange = 0,
                Labels = new[] {"Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec" }
            });
            //cartesianChart1.AxisX.
           
            
            
        }

        private void datetime2_TextChanged(object sender, EventArgs e)
        {
            Load();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Năm này")
            {
                Load_Chart_For_Year();
            } 
            else
            {
                Load_Chart_For_Month(comboBox1.Text);
            }    
        }
        private void Load_Chart_For_Month(string month)
        {
            string m = month.Substring(month.Length - 2);
            //MessageBox.Show(Convert.ToInt32(m).ToString());
            int n = DateTime.DaysInMonth(DateTime.Now.Year, Convert.ToInt32(m));
            cartesianChart1.AxisX.Clear();
            cartesianChart1.Series.Clear();
            
            Double[] re = new Double[n+1] ;
            DataTable revenue = BaocaoDAO.Instance.Revenue_Month_BH(Convert.ToInt32(m).ToString());
            DataTable revenueSC = BaocaoDAO.Instance.Revenue_Month_SC(Convert.ToInt32(m).ToString());
            for (int i = 0; i < revenue.Rows.Count; i++)
            {
                re[Convert.ToInt32(revenue.Rows[i]["ngay"])] = Convert.ToDouble(revenue.Rows[i]["doanh_thu"]);
            }
            for (int i = 0; i < revenueSC.Rows.Count; i++)
            {
                re[Convert.ToInt32(revenueSC.Rows[i]["ngay"])] += Convert.ToDouble(revenueSC.Rows[i]["doanh_thu"]);
            }

            ChartValues<ObservablePoint> p = new ChartValues<ObservablePoint>();
            for (int i = 1; i < re.Length; i++)
            {
                if (re[i] >= 0)
                    p.Add(new ObservablePoint(i, re[i]));
                else
                    p.Add(new ObservablePoint(i, 0));
            }
            cartesianChart1.Series = new LiveCharts.SeriesCollection
            {
                new LineSeries
                {
                    Title = "Revenue",
                    Values = p ,
                    PointGeometrySize = 7
                }
            };






        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            int ypoint = 0;
            PdfDocument pdf = new PdfDocument();
           pdf.Info.Title = "datbase";
            PdfPage pdfpage = pdf.AddPage();
            XGraphics graph = XGraphics.FromPdfPage(pdfpage);
            XFont font = new XFont("Verdana", 10, XFontStyle.Regular);
            ypoint = ypoint + 10;
            graph.DrawString("swadad", font, XBrushes.Black, new XRect(40, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
            string pdfFilename = "abc.pdf";
            pdf.Save(pdfFilename);
            Process.Start(pdfFilename);
        }
    }
}
