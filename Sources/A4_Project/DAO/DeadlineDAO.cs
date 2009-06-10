using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;
//using DTO;

namespace DAO
{
    public class DeadlineDAO
    {
        public DataTable LayDanhSach()
        {
            DataTable dtkq = new DataTable();
            string strSQL = "Select Subject.Name, Deadline.Title, Deadline.Time from Deadline, Subject where Deadline.OpenSubjectID = Subject.SubjectID and Time > ? Order by Time";
            OleDbConnection cn = DataProvider.ConnectionData();
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@Time", OleDbType.Date);
            cmd.Parameters["@Time"].Value = DateTime.Now;
            OleDbDataAdapter da = new OleDbDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dtkq);
            cn.Close();
            return dtkq;
        }
    }
}
