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
        StudentDTO sd;
        public StudentDAO(StudentDTO _stdao)
        {
            sd = _stdao;
        }
        public int isExist()
        {
            OleDbConnection cn = new OleDbConnection(ConnectString);
            string strSQL;
            
            cn.Open();
            
            strSQL = "Select * from Student where StudentID = " + sd.StudentID + " and stPassword = '" + sd.Password + "'";
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
                //MessageBox.Show(dr["StudentID"].ToString());
                return int.Parse(dr["StudentID"].ToString());
            }
        }
        private bool isAbleToUpdate()
        {
            OleDbConnection cn = new OleDbConnection(ConnectString);
            string strSQL;
            
            cn.Open();
            
            strSQL = "Select * from Student where StudentID = " + sd.StudentID + " and Password = '" + sd.Password + "'";
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
                //DataRow dr = dst.Tables[0].Rows[0];
                //MessageBox.Show(dr["StudentID"].ToString());
                return true;
            }


        }
        public bool ChangePassword(String newpass)
        {
            //Kiểm tra coi pass cũ có đúng ko đã
            if (isAbleToUpdate() == false)
            {
                MessageBox.Show("Mời bạn kiểm tra lại Password cũ");
                return false;
            }
            else
            {
                OleDbConnection cn = new OleDbConnection(ConnectString);
                cn.Open();
               // string strSQL = "Update Student Set stPassword = '" + sd.Password + "' Where StudentID = " + sd.StudentID;
                string strSQL = "Update Student Set stPassword = 'ffdsfdfsg' Where StudentID = 612513";
                
                //string strSQL = "update Student set Password = ? where StudentID = ?";
                
                OleDbCommand cmd = new OleDbCommand(strSQL, cn);
                
                /*cmd.Parameters.Add("@Password", OleDbType.WChar);
                cmd.Parameters.Add("@StudentID", OleDbType.Integer);

                cmd.Parameters["@Password"].Value = sd.Password;
                cmd.Parameters["@StudentID"].Value = sd.StudentID;*/

                cmd.ExecuteNonQuery();
                //B5: Dong ket noi CSDL
                cn.Close();
                return true;
            }
        }
    }
}
