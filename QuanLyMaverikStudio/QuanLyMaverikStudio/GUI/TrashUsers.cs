using QuanLyMaverikStudio.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace QuanLyMaverikStudio.GUI
{
    public partial class TrashUsers : Form
    {
        private DataTable user;
        private int idStaff = -1;
        public TrashUsers(DataTable user)
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

            dgvListUsers.DataSource = UsersDAO.Instance.GetAllUsersDeleted();
            if(dgvListUsers.DataSource != null)
            {
                dgvListUsers.Columns["group_id"].Visible = false;
            }

            DataTable dataTable = GroupsDAO.Instance.GetAllGroups();

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
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            cmbSearchPermission.SelectedValue = -1;
            dtpDateFrom.Value = dtpDateTo.Value = DateTime.Now;
            this.idStaff = -1;
            Load();
        }

        private void dgvListUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.idStaff = -1;
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

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if(this.idStaff == -1)
            {
                MessageBox.Show("Bạn phải chọn 1 nhân viên để khôi phục");
            }
            else
            {
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn khôi phục nhân viên có mã là: {this.idStaff} không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (UsersDAO.Instance.Restore(this.idStaff))
                    {
                        MessageBox.Show("Khôi phục thành công");
                        this.idStaff = -1;
                        btnReset.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Khôi phục thất bại");
                    }
                }
            }
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersList usersList = new UsersList(this.user);
            this.Hide();
            usersList.ShowDialog();
            this.Close();
        }

        private void thùngRácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đó là trang hiện tại");
        }

        private void homePageMenuItem_Click(object sender, EventArgs e)
        {
            this.user = UsersDAO.Instance.GetUser((int)this.user.Rows[0]["Mã nhân viên"]);
            HomePage homePage = new HomePage(this.user);
            this.Hide();
            homePage.ShowDialog();
            this.Close();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string search = $"%{txtSearch.Text}%";
            int groupID = -1;
            if (int.TryParse(cmbSearchPermission.SelectedValue.ToString(), out int result1))
            {
                groupID = result1;
            }
            if (cbTime.Checked == false)
            {
                dgvListUsers.DataSource = UsersDAO.Instance.SearchDeleted(search, groupID, "", "");
            }
            else
            {
                dgvListUsers.DataSource = UsersDAO.Instance.SearchDeleted(search, groupID, dtpDateFrom.Value.ToString("yyyy/MM/dd"), dtpDateTo.Value.ToString("yyyy/MM/dd"));
            }
        }

        private void cbTime_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTime.Checked == false)
            {
                dtpDateFrom.Enabled = false;
                dtpDateTo.Enabled = false;
            }
            else
            {
                dtpDateFrom.Enabled = true;
                dtpDateTo.Enabled = true;
            }
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
            TrashCategories trashCategories = new TrashCategories(this.user);
            this.Hide();
            trashCategories.ShowDialog();
            this.Close();
        }
    }
}
