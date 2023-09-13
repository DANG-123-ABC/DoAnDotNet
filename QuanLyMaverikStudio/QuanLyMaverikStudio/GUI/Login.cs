using QuanLyMaverikStudio.DAO;
using QuanLyMaverikStudio.DTO;
using QuanLyMaverikStudio.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMaverikStudio
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable user = UsersDAO.Instance.Login(txtUserName.Text, HelpSHA256.Instance.Hash(txtPassword.Text) );

            if(user == null)
            {
                MessageBox.Show("tài khoản mật khẩu không chính xác");
            } 
            else
            {
                HomePage homePage = new HomePage(user);
                this.Hide();
                homePage.ShowDialog();
                this.Close();
            }
        }
    }
}
