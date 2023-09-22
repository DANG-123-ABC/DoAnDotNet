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
            this.pnInsert = new System.Windows.Forms.Panel();
            this.lbInfoCategories = new System.Windows.Forms.Label();
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
            this.pnInfo = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.txtNameInfo = new System.Windows.Forms.TextBox();
            this.lbNameInfo = new System.Windows.Forms.Label();
            this.cmbParentInfo = new System.Windows.Forms.ComboBox();
            this.lbParentInfo = new System.Windows.Forms.Label();
            this.lbInsert = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriesList)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnInsert.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCategoriesList
            // 
            this.dgvCategoriesList.AllowUserToAddRows = false;
            this.dgvCategoriesList.AllowUserToResizeRows = false;
            this.dgvCategoriesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategoriesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoriesList.Location = new System.Drawing.Point(12, 231);
            this.dgvCategoriesList.MultiSelect = false;
            this.dgvCategoriesList.Name = "dgvCategoriesList";
            this.dgvCategoriesList.ReadOnly = true;
            this.dgvCategoriesList.RowHeadersVisible = false;
            this.dgvCategoriesList.RowHeadersWidth = 30;
            this.dgvCategoriesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            this.cmbParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(158)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUpdate.Location = new System.Drawing.Point(19, 122);
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
            this.btnDelete.Location = new System.Drawing.Point(147, 122);
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
            this.btnSearch.Location = new System.Drawing.Point(193, 122);
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
            this.btnReset.Location = new System.Drawing.Point(271, 122);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 28);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtSearch.Location = new System.Drawing.Point(15, 124);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(172, 26);
            this.txtSearch.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpDateTo);
            this.panel1.Controls.Add(this.lbDateFrom);
            this.panel1.Controls.Add(this.lbDateTo);
            this.panel1.Controls.Add(this.dtpDateFrom);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Location = new System.Drawing.Point(784, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 165);
            this.panel1.TabIndex = 24;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Enabled = false;
            this.dtpDateTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDateTo.Location = new System.Drawing.Point(14, 85);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(257, 25);
            this.dtpDateTo.TabIndex = 31;
            // 
            // lbDateFrom
            // 
            this.lbDateFrom.AutoSize = true;
            this.lbDateFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbDateFrom.Location = new System.Drawing.Point(10, 6);
            this.lbDateFrom.Name = "lbDateFrom";
            this.lbDateFrom.Size = new System.Drawing.Size(58, 19);
            this.lbDateFrom.TabIndex = 32;
            this.lbDateFrom.Text = "Từ ngày";
            // 
            // lbDateTo
            // 
            this.lbDateTo.AutoSize = true;
            this.lbDateTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbDateTo.Location = new System.Drawing.Point(10, 63);
            this.lbDateTo.Name = "lbDateTo";
            this.lbDateTo.Size = new System.Drawing.Size(68, 19);
            this.lbDateTo.TabIndex = 33;
            this.lbDateTo.Text = "Đến ngày";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Enabled = false;
            this.dtpDateFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDateFrom.Location = new System.Drawing.Point(14, 28);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(257, 25);
            this.dtpDateFrom.TabIndex = 30;
            // 
            // pnInsert
            // 
            this.pnInsert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnInsert.Controls.Add(this.txtName);
            this.pnInsert.Controls.Add(this.lbName);
            this.pnInsert.Controls.Add(this.cmbParent);
            this.pnInsert.Controls.Add(this.lbParent);
            this.pnInsert.Controls.Add(this.btnInsert);
            this.pnInsert.Location = new System.Drawing.Point(12, 60);
            this.pnInsert.Name = "pnInsert";
            this.pnInsert.Size = new System.Drawing.Size(373, 165);
            this.pnInsert.TabIndex = 25;
            // 
            // lbInfoCategories
            // 
            this.lbInfoCategories.AutoSize = true;
            this.lbInfoCategories.Location = new System.Drawing.Point(397, 38);
            this.lbInfoCategories.Name = "lbInfoCategories";
            this.lbInfoCategories.Size = new System.Drawing.Size(146, 19);
            this.lbInfoCategories.TabIndex = 11;
            this.lbInfoCategories.Text = "Thông tin chuyên mục";
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
            // rdoUpdated
            // 
            this.rdoUpdated.AutoSize = true;
            this.rdoUpdated.Enabled = false;
            this.rdoUpdated.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdoUpdated.Location = new System.Drawing.Point(932, 35);
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
            this.rdoCreated.Location = new System.Drawing.Point(877, 35);
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
            this.cbTime.Location = new System.Drawing.Point(784, 36);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(87, 23);
            this.cbTime.TabIndex = 27;
            this.cbTime.Text = "Thời gian:";
            this.cbTime.UseVisualStyleBackColor = true;
            this.cbTime.CheckedChanged += new System.EventHandler(this.cbTime_CheckedChanged);
            // 
            // pnInfo
            // 
            this.pnInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnInfo.Controls.Add(this.txtID);
            this.pnInfo.Controls.Add(this.lbID);
            this.pnInfo.Controls.Add(this.btnReset);
            this.pnInfo.Controls.Add(this.txtNameInfo);
            this.pnInfo.Controls.Add(this.lbNameInfo);
            this.pnInfo.Controls.Add(this.btnUpdate);
            this.pnInfo.Controls.Add(this.cmbParentInfo);
            this.pnInfo.Controls.Add(this.btnDelete);
            this.pnInfo.Controls.Add(this.lbParentInfo);
            this.pnInfo.Location = new System.Drawing.Point(401, 60);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(367, 165);
            this.pnInfo.TabIndex = 30;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtID.Location = new System.Drawing.Point(19, 28);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(155, 25);
            this.txtID.TabIndex = 28;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbID.Location = new System.Drawing.Point(15, 6);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(107, 19);
            this.lbID.TabIndex = 27;
            this.lbID.Text = "Mã chuyên mục";
            // 
            // txtNameInfo
            // 
            this.txtNameInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNameInfo.Location = new System.Drawing.Point(194, 28);
            this.txtNameInfo.Name = "txtNameInfo";
            this.txtNameInfo.Size = new System.Drawing.Size(155, 25);
            this.txtNameInfo.TabIndex = 24;
            // 
            // lbNameInfo
            // 
            this.lbNameInfo.AutoSize = true;
            this.lbNameInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbNameInfo.Location = new System.Drawing.Point(190, 6);
            this.lbNameInfo.Name = "lbNameInfo";
            this.lbNameInfo.Size = new System.Drawing.Size(108, 19);
            this.lbNameInfo.TabIndex = 23;
            this.lbNameInfo.Text = "Tên chuyên mục";
            // 
            // cmbParentInfo
            // 
            this.cmbParentInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParentInfo.FormattingEnabled = true;
            this.cmbParentInfo.Location = new System.Drawing.Point(19, 85);
            this.cmbParentInfo.Name = "cmbParentInfo";
            this.cmbParentInfo.Size = new System.Drawing.Size(330, 25);
            this.cmbParentInfo.TabIndex = 26;
            // 
            // lbParentInfo
            // 
            this.lbParentInfo.AutoSize = true;
            this.lbParentInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbParentInfo.Location = new System.Drawing.Point(15, 63);
            this.lbParentInfo.Name = "lbParentInfo";
            this.lbParentInfo.Size = new System.Drawing.Size(33, 19);
            this.lbParentInfo.TabIndex = 25;
            this.lbParentInfo.Text = "Cha";
            // 
            // lbInsert
            // 
            this.lbInsert.AutoSize = true;
            this.lbInsert.Location = new System.Drawing.Point(8, 38);
            this.lbInsert.Name = "lbInsert";
            this.lbInsert.Size = new System.Drawing.Size(121, 19);
            this.lbInsert.TabIndex = 31;
            this.lbInsert.Text = "Thêm chuyên mục";
            // 
            // CategoriesManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1084, 612);
            this.Controls.Add(this.lbInsert);
            this.Controls.Add(this.pnInfo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbInfoCategories);
            this.Controls.Add(this.pnInsert);
            this.Controls.Add(this.rdoUpdated);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rdoCreated);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.dgvCategoriesList);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MaximizeBox = false;
            this.Name = "CategoriesManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý chuyên mục";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoriesList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnInsert.ResumeLayout(false);
            this.pnInsert.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnInfo.ResumeLayout(false);
            this.pnInfo.PerformLayout();
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
        private System.Windows.Forms.Panel pnInsert;
        private System.Windows.Forms.Label lbInfoCategories;
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
        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.TextBox txtNameInfo;
        private System.Windows.Forms.Label lbNameInfo;
        private System.Windows.Forms.ComboBox cmbParentInfo;
        private System.Windows.Forms.Label lbParentInfo;
        private System.Windows.Forms.Label lbInsert;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbID;
    }
}