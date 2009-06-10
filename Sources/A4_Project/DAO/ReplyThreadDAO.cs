using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class ReplyThreadDAO
    {
        public DataTable LayDanhSach(int iThead)
        {
            DataTable dt = new DataTable();
            OleDbConnection cn = DataProvider.ConnectionData();
            string strSQL = "Select * from ReplyThread, Student where Student.StudentID = ReplyThread.StudentID and ThreadID = ? order by Time";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@ThreadID", OleDbType.Integer);
            cmd.Parameters["@ThreadID"].Value = iThead;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();
            return dt;
        }

        public void ThemReply(ReplyThreadDTO rtdto)
        {
            OleDbConnection cn = DataProvider.ConnectionData();
            string strSQL = "Insert into ReplyThread values (?, ?, ?, ?, ?)";

            OleDbCommand cmd = new OleDbCommand(strSQL, cn);

            cmd.Parameters.Add("@Content", OleDbType.VarWChar);
            cmd.Parameters.Add("@Time", OleDbType.Date);
            cmd.Parameters.Add("@ThreadID", OleDbType.Integer);
            cmd.Parameters.Add("@StudentID", OleDbType.Integer);

            cmd.Parameters["@Content"].Value = rtdto.Content.ToString();
            cmd.Parameters["@Time"].Value = rtdto.Time;
            cmd.Parameters["@ThreadID"].Value = rtdto.ThreadID;
            cmd.Parameters["@StudentID"].Value = rtdto.StudentID;
            cmd.ExecuteNonQuery();

            cn.Close();
        }

    }
}
