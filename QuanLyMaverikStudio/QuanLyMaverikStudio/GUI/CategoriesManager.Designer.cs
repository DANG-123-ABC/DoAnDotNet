namespace QuanLyMaverikStudio.GUI
{
    partial class CategoriesManager
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
            this.dgvCategoriesList = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbParent = new System.Windows.Forms.Label();
            this.cmbParent = new System.Windows.Forms.ComboBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.lbDateFrom = new System.Windows.Forms.Label();
            this.lbDateTo = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.txtFilterName = new System.Windows.Forms.TextBox();
            this.lbFilterName = new System.Windows.Forms.Label();
            this.lbFilterParent = new System.Windows.Forms.Label();
            this.cmbFilterParent = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbInfoCategories = new System.Windows.Forms.Label();
            this.lbFilter = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homePageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.rdoUpdated = new System.Windows.Forms.RadioButton();
            this.rdoCreated = new System.Windows.Forms.RadioButton();
            this.cbTime = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriesList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCategoriesList
            // 
            this.dgvCategoriesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategoriesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoriesList.Location = new System.Drawing.Point(12, 231);
            this.dgvCategoriesList.MultiSelect = false;
            this.dgvCategoriesList.Name = "dgvCategoriesList";
            this.dgvCategoriesList.ReadOnly = true;
            this.dgvCategoriesList.RowHeadersWidth = 30;
            this.dgvCategoriesList.Size = new System.Drawing.Size(1060, 368);
            this.dgvCategoriesList.TabIndex = 1;
            this.dgvCategoriesList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoriesList_CellClick);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Location = new System.Drawing.Point(20, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(330, 25);
            this.txtName.TabIndex = 8;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbName.Location = new System.Drawing.Point(16, 6);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(108, 19);
            this.lbName.TabIndex = 7;
            this.lbName.Text = "Tên chuyên mục";
            // 
            // lbParent
            // 
            this.lbParent.AutoSize = true;
            this.lbParent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbParent.Location = new System.Drawing.Point(16, 63);
            this.lbParent.Name = "lbParent";
            this.lbParent.Size = new System.Drawing.Size(33, 19);
            this.lbParent.TabIndex = 9;
            this.lbParent.Text = "Cha";
            // 
            // cmbParent
            // 
            this.cmbParent.FormattingEnabled = true;
            this.cmbParent.Location = new System.Drawing.Point(20, 85);
            this.cmbParent.Name = "cmbParent";
            this.cmbParent.Size = new System.Drawing.Size(330, 25);
            this.cmbParent.TabIndex = 10;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(158)))));
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnInsert.Location = new System.Drawing.Point(20, 122);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(78, 28);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(158)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUpdate.Location = new System.Drawing.Point(104, 122);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(78, 28);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(158)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDelete.Location = new System.Drawing.Point(188, 122);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 28);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(158)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSearch.Location = new System.Drawing.Point(14, 121);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 28);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(158)))));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReset.Location = new System.Drawing.Point(272, 122);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 28);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.Location = new System.Drawing.Point(98, 122);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(274, 27);
            this.txtSearch.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpDateTo);
            this.panel1.Controls.Add(this.lbDateFrom);
            this.panel1.Controls.Add(this.lbDateTo);
            this.panel1.Controls.Add(this.dtpDateFrom);
            this.panel1.Controls.Add(this.txtFilterName);
            this.panel1.Controls.Add(this.lbFilterName);
            this.panel1.Controls.Add(this.lbFilterParent);
            this.panel1.Controls.Add(this.cmbFilterParent);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Location = new System.Drawing.Point(405, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 165);
            this.panel1.TabIndex = 24;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Enabled = false;
            this.dtpDateTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDateTo.Location = new System.Drawing.Point(392, 85);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(257, 25);
            this.dtpDateTo.TabIndex = 31;
            // 
            // lbDateFrom
            // 
            this.lbDateFrom.AutoSize = true;
            this.lbDateFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbDateFrom.Location = new System.Drawing.Point(388, 6);
            this.lbDateFrom.Name = "lbDateFrom";
            this.lbDateFrom.Size = new System.Drawing.Size(58, 19);
            this.lbDateFrom.TabIndex = 32;
            this.lbDateFrom.Text = "Từ ngày";
            // 
            // lbDateTo
            // 
            this.lbDateTo.AutoSize = true;
            this.lbDateTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbDateTo.Location = new System.Drawing.Point(388, 63);
            this.lbDateTo.Name = "lbDateTo";
            this.lbDateTo.Size = new System.Drawing.Size(68, 19);
            this.lbDateTo.TabIndex = 33;
            this.lbDateTo.Text = "Đến ngày";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Enabled = false;
            this.dtpDateFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDateFrom.Location = new System.Drawing.Point(392, 28);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(257, 25);
            this.dtpDateFrom.TabIndex = 30;
            // 
            // txtFilterName
            // 
            this.txtFilterName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFilterName.Location = new System.Drawing.Point(14, 28);
            this.txtFilterName.Name = "txtFilterName";
            this.txtFilterName.Size = new System.Drawing.Size(358, 25);
            this.txtFilterName.TabIndex = 12;
            // 
            // lbFilterName
            // 
            this.lbFilterName.AutoSize = true;
            this.lbFilterName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbFilterName.Location = new System.Drawing.Point(10, 6);
            this.lbFilterName.Name = "lbFilterName";
            this.lbFilterName.Size = new System.Drawing.Size(108, 19);
            this.lbFilterName.TabIndex = 11;
            this.lbFilterName.Text = "Tên chuyên mục";
            // 
            // lbFilterParent
            // 
            this.lbFilterParent.AutoSize = true;
            this.lbFilterParent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbFilterParent.Location = new System.Drawing.Point(10, 63);
            this.lbFilterParent.Name = "lbFilterParent";
            this.lbFilterParent.Size = new System.Drawing.Size(33, 19);
            this.lbFilterParent.TabIndex = 13;
            this.lbFilterParent.Text = "Cha";
            // 
            // cmbFilterParent
            // 
            this.cmbFilterParent.FormattingEnabled = true;
            this.cmbFilterParent.Location = new System.Drawing.Point(14, 85);
            this.cmbFilterParent.Name = "cmbFilterParent";
            this.cmbFilterParent.Size = new System.Drawing.Size(358, 25);
            this.cmbFilterParent.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.cmbParent);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.lbParent);
            this.panel2.Controls.Add(this.btnInsert);
            this.panel2.Location = new System.Drawing.Point(12, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 165);
            this.panel2.TabIndex = 25;
            // 
            // lbInfoCategories
            // 
            this.lbInfoCategories.AutoSize = true;
            this.lbInfoCategories.Location = new System.Drawing.Point(8, 38);
            this.lbInfoCategories.Name = "lbInfoCategories";
            this.lbInfoCategories.Size = new System.Drawing.Size(146, 19);
            this.lbInfoCategories.TabIndex = 11;
            this.lbInfoCategories.Text = "Thông tin chuyên mục";
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.Location = new System.Drawing.Point(401, 38);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(46, 19);
            this.lbFilter.TabIndex = 26;
            this.lbFilter.Text = "Bộ lọc";
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
            this.menuStrip1.TabIndex = 27;
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
            this.orderMenuItem.Name = "orderMenuItem";
            this.orderMenuItem.Size = new System.Drawing.Size(82, 23);
            this.orderMenuItem.Text = "Đơn hàng";
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
            this.danhSáchNhânViênToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.danhSáchNhânViênToolStripMenuItem.Text = "Quản lý";
            this.danhSáchNhânViênToolStripMenuItem.Click += new System.EventHandler(this.danhSáchNhânViênToolStripMenuItem_Click);
            // 
            // thùngRácToolStripMenuItem
            // 
            this.thùngRácToolStripMenuItem.Name = "thùngRácToolStripMenuItem";
            this.thùngRácToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
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
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            this.quảnLýToolStripMenuItem.Click += new System.EventHandler(this.quảnLýToolStripMenuItem_Click);
            // 
            // thùngRácToolStripMenuItem1
            // 
            this.thùngRácToolStripMenuItem1.Name = "thùngRácToolStripMenuItem1";
            this.thùngRácToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
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
            this.changePasswordMenuItem.Size = new System.Drawing.Size(180, 24);
            this.changePasswordMenuItem.Text = "Đổi mật khẩu";
            this.changePasswordMenuItem.Click += new System.EventHandler(this.changePasswordMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // rdoUpdated
            // 
            this.rdoUpdated.AutoSize = true;
            this.rdoUpdated.Enabled = false;
            this.rdoUpdated.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdoUpdated.Location = new System.Drawing.Point(946, 35);
            this.rdoUpdated.Name = "rdoUpdated";
            this.rdoUpdated.Size = new System.Drawing.Size(49, 23);
            this.rdoUpdated.TabIndex = 29;
            this.rdoUpdated.Text = "Sửa";
            this.rdoUpdated.UseVisualStyleBackColor = true;
            // 
            // rdoCreated
            // 
            this.rdoCreated.AutoSize = true;
            this.rdoCreated.Checked = true;
            this.rdoCreated.Enabled = false;
            this.rdoCreated.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdoCreated.Location = new System.Drawing.Point(891, 35);
            this.rdoCreated.Name = "rdoCreated";
            this.rdoCreated.Size = new System.Drawing.Size(49, 23);
            this.rdoCreated.TabIndex = 28;
            this.rdoCreated.TabStop = true;
            this.rdoCreated.Text = "Tạo";
            this.rdoCreated.UseVisualStyleBackColor = true;
            // 
            // cbTime
            // 
            this.cbTime.AutoSize = true;
            this.cbTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTime.Location = new System.Drawing.Point(798, 36);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(87, 23);
            this.cbTime.TabIndex = 27;
            this.cbTime.Text = "Thời gian:";
            this.cbTime.UseVisualStyleBackColor = true;
            // 
            // CategoriesManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbFilter);
            this.Controls.Add(this.lbInfoCategories);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rdoUpdated);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rdoCreated);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.dgvCategoriesList);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "CategoriesManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý chuyên mục";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriesList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategoriesList;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbParent;
        private System.Windows.Forms.ComboBox cmbParent;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFilterName;
        private System.Windows.Forms.Label lbFilterName;
        private System.Windows.Forms.Label lbFilterParent;
        private System.Windows.Forms.ComboBox cmbFilterParent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbInfoCategories;
        private System.Windows.Forms.Label lbFilter;
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
        private System.Windows.Forms.RadioButton rdoUpdated;
        private System.Windows.Forms.RadioButton rdoCreated;
        private System.Windows.Forms.CheckBox cbTime;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label lbDateFrom;
        private System.Windows.Forms.Label lbDateTo;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
    }
}