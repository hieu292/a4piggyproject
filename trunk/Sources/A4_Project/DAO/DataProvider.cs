using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace DAO
{
    class DataProvider
    {
        public static OleDbConnection ConnectionData()
        {
            string cnStr = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + Application.StartupPath + "\\AccessMoodle.mdb";  
            OleDbConnection cn = new OleDbConnection(cnStr);
            cn.Open();
            return cn;
        }

        public static DataTable LayBang(string TenBang)
        {
            DataTable dt = new DataTable();
            // B1 & B2: Tạo chuỗi kết nối, mở kết nối bằng đối tượng kết nối
            OleDbConnection cn;
            cn = DataProvider.ConnectionData();
            string strSQL = "Select * from " + TenBang;
            // B3: Tạo chuỗi strSQL thao tác cơ sở dữ liệu
            OleDbDataAdapter da = new OleDbDataAdapter(strSQL, cn);
            da.Fill(dt);
            // B5: Đóng kết nối cơ sở dữ liệu
            cn.Close();
            return dt;
        }
    }
}
