using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;

namespace A4_Project
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (DataInvalid() != false)
            {
                    StudentDTO sd = new StudentDTO();
                    sd.StudentID = int.Parse(txtbUser.Text);
                    sd.Password = txtbPass.Text;
                    StudentBUS ub = new StudentBUS(sd);
                    int kq = ub.isAtuthencation();
                    GlobalVarian.StudentID = kq;
                    if (kq >0)
                    {
                        MessageBox.Show("Xin chào, bạn đã đăng nhập thành công!");
                        
                        //frmMain fmain = new frmMain();
                        //MessageBox.Show("lay tu global:" + GlobalVarian.StudentID.ToString());
                       // this.Hide();
                        //fmain.ShowDialog();
                      //frmChangePassword cp = new frmChangePassword();
                        //cp.Show();
                        frmNewThread a = new frmNewThread();
                        a.ShowDialog();
                        
                    }
                    else
                        MessageBox.Show("Lỗi đăng nhập, mời bạn kiểm tra lại tài khoản!");

            }
        }
        private bool DataInvalid()
        {
            if (txtbUser.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Username!");
                return false;
            }
            if (txtbPass.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Password!");
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
