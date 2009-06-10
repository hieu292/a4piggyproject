namespace A4_Project
{
    partial class frmSubmitAssignment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTenMonHoc = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblDateDead = new System.Windows.Forms.Label();
            this.lklblFileNop = new System.Windows.Forms.LinkLabel();
            this.txtLinkFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.opnFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblTenMonHoc
            // 
            this.lblTenMonHoc.AutoSize = true;
            this.lblTenMonHoc.Location = new System.Drawing.Point(15, 25);
            this.lblTenMonHoc.Name = "lblTenMonHoc";
            this.lblTenMonHoc.Size = new System.Drawing.Size(76, 13);
            this.lblTenMonHoc.TabIndex = 0;
            this.lblTenMonHoc.Text = "[Tên môn học]";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Location = new System.Drawing.Point(180, 25);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(50, 13);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "[Tiêu đề]";
            // 
            // lblDateDead
            // 
            this.lblDateDead.AutoSize = true;
            this.lblDateDead.Location = new System.Drawing.Point(319, 25);
            this.lblDateDead.Name = "lblDateDead";
            this.lblDateDead.Size = new System.Drawing.Size(83, 13);
            this.lblDateDead.TabIndex = 0;
            this.lblDateDead.Text = "[Ngày Deadline]";
            // 
            // lklblFileNop
            // 
            this.lklblFileNop.AutoSize = true;
            this.lklblFileNop.Location = new System.Drawing.Point(491, 25);
            this.lklblFileNop.Name = "lklblFileNop";
            this.lklblFileNop.Size = new System.Drawing.Size(65, 13);
            this.lklblFileNop.TabIndex = 1;
            this.lklblFileNop.TabStop = true;
            this.lklblFileNop.Text = "[linkFileNop]";
            this.lklblFileNop.Visible = false;
            // 
            // txtLinkFile
            // 
            this.txtLinkFile.Location = new System.Drawing.Point(29, 84);
            this.txtLinkFile.Name = "txtLinkFile";
            this.txtLinkFile.Size = new System.Drawing.Size(394, 20);
            this.txtLinkFile.TabIndex = 2;
            this.txtLinkFile.TextChanged += new System.EventHandler(this.txtLinkFile_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(437, 81);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse..";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(526, 81);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmSubmitAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 136);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtLinkFile);
            this.Controls.Add(this.lklblFileNop);
            this.Controls.Add(this.lblDateDead);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblTenMonHoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSubmitAssignment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nộp Bài";
            this.Load += new System.EventHandler(this.frmSubmitAssignment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenMonHoc;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblDateDead;
        private System.Windows.Forms.LinkLabel lklblFileNop;
        private System.Windows.Forms.TextBox txtLinkFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.OpenFileDialog opnFileDlg;
    }
}