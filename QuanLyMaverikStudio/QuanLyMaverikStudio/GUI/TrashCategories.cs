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

namespace QuanLyMaverikStudio.GUI
{
    public partial class TrashCategories : Form
    {
        private DataTable user;
        public TrashCategories(DataTable user)
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

            DataTable data = CategoriesDAO.Instance.getAllCategories();
            if (data != null)
            {
                DataTable dataHandle = data.Clone();
                LoadCmbParent(dataHandle, data, -1, "");

                DataRow defaultRow = dataHandle.NewRow();
                defaultRow["Mã chuyên mục"] = -1;  // Giá trị id của tùy chọn mặc định
                defaultRow["Tên chuyên mục"] = "Không";  // Tên hiển thị của tùy chọn mặc định
                dataHandle.Rows.InsertAt(defaultRow, 0);

                cmbParentInfo.DataSource = dataHandle;
                cmbParentInfo.DisplayMember = "Tên chuyên mục";
                cmbParentInfo.ValueMember = "Mã chuyên mục";
            }
            else
            {
                List<object> list2 = new List<object>
                {
                    new { Name = "Không", Value = -1 }
                };
                cmbParentInfo.DataSource = list2;
                cmbParentInfo.DisplayMember = "Name";
                cmbParentInfo.ValueMember = "Value";
            }

            DataTable dataTable = CategoriesDAO.Instance.getAllCategoriesDeleted();
            if(dataTable != null)
            {
                dgvCategoriesList.DataSource = dataTable;
                if (dgvCategoriesList.Columns.Contains("parent_id"))
                {
                    dgvCategoriesList.Columns["parent_id"].Visible = false;
                }
            }
        }

        public void LoadCmbParent(DataTable dataHandle, DataTable dataTable, int parentID = -1, string space = "")
        {
            DataTable copy = dataTable.Copy(); // Tạo một bản sao của DataTable

            for (int i = 0; i < copy.Rows.Count; i++)
            {
                DataRow row = copy.Rows[i];

                if ((int)row["parent_id"] == parentID)
                {
                    int temp = (int)row["Mã chuyên mục"];
                    DataRow newRow = dataHandle.NewRow();
                    newRow.ItemArray = row.ItemArray;
                    newRow["Tên chuyên mục"] = space + newRow["Tên chuyên mục"];
                    dataHandle.Rows.Add(newRow);

                    DataRow rowToRemove = dataTable.Select($"[Mã chuyên mục] = {temp}").FirstOrDefault();
                    if (rowToRemove != null)
                    {
                        dataTable.Rows.Remove(rowToRemove);
                    }

                    LoadCmbParent(dataHandle, dataTable, temp, space + "   ");
                }
            }
        }

        private void homePageMenuItem_Click(object sender, EventArgs e)
        {
            this.user = UsersDAO.Instance.GetUser((int)this.user.Rows[0]["Mã nhân viên"]);
            HomePage homePage = new HomePage(this.user);
            this.Hide();
            homePage.ShowDialog();
            this.Close();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersList usersList = new UsersList(this.user);
            this.Hide();
            usersList.ShowDialog();
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

        private void thùngRácToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đó là trang hiện tại");
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriesManager categoriesManager = new CategoriesManager(this.user);
            this.Hide();
            categoriesManager.ShowDialog();
            this.Close();
        }

        private void thùngRácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrashUsers trashUsers = new TrashUsers(this.user);
            this.Hide();
            trashUsers.ShowDialog();
            this.Close();
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtNameInfo.Text = "";
            txtSearch.Text = "";
            cbTime.Checked = false;
            dtpDateFrom.Value = DateTime.Now;
            dtpDateTo.Value = DateTime.Now;
            cmbParentInfo.SelectedValue = -1;
            dgvCategoriesList.DataSource = null;
            Load();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = $"%{txtSearch.Text}%";
            DataTable data = new DataTable();
            if (cbTime.Checked == false)
            {
                data = CategoriesDAO.Instance.SearchDeleted(name, "", "");

                if (data != null)
                {
                    dgvCategoriesList.DataSource = data;
                    if (dgvCategoriesList.Columns.Contains("parent_id"))
                    {
                        dgvCategoriesList.Columns["parent_id"].Visible = false;
                    }
                }
            }
            else
            {
                data = CategoriesDAO.Instance.SearchDeleted(name, dtpDateFrom.Value.ToString("yyyy/MM/dd"), dtpDateTo.Value.ToString("yyyy/MM/dd"));

                if (data != null)
                {
                    dgvCategoriesList.DataSource = data;
                    if (dgvCategoriesList.Columns.Contains("parent_id"))
                    {
                        dgvCategoriesList.Columns["parent_id"].Visible = false;
                    }
                }
                else
                {
                    dgvCategoriesList.DataSource = null;
                }
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if(txtID.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải chọn 1 chuyên mục để khôi phục");
            }
            else if(int.TryParse(txtID.Text, out int id))
            {
                if(CategoriesDAO.Instance.Restore(id, (int)cmbParentInfo.SelectedValue))
                {
                    MessageBox.Show("Khôi phục thành công");
                    btnReset.PerformClick();
                }
                else
                {
                    MessageBox.Show("Khôi phục thất bại");
                }
            }
        }

        private void dgvCategoriesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text = dgvCategoriesList.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNameInfo.Text = dgvCategoriesList.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtID.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải chọn 1 chuyên mục để xóa vĩnh viễn");
            }
            else if(int.TryParse(txtID.Text, out int id))
            {
                if(CategoriesDAO.Instance.CheckDestroy(id))
                {
                    DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa chuyên mục có mã là: {id} không?\nNếu xóa thì sẽ không thể khôi phục", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (CategoriesDAO.Instance.Destroy(id))
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
                    MessageBox.Show("Không thể xóa chuyên mục này vì trong chuyên mục này có chứa sản phẩm");
                }
            }
        }
    }
}
