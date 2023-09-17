namespace QuanLyMaverikStudio
{
    partial class ChangePassword
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lbNewPassword = new System.Windows.Forms.Label();
            this.txtComfirmPassword = new System.Windows.Forms.TextBox();
            this.lbComfirmPassword = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tabChangePassword = new System.Windows.Forms.TabControl();
            this.tabPageChangePassword = new System.Windows.Forms.TabPage();
            this.tabPageInfoUser = new System.Windows.Forms.TabPage();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.lbPhonenumber = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbSalary = new System.Windows.Forms.Label();
            this.lbPermission = new System.Windows.Forms.Label();
            this.lbAccount = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.tabChangePassword.SuspendLayout();
            this.tabPageChangePassword.SuspendLayout();
            this.tabPageInfoUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location = new System.Drawing.Point(19, 42);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(350, 25);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbPassword.Location = new System.Drawing.Point(15, 18);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(68, 19);
            this.lbPassword.TabIndex = 15;
            this.lbPassword.Text = "Mật khẩu";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNewPassword.Location = new System.Drawing.Point(19, 101);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(350, 25);
            this.txtNewPassword.TabIndex = 8;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.AutoSize = true;
            this.lbNewPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbNewPassword.Location = new System.Drawing.Point(15, 77);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(95, 19);
            this.lbNewPassword.TabIndex = 17;
            this.lbNewPassword.Text = "Mật khẩu mới";
            // 
            // txtComfirmPassword
            // 
            this.txtComfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtComfirmPassword.Location = new System.Drawing.Point(19, 163);
            this.txtComfirmPassword.Name = "txtComfirmPassword";
            this.txtComfirmPassword.Size = new System.Drawing.Size(350, 25);
            this.txtComfirmPassword.TabIndex = 9;
            this.txtComfirmPassword.UseSystemPasswordChar = true;
            // 
            // lbComfirmPassword
            // 
            this.lbComfirmPassword.AutoSize = true;
            this.lbComfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbComfirmPassword.Location = new System.Drawing.Point(15, 139);
            this.lbComfirmPassword.Name = "lbComfirmPassword";
            this.lbComfirmPassword.Size = new System.Drawing.Size(121, 19);
            this.lbComfirmPassword.TabIndex = 19;
            this.lbComfirmPassword.Text = "Nhập lại mật khẩu";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(237)))), ((int)(((byte)(158)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUpdate.Location = new System.Drawing.Point(150, 226);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 33);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tabChangePassword
            // 
            this.tabChangePassword.Controls.Add(this.tabPageChangePassword);
            this.tabChangePassword.Controls.Add(this.tabPageInfoUser);
            this.tabChangePassword.Location = new System.Drawing.Point(12, 12);
            this.tabChangePassword.Name = "tabChangePassword";
            this.tabChangePassword.SelectedIndex = 0;
            this.tabChangePassword.Size = new System.Drawing.Size(397, 320);
            this.tabChangePassword.TabIndex = 20;
            // 
            // tabPageChangePassword
            // 
            this.tabPageChangePassword.Controls.Add(this.txtNewPassword);
            this.tabPageChangePassword.Controls.Add(this.btnUpdate);
            this.tabPageChangePassword.Controls.Add(this.lbPassword);
            this.tabPageChangePassword.Controls.Add(this.txtPassword);
            this.tabPageChangePassword.Controls.Add(this.txtComfirmPassword);
            this.tabPageChangePassword.Controls.Add(this.lbNewPassword);
            this.tabPageChangePassword.Controls.Add(this.lbComfirmPassword);
            this.tabPageChangePassword.Location = new System.Drawing.Point(4, 22);
            this.tabPageChangePassword.Name = "tabPageChangePassword";
            this.tabPageChangePassword.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChangePassword.Size = new System.Drawing.Size(389, 277);
            this.tabPageChangePassword.TabIndex = 0;
            this.tabPageChangePassword.Text = "Đổi mật khẩu";
            this.tabPageChangePassword.UseVisualStyleBackColor = true;
            // 
            // tabPageInfoUser
            // 
            this.tabPageInfoUser.AutoScroll = true;
            this.tabPageInfoUser.Controls.Add(this.lbDateOfBirth);
            this.tabPageInfoUser.Controls.Add(this.lbPhonenumber);
            this.tabPageInfoUser.Controls.Add(this.lbEmail);
            this.tabPageInfoUser.Controls.Add(this.lbAddress);
            this.tabPageInfoUser.Controls.Add(this.lbSalary);
            this.tabPageInfoUser.Controls.Add(this.lbPermission);
            this.tabPageInfoUser.Controls.Add(this.lbAccount);
            this.tabPageInfoUser.Controls.Add(this.lbName);
            this.tabPageInfoUser.Controls.Add(this.lbID);
            this.tabPageInfoUser.Location = new System.Drawing.Point(4, 22);
            this.tabPageInfoUser.Name = "tabPageInfoUser";
            this.tabPageInfoUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInfoUser.Size = new System.Drawing.Size(389, 294);
            this.tabPageInfoUser.TabIndex = 1;
            this.tabPageInfoUser.Text = "Thông tin";
            this.tabPageInfoUser.UseVisualStyleBackColor = true;
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoSize = true;
            this.lbDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbDateOfBirth.Location = new System.Drawing.Point(195, 185);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(73, 19);
            this.lbDateOfBirth.TabIndex = 8;
            this.lbDateOfBirth.Text = "Ngày sinh:";
            // 
            // lbPhonenumber
            // 
            this.lbPhonenumber.AutoSize = true;
            this.lbPhonenumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbPhonenumber.Location = new System.Drawing.Point(6, 185);
            this.lbPhonenumber.Name = "lbPhonenumber";
            this.lbPhonenumber.Size = new System.Drawing.Size(92, 19);
            this.lbPhonenumber.TabIndex = 7;
            this.lbPhonenumber.Text = "Số điện thoại:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbEmail.Location = new System.Drawing.Point(195, 125);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(44, 19);
            this.lbEmail.TabIndex = 6;
            this.lbEmail.Text = "Email:";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbAddress.Location = new System.Drawing.Point(6, 245);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(53, 19);
            this.lbAddress.TabIndex = 5;
            this.lbAddress.Text = "Địa chỉ:";
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbSalary.Location = new System.Drawing.Point(197, 64);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(51, 19);
            this.lbSalary.TabIndex = 4;
            this.lbSalary.Text = "Lương:";
            // 
            // lbPermission
            // 
            this.lbPermission.AutoSize = true;
            this.lbPermission.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbPermission.Location = new System.Drawing.Point(6, 64);
            this.lbPermission.Name = "lbPermission";
            this.lbPermission.Size = new System.Drawing.Size(53, 19);
            this.lbPermission.TabIndex = 3;
            this.lbPermission.Text = "Quyền:";
            // 
            // lbAccount
            // 
            this.lbAccount.AutoSize = true;
            this.lbAccount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbAccount.Location = new System.Drawing.Point(6, 125);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(69, 19);
            this.lbAccount.TabIndex = 2;
            this.lbAccount.Text = "Tài khoản:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbName.Location = new System.Drawing.Point(197, 13);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(33, 19);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Tên:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbID.Location = new System.Drawing.Point(6, 13);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(32, 19);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Mã:";
            // 
            // ChangePassword
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(423, 344);
            this.Controls.Add(this.tabChangePassword);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.tabChangePassword.ResumeLayout(false);
            this.tabPageChangePassword.ResumeLayout(false);
            this.tabPageChangePassword.PerformLayout();
            this.tabPageInfoUser.ResumeLayout(false);
            this.tabPageInfoUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lbNewPassword;
        private System.Windows.Forms.TextBox txtComfirmPassword;
        private System.Windows.Forms.Label lbComfirmPassword;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TabControl tabChangePassword;
        private System.Windows.Forms.TabPage tabPageChangePassword;
        private System.Windows.Forms.TabPage tabPageInfoUser;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.Label lbPermission;
        private System.Windows.Forms.Label lbAccount;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbDateOfBirth;
        private System.Windows.Forms.Label lbPhonenumber;
        private System.Windows.Forms.Label lbEmail;
    }
}