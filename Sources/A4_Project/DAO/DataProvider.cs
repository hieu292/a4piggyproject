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
    }
}
