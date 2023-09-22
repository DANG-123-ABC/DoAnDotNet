namespace QuanLyMaverikStudio.GUI
{
    partial class ChooseClientWhenSell
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
            this.tabChooseClient = new System.Windows.Forms.TabControl();
            this.tabPageListClient = new System.Windows.Forms.TabPage();
            this.btnChoose = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.dgvListClient = new System.Windows.Forms.DataGridView();
            this.tabPageCreateClient = new System.Windows.Forms.TabPage();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.lbGender = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.lbAccount = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tabChooseClient.SuspendLayout();
            this.tabPageListClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListClient)).BeginInit();
            this.tabPageCreateClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabChooseClient
            // 
            this.tabChooseClient.Controls.Add(this.tabPageListClient);
            this.tabChooseClient.Controls.Add(this.tabPageCreateClient);
            this.tabChooseClient.Location = new System.Drawing.Point(13, 13);
            this.tabChooseClient.Name = "tabChooseClient";
            this.tabChooseClient.SelectedIndex = 0;
            this.tabChooseClient.Size = new System.Drawing.Size(659, 401);
            this.tabChooseClient.TabIndex = 0;
            // 
            // tabPageListClient
            // 
            this.tabPageListClient.Controls.Add(this.btnChoose);
            this.tabPageListClient.Controls.Add(this.txtSearch);
            this.tabPageListClient.Controls.Add(this.lbSearch);
            this.tabPageListClient.Controls.Add(this.dgvListClient);
            this.tabPageListClient.Location = new System.Drawing.Point(4, 26);
            this.tabPageListClient.Name = "tabPageListClient";
            this.tabPageListClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListClient.Size = new System.Drawing.Size(651, 371);
            this.tabPageListClient.TabIndex = 0;
            this.tabPageListClient.Text = "Danh sách";
            this.tabPageListClient.UseVisualStyleBackColor = true;
            // 
            // btnChoose
            // 
            this.btnChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(158)))));
            this.btnChoose.Location = new System.Drawing.Point(570, 22);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 27);
            this.btnChoose.TabIndex = 3;
            this.btnChoose.Text = "Chọn";
            this.btnChoose.UseVisualStyleBackColor = false;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(10, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(303, 25);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(6, 3);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(64, 19);
            this.lbSearch.TabIndex = 1;
            this.lbSearch.Text = "Tìm kiếm";
            // 
            // dgvListClient
            // 
            this.dgvListClient.AllowUserToAddRows = false;
            this.dgvListClient.AllowUserToResizeRows = false;
            this.dgvListClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListClient.Location = new System.Drawing.Point(7, 54);
            this.dgvListClient.Name = "dgvListClient";
            this.dgvListClient.ReadOnly = true;
            this.dgvListClient.RowHeadersVisible = false;
            this.dgvListClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListClient.Size = new System.Drawing.Size(638, 311);
            this.dgvListClient.TabIndex = 0;
            this.dgvListClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListClient_CellClick);
            // 
            // tabPageCreateClient
            // 
            this.tabPageCreateClient.BackColor = System.Drawing.Color.White;
            this.tabPageCreateClient.Controls.Add(this.btnInsert);
            this.tabPageCreateClient.Controls.Add(this.btnReset);
            this.tabPageCreateClient.Controls.Add(this.rdoFemale);
            this.tabPageCreateClient.Controls.Add(this.rdoMale);
            this.tabPageCreateClient.Controls.Add(this.lbGender);
            this.tabPageCreateClient.Controls.Add(this.dtpDateOfBirth);
            this.tabPageCreateClient.Controls.Add(this.lbDateOfBirth);
            this.tabPageCreateClient.Controls.Add(this.txtPhoneNumber);
            this.tabPageCreateClient.Controls.Add(this.lbPhoneNumber);
            this.tabPageCreateClient.Controls.Add(this.txtPassword);
            this.tabPageCreateClient.Controls.Add(this.lbPassword);
            this.tabPageCreateClient.Controls.Add(this.txtEmail);
            this.tabPageCreateClient.Controls.Add(this.lbEmail);
            this.tabPageCreateClient.Controls.Add(this.txtAddress);
            this.tabPageCreateClient.Controls.Add(this.lbAddress);
            this.tabPageCreateClient.Controls.Add(this.txtAccount);
            this.tabPageCreateClient.Controls.Add(this.lbAccount);
            this.tabPageCreateClient.Controls.Add(this.lbName);
            this.tabPageCreateClient.Controls.Add(this.txtName);
            this.tabPageCreateClient.Location = new System.Drawing.Point(4, 26);
            this.tabPageCreateClient.Name = "tabPageCreateClient";
            this.tabPageCreateClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCreateClient.Size = new System.Drawing.Size(651, 371);
            this.tabPageCreateClient.TabIndex = 1;
            this.tabPageCreateClient.Text = "Thêm khách hàng";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(158)))));
            this.btnInsert.Location = new System.Drawing.Point(538, 327);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(96, 33);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "Đồng ý";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(158)))));
            this.btnReset.Location = new System.Drawing.Point(17, 327);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 33);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFemale.Location = new System.Drawing.Point(483, 271);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(44, 21);
            this.rdoFemale.TabIndex = 8;
            this.rdoFemale.Text = "Nữ";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Checked = true;
            this.rdoMale.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMale.Location = new System.Drawing.Point(423, 271);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(54, 21);
            this.rdoMale.TabIndex = 7;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Nam";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(358, 273);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(59, 17);
            this.lbGender.TabIndex = 39;
            this.lbGender.Text = "Giới tính:";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfBirth.Location = new System.Drawing.Point(361, 195);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(273, 25);
            this.dtpDateOfBirth.TabIndex = 6;
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoSize = true;
            this.lbDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateOfBirth.Location = new System.Drawing.Point(358, 175);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(66, 17);
            this.lbDateOfBirth.TabIndex = 37;
            this.lbDateOfBirth.Text = "Ngày sinh";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(17, 116);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(273, 25);
            this.txtPhoneNumber.TabIndex = 2;
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneNumber.Location = new System.Drawing.Point(14, 96);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(85, 17);
            this.lbPhoneNumber.TabIndex = 36;
            this.lbPhoneNumber.Text = "Số điện thoại";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(17, 273);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(273, 25);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.Location = new System.Drawing.Point(14, 253);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(62, 17);
            this.lbPassword.TabIndex = 33;
            this.lbPassword.Text = "Mật khẩu";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(361, 116);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(273, 25);
            this.txtEmail.TabIndex = 3;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(358, 96);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(39, 17);
            this.lbEmail.TabIndex = 32;
            this.lbEmail.Text = "Email";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(361, 34);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(273, 25);
            this.txtAddress.TabIndex = 1;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(358, 14);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(47, 17);
            this.lbAddress.TabIndex = 31;
            this.lbAddress.Text = "Địa chỉ";
            // 
            // txtAccount
            // 
            this.txtAccount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccount.Location = new System.Drawing.Point(17, 195);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(273, 25);
            this.txtAccount.TabIndex = 4;
            // 
            // lbAccount
            // 
            this.lbAccount.AutoSize = true;
            this.lbAccount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccount.Location = new System.Drawing.Point(14, 175);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(63, 17);
            this.lbAccount.TabIndex = 30;
            this.lbAccount.Text = "Tài khoản";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(14, 14);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(98, 17);
            this.lbName.TabIndex = 9;
            this.lbName.Text = "Tên khách hàng";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(17, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(273, 25);
            this.txtName.TabIndex = 0;
            // 
            // ChooseClientWhenSell
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(684, 426);
            this.Controls.Add(this.tabChooseClient);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MaximizeBox = false;
            this.Name = "ChooseClientWhenSell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn khách hàng";
            this.tabChooseClient.ResumeLayout(false);
            this.tabPageListClient.ResumeLayout(false);
            this.tabPageListClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListClient)).EndInit();
            this.tabPageCreateClient.ResumeLayout(false);
            this.tabPageCreateClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabChooseClient;
        private System.Windows.Forms.TabPage tabPageListClient;
        private System.Windows.Forms.TabPage tabPageCreateClient;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.DataGridView dgvListClient;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label lbAccount;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label lbDateOfBirth;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnReset;
    }
}