using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace A4_Project
{
    public partial class frmThreadView : Form
    {
        public frmThreadView()
        {
            InitializeComponent();
            ComboBoxInit();
        }

        void ComboBoxInit()
        {
            cmbMonHoc.DataSource = frmMain.tbDanhSachMonHoc;
            cmbMonHoc.DisplayMember = "Name";
            cmbMonHoc.ValueMember = "SubjectID";
        }

        void ListDSThreadInit()
        {
            ThreadBUS tbus = new ThreadBUS();
            DataTable dt = new DataTable();
            string a = cmbMonHoc.SelectedItem.ToString();
            lstDanhSachThread.DataSource = tbus.LayDanhSach(cmbMonHoc.Text);
            lstDanhSachThread.ValueMember = "ThreadID";
            lstDanhSachThread.DisplayMember = "Title";
        }


        public frmThreadView(string strMH, string strThread)
        {
            InitializeComponent();
            ComboBoxInit();
            cmbMonHoc.SelectedValue = strMH;
            ListDSThreadInit();
            lstDanhSachThread.SelectedValue = strThread;
        }

        public frmThreadView(string strMH)
        {
            InitializeComponent();
            ComboBoxInit();
            cmbMonHoc.SelectedValue = strMH;
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
            ReplyThreadDTO rtdto = new ReplyThreadDTO();
            rtdto.StudentID = GlobalVarian.StudentID;
            rtdto.ThreadID = int.Parse(lstDanhSachThread.SelectedValue.ToString());
            rtdto.Time = DateTime.Now;
            rtdto.Content = txtbNoiDungPost.Text;

            ReplyThreadBUS rtbus = new ReplyThreadBUS();
            rtbus.ThemReply(rtdto);

            txtbNoiDungThread.Text += "\r\n \r\n"; //Them Ten Nguoi Goi + Ngay Thang
            txtbNoiDungThread.Text += GlobalVarian.StudentName + " - " + DateTime.Now.ToString();
            txtbNoiDungThread.Text += "\r\n" + txtbNoiDungPost.Text;
            txtbNoiDungPost.Clear();
            
        }

        private void frmThreadView_Load(object sender, EventArgs e)
        {
            ListDSThreadInit();
        }

        private void cmbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThreadBUS tbus = new ThreadBUS();
            DataTable dt = new DataTable();
            string a = cmbMonHoc.SelectedItem.ToString();
            lstDanhSachThread.DataSource = tbus.LayDanhSach(cmbMonHoc.Text);
            lstDanhSachThread.ValueMember = "ThreadID";
            lstDanhSachThread.DisplayMember = "Title";
        }

        private void lstDanhSachThread_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtbNoiDungThread.Clear();
            ThreadBUS tbus = new ThreadBUS();
            DataTable dt1 = new DataTable();
            dt1 = tbus.ThongTinThread(int.Parse(lstDanhSachThread.SelectedValue.ToString()));

            string sContent = dt1.Rows[0]["Title"].ToString() + "\r\n";
            sContent += dt1.Rows[0]["Name"].ToString() + " - " + dt1.Rows[0]["TimePost"].ToString() + "\r\n";
            sContent += dt1.Rows[0]["Content"].ToString();

            ReplyThreadBUS rtbus = new ReplyThreadBUS();
            DataTable dt2 = new DataTable();
            dt2 = rtbus.LayDanhSach(int.Parse(lstDanhSachThread.SelectedValue.ToString()));
            for(int i = 0; i < dt2.Rows.Count; i++)
            {
                sContent += "\r\n \r\n";
                sContent += dt2.Rows[i]["Name"].ToString() + " - " + dt2.Rows[0]["TimePost"].ToString() + "\r\n";
                sContent += dt2.Rows[i]["Content"].ToString();
            }

            txtbNoiDungThread.Text = sContent;
        }

        private void btnThemThread_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNewThread frm = new frmNewThread(int.Parse(cmbMonHoc.SelectedValue.ToString()));
            frm.ShowDialog();
            ListDSThreadInit();
            this.Show();
        }
    }
}