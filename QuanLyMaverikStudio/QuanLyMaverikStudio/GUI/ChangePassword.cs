using QuanLyMaverikStudio.DAO;
using QuanLyMaverikStudio.DTO;
using QuanLyMaverikStudio.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyMaverikStudio
{
    public partial class ChangePassword : Form
    {
        private DataTable user;
        public ChangePassword(DataTable user)
        {
            InitializeComponent();
            this.user = user;

            Load();
        }

        public void Load()
        {
            lbID.Text = $"Mã: {this.user.Rows[0]["Mã nhân viên"].ToString()}";
            lbName.Text = $"Tên: {this.user.Rows[0]["Tên nhân viên"].ToString()}";
            lbAccount.Text = $"Tài khoản: {this.user.Rows[0]["Tài khoản"].ToString()}";
            lbPhonenumber.Text = $"Số điện thoại: {this.user.Rows[0]["phone_number"].ToString()}";
            lbAddress.Text = $"Địa chỉ: {this.user.Rows[0]["Địa chỉ"].ToString()}";
            lbPermission.Text = $"Quyền: {this.user.Rows[0]["Quyền"].ToString()}";
            lbEmail.Text = $"Email: {this.user.Rows[0]["email"].ToString()}";
            lbSalary.Text = $"Lương: {this.user.Rows[0]["Lương"].ToString()}";
            DateTime dateTime = (DateTime)this.user.Rows[0]["date_of_birth"];
            lbDateOfBirth.Text = $"Ngày sinh: {dateTime.ToString("dd/MM/yyyy")}";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(Validate())
            {
                bool checkChangPassword = UsersDAO.Instance.changePassword((int)this.user.Rows[0]["Mã nhân viên"], HelpSHA256.Instance.Hash(txtPassword.Text), HelpSHA256.Instance.Hash(txtNewPassword.Text));
                if (checkChangPassword)
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                    txtPassword.Text = "";
                    txtNewPassword.Text = "";
                    txtComfirmPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Mật khẩu không chính xác");
                }
            }
        }

        public bool Validate()
        {
            if(txtNewPassword.Text == "" || txtComfirmPassword.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin");
                return false;
            }
            else if(txtNewPassword.Text.Length < 5)
            {
                MessageBox.Show("Mật khẩu mới phải lớn hơn 4 ký tự");
                return false;
            }
            else if(txtComfirmPassword.Text != txtNewPassword.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}