using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            //this.DialogResult = DialogResult.OK;
            //this.Close();
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
                    StudentDTO ud = new StudentDTO();
                    ud.
                    StudentBO ub = new StudentBO();
            }
            

        }
    }
}
