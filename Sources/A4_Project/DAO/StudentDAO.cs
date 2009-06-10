using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DTO;
using System.Data.OleDb;
using System.Data;


namespace DAO
{
    public class StudentDAO
    {
        public string ConnectString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = AccessMoodle.mdb";
        public int isExist(StudentDTO sd)
        {
            OleDbConnection cn = new OleDbConnection(ConnectString);
            string strSQL;
            strSQL = "Select * from Student where StudentID = " + sd.StudentID + " and Password = '" + sd.Password + "'";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataAdapter dad;
            dad = new OleDbDataAdapter(cmd);

            DataSet dst = new DataSet();
            
            dad.Fill(dst);

            if (dst.Tables[0].Rows.Count == 0)
                return -1;
            else
            {
                DataRow dr = dst.Tables[0].Rows[0];
                MessageBox.Show(dr["StudentID"].ToString());
                return int.Parse(dr["StudentID"].ToString());
            }

        }
    }
}
