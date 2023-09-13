using QuanLyMaverikStudio.DAO;
using QuanLyMaverikStudio.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMaverikStudio
{
    public partial class UsersList : Form
    {
        private int idStaff = -1;
        public UsersList()
        {
            InitializeComponent();

            Load();
        }

        public void Load()
        {
            dgvListUsers.DataSource = UsersDAO.Instance.GetAllUsers();

            DataTable dataTable = GroupsDAO.Instance.GetAllGroups();

            // Tạo một dòng dữ liệu mới cho tùy chọn mặc định
            DataRow defaultRow = dataTable.NewRow();
            defaultRow["id"] = -1;  // Giá trị id của tùy chọn mặc định
            defaultRow["name"] = "Tất cả";  // Tên hiển thị của tùy chọn mặc định

            // Thêm dòng dữ liệu tùy chọn mặc định vào DataTable
            dataTable.Rows.InsertAt(defaultRow, 0);

            // Gán DataTable đã thêm vào ComboBox
            cmbPermission.DataSource = dataTable;
            cmbPermission.DisplayMember = "name";
            cmbPermission.ValueMember = "id";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtAccount.Text = "";
            cmbPermission.SelectedValue = -1;
            this.idStaff = -1;
            Load();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id;
            if (txtID.Text == "")
            {
                id = -1;
            }
            else if (int.TryParse(txtID.Text, out int result))
            {
                id = result;
            }
            else
            {
                MessageBox.Show("Mã nhân viên phải là số nguyên");
                return;
            }
            string name = $"%{txtName.Text}%";
            string account = $"%{txtAccount.Text}%";
            int groupID;
            if (int.TryParse(cmbPermission.SelectedValue.ToString(), out int result1))
            {
                groupID = result1;
            }
            else
            {
                MessageBox.Show("Quyền không hợp lệ");
                return;
            }
            if (cbTime.Checked == false)
            {
                dgvListUsers.DataSource = UsersDAO.Instance.Search(id, name, account, groupID, "", "");
            }
            else
            {
                dgvListUsers.DataSource = UsersDAO.Instance.Search(id, name, account, groupID, dtpDateFrom.Value.ToString("yyyy/MM/dd"), dtpDateTo.Value.ToString("yyyy/MM/dd"));
            }
        }

        private void dgvListUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.idStaff = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(this.idStaff == -1)
            {
                MessageBox.Show("Bạn phải chọn 1 nhân viên để xóa");
            }
            else if(this.idStaff == 1)
            {
                MessageBox.Show("Không thể xóa admin");
            }
            else
            {
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên có mã là: {this.idStaff} không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string timeNow = DateTime.Now.ToString();
                    if (UsersDAO.Instance.Delete(this.idStaff, timeNow))
                    {
                        MessageBox.Show("Xóa thành công");
                        this.idStaff = -1;
                        btnReset.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertUsers fInsertUsers = new InsertUsers();
            this.Hide();
            fInsertUsers.ShowDialog();
            this.Close();
        }

        private void dgvListUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int r = e.RowIndex;
                if (int.TryParse(dgvListUsers.Rows[r].Cells[0].Value.ToString(), out int result))
                {
                    this.idStaff = result;
                }
                else
                {
                    this.idStaff = -1;
                }
            }
        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            if(this.idStaff != -1)
            {
                UpdateUsers fUpdateUsers = new UpdateUsers(this.idStaff);
                fUpdateUsers.ShowDialog();
                btnReset.PerformClick();
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 nhân viên để xem");
            }
        }
    }
}
