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
                panel4.Visible = false;
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
            try
            {
                string ngay1 = datetime1.Value.ToString();
                string ngay2 = datetime2.Value.ToString();
                int ypoint = 0;
                int sotrang = 0;
                PdfDocument pdf = new PdfDocument();
                pdf.Info.Title = "datbase";
                PdfPage pdfpage = pdf.AddPage();
                XGraphics graph = XGraphics.FromPdfPage(pdfpage);
                XFont font_nho = new XFont("Arial", 5, XFontStyle.Italic);
                XFont font_to = new XFont("Arial", 15, XFontStyle.Bold);
                XFont font_thuong = new XFont("Arial", 10, XFontStyle.Regular);
                XFont font_thuong_dam = new XFont("Arial", 10, XFontStyle.Bold);
                ypoint = ypoint + 10;
                if (ypoint / 790 > sotrang)
                {
                    sotrang++;
                    pdfpage = pdf.AddPage();
                    graph = XGraphics.FromPdfPage(pdfpage);
                    ypoint = 20;
                }
                graph.DrawString("Chi tiết doanh thu", font_to, XBrushes.Black, new XRect(40, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopCenter);
                graph.DrawString("Từ ngày " + datetime1.Value.ToString("dd/MM/yyyy") + " Đến ngày "+ datetime2.Value.ToString("dd/MM/yyyy"), font_nho, XBrushes.Black, new XRect(40, 30, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopCenter);
                ypoint = ypoint + 30;
                graph.DrawString("Báo cáo bán hàng ", font_thuong_dam, XBrushes.Black, new XRect(40, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                ypoint = ypoint + 30;
                if (ypoint / 790 > sotrang)
                {
                    sotrang++;
                    pdfpage = pdf.AddPage();
                    graph = XGraphics.FromPdfPage(pdfpage);
                    ypoint = 20;
                }
                DataTable a = HoadonDAO.Instance.listHD_date_to_date(ngay1,ngay2);
                int dem = a.Rows.Count;
                string ngay = "";
                decimal tien = 0;
                decimal tong_tien = 0;
                int dd = 0;
                for (int i = 0; i < a.Rows.Count; i++)
                {
                    if (ngay != a.Rows[i]["ngay_ban"].ToString())
                    {
                        if (dd != 0)
                        {
                            graph.DrawString("Tổng giá trị ngày " + DateTime.Parse(ngay).ToString("dd/MM/yyyy"), font_thuong_dam, XBrushes.Black, new XRect(40, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                            graph.DrawString(Convert.ToDecimal(tien).ToString("#,##0"), font_thuong_dam, XBrushes.Black, new XRect(540, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                            tien = 0;
                            ypoint = ypoint + 30;
                            if (ypoint / 790 > sotrang)
                            {
                                sotrang++;
                                pdfpage = pdf.AddPage();
                                graph = XGraphics.FromPdfPage(pdfpage);
                                ypoint = 20;
                            }
                        }
                        ngay = a.Rows[i]["ngay_ban"].ToString();
                        graph.DrawString("Ngày " + DateTime.Parse(a.Rows[i]["ngay_ban"].ToString()).ToString("dd/MM/yyyy"), font_thuong_dam, XBrushes.Black, new XRect(40, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                        ypoint = ypoint + 30;
                        if (ypoint / 790 > sotrang)
                        {
                            sotrang++;
                            pdfpage = pdf.AddPage();
                            graph = XGraphics.FromPdfPage(pdfpage);
                            ypoint = 20;
                        }

                    }
                    graph.DrawString("Mã hóa đơn", font_thuong_dam, XBrushes.Black, new XRect(40, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                    graph.DrawString("Ngày bán", font_thuong_dam, XBrushes.Black, new XRect(140, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                    graph.DrawString("Người bán", font_thuong_dam, XBrushes.Black, new XRect(240, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                    graph.DrawString("Khách hàng", font_thuong_dam, XBrushes.Black, new XRect(340, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                    graph.DrawString("Giảm giá", font_thuong_dam, XBrushes.Black, new XRect(440, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                    graph.DrawString("Trị giá", font_thuong_dam, XBrushes.Black, new XRect(540, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                    ypoint = ypoint + 30;
                    if (ypoint / 790 > sotrang)
                    {
                        sotrang++;
                        pdfpage = pdf.AddPage();
                        graph = XGraphics.FromPdfPage(pdfpage);
                        ypoint = 20;
                    }
                    graph.DrawString(a.Rows[i]["mahd"].ToString(), font_thuong, XBrushes.Black, new XRect(40, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                    graph.DrawString(DateTime.Parse(a.Rows[i]["ngay_ban"].ToString()).ToString("dd/MM/yyyy"), font_thuong, XBrushes.Black, new XRect(140, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                    DataTable b;
                    b = StaffDAO.Instance.ViewStaff(a.Rows[i]["manv"].ToString());
                    graph.DrawString(b.Rows[0]["ten_nv"].ToString(), font_thuong, XBrushes.Black, new XRect(240, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                    b = CustomersDAO.Instance.ViewCustomer(a.Rows[i]["makh"].ToString());
                    graph.DrawString(b.Rows[0]["ten_kh"].ToString(), font_thuong, XBrushes.Black, new XRect(340, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                    graph.DrawString(a.Rows[i]["giam_gia"].ToString(), font_thuong, XBrushes.Black, new XRect(440, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                    graph.DrawString(Convert.ToDouble(Double.Parse(a.Rows[i]["tri_gia"].ToString())).ToString("#,##0"), font_thuong, XBrushes.Black, new XRect(540, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                    ypoint = ypoint + 30;
                    if (ypoint / 790 > sotrang)
                    {
                        sotrang++;
                        pdfpage = pdf.AddPage();
                        graph = XGraphics.FromPdfPage(pdfpage);
                        ypoint = 20;
                    }
                    tien = tien + (decimal)(Double.Parse(a.Rows[i]["tri_gia"].ToString()));
                    dd = 1;
                }

                if (a.Rows.Count == 1)
                {
                    graph.DrawString("Tổng giá trị ngày " + DateTime.Parse(a.Rows[0]["ngay_ban"].ToString()).ToString("dd/MM/yyyy"), font_thuong_dam, XBrushes.Black, new XRect(40, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                    graph.DrawString(Convert.ToDecimal(tien).ToString("#,##0"), font_thuong_dam, XBrushes.Black, new XRect(540, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                }
                else
                    if (a.Rows.Count == 0) dd = 1;
                    else
                    {
                        graph.DrawString("Tổng giá trị ngày " + DateTime.Parse(ngay).ToString("dd/MM/yyyy"), font_thuong_dam, XBrushes.Black, new XRect(40, ypoint, pdfpage.Width, pdfpage.Height), XStringFormat.TopLeft);
                        graph.DrawString(Convert.ToDecimal(tien).ToString("#,##0"), font_thuong_dam, XBrushes.Black, new XRect(540, ypoint, pdfpage.Width, pdfpage.Height), XStringFormat.TopLeft);
                    }
                dd = 0;
                //--------------------------------------------
                dd = 0;
                ngay = "";
                ypoint = ypoint + 30;
                tien = 0;
                if (ypoint / 790 > sotrang)
                {
                    sotrang++;
                    pdfpage = pdf.AddPage();
                    graph = XGraphics.FromPdfPage(pdfpage);
                    ypoint = 20;
                }
                graph.DrawString("Báo cáo sửa chửa ", font_thuong_dam, XBrushes.Black, new XRect(40, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                ypoint = ypoint + 30;
                a = SuachuaDAO.Instance.list_sua_chua_date_to_date(ngay1, ngay2);
                if (ypoint / 790 > sotrang)
                {
                    sotrang++;
                    pdfpage = pdf.AddPage();
                    graph = XGraphics.FromPdfPage(pdfpage);
                    ypoint = 20;
                }
                for (int i = 0; i < a.Rows.Count; i++)
                {
                    if (ngay != a.Rows[i]["ngay_nhan"].ToString())
                    {
                        if (dd != 0)
                        {
                            graph.DrawString("Tổng giá trị ngày " + DateTime.Parse(ngay).ToString("dd/MM/yyyy"), font_thuong_dam, XBrushes.Black, new XRect(40, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                            graph.DrawString(Convert.ToDecimal(tien).ToString("#,##0"), font_thuong_dam, XBrushes.Black, new XRect(540, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                            tien = 0;
                            ypoint = ypoint + 30;
                            if (ypoint / 790 > sotrang)
                            {
                                sotrang++;
                                pdfpage = pdf.AddPage();
                                graph = XGraphics.FromPdfPage(pdfpage);
                                ypoint = 20;
                            }
                        }
                        ngay = a.Rows[i]["ngay_nhan"].ToString();
                        graph.DrawString("Ngày " + DateTime.Parse(a.Rows[i]["ngay_nhan"].ToString()).ToString("dd/MM/yyyy"), font_thuong_dam, XBrushes.Black, new XRect(40, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                        ypoint = ypoint + 30;
                        if (ypoint / 790 > sotrang)
                        {
                            sotrang++;
                            pdfpage = pdf.AddPage();
                            graph = XGraphics.FromPdfPage(pdfpage);
                            ypoint = 20;
                        }
                    }
                    graph.DrawString("Mã hóa đơn", font_thuong_dam, XBrushes.Black, new XRect(40, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                    graph.DrawString("Ngày nhận", font_thuong_dam, XBrushes.Black, new XRect(140, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                    graph.DrawString("Ngày giao", font_thuong_dam, XBrushes.Black, new XRect(240, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                    graph.DrawString("Người nhận", font_thuong_dam, XBrushes.Black, new XRect(340, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                    graph.DrawString("Khách hàng", font_thuong_dam, XBrushes.Black, new XRect(440, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                    graph.DrawString("Trị giá", font_thuong_dam, XBrushes.Black, new XRect(540, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                    ypoint = ypoint + 30;
                    if (ypoint / 790 > sotrang)
                    {
                        sotrang++;
                        pdfpage = pdf.AddPage();
                        graph = XGraphics.FromPdfPage(pdfpage);
                        ypoint = 20;
                    }
                    graph.DrawString(a.Rows[i]["masc"].ToString(), font_thuong, XBrushes.Black, new XRect(40, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                    graph.DrawString(DateTime.Parse(a.Rows[i]["ngay_giao"].ToString()).ToString("dd/MM/yyyy"), font_thuong, XBrushes.Black, new XRect(140, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                    graph.DrawString(DateTime.Parse(a.Rows[i]["ngay_nhan"].ToString()).ToString("dd/MM/yyyy"), font_thuong, XBrushes.Black, new XRect(240, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                    DataTable b;
                    b = StaffDAO.Instance.ViewStaff(a.Rows[i]["manv"].ToString());
                    graph.DrawString(b.Rows[0]["ten_nv"].ToString(), font_thuong, XBrushes.Black, new XRect(340, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                    b = CustomersDAO.Instance.ViewCustomer(a.Rows[i]["makh"].ToString());
                    graph.DrawString(b.Rows[0]["ten_kh"].ToString(), font_thuong, XBrushes.Black, new XRect(440, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                    graph.DrawString(Convert.ToDouble(Double.Parse(a.Rows[i]["tri_gia"].ToString())).ToString("#,##0"), font_thuong, XBrushes.Black, new XRect(540, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                    ypoint = ypoint + 30;
                    if (ypoint / 790 > sotrang)
                    {
                        sotrang++;
                        pdfpage = pdf.AddPage();
                        graph = XGraphics.FromPdfPage(pdfpage);
                        ypoint = 20;
                    }
                    tien = tien + (decimal)(Double.Parse(a.Rows[i]["tri_gia"].ToString()));
                    dd = 1;
                }
                
                if (a.Rows.Count==1)
                {
                    graph.DrawString("Tổng giá trị ngày " + DateTime.Parse(a.Rows[0]["ngay_nhan"].ToString()).ToString("dd/MM/yyyy"), font_thuong_dam, XBrushes.Black, new XRect(40, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                    graph.DrawString(Convert.ToDecimal(tien).ToString("#,##0"), font_thuong_dam, XBrushes.Black, new XRect(540, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                }    
                else
                    if (a.Rows.Count == 0) dd = 1;
                    else
                    {
                        graph.DrawString("Tổng giá trị ngày " + DateTime.Parse(ngay).ToString("dd/MM/yyyy"), font_thuong_dam, XBrushes.Black, new XRect(40, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                        graph.DrawString(Convert.ToDecimal(tien).ToString("#,##0"), font_thuong_dam, XBrushes.Black, new XRect(540, ypoint, pdfpage.Width.Point, pdfpage.Height.Point), XStringFormat.TopLeft);
                    }
                string pdfFilename = @"D:\\phieu_thu.pdf";
                pdf.Save(pdfFilename);
                Process.Start(pdfFilename);
                //--------------------------------
                PdfDocument pdf1 = new PdfDocument();
                pdf1.Info.Title = ".....";
                sotrang = 0;
                tien = 0;
                ngay = "";
                dd = 0;
                PdfPage pdfpage1 = pdf1.AddPage();
                graph = XGraphics.FromPdfPage(pdfpage1);
                ypoint = 10;
                graph.DrawString("Chi tiết doanh thu", font_to, XBrushes.Black, new XRect(40, ypoint, pdfpage1.Width.Point, pdfpage1.Height.Point), XStringFormat.TopCenter);
                graph.DrawString("Từ ngày " + datetime1.Value.ToString("dd/MM/yyyy") + " Đến ngày " + datetime2.Value.ToString("dd/MM/yyyy"), font_nho, XBrushes.Black, new XRect(40, 30, pdfpage1.Width.Point, pdfpage1.Height.Point), XStringFormat.TopCenter);
                ypoint = ypoint + 30;
                graph.DrawString("Báo cáo nhập hàng ", font_thuong_dam, XBrushes.Black, new XRect(40, ypoint, pdfpage1.Width.Point, pdfpage1.Height.Point), XStringFormat.TopLeft);
                ypoint = ypoint + 30;
                if (ypoint / 790 > sotrang)
                {
                    sotrang++;
                    pdfpage = pdf.AddPage();
                    graph = XGraphics.FromPdfPage(pdfpage);
                    ypoint = 20;
                }
                a = WarehouseDAO.Instance.list_nhap_kho_date_to_date(ngay1, ngay2);
                for (int i=0;i<a.Rows.Count;i++)
                {
                    if (ngay != a.Rows[i]["ngay_nhap"].ToString())
                    {
                        if (dd != 0)
                        {
                            graph.DrawString("Tổng giá trị ngày " + DateTime.Parse(ngay).ToString("dd/MM/yyyy"), font_thuong_dam, XBrushes.Black, new XRect(40, ypoint, pdfpage1.Width.Point, pdfpage1.Height.Point), XStringFormat.TopLeft);
                            graph.DrawString(Convert.ToDecimal(tien).ToString("#,##0"), font_thuong_dam, XBrushes.Black, new XRect(340, ypoint, pdfpage1.Width.Point, pdfpage1.Height.Point), XStringFormat.TopLeft);
                            tien = 0;
                            ypoint = ypoint + 30;
                            if (ypoint / 790 > sotrang)
                            {
                                sotrang++;
                                pdfpage1 = pdf1.AddPage();
                                graph = XGraphics.FromPdfPage(pdfpage1);
                                ypoint = 20;
                            }
                        }
                        ngay = a.Rows[i]["ngay_nhap"].ToString();
                        graph.DrawString("Ngày " + DateTime.Parse(a.Rows[i]["ngay_nhap"].ToString()).ToString("dd/MM/yyyy"), font_thuong_dam, XBrushes.Black, new XRect(40, ypoint, pdfpage1.Width.Point, pdfpage1.Height.Point), XStringFormat.TopLeft);
                        ypoint = ypoint + 30;
                        if (ypoint / 790 > sotrang)
                        {
                            sotrang++;
                            pdfpage1 = pdf1.AddPage();
                            graph = XGraphics.FromPdfPage(pdfpage1);
                            ypoint = 20;
                        }
                    }
                    graph.DrawString("Mã nhập hàng", font_thuong_dam, XBrushes.Black, new XRect(40, ypoint, pdfpage1.Width.Point, pdfpage1.Height.Point), XStringFormat.TopLeft);
                    graph.DrawString("Ngày nhập", font_thuong_dam, XBrushes.Black, new XRect(140, ypoint, pdfpage1.Width.Point, pdfpage1.Height.Point), XStringFormat.TopLeft);
                    graph.DrawString("Người nhập", font_thuong_dam, XBrushes.Black, new XRect(240, ypoint, pdfpage1.Width.Point, pdfpage1.Height.Point), XStringFormat.TopLeft);
                    graph.DrawString("Trị giá", font_thuong_dam, XBrushes.Black, new XRect(340, ypoint, pdfpage1.Width.Point, pdfpage1.Height.Point), XStringFormat.TopLeft);
                    ypoint = ypoint + 30;
                    if (ypoint / 790 > sotrang)
                    {
                        sotrang++;
                        pdfpage1 = pdf1.AddPage();
                        graph = XGraphics.FromPdfPage(pdfpage1);
                        ypoint = 20;
                    }
                    graph.DrawString(a.Rows[i]["manhaphang"].ToString(), font_thuong, XBrushes.Black, new XRect(40, ypoint, pdfpage1.Width.Point, pdfpage1.Height.Point), XStringFormat.TopLeft);
                    graph.DrawString(DateTime.Parse(a.Rows[i]["ngay_nhap"].ToString()).ToString("dd/MM/yyyy"), font_thuong, XBrushes.Black, new XRect(140, ypoint, pdfpage1.Width.Point, pdfpage1.Height.Point), XStringFormat.TopLeft);
                    DataTable b = StaffDAO.Instance.ViewStaff(a.Rows[i]["manguoinhap"].ToString());
                    graph.DrawString(b.Rows[0]["ten_nv"].ToString(), font_thuong, XBrushes.Black, new XRect(240, ypoint, pdfpage1.Width.Point, pdfpage1.Height.Point), XStringFormat.TopLeft);
                    graph.DrawString(Convert.ToDecimal(decimal.Parse(a.Rows[i]["tong_tien"].ToString())).ToString("#,##0"), font_thuong, XBrushes.Black, new XRect(340, ypoint, pdfpage1.Width.Point, pdfpage1.Height.Point), XStringFormat.TopLeft);
                    tien = tien + decimal.Parse(a.Rows[i]["tong_tien"].ToString());
                    ypoint = ypoint + 30;
                    if (ypoint / 790 > sotrang)
                    {
                        sotrang++;
                        pdfpage1 = pdf1.AddPage();
                        graph = XGraphics.FromPdfPage(pdfpage1);
                        ypoint = 20;
                    }
                    dd = 1;
                }
                if (a.Rows.Count == 1)
                {
                    graph.DrawString("Tổng giá trị ngày " + DateTime.Parse(a.Rows[0]["ngay_nhap"].ToString()).ToString("dd/MM/yyyy"), font_thuong_dam, XBrushes.Black, new XRect(40, ypoint, pdfpage1.Width.Point, pdfpage1.Height.Point), XStringFormat.TopLeft);
                    graph.DrawString(Convert.ToDecimal(tien).ToString("#,##0"), font_thuong_dam, XBrushes.Black, new XRect(340, ypoint, pdfpage1.Width.Point, pdfpage1.Height.Point), XStringFormat.TopLeft);
                }
                else
                    if (a.Rows.Count == 0) dd = 1;
                else
                {
                    graph.DrawString("Tổng giá trị ngày " + DateTime.Parse(ngay).ToString("dd/MM/yyyy"), font_thuong_dam, XBrushes.Black, new XRect(40, ypoint, pdfpage1.Width.Point, pdfpage1.Height.Point), XStringFormat.TopLeft);
                    graph.DrawString(Convert.ToDecimal(tien).ToString("#,##0"), font_thuong_dam, XBrushes.Black, new XRect(340, ypoint, pdfpage1.Width.Point, pdfpage1.Height.Point), XStringFormat.TopLeft);
                }
                string pdfFilename1 = @"D:\\phieu_chi.pdf";
                pdf1.Save(pdfFilename1);
                Process.Start(pdfFilename1);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {

        }
    }
}
 