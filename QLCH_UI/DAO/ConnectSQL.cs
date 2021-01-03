using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCH_UI.DAO
{
     public class ConnectSQL
    {
        private static ConnectSQL instance;
        private ConnectSQL() { }
        public static ConnectSQL Instance
        {
            get { if (instance == null) instance = new ConnectSQL(); return instance; }
            private set => instance = value;
        }
        private string connectionSTR;
        public bool TestConnString()
        {
            connectionSTR = @"Data Source=LAPTOP-4CIHSEK9\SQLEXPRESS;Initial Catalog=QL_CHDT;Integrated Security=True";
            //-------connectionSTR = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;

            //MessageBox.Show(connectionSTR);
            bool isValidConnectionString = true;
            try
            {
                var con = new SqlConnectionStringBuilder(connectionSTR);
            }
            catch (Exception)
            {
                // can be KeyNotFoundException, FormatException, ArgumentException
                //MessageBox.Show(connectionSTR);
                isValidConnectionString = false;
            }
            return isValidConnectionString;
        }
        public DataTable ExecuteQuery(string query, object[] paramater = null)
        {
            //-------connectionSTR = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (paramater != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, paramater[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        public int ExecuteNonQuery(string query, object[] paramater = null)
        {
            //-------connectionSTR = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (paramater != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, paramater[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] paramater = null)
        {
            //-------connectionSTR = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (paramater != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, paramater[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
        public ReportDataSource Datasoucre(string mahd)
        {
            // this.reportViewer2.RefreshReport();
            // ReportDataSource datasource = ConnectSQL.Instance.Datasoucre(ma);

            string query = "select  HOA_DON.mahd, HOA_DOn.manv, dien_thoai, HOA_DON.ngay_ban , SAN_PHAM.gia_ban, HOA_DON.giam_gia, ten_sp, CTHD.so_luong,HOA_DON.tri_gia  from (HOA_DON inner join"
                           + " (CTHD inner join SAN_PHAM on CTHD.masp = SAN_PHAM.masp) on HOA_DON.mahd = CTHD.mahd) inner join KHACH_HANG on KHACH_HANG.makh = HOA_DON.makh where HOA_DON.mahd = '" + mahd + "'";
            SqlConnection con = new SqlConnection(connectionSTR);

            con.Open();
            //   SqlCommand Command = new SqlCommand(query, con);
            DataSet1 ds = new DataSet1();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds, "Receipt");
            con.Close();

            ReportDataSource datasource = new ReportDataSource("DataSet_Report", ds.Tables[0]);
            return datasource;
        }
    }
}

