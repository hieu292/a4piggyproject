using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace A4_Project
{
    public partial class frmSubmitAssignment : Form
    {
        public frmSubmitAssignment()
        {
            InitializeComponent();
        }

        public frmSubmitAssignment(string monhoc, string title, string sdatedead)
        {
            InitializeComponent();
            lblTenMonHoc.Text = monhoc;
            lblTieuDe.Text = title;
            lblDateDead.Text = sdatedead;
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if( opnFileDlg.ShowDialog() == DialogResult.OK)
            {
                txtLinkFile.Text = opnFileDlg.FileName;       
            }
        }

        private void frmSubmitAssignment_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(txtLinkFile.Text);
            if (fi.Exists)
            {
                lklblFileNop.Visible = true;
                lklblFileNop.Text = Path.GetFileName(txtLinkFile.Text);
            }
            else
                MessageBox.Show("File không tồn tại", "Error");
        }

        private void txtLinkFile_TextChanged(object sender, EventArgs e)
        {
            if (txtLinkFile.Text.Length > 0)
                btnSubmit.Enabled = true;
            else
                btnSubmit.Enabled = false;
        }
    }
}