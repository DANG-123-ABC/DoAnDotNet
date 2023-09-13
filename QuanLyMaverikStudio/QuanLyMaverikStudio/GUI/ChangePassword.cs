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
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(Validate())
            {
                bool checkChangPassword = UsersDAO.Instance.changePassword((int)this.user.Rows[0]["id"], HelpSHA256.Instance.Hash(txtPassword.Text), HelpSHA256.Instance.Hash(txtNewPassword.Text));
                if (checkChangPassword)
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                    txtPassword.Text = "";
                    txtNewPassword.Text = "";
                    txtComfirmPassword.Text = "";
                    btnBack.PerformClick();
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