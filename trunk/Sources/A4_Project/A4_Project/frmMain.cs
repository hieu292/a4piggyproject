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
    public partial class frmMain : Form
    {
        public static DataTable tbDanhSachMonHoc;
        public static DataTable tbDanhSachThread;
        public static DataTable tbDanhSachDeadLine;
        public frmMain()
        {
            InitializeComponent();
        }

        void DanhSachMonHocInit()
        {
            SubjectBUS sbus = new SubjectBUS();
            tbDanhSachMonHoc = new DataTable();
            tbDanhSachMonHoc = sbus.LayDanhSach();
            dtgvDanhSachMonHoc.Rows.Add(tbDanhSachMonHoc.Rows.Count);
            for (int i = 0; i < tbDanhSachMonHoc.Rows.Count; i++)
            {
                dtgvDanhSachMonHoc.Rows[i].Cells["DSMH"].Value = tbDanhSachMonHoc.Rows[i][1];
            }
        }

        void DanhSachThreadMoiInit()
        {
            ThreadBUS tbus = new ThreadBUS();
            tbDanhSachThread = tbus.LayBang();
            DataTable dt = new DataTable();
            dt = tbus.LayDanhSach(612557);
            if (dt.Rows.Count > 0)
            {
                dtgvDSNewThread.Rows.Add(dt.Rows.Count);
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dtgvDSNewThread.Rows[i].Cells["MonHoc"].Value = dt.Rows[i][0];
                dtgvDSNewThread.Rows[i].Cells["TieuDe"].Value = dt.Rows[i][1];
                dtgvDSNewThread.Rows[i].Cells["NgayCapNhat"].Value = dt.Rows[i][2];
            }
        }

        void DanhSachDeadLineInit()
        {
            DeadlineBUS dbus = new DeadlineBUS();
            tbDanhSachDeadLine = new DataTable();
            tbDanhSachDeadLine = dbus.LayDanhSach();
            dtgvDanhSachDeadline.Rows.Add(tbDanhSachDeadLine.Rows.Count);
            for (int i = 0; i < tbDanhSachDeadLine.Rows.Count; i++)
            {
                dtgvDanhSachDeadline.Rows[i].Cells["Mon"].Value = tbDanhSachDeadLine.Rows[i][0];
                dtgvDanhSachDeadline.Rows[i].Cells["Ten"].Value = tbDanhSachDeadLine.Rows[i][1];
                dtgvDanhSachDeadline.Rows[i].Cells["ThoiGian"].Value = tbDanhSachDeadLine.Rows[i][2];
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DanhSachMonHocInit();
            DanhSachDeadLineInit();
            DanhSachThreadMoiInit();
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

//         private void privateInfoToolStripMenuItem_Click(object sender, EventArgs e)
//         {
//             frmChangePassword frm = new frmChangePassword();
//             frm.ShowDialog();
//         }

//         private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
//         {
//             this.Hide();
//             frmLogin frm = new frmLogin();
//             if (frm.ShowDialog() == DialogResult.Cancel)
//             {
//                 this.Close();
//             }
//             this.Show();
//             this.BringToFront();
//         }

        private void dtgvDanhSachMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            string svalue = "";
            string strTenMH = dtgvDanhSachMonHoc.CurrentRow.Cells[0].Value.ToString();
            for(int i = 0; i < tbDanhSachMonHoc.Rows.Count; i++)
                if(tbDanhSachMonHoc.Rows[i][1].ToString() == strTenMH)
                {
                    svalue = tbDanhSachMonHoc.Rows[i][0].ToString();
                    break;
                }
            frmThreadView frm = new frmThreadView(svalue);
            frm.ShowDialog();
            this.Show();
        }

        private void dtgvDSNewThread_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            string sMonHoc = "";
            string sThread = "";
            string strTenMH = dtgvDSNewThread.CurrentRow.Cells[0].Value.ToString();
            for (int i = 0; i < tbDanhSachMonHoc.Rows.Count; i++)
                if (tbDanhSachMonHoc.Rows[i][1].ToString() == strTenMH)
                {
                    sMonHoc = tbDanhSachMonHoc.Rows[i][0].ToString();
                    break;
                }

            string sTieuDe = dtgvDSNewThread.CurrentRow.Cells[1].Value.ToString();
            for (int i = 0; i < tbDanhSachThread.Rows.Count; i++)
                if (tbDanhSachThread.Rows[i][1].ToString() == sTieuDe)
                {
                    sThread = tbDanhSachThread.Rows[i][0].ToString();
                    break;
                }

            frmThreadView frm = new frmThreadView(sMonHoc, sThread);
            frm.ShowDialog();
            this.Show();
        }

        private void dtgvDanhSachDeadline_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();
            string MonHoc = dtgvDanhSachDeadline.CurrentRow.Cells[0].Value.ToString();
            string title = dtgvDanhSachDeadline.CurrentRow.Cells[1].Value.ToString();
            string sdatedead = dtgvDanhSachDeadline.CurrentRow.Cells[2].Value.ToString();
            frmSubmitAssignment frm = new frmSubmitAssignment(MonHoc, title, sdatedead);
            frm.ShowDialog();
            this.Show();
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalVarian.StudentID = -1;
            GlobalVarian.StudentName = "";
            this.Hide();
            frmLogin frm = new frmLogin();
            if (frm.ShowDialog() == DialogResult.Cancel)
            {
                this.Close();
            }
            this.Show();
            this.BringToFront();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void privateInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChangePassword frm = new frmChangePassword();
            frm.ShowDialog();
            this.Show();
        }

    }
}