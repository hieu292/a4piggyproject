using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace A4_Project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            if (frm.ShowDialog() == DialogResult.Cancel)
            {
                this.Close();
            }
            this.BringToFront();
        }

        private void linkDownloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLinkDownload frm = new frmLinkDownload();
            frm.ShowDialog();
        }

        private void privateInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.ShowDialog();
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            if (frm.ShowDialog() == DialogResult.Cancel)
            {
                this.Close();
            }
            this.Show();
            this.BringToFront();
        }

        private void dtgvDanhSachMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string strTenMH = dtgvDanhSachMonHoc.CurrentRow.Cells[0].Value.ToString();
            frmThreadView frm = new frmThreadView(strTenMH, -1);
            frm.ShowDialog();
        }

        private void dtgvDSNewThread_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string strTenMH = dtgvDSNewThread.CurrentRow.Cells[0].Value.ToString();
            //int iThread = LayMaThread(dtgvDSNewThread.CurrentRow.Cells[0].Value.ToString(), dtgvDSNewThread.CurrentRow.Cells[1].Value.ToString(), dtgvDSNewThread.CurrentRow.Cells[0].Value.ToString());
            //frmThreadView frm = new frmThreadView(strTenMH, iThread);
            //frm.ShowDialog();
        }

    }
}