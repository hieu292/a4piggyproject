namespace A4_Project
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MenuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkDownloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.privateInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howDoIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgvDSNewThread = new System.Windows.Forms.DataGridView();
            this.MonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCapNhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grDSDL = new System.Windows.Forms.GroupBox();
            this.dtgvDanhSachDeadline = new System.Windows.Forms.DataGridView();
            this.Mon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDSMH = new System.Windows.Forms.GroupBox();
            this.dtgvDanhSachMonHoc = new System.Windows.Forms.DataGridView();
            this.grDSMH = new System.Windows.Forms.GroupBox();
            this.DSMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSNewThread)).BeginInit();
            this.grDSDL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachDeadline)).BeginInit();
            this.gbDSMH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachMonHoc)).BeginInit();
            this.grDSMH.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuMain
            // 
            this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuMain.Location = new System.Drawing.Point(0, 0);
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Size = new System.Drawing.Size(739, 24);
            this.MenuMain.TabIndex = 0;
            this.MenuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linkDownloadToolStripMenuItem,
            this.privateInfoToolStripMenuItem,
            this.LogOutToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // linkDownloadToolStripMenuItem
            // 
            this.linkDownloadToolStripMenuItem.Name = "linkDownloadToolStripMenuItem";
            this.linkDownloadToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.linkDownloadToolStripMenuItem.Text = "Link download...";
            this.linkDownloadToolStripMenuItem.Click += new System.EventHandler(this.linkDownloadToolStripMenuItem_Click);
            // 
            // privateInfoToolStripMenuItem
            // 
            this.privateInfoToolStripMenuItem.Name = "privateInfoToolStripMenuItem";
            this.privateInfoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.privateInfoToolStripMenuItem.Text = "Đổi mật khẩu...";
            this.privateInfoToolStripMenuItem.Click += new System.EventHandler(this.privateInfoToolStripMenuItem_Click);
            // 
            // LogOutToolStripMenuItem
            // 
            this.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem";
            this.LogOutToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.LogOutToolStripMenuItem.Text = "Đăng xuất";
            this.LogOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howDoIToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howDoIToolStripMenuItem
            // 
            this.howDoIToolStripMenuItem.Name = "howDoIToolStripMenuItem";
            this.howDoIToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.howDoIToolStripMenuItem.Text = "How Do I";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.updateToolStripMenuItem.Text = "Update...";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // dtgvDSNewThread
            // 
            this.dtgvDSNewThread.AllowUserToAddRows = false;
            this.dtgvDSNewThread.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvDSNewThread.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvDSNewThread.BackgroundColor = System.Drawing.Color.Lavender;
            this.dtgvDSNewThread.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSNewThread.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MonHoc,
            this.TieuDe,
            this.NgayCapNhat});
            this.dtgvDSNewThread.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDSNewThread.Location = new System.Drawing.Point(3, 20);
            this.dtgvDSNewThread.Name = "dtgvDSNewThread";
            this.dtgvDSNewThread.ReadOnly = true;
            this.dtgvDSNewThread.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDSNewThread.Size = new System.Drawing.Size(733, 188);
            this.dtgvDSNewThread.TabIndex = 1;
            this.dtgvDSNewThread.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSNewThread_CellContentClick);
            // 
            // MonHoc
            // 
            this.MonHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MonHoc.FillWeight = 95.93722F;
            this.MonHoc.HeaderText = "Môn học";
            this.MonHoc.Name = "MonHoc";
            this.MonHoc.ReadOnly = true;
            // 
            // TieuDe
            // 
            this.TieuDe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TieuDe.FillWeight = 82.23538F;
            this.TieuDe.HeaderText = "Tiêu đề";
            this.TieuDe.Name = "TieuDe";
            this.TieuDe.ReadOnly = true;
            // 
            // NgayCapNhat
            // 
            this.NgayCapNhat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayCapNhat.FillWeight = 121.8274F;
            this.NgayCapNhat.HeaderText = "Ngày cập nhật";
            this.NgayCapNhat.Name = "NgayCapNhat";
            this.NgayCapNhat.ReadOnly = true;
            // 
            // grDSDL
            // 
            this.grDSDL.Controls.Add(this.dtgvDanhSachDeadline);
            this.grDSDL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grDSDL.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grDSDL.ForeColor = System.Drawing.Color.Blue;
            this.grDSDL.Location = new System.Drawing.Point(258, 24);
            this.grDSDL.Name = "grDSDL";
            this.grDSDL.Size = new System.Drawing.Size(481, 173);
            this.grDSDL.TabIndex = 5;
            this.grDSDL.TabStop = false;
            this.grDSDL.Text = "Danh Sách Deadline";
            // 
            // dtgvDanhSachDeadline
            // 
            this.dtgvDanhSachDeadline.AllowUserToAddRows = false;
            this.dtgvDanhSachDeadline.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvDanhSachDeadline.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgvDanhSachDeadline.BackgroundColor = System.Drawing.Color.Lavender;
            this.dtgvDanhSachDeadline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachDeadline.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mon,
            this.Ten,
            this.ThoiGian});
            this.dtgvDanhSachDeadline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDanhSachDeadline.Location = new System.Drawing.Point(3, 20);
            this.dtgvDanhSachDeadline.Name = "dtgvDanhSachDeadline";
            this.dtgvDanhSachDeadline.ReadOnly = true;
            this.dtgvDanhSachDeadline.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDanhSachDeadline.Size = new System.Drawing.Size(475, 150);
            this.dtgvDanhSachDeadline.TabIndex = 0;
            this.dtgvDanhSachDeadline.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSachDeadline_CellContentClick);
            // 
            // Mon
            // 
            this.Mon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mon.HeaderText = "Môn học";
            this.Mon.Name = "Mon";
            this.Mon.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ten.HeaderText = "Tên Dealine";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // ThoiGian
            // 
            this.ThoiGian.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThoiGian.HeaderText = "Thời gian";
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.ReadOnly = true;
            // 
            // gbDSMH
            // 
            this.gbDSMH.Controls.Add(this.dtgvDanhSachMonHoc);
            this.gbDSMH.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbDSMH.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDSMH.ForeColor = System.Drawing.Color.Blue;
            this.gbDSMH.Location = new System.Drawing.Point(0, 24);
            this.gbDSMH.Name = "gbDSMH";
            this.gbDSMH.Size = new System.Drawing.Size(258, 173);
            this.gbDSMH.TabIndex = 4;
            this.gbDSMH.TabStop = false;
            this.gbDSMH.Text = "Danh Sách Môn Học";
            // 
            // dtgvDanhSachMonHoc
            // 
            this.dtgvDanhSachMonHoc.AllowUserToAddRows = false;
            this.dtgvDanhSachMonHoc.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvDanhSachMonHoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dtgvDanhSachMonHoc.BackgroundColor = System.Drawing.Color.Lavender;
            this.dtgvDanhSachMonHoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgvDanhSachMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DSMH});
            this.dtgvDanhSachMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDanhSachMonHoc.Location = new System.Drawing.Point(3, 20);
            this.dtgvDanhSachMonHoc.MultiSelect = false;
            this.dtgvDanhSachMonHoc.Name = "dtgvDanhSachMonHoc";
            this.dtgvDanhSachMonHoc.ReadOnly = true;
            this.dtgvDanhSachMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDanhSachMonHoc.Size = new System.Drawing.Size(252, 150);
            this.dtgvDanhSachMonHoc.TabIndex = 0;
            this.dtgvDanhSachMonHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSachMonHoc_CellContentClick);
            // 
            // grDSMH
            // 
            this.grDSMH.Controls.Add(this.dtgvDSNewThread);
            this.grDSMH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grDSMH.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grDSMH.ForeColor = System.Drawing.Color.Blue;
            this.grDSMH.Location = new System.Drawing.Point(0, 197);
            this.grDSMH.Name = "grDSMH";
            this.grDSMH.Size = new System.Drawing.Size(739, 211);
            this.grDSMH.TabIndex = 3;
            this.grDSMH.TabStop = false;
            this.grDSMH.Text = "Danh Sách Thread Bạn Tham Gia";
            // 
            // DSMH
            // 
            this.DSMH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DSMH.DefaultCellStyle = dataGridViewCellStyle12;
            this.DSMH.HeaderText = "Danh Sách Môn Học";
            this.DSMH.Name = "DSMH";
            this.DSMH.ReadOnly = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 408);
            this.Controls.Add(this.grDSDL);
            this.Controls.Add(this.gbDSMH);
            this.Controls.Add(this.grDSMH);
            this.Controls.Add(this.MenuMain);
            this.Name = "frmMain";
            this.Text = "My Moodle Rip";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MenuMain.ResumeLayout(false);
            this.MenuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSNewThread)).EndInit();
            this.grDSDL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachDeadline)).EndInit();
            this.gbDSMH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachMonHoc)).EndInit();
            this.grDSMH.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem privateInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howDoIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dtgvDSNewThread;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TieuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCapNhat;
        private System.Windows.Forms.GroupBox grDSDL;
        private System.Windows.Forms.DataGridView dtgvDanhSachDeadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.GroupBox gbDSMH;
        private System.Windows.Forms.DataGridView dtgvDanhSachMonHoc;
        private System.Windows.Forms.GroupBox grDSMH;
        private System.Windows.Forms.ToolStripMenuItem linkDownloadToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DSMH;

    }
}

