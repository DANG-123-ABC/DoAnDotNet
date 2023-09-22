namespace QuanLyMaverikStudio.GUI
{
    partial class TrashUsers
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.dgvListUsers = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homePageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đóngGóiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thùngRácToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyênMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thùngRácToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnTime = new System.Windows.Forms.Panel();
            this.lbDateFrom = new System.Windows.Forms.Label();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lbDateTo = new System.Windows.Forms.Label();
            this.lbFilter = new System.Windows.Forms.Label();
            this.pnFilter = new System.Windows.Forms.Panel();
            this.lbSearchPermission = new System.Windows.Forms.Label();
            this.cmbSearchPermission = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbTime = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUsers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnTime.SuspendLayout();
            this.pnFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(158)))));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReset.Location = new System.Drawing.Point(124, 143);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 35);
            this.btnReset.TabIndex = 37;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(158)))));
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRestore.Location = new System.Drawing.Point(26, 143);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(78, 35);
            this.btnRestore.TabIndex = 20;
            this.btnRestore.Text = "Khôi phục";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // dgvListUsers
            // 
            this.dgvListUsers.AllowUserToAddRows = false;
            this.dgvListUsers.AllowUserToResizeRows = false;
            this.dgvListUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListUsers.Location = new System.Drawing.Point(12, 184);
            this.dgvListUsers.MultiSelect = false;
            this.dgvListUsers.Name = "dgvListUsers";
            this.dgvListUsers.ReadOnly = true;
            this.dgvListUsers.RowHeadersWidth = 30;
            this.dgvListUsers.Size = new System.Drawing.Size(1060, 415);
            this.dgvListUsers.TabIndex = 19;
            this.dgvListUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListUsers_CellClick);
            this.dgvListUsers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListUsers_RowHeaderMouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(237)))), ((int)(((byte)(158)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homePageMenuItem,
            this.productMenuItem,
            this.orderMenuItem,
            this.clientMenuItem,
            this.staffMenuItem,
            this.chuyênMụcToolStripMenuItem,
            this.statisticalMenuItem,
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 27);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homePageMenuItem
            // 
            this.homePageMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(237)))), ((int)(((byte)(158)))));
            this.homePageMenuItem.Name = "homePageMenuItem";
            this.homePageMenuItem.Size = new System.Drawing.Size(81, 23);
            this.homePageMenuItem.Text = "Trang chủ";
            this.homePageMenuItem.Click += new System.EventHandler(this.homePageMenuItem_Click);
            // 
            // productMenuItem
            // 
            this.productMenuItem.Name = "productMenuItem";
            this.productMenuItem.Size = new System.Drawing.Size(82, 23);
            this.productMenuItem.Text = "Sản phẩm";
            // 
            // orderMenuItem
            // 
            this.orderMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bánHàngToolStripMenuItem,
            this.đóngGóiToolStripMenuItem,
            this.danhSáchToolStripMenuItem});
            this.orderMenuItem.Name = "orderMenuItem";
            this.orderMenuItem.Size = new System.Drawing.Size(82, 23);
            this.orderMenuItem.Text = "Đơn hàng";
            // 
            // bánHàngToolStripMenuItem
            // 
            this.bánHàngToolStripMenuItem.Name = "bánHàngToolStripMenuItem";
            this.bánHàngToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.bánHàngToolStripMenuItem.Text = "Bán hàng";
            this.bánHàngToolStripMenuItem.Click += new System.EventHandler(this.bánHàngToolStripMenuItem_Click);
            // 
            // đóngGóiToolStripMenuItem
            // 
            this.đóngGóiToolStripMenuItem.Name = "đóngGóiToolStripMenuItem";
            this.đóngGóiToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.đóngGóiToolStripMenuItem.Text = "Đóng gói";
            // 
            // danhSáchToolStripMenuItem
            // 
            this.danhSáchToolStripMenuItem.Name = "danhSáchToolStripMenuItem";
            this.danhSáchToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.danhSáchToolStripMenuItem.Text = "Danh sách";
            // 
            // clientMenuItem
            // 
            this.clientMenuItem.Name = "clientMenuItem";
            this.clientMenuItem.Size = new System.Drawing.Size(93, 23);
            this.clientMenuItem.Text = "Khách hàng";
            // 
            // staffMenuItem
            // 
            this.staffMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchNhânViênToolStripMenuItem,
            this.thùngRácToolStripMenuItem});
            this.staffMenuItem.Name = "staffMenuItem";
            this.staffMenuItem.Size = new System.Drawing.Size(83, 23);
            this.staffMenuItem.Text = "Nhân viên";
            // 
            // danhSáchNhânViênToolStripMenuItem
            // 
            this.danhSáchNhânViênToolStripMenuItem.Name = "danhSáchNhânViênToolStripMenuItem";
            this.danhSáchNhânViênToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.danhSáchNhânViênToolStripMenuItem.Text = "Quản lý";
            this.danhSáchNhânViênToolStripMenuItem.Click += new System.EventHandler(this.danhSáchNhânViênToolStripMenuItem_Click);
            // 
            // thùngRácToolStripMenuItem
            // 
            this.thùngRácToolStripMenuItem.Name = "thùngRácToolStripMenuItem";
            this.thùngRácToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.thùngRácToolStripMenuItem.Text = "Thùng rác";
            this.thùngRácToolStripMenuItem.Click += new System.EventHandler(this.thùngRácToolStripMenuItem_Click);
            // 
            // chuyênMụcToolStripMenuItem
            // 
            this.chuyênMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.thùngRácToolStripMenuItem1});
            this.chuyênMụcToolStripMenuItem.Name = "chuyênMụcToolStripMenuItem";
            this.chuyênMụcToolStripMenuItem.Size = new System.Drawing.Size(98, 23);
            this.chuyênMụcToolStripMenuItem.Text = "Chuyên mục";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            this.quảnLýToolStripMenuItem.Click += new System.EventHandler(this.quảnLýToolStripMenuItem_Click);
            // 
            // thùngRácToolStripMenuItem1
            // 
            this.thùngRácToolStripMenuItem1.Name = "thùngRácToolStripMenuItem1";
            this.thùngRácToolStripMenuItem1.Size = new System.Drawing.Size(139, 24);
            this.thùngRácToolStripMenuItem1.Text = "Thùng rác";
            this.thùngRácToolStripMenuItem1.Click += new System.EventHandler(this.thùngRácToolStripMenuItem1_Click);
            // 
            // statisticalMenuItem
            // 
            this.statisticalMenuItem.Name = "statisticalMenuItem";
            this.statisticalMenuItem.Size = new System.Drawing.Size(78, 23);
            this.statisticalMenuItem.Text = "Thống kê";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(78, 23);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // changePasswordMenuItem
            // 
            this.changePasswordMenuItem.Name = "changePasswordMenuItem";
            this.changePasswordMenuItem.Size = new System.Drawing.Size(161, 24);
            this.changePasswordMenuItem.Text = "Đổi mật khẩu";
            this.changePasswordMenuItem.Click += new System.EventHandler(this.changePasswordMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // pnTime
            // 
            this.pnTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTime.Controls.Add(this.lbDateFrom);
            this.pnTime.Controls.Add(this.dtpDateTo);
            this.pnTime.Controls.Add(this.dtpDateFrom);
            this.pnTime.Controls.Add(this.lbDateTo);
            this.pnTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnTime.Location = new System.Drawing.Point(566, 60);
            this.pnTime.Name = "pnTime";
            this.pnTime.Size = new System.Drawing.Size(506, 67);
            this.pnTime.TabIndex = 42;
            // 
            // lbDateFrom
            // 
            this.lbDateFrom.AutoSize = true;
            this.lbDateFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbDateFrom.Location = new System.Drawing.Point(265, 4);
            this.lbDateFrom.Name = "lbDateFrom";
            this.lbDateFrom.Size = new System.Drawing.Size(68, 19);
            this.lbDateFrom.TabIndex = 16;
            this.lbDateFrom.Text = "Đến ngày";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Enabled = false;
            this.dtpDateTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDateTo.Location = new System.Drawing.Point(269, 25);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(226, 25);
            this.dtpDateTo.TabIndex = 12;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Enabled = false;
            this.dtpDateFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDateFrom.Location = new System.Drawing.Point(14, 26);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(222, 25);
            this.dtpDateFrom.TabIndex = 13;
            // 
            // lbDateTo
            // 
            this.lbDateTo.AutoSize = true;
            this.lbDateTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbDateTo.Location = new System.Drawing.Point(10, 4);
            this.lbDateTo.Name = "lbDateTo";
            this.lbDateTo.Size = new System.Drawing.Size(58, 19);
            this.lbDateTo.TabIndex = 15;
            this.lbDateTo.Text = "Từ ngày";
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbFilter.Location = new System.Drawing.Point(8, 38);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(46, 19);
            this.lbFilter.TabIndex = 41;
            this.lbFilter.Text = "Bộ lọc";
            // 
            // pnFilter
            // 
            this.pnFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnFilter.Controls.Add(this.lbSearchPermission);
            this.pnFilter.Controls.Add(this.cmbSearchPermission);
            this.pnFilter.Controls.Add(this.btnSearch);
            this.pnFilter.Controls.Add(this.txtSearch);
            this.pnFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pnFilter.Location = new System.Drawing.Point(12, 60);
            this.pnFilter.Name = "pnFilter";
            this.pnFilter.Size = new System.Drawing.Size(537, 67);
            this.pnFilter.TabIndex = 40;
            // 
            // lbSearchPermission
            // 
            this.lbSearchPermission.AutoSize = true;
            this.lbSearchPermission.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbSearchPermission.Location = new System.Drawing.Point(321, 3);
            this.lbSearchPermission.Name = "lbSearchPermission";
            this.lbSearchPermission.Size = new System.Drawing.Size(50, 19);
            this.lbSearchPermission.TabIndex = 31;
            this.lbSearchPermission.Text = "Quyền";
            // 
            // cmbSearchPermission
            // 
            this.cmbSearchPermission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchPermission.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSearchPermission.FormattingEnabled = true;
            this.cmbSearchPermission.Location = new System.Drawing.Point(325, 25);
            this.cmbSearchPermission.Name = "cmbSearchPermission";
            this.cmbSearchPermission.Size = new System.Drawing.Size(195, 25);
            this.cmbSearchPermission.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(158)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSearch.Location = new System.Drawing.Point(13, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 28);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(111, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(195, 25);
            this.txtSearch.TabIndex = 10;
            // 
            // cbTime
            // 
            this.cbTime.AutoSize = true;
            this.cbTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTime.Location = new System.Drawing.Point(566, 36);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(109, 23);
            this.cbTime.TabIndex = 39;
            this.cbTime.Text = "Thời gian xóa";
            this.cbTime.UseVisualStyleBackColor = true;
            this.cbTime.CheckedChanged += new System.EventHandler(this.cbTime_CheckedChanged);
            // 
            // TrashUsers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1084, 612);
            this.Controls.Add(this.pnTime);
            this.Controls.Add(this.lbFilter);
            this.Controls.Add(this.pnFilter);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.dgvListUsers);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "TrashUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thùng rác nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUsers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnTime.ResumeLayout(false);
            this.pnTime.PerformLayout();
            this.pnFilter.ResumeLayout(false);
            this.pnFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.DataGridView dgvListUsers;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homePageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thùngRácToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyênMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thùngRácToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem statisticalMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel pnTime;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label lbDateTo;
        private System.Windows.Forms.Label lbDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.Panel pnFilter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbSearchPermission;
        private System.Windows.Forms.Label lbSearchPermission;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox cbTime;
        private System.Windows.Forms.ToolStripMenuItem bánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đóngGóiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchToolStripMenuItem;
    }
}