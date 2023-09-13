using QuanLyMaverikStudio.DAO;
using QuanLyMaverikStudio.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using QuanLyMaverikStudio.Helper;

namespace QuanLyMaverikStudio.GUI
{
    public partial class InsertUsers : Form
    {
        public InsertUsers()
        {
            InitializeComponent();
            Load();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UsersList fUsersList = new UsersList();
            this.Hide();
            fUsersList.ShowDialog();
            this.Close();
        }

        public void Load()
        {
            DataTable dataTable = GroupsDAO.Instance.GetAllGroups();

            if(dataTable.Rows.Count > 0)
            {
                dataTable.Rows.RemoveAt(0);
            }

            cmbPermission.DataSource = dataTable;
            cmbPermission.DisplayMember = "name";
            cmbPermission.ValueMember = "id";
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(Validate())
            {
                if(UsersDAO.Instance.InsertData(HandleData()))
                {
                    DialogResult result = MessageBox.Show("Thêm thành công. Bạn có muốn tiếp tục thêm?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        return;
                    }
                    else
                    {
                        UsersList fUsersList = new UsersList();
                        this.Hide();
                        fUsersList.ShowDialog();
                        this.Close();
                    }
                }
            }
            else
            {
                return;
            } 
        }

        public bool Validate()
        {
            if(txtName.Text.Length > 50 || txtName.Text == "")
            {
                MessageBox.Show("Tên nhân viên phải nhỏ hơn 50 ký tự và không được để trống");
                return false;
            }
            else if(txtAddress.Text.Length > 250 || txtAddress.Text == "")
            {
                MessageBox.Show("Địa chỉ phải nhỏ hơn 250 ký tự và không được để trống");
                return false;
            }
            else if(txtEmail.Text.Length > 250 || !Regex.IsMatch(txtEmail.Text, @"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$"))
            {
                MessageBox.Show("Email không được để trống và phải nhập đúng định dạng email");
                return false;
            }
            else if(txtPhoneNumber.Text == "" || !Regex.IsMatch(txtPhoneNumber.Text, @"^0[0-9]{9,10}$"))
            {
                MessageBox.Show("Số điện thoại không được để trống và phải đúng định dạng");
                return false;
            }
            else if (UsersDAO.Instance.CheckExistAccount(txtAccount.Text))
            {
                MessageBox.Show("Tài khoản đã tồn tại");
                return false;
            }
            else if(txtAccount.Text == "" || txtAccount.Text.Length > 50)
            {
                MessageBox.Show("Tài khoản không được để trống và phải nhỏ hơn 50 ký tự");
                return false;
            }
            else if (txtPassword.Text == "" || txtPassword.Text.Length > 300 || txtPassword.Text.Length < 5)
            {
                MessageBox.Show("Mật khẩu không được để trống và phải nhỏ hơn 300 ký tự và phải lớn hơn 4 ký tự");
                return false;
            }
            else if (!double.TryParse(txtSalary.Text, out double result))
            {
                MessageBox.Show("Lương phải là số thực");
                return false;
            }
            return true;
        }

        public Users HandleData()
        {
            if(double.TryParse(txtSalary.Text, out double salary))
            {
                Users user = new Users(txtName.Text, txtAddress.Text, txtEmail.Text, txtPhoneNumber.Text, txtAccount.Text, HelpSHA256.Instance.Hash(txtPassword.Text), salary, dtpDateOfBirth.Value.ToString(), (int)cmbPermission.SelectedValue, DateTime.Now.ToString());
                return user;
            }
            else
            {
                return null;
            }
        }
    }
}
