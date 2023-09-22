namespace QuanLyMaverikStudio
{
    partial class UsersList
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
            this.dgvListUsers = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.lbAccount = new System.Windows.Forms.Label();
            this.lbPermission = new System.Windows.Forms.Label();
            this.cmbPermission = new System.Windows.Forms.ComboBox();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.lbDateFrom = new System.Windows.Forms.Label();
            this.lbDateTo = new System.Windows.Forms.Label();
            this.cbTime = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
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
            this.pnInfoUser = new System.Windows.Forms.Panel();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.lbGender = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lbSalary = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbInfoUser = new System.Windows.Forms.Label();
            this.pnFilter = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbSearchPermission = new System.Windows.Forms.ComboBox();
            this.lbSearchPermission = new System.Windows.Forms.Label();
            this.lbFilter = new System.Windows.Forms.Label();
            this.pnTime = new System.Windows.Forms.Panel();
            this.rdoCreated = new System.Windows.Forms.RadioButton();
            this.rdoUpdated = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUsers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnInfoUser.SuspendLayout();
            this.pnFilter.SuspendLayout();
            this.pnTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListUsers
            // 
            this.dgvListUsers.AllowUserToAddRows = false;
            this.dgvListUsers.AllowUserToResizeRows = false;
            this.dgvListUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListUsers.Location = new System.Drawing.Point(12, 329);
            this.dgvListUsers.MultiSelect = false;
            this.dgvListUsers.Name = "dgvListUsers";
            this.dgvListUsers.ReadOnly = true;
            this.dgvListUsers.RowHeadersVisible = false;
            this.dgvListUsers.RowHeadersWidth = 30;
            this.dgvListUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListUsers.Size = new System.Drawing.Size(1060, 270);
            this.dgvListUsers.TabIndex = 20;
            this.dgvListUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListUsers_CellClick);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(158)))));
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnInsert.Location = new System.Drawing.Point(13, 133);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(78, 28);
            this.btnInsert.TabIndex = 14;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(158)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnUpdate.Location = new System.Drawing.Point(108, 133);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(78, 28);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnSee_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(158)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnDelete.Location = new System.Drawing.Point(203, 133);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 28);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(158)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnSearch.Location = new System.Drawing.Point(12, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 28);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbID.Location = new System.Drawing.Point(7, 9);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(77, 13);
            this.lbID.TabIndex = 5;
            this.lbID.Text = "Mã nhân viên";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtID.Location = new System.Drawing.Point(11, 25);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(170, 22);
            this.txtID.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtName.Location = new System.Drawing.Point(12, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 22);
            this.txtName.TabIndex = 5;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbName.Location = new System.Drawing.Point(8, 55);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(79, 13);
            this.lbName.TabIndex = 7;
            this.lbName.Text = "Tên nhân viên";
            // 
            // txtAccount
            // 
            this.txtAccount.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtAccount.Location = new System.Drawing.Point(216, 24);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(170, 22);
            this.txtAccount.TabIndex = 1;
            // 
            // lbAccount
            // 
            this.lbAccount.AutoSize = true;
            this.lbAccount.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbAccount.Location = new System.Drawing.Point(213, 8);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(57, 13);
            this.lbAccount.TabIndex = 9;
            this.lbAccount.Text = "Tài khoản";
            // 
            // lbPermission
            // 
            this.lbPermission.AutoSize = true;
            this.lbPermission.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbPermission.Location = new System.Drawing.Point(820, 8);
            this.lbPermission.Name = "lbPermission";
            this.lbPermission.Size = new System.Drawing.Size(40, 13);
            this.lbPermission.TabIndex = 11;
            this.lbPermission.Text = "Quyền";
            // 
            // cmbPermission
            // 
            this.cmbPermission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPermission.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cmbPermission.FormattingEnabled = true;
            this.cmbPermission.Location = new System.Drawing.Point(824, 25);
            this.cmbPermission.Name = "cmbPermission";
            this.cmbPermission.Size = new System.Drawing.Size(221, 21);
            this.cmbPermission.TabIndex = 4;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Enabled = false;
            this.dtpDateFrom.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dtpDateFrom.Location = new System.Drawing.Point(42, 22);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(195, 22);
            this.dtpDateFrom.TabIndex = 12;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Enabled = false;
            this.dtpDateTo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dtpDateTo.Location = new System.Drawing.Point(259, 22);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(195, 22);
            this.dtpDateTo.TabIndex = 13;
            // 
            // lbDateFrom
            // 
            this.lbDateFrom.AutoSize = true;
            this.lbDateFrom.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbDateFrom.Location = new System.Drawing.Point(39, 6);
            this.lbDateFrom.Name = "lbDateFrom";
            this.lbDateFrom.Size = new System.Drawing.Size(48, 13);
            this.lbDateFrom.TabIndex = 15;
            this.lbDateFrom.Text = "Từ ngày";
            // 
            // lbDateTo
            // 
            this.lbDateTo.AutoSize = true;
            this.lbDateTo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbDateTo.Location = new System.Drawing.Point(256, 6);
            this.lbDateTo.Name = "lbDateTo";
            this.lbDateTo.Size = new System.Drawing.Size(56, 13);
            this.lbDateTo.TabIndex = 16;
            this.lbDateTo.Text = "Đến ngày";
            // 
            // cbTime
            // 
            this.cbTime.AutoSize = true;
            this.cbTime.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cbTime.Location = new System.Drawing.Point(566, 241);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(78, 17);
            this.cbTime.TabIndex = 19;
            this.cbTime.Text = "Thời gian:";
            this.cbTime.UseVisualStyleBackColor = true;
            this.cbTime.CheckStateChanged += new System.EventHandler(this.cbTime_CheckStateChanged);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(158)))));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnReset.Location = new System.Drawing.Point(300, 133);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(78, 28);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
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
            this.menuStrip1.TabIndex = 19;
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
            // pnInfoUser
            // 
            this.pnInfoUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnInfoUser.Controls.Add(this.rdoFemale);
            this.pnInfoUser.Controls.Add(this.rdoMale);
            this.pnInfoUser.Controls.Add(this.lbGender);
            this.pnInfoUser.Controls.Add(this.dtpDateOfBirth);
            this.pnInfoUser.Controls.Add(this.lbDateOfBirth);
            this.pnInfoUser.Controls.Add(this.txtSalary);
            this.pnInfoUser.Controls.Add(this.lbSalary);
            this.pnInfoUser.Controls.Add(this.txtPassword);
            this.pnInfoUser.Controls.Add(this.lbPassword);
            this.pnInfoUser.Controls.Add(this.txtPhoneNumber);
            this.pnInfoUser.Controls.Add(this.lbPhoneNumber);
            this.pnInfoUser.Controls.Add(this.txtEmail);
            this.pnInfoUser.Controls.Add(this.lbEmail);
            this.pnInfoUser.Controls.Add(this.txtAddress);
            this.pnInfoUser.Controls.Add(this.lbAddress);
            this.pnInfoUser.Controls.Add(this.btnInsert);
            this.pnInfoUser.Controls.Add(this.btnUpdate);
            this.pnInfoUser.Controls.Add(this.btnDelete);
            this.pnInfoUser.Controls.Add(this.btnReset);
            this.pnInfoUser.Controls.Add(this.txtAccount);
            this.pnInfoUser.Controls.Add(this.lbID);
            this.pnInfoUser.Controls.Add(this.txtID);
            this.pnInfoUser.Controls.Add(this.lbName);
            this.pnInfoUser.Controls.Add(this.cmbPermission);
            this.pnInfoUser.Controls.Add(this.txtName);
            this.pnInfoUser.Controls.Add(this.lbPermission);
            this.pnInfoUser.Controls.Add(this.lbAccount);
            this.pnInfoUser.Location = new System.Drawing.Point(12, 55);
            this.pnInfoUser.Name = "pnInfoUser";
            this.pnInfoUser.Size = new System.Drawing.Size(1060, 175);
            this.pnInfoUser.TabIndex = 20;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(121, 105);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(40, 17);
            this.rdoFemale.TabIndex = 31;
            this.rdoFemale.Text = "Nữ";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Checked = true;
            this.rdoMale.Location = new System.Drawing.Point(71, 105);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(48, 17);
            this.rdoMale.TabIndex = 27;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Nam";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbGender.Location = new System.Drawing.Point(10, 107);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(55, 13);
            this.lbGender.TabIndex = 30;
            this.lbGender.Text = "Giới tính:";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dtpDateOfBirth.Location = new System.Drawing.Point(825, 71);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(221, 22);
            this.dtpDateOfBirth.TabIndex = 9;
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoSize = true;
            this.lbDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbDateOfBirth.Location = new System.Drawing.Point(821, 55);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(58, 13);
            this.lbDateOfBirth.TabIndex = 29;
            this.lbDateOfBirth.Text = "Ngày sinh";
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtSalary.Location = new System.Drawing.Point(619, 24);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(170, 22);
            this.txtSalary.TabIndex = 3;
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbSalary.Location = new System.Drawing.Point(616, 8);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(40, 13);
            this.lbSalary.TabIndex = 27;
            this.lbSalary.Text = "Lương";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtPassword.Location = new System.Drawing.Point(216, 70);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(170, 22);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbPassword.Location = new System.Drawing.Point(213, 55);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(56, 13);
            this.lbPassword.TabIndex = 25;
            this.lbPassword.Text = "Mật khẩu";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtPhoneNumber.Location = new System.Drawing.Point(620, 70);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(170, 22);
            this.txtPhoneNumber.TabIndex = 8;
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbPhoneNumber.Location = new System.Drawing.Point(617, 55);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(76, 13);
            this.lbPhoneNumber.TabIndex = 23;
            this.lbPhoneNumber.Text = "Số điện thoại";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtEmail.Location = new System.Drawing.Point(419, 70);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(170, 22);
            this.txtEmail.TabIndex = 7;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbEmail.Location = new System.Drawing.Point(416, 55);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(34, 13);
            this.lbEmail.TabIndex = 21;
            this.lbEmail.Text = "Email";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtAddress.Location = new System.Drawing.Point(419, 24);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(170, 22);
            this.txtAddress.TabIndex = 2;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbAddress.Location = new System.Drawing.Point(416, 8);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(42, 13);
            this.lbAddress.TabIndex = 19;
            this.lbAddress.Text = "Địa chỉ";
            // 
            // lbInfoUser
            // 
            this.lbInfoUser.AutoSize = true;
            this.lbInfoUser.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbInfoUser.Location = new System.Drawing.Point(9, 39);
            this.lbInfoUser.Name = "lbInfoUser";
            this.lbInfoUser.Size = new System.Drawing.Size(112, 13);
            this.lbInfoUser.TabIndex = 21;
            this.lbInfoUser.Text = "Thông tin nhân viên";
            // 
            // pnFilter
            // 
            this.pnFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnFilter.Controls.Add(this.txtSearch);
            this.pnFilter.Controls.Add(this.cmbSearchPermission);
            this.pnFilter.Controls.Add(this.lbSearchPermission);
            this.pnFilter.Controls.Add(this.btnSearch);
            this.pnFilter.Location = new System.Drawing.Point(12, 258);
            this.pnFilter.Name = "pnFilter";
            this.pnFilter.Size = new System.Drawing.Size(537, 60);
            this.pnFilter.TabIndex = 22;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtSearch.Location = new System.Drawing.Point(108, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(195, 22);
            this.txtSearch.TabIndex = 10;
            // 
            // cmbSearchPermission
            // 
            this.cmbSearchPermission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchPermission.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cmbSearchPermission.FormattingEnabled = true;
            this.cmbSearchPermission.Location = new System.Drawing.Point(324, 22);
            this.cmbSearchPermission.Name = "cmbSearchPermission";
            this.cmbSearchPermission.Size = new System.Drawing.Size(195, 21);
            this.cmbSearchPermission.TabIndex = 11;
            // 
            // lbSearchPermission
            // 
            this.lbSearchPermission.AutoSize = true;
            this.lbSearchPermission.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbSearchPermission.Location = new System.Drawing.Point(321, 4);
            this.lbSearchPermission.Name = "lbSearchPermission";
            this.lbSearchPermission.Size = new System.Drawing.Size(40, 13);
            this.lbSearchPermission.TabIndex = 31;
            this.lbSearchPermission.Text = "Quyền";
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbFilter.Location = new System.Drawing.Point(9, 242);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(38, 13);
            this.lbFilter.TabIndex = 23;
            this.lbFilter.Text = "Bộ lọc";
            // 
            // pnTime
            // 
            this.pnTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTime.Controls.Add(this.dtpDateTo);
            this.pnTime.Controls.Add(this.lbDateFrom);
            this.pnTime.Controls.Add(this.lbDateTo);
            this.pnTime.Controls.Add(this.dtpDateFrom);
            this.pnTime.Location = new System.Drawing.Point(566, 258);
            this.pnTime.Name = "pnTime";
            this.pnTime.Size = new System.Drawing.Size(506, 60);
            this.pnTime.TabIndex = 24;
            // 
            // rdoCreated
            // 
            this.rdoCreated.AutoSize = true;
            this.rdoCreated.Checked = true;
            this.rdoCreated.Enabled = false;
            this.rdoCreated.Location = new System.Drawing.Point(650, 240);
            this.rdoCreated.Name = "rdoCreated";
            this.rdoCreated.Size = new System.Drawing.Size(44, 17);
            this.rdoCreated.TabIndex = 25;
            this.rdoCreated.TabStop = true;
            this.rdoCreated.Text = "Tạo";
            this.rdoCreated.UseVisualStyleBackColor = true;
            // 
            // rdoUpdated
            // 
            this.rdoUpdated.AutoSize = true;
            this.rdoUpdated.Enabled = false;
            this.rdoUpdated.Location = new System.Drawing.Point(700, 240);
            this.rdoUpdated.Name = "rdoUpdated";
            this.rdoUpdated.Size = new System.Drawing.Size(44, 17);
            this.rdoUpdated.TabIndex = 26;
            this.rdoUpdated.Text = "Sửa";
            this.rdoUpdated.UseVisualStyleBackColor = true;
            // 
            // UsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 612);
            this.Controls.Add(this.rdoUpdated);
            this.Controls.Add(this.rdoCreated);
            this.Controls.Add(this.pnTime);
            this.Controls.Add(this.lbFilter);
            this.Controls.Add(this.pnFilter);
            this.Controls.Add(this.lbInfoUser);
            this.Controls.Add(this.pnInfoUser);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvListUsers);
            this.Controls.Add(this.cbTime);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.MaximizeBox = false;
            this.Name = "UsersList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListUsers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnInfoUser.ResumeLayout(false);
            this.pnInfoUser.PerformLayout();
            this.pnFilter.ResumeLayout(false);
            this.pnFilter.PerformLayout();
            this.pnTime.ResumeLayout(false);
            this.pnTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListUsers;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label lbAccount;
        private System.Windows.Forms.Label lbPermission;
        private System.Windows.Forms.ComboBox cmbPermission;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label lbDateFrom;
        private System.Windows.Forms.Label lbDateTo;
        private System.Windows.Forms.CheckBox cbTime;
        private System.Windows.Forms.Button btnReset;
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
        private System.Windows.Forms.Panel pnInfoUser;
        private System.Windows.Forms.Label lbInfoUser;
        private System.Windows.Forms.Panel pnFilter;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lbDateOfBirth;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.ComboBox cmbSearchPermission;
        private System.Windows.Forms.Label lbSearchPermission;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnTime;
        private System.Windows.Forms.RadioButton rdoCreated;
        private System.Windows.Forms.RadioButton rdoUpdated;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label lbGender;
    }
}