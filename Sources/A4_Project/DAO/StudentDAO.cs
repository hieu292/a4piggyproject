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
        StudentDTO sd;
        public StudentDAO(StudentDTO _stdao)
        {
            sd = _stdao;
        }
        public int isExist()
        {
            OleDbConnection cn = DataProvider.ConnectionData();
            
            string strSQL = "Select * from Student where StudentID = " + sd.StudentID + " and Pass = '" + sd.Password + "'";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataAdapter dad;
            dad = new OleDbDataAdapter(cmd);

            DataSet dst = new DataSet();
            
            dad.Fill(dst);
            
            cn.Close();

            if (dst.Tables[0].Rows.Count == 0)
                return -1;
            else
            {
                DataRow dr = dst.Tables[0].Rows[0];
                return int.Parse(dr["StudentID"].ToString());
            }
        }
        private bool isAbleToUpdate()
        {
            OleDbConnection cn = DataProvider.ConnectionData();
            
            string strSQL = "Select * from Student where StudentID = " + sd.StudentID + " and Pass = '" + sd.Password + "'";
            OleDbCommand cmd = new OleDbCommand(strSQL, cn);
            OleDbDataAdapter dad;
            dad = new OleDbDataAdapter(cmd);

            DataSet dst = new DataSet();
            
            dad.Fill(dst);
            
            cn.Close();

            if (dst.Tables[0].Rows.Count == 0)
                return false;
            else
            {
                return true;
            }


        }
        public bool ChangePassword(string newpass)
        {
            //Kiểm tra coi pass cũ có đúng ko đã
            if (isAbleToUpdate() == false)
            {
                MessageBox.Show("Mời bạn kiểm tra lại Password cũ");
                return false;
            }
            else
            {
                OleDbConnection cn = DataProvider.ConnectionData();
                string strSQL = "update Student set Pass = ? where StudentID = ?";
                
                OleDbCommand cmd = new OleDbCommand(strSQL, cn);
                
                cmd.Parameters.Add("@Pass", OleDbType.WChar);
                cmd.Parameters.Add("@StudentID", OleDbType.Integer);

                cmd.Parameters["@Pass"].Value = newpass;
                cmd.Parameters["@StudentID"].Value = sd.StudentID;

                cmd.ExecuteNonQuery();
                //B5: Dong ket noi CSDL
                cn.Close();
                return true;
            }
        }
    }
}
