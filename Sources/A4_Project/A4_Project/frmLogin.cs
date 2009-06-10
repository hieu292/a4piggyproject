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
                        this.DialogResult = DialogResult.OK;
                        this.Close();   
                    }
                    else
                        MessageBox.Show("Lỗi đăng nhập, mời bạn kiểm tra lại tài khoản!", "Error");

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
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
