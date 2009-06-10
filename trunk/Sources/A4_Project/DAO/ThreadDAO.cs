using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace DAO
{
    public class ThreadDAO
    {
        public DataTable LayDanhSach(int sID)
        {
            DataTable dt = new DataTable();
            OleDbConnection cn = DataProvider.ConnectionData();
            string strSQL = "Select Subject.Name, Thread.Title, Thread.Time, ThreadID from Thread, Subject, Student where Thread.OpenSubjectID = Subject.SubjectID and Thread.StudentID = Student.StudentID and Student.StudentID = ?";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@Student.StudentID", OleDbType.Integer);
            cmd.Parameters["@Student.StudentID"].Value = sID;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();
            return dt;
        }

        public DataTable LayBang()
        {
            return DataProvider.LayBang("Thread");
        }

        public DataTable LayDanhSach(string MonHoc)
        {
            DataTable dt = new DataTable();
            OleDbConnection cn = DataProvider.ConnectionData();
            string strSQL = "Select * from Thread, Subject where Thread.OpenSubjectID = Subject.SubjectID and Subject.Name = ?";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@Subject.Name", OleDbType.VarChar);
            cmd.Parameters["@Subject.Name"].Value = MonHoc;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();
            return dt;
        }

        public DataTable ThongTinThread(int iThead)
        {
            DataTable dt = new DataTable();
            OleDbConnection cn = DataProvider.ConnectionData();
            string strSQL = "Select * from Thread, Student where Thread.StudentID = Student.StudentID and ThreadID = ?";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@ThreadID", OleDbType.Integer);
            cmd.Parameters["@ThreadID"].Value = iThead;
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();
            return dt;
        }
    }
}
