using QuanLyMaverikStudio.DAO;
using QuanLyMaverikStudio.DTO;
using QuanLyMaverikStudio.GUI;
using QuanLyMaverikStudio.Helper;
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

namespace QuanLyMaverikStudio
{
    public partial class UsersList : Form
    {
        private DataTable user;

        public UsersList(DataTable user)
        {
            InitializeComponent();
            this.user = user;
            Load();
        }

        public void Load()
        {
            dtpDateFrom.Enabled = false;
            dtpDateTo.Enabled = false;
            cbTime.Checked = false;

            dgvListUsers.DataSource = UsersDAO.Instance.GetAllUsers();
            dgvListUsers.Columns["email"].Visible = false;
            dgvListUsers.Columns["phone_number"].Visible = false;
            dgvListUsers.Columns["date_of_birth"].Visible = false;
            dgvListUsers.Columns["group_id"].Visible = false;

            DataTable dataTable = GroupsDAO.Instance.GetAllGroups();

            DataTable dataTable2 = dataTable.Copy();

            // Tạo một dòng dữ liệu mới cho tùy chọn mặc định
            DataRow defaultRow = dataTable.NewRow();
            defaultRow["id"] = -1;  // Giá trị id của tùy chọn mặc định
            defaultRow["name"] = "Tất cả";  // Tên hiển thị của tùy chọn mặc định

            // Thêm dòng dữ liệu tùy chọn mặc định vào DataTable
            dataTable.Rows.InsertAt(defaultRow, 0);

            // Gán DataTable đã thêm vào ComboBox
            cmbSearchPermission.DataSource = dataTable;
            cmbSearchPermission.DisplayMember = "name";
            cmbSearchPermission.ValueMember = "id";

            DataRow defaultRow2 = dataTable2.NewRow();
            defaultRow2["id"] = -1;  // Giá trị id của tùy chọn mặc định
            defaultRow2["name"] = "";  // Tên hiển thị của tùy chọn mặc định

            // Thêm dòng dữ liệu tùy chọn mặc định vào DataTable
            dataTable2.Rows.InsertAt(defaultRow2, 0);

            cmbPermission.DataSource = dataTable2;
            cmbPermission.DisplayMember = "name";
            cmbPermission.ValueMember = "id";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtAccount.Text = "";
            txtPassword.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtSalary.Text = "";
            txtPhoneNumber.Text = "";
            cmbPermission.SelectedValue = -1;
            cmbSearchPermission.SelectedValue = -1;
            txtSearch.Text = "";
            dtpDateOfBirth.Value = DateTime.Now;
            dtpDateFrom.Value = DateTime.Now;
            dtpDateTo.Value = DateTime.Now;
            Load();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = $"%{txtSearch.Text}%";
            int groupID = -1;
            if (int.TryParse(cmbSearchPermission.SelectedValue.ToString(), out int result1))
            {
                groupID = result1;
            }
            if (cbTime.Checked == false)
            {
                dgvListUsers.DataSource = UsersDAO.Instance.Search(search, groupID, "", "", "", "");
            }
            else
            {
                if(rdoCreated.Checked == true)
                {
                    dgvListUsers.DataSource = UsersDAO.Instance.Search(search, groupID, dtpDateFrom.Value.ToString("yyyy/MM/dd"), dtpDateTo.Value.ToString("yyyy/MM/dd"), "", "");
                }
                else if(rdoUpdated.Checked == true)
                {
                    dgvListUsers.DataSource = UsersDAO.Instance.Search(search, groupID, "", "", dtpDateFrom.Value.ToString("yyyy/MM/dd"), dtpDateTo.Value.ToString("yyyy/MM/dd"));

                }
            }
        }

        private void dgvListUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                txtID.Text = dgvListUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dgvListUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAccount.Text = dgvListUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAddress.Text = dgvListUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtSalary.Text = dgvListUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (int.TryParse(dgvListUsers.Rows[e.RowIndex].Cells[11].Value.ToString(), out int result))
                {
                    cmbPermission.SelectedValue = result;
                }
                txtEmail.Text = dgvListUsers.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtPhoneNumber.Text = dgvListUsers.Rows[e.RowIndex].Cells[9].Value.ToString();
                if(DateTime.TryParse(dgvListUsers.Rows[e.RowIndex].Cells[10].Value.ToString(), out DateTime result1))
                {
                    dtpDateOfBirth.Value = result1;
                }
                if(dgvListUsers.Rows[e.RowIndex].Cells[0].Value.ToString().Equals("1"))
                {
                    cmbPermission.Enabled = false;
                }
                else
                {
                    cmbPermission.Enabled = true;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtID.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải chọn 1 nhân viên để xóa");
            }
            else if(txtID.Text.Equals("1"))
            {
                MessageBox.Show("Không thể xóa admin");
            }
            else if (int.TryParse(txtID.Text, out int result))
            {
                DialogResult resultConfirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên có mã là: {result} không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultConfirm == DialogResult.Yes)
                {
                    if (UsersDAO.Instance.Delete(result, DateTime.Now.ToString()))
                    {
                        MessageBox.Show("Xóa thành công");
                        btnReset.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra, không thể xóa");
            }
        }

