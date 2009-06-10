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
                MessageBox.Show(GlobalVarian.StudentName);
                    StudentDTO sd = new StudentDTO();
                    sd.StudentID = int.Parse(txtbUser.Text);
                    sd.Password = txtbPass.Text;
                    StudentBUS ub = new StudentBUS(sd);
                    bool kq = ub.isAtuthencation();
                    if (kq == true)
                    {
                        MessageBox.Show("Dang nhap thanh cong");
                        
                        frmMain fmain = new frmMain();
                       // this.Hide();
                        fmain.ShowDialog();
                        

                    }
                    else
                        MessageBox.Show("Dang nhap LOI");

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
    }
}
