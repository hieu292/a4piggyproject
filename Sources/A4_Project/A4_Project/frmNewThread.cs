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
    public partial class frmNewThread : Form
    {
        public int SubjectID;
        public frmNewThread(int _ID)
        {
            SubjectID = _ID;
            InitializeComponent();
        }
        public frmNewThread()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Mời bạn nhập Tiêu đề!");
            if(textBox2.Text=="")
                MessageBox.Show("Mời bạn nhập Nội dung!");
            else
            {
                ThreadDTO tr = new ThreadDTO();
                tr.Title = textBox1.Text;
                tr.Content = textBox2.Text;
                tr.Time = DateTime.Now;
                tr.OpenSubjectID = SubjectID;
                tr.StudentID = GlobalVarian.StudentID;

                ThreadBUS trbus = new ThreadBUS();

                if(trbus.AddThread(tr)==true)
                    MessageBox.Show("Thread đã được tạo.");

            }
        }

        private void frmNewThread_Load(object sender, EventArgs e)
        {

        }
    }
}