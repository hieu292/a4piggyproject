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
            if (txtbUser.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập Username!");
            }
            if (txtbPass.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Password!");
            }
            else
            {
                    StudentDTO sd = new StudentDTO();
                    sd.Name = txtbUser.Text;
                    sd.Password = txtbPass.Text;
                    StudentBUS ub = new StudentBO(sd);
                    bool kq = ub.isAtuthencation();
                if(kq==true)
                    MessageBox.Show("Dang nhap thanh cong");
                else
                    MessageBox.Show("Dang nhap LOI");

            }
        }
    }
}
