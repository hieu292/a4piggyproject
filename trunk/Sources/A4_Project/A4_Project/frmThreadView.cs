using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace A4_Project
{
    public partial class frmThreadView : Form
    {
        public frmThreadView()
        {
            InitializeComponent();
        }

        public frmThreadView(string strMH, int Thread)
        {
            InitializeComponent();
            cmbMonHoc.SelectedItem = strMH;
            if (lstDanhSachThread.Items.Count > 0)
            {
                lstDanhSachThread.SelectedValue = Thread;
            }
        }

        private void txtbNoiDungPost_TextChanged(object sender, EventArgs e)
        {
            if (txtbNoiDungPost.Text.Length > 0)
                btnPost.Enabled = true;
            else
                btnPost.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            txtbNoiDungThread.Text += "\r\n \r\n" + txtbNoiDungPost.Text; //Them Ten Nguoi Goi + Ngay Thang
            txtbNoiDungPost.Clear();
        }

        private void lstDanhSachThread_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lstDanhSachThread.SelectedItem
        }

        private void frmThreadView_Load(object sender, EventArgs e)
        {
            
        }
    }
}