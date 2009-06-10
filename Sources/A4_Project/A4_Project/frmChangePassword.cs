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
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
           
        }

        private bool DataInvalid()
        {
            if (txtbOldPass.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu cũ");
                return false;
            }
            if (txtbNewPass.Text == "" || txtbConPass.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu mới");
                return false;
            }
            if (txtbNewPass.Text != txtbConPass.Text)
            {
                MessageBox.Show("Hai mật khẩu mới phải giống nhau!");
                return false;
            }
            return true;
        }
        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (DataInvalid() == true)
            {
                StudentDTO st = new StudentDTO();
                st.Password = txtbNewPass.Text;

               // StudenBUS sb = new StudentBUS();


            }
        }
    }
}