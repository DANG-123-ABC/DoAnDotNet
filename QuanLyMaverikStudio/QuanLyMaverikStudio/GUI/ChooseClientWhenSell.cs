using QuanLyMaverikStudio.DAO;
using QuanLyMaverikStudio.DTO;
using QuanLyMaverikStudio.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMaverikStudio.GUI
{
    public partial class ChooseClientWhenSell : Form
    {
        private int id = -1;
        private string name = "";
        private string phoneNumber = "";
        public ChooseClientWhenSell()
        {
            InitializeComponent();

            Load();
        }

        public void Load()
        {
            dgvListClient.DataSource =  ClientsDAO.Instance.GetAllClientForSell();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if(this.id == -1)
            {
                MessageBox.Show("Bạn phải chọn 1 khách hàng");
            }
            else
            {
                Storage.IdClient = id;
                Storage.NameClient = name;
                Storage.PhoneNumberClient = phoneNumber;
                this.Close();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(txtSearch.Text, out int id) && !Regex.IsMatch(txtSearch.Text, @"^0\d+"))
            {
                dgvListClient.DataSource = ClientsDAO.Instance.SearchAllClientForSell(txtSearch.Text, id);
            }
            else
            {
                string search = $"%{txtSearch.Text}%";
                dgvListClient.DataSource = ClientsDAO.Instance.SearchAllClientForSell(search);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPhoneNumber.Text = "";
            txtAccount.Text = "";
            txtPassword.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            dtpDateOfBirth.Value = DateTime.Now;
            this.id = -1;
            this.name = "";
            this.phoneNumber = "";
        }

        public bool Validate(int id = -1, bool noNullPass = true)
        {
            if (txtName.Text.Length > 50 || txtName.Text == "")
            {
                MessageBox.Show("Tên nhân viên phải nhỏ hơn 50 ký tự và không được để trống");
                return false;
            }
            else if (txtAddress.Text.Length > 250 || txtAddress.Text == "")
            {
                MessageBox.Show("Địa chỉ phải nhỏ hơn 250 ký tự và không được để trống");
                return false;
            }
            else if (txtEmail.Text.Length > 250 || !Regex.IsMatch(txtEmail.Text, @"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$"))
            {
                MessageBox.Show("Email không được để trống và phải nhập đúng định dạng email");
                return false;
            }
            else if (txtPhoneNumber.Text == "" || !Regex.IsMatch(txtPhoneNumber.Text, @"^0[0-9]{9,10}$"))
            {
                MessageBox.Show("Số điện thoại không được để trống và phải đúng định dạng");
                return false;
            }
            else if (ClientsDAO.Instance.CheckExistAccount(txtAccount.Text, id))
            {
                MessageBox.Show("Tài khoản đã tồn tại");
                return false;
            }
            else if (txtAccount.Text == "" || txtAccount.Text.Length > 50)
            {
                MessageBox.Show("Tài khoản không được để trống và phải nhỏ hơn 50 ký tự");
                return false;
            }
            else if (noNullPass && (txtPassword.Text == "" || txtPassword.Text.Length > 300 || txtPassword.Text.Length < 5))
            {
                MessageBox.Show("Mật khẩu không được để trống và phải nhỏ hơn 300 ký tự và phải lớn hơn 4 ký tự");
                return false;
            }
            return true;
        }

        public Clients HandleData()
        {
            string gender;
            if (rdoMale.Checked == true)
            {
                gender = "Nam";
            }
            else
            {
                gender = "Nữ";
            }
            Clients client = new Clients(txtName.Text, txtAddress.Text, gender, txtEmail.Text, txtPhoneNumber.Text, txtAccount.Text, HelpSHA256.Instance.Hash(txtPassword.Text), dtpDateOfBirth.Value.ToString(), DateTime.Now.ToString());
            return client;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(Validate())
            {
                DataTable data = ClientsDAO.Instance.InsertData(HandleData());

                if(data != null && data.Rows.Count > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    Storage.IdClient = (int)data.Rows[0]["id"];
                    Storage.NameClient = data.Rows[0]["name"].ToString();
                    Storage.PhoneNumberClient = data.Rows[0]["phone_number"].ToString();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }

        private void dgvListClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if (int.TryParse(dgvListClient.Rows[e.RowIndex].Cells["Mã khách hàng"].Value.ToString(), out int id))
                {
                    this.id = id;
                }
                this.name = dgvListClient.Rows[e.RowIndex].Cells["Tên khách hàng"].Value.ToString();
                this.phoneNumber = dgvListClient.Rows[e.RowIndex].Cells["Số điện thoại"].Value.ToString();
            }
        }
    }
}
