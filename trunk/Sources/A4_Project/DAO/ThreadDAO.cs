using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class ThreadDAO
    {
        public DataTable LayDanhSach(int sID)
        {
            DataTable dt = new DataTable();
            OleDbConnection cn = DataProvider.ConnectionData();
            string strSQL = "Select Subject.Name, Thread.Title, Thread.TimePost, ThreadID from Thread, Subject, Student where Thread.OpenSubjectID = Subject.SubjectID and Thread.StudentID = Student.StudentID and Student.StudentID = ?";
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

        public bool AddThread(ThreadDTO td)
        {
            OleDbConnection cn = DataProvider.ConnectionData();

            string strSQL = "Insert into Thread(Title, Content, TimePost, OpenSubjectID, StudentID) values (?, ?, ?, ?, ?)";
            //B4: Thuc thi chuoi strSQL
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            cmd.Parameters.Add("@Title", OleDbType.WChar);
            cmd.Parameters.Add("@Content", OleDbType.WChar);
            cmd.Parameters.Add("@TimePost", OleDbType.Date);
            cmd.Parameters.Add("@OpenSubjectID", OleDbType.Integer);
            cmd.Parameters.Add("@StudentID", OleDbType.Integer);

            cmd.Parameters["@Title"].Value = td.Title;
            cmd.Parameters["@Content"].Value = td.Content;
            cmd.Parameters["@TimePost"].Value = td.Time;
            cmd.Parameters["@OpenSubjectID"].Value = td.OpenSubjectID;
            cmd.Parameters["@StudentID"].Value = td.StudentID;
            cmd.ExecuteNonQuery();
            cn.Close();
            return true;

        }
    }
}
