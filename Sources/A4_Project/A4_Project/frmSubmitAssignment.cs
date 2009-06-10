using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace A4_Project
{
    public partial class frmSubmitAssignment : Form
    {
        public frmSubmitAssignment()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if( opnFileDlg.ShowDialog() == DialogResult.OK)
            {
                txtLinkFile.Text = opnFileDlg.FileName;
            }
        }
    }
}