        public Users HandleData(bool updateOrInsert = true)
        {
            if(updateOrInsert)
            {
                if (int.TryParse(txtID.Text, out int id))
                {
                    if (double.TryParse(txtSalary.Text, out double salary))
                    {
                        Users user = new Users(id, txtName.Text, txtAddress.Text, txtEmail.Text, txtPhoneNumber.Text, txtAccount.Text, txtPassword.Text.Equals("") ? "" : HelpSHA256.Instance.Hash(txtPassword.Text), salary, dtpDateOfBirth.Value.ToString(), (int)cmbPermission.SelectedValue, "", DateTime.Now.ToString(), "");
                        return user;
                    }
                    else
                    {
                        return null;
                    }
                }
                return null;
            }
            else
            {
                if (double.TryParse(txtSalary.Text, out double salary))
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
            else if (UsersDAO.Instance.CheckExistAccount(txtAccount.Text, id))
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
            else if (!double.TryParse(txtSalary.Text, out double result))
            {
                MessageBox.Show("Lương phải là số thực");
                return false;
            }
            return true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if ((int)cmbPermission.SelectedValue == 1)
            {
                MessageBox.Show("Admin chỉ có 1");
                return;
            }
            else if ((int)cmbPermission.SelectedValue == -1)
            {
                MessageBox.Show("Bạn chưa chọn quyền");
            }
            else
            {
                if (Validate())
                {
                    if (UsersDAO.Instance.InsertData(HandleData(false)))
                    {
                        MessageBox.Show("Thêm thành công");
                        btnReset.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải chọn 1 nhân viên để sửa");
            }
            else if (int.TryParse(txtID.Text, out int id))
            {
                if (id != 1 && (int)cmbPermission.SelectedValue == 1)
                {
                    MessageBox.Show("Admin chỉ có 1");
                    return;
                }
                else if((int)cmbPermission.SelectedValue == -1)
                {
                    MessageBox.Show("Bạn chưa chọn quyền");
                }
                else
                {
                    if (Validate(id, false))
                    {
                        if (UsersDAO.Instance.UpdateData(HandleData()))
                        {
                            MessageBox.Show("Cập nhật thành công");
                            btnReset.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại");
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra, không thể sửa");
            }
        }

        private void cbTime_CheckStateChanged(object sender, EventArgs e)
        {
            if(cbTime.Checked == false)
            {
                dtpDateFrom.Enabled = false;
                dtpDateTo.Enabled = false;
                rdoCreated.Enabled = false;
                rdoUpdated.Enabled = false;
            }
            else
            {
                dtpDateFrom.Enabled = true;
                dtpDateTo.Enabled = true;
                rdoCreated.Enabled = true;
                rdoUpdated.Enabled = true;
            }
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đó là trang hiện tại");
        }

        private void thùngRácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrashUsers trashUsers = new TrashUsers(this.user);
            this.Hide();
            trashUsers.ShowDialog();
            this.Close();
        }

        private void homePageMenuItem_Click(object sender, EventArgs e)
        {
            this.user = UsersDAO.Instance.GetUser((int)this.user.Rows[0]["Mã nhân viên"]);
            HomePage homePage = new HomePage(this.user);
            this.Hide();
            homePage.ShowDialog();
            this.Close();
        }

        private void changePasswordMenuItem_Click(object sender, EventArgs e)
        {
            this.user = UsersDAO.Instance.GetUser((int)this.user.Rows[0]["Mã nhân viên"]);
            ChangePassword changePassword = new ChangePassword(this.user);

            changePassword.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login flogin = new Login();
            this.Hide();
            flogin.ShowDialog();
            this.Close();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriesManager categoriesManager = new CategoriesManager(this.user);
            this.Hide();
            categoriesManager.ShowDialog();
            this.Close();
        }

        private void thùngRácToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
