using QuanLyMaverikStudio.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMaverikStudio.GUI
{
    public partial class CategoriesManager : Form
    {
        private int idCategory = -1;
        private DataTable user;
        public CategoriesManager(DataTable user)
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
            DataTable dataHandle = data.Clone();
            LoadCmbParent1(dataHandle, data, -1, "");

            DataTable dataHandleCopy = dataHandle.Copy();

            DataRow defaultRow = dataHandle.NewRow();
            defaultRow["Mã chuyên mục"] = -1;  // Giá trị id của tùy chọn mặc định
            defaultRow["Tên chuyên mục"] = "Không";  // Tên hiển thị của tùy chọn mặc định
            dataHandle.Rows.InsertAt(defaultRow, 0);

            cmbParent.DataSource = dataHandle;
            cmbParent.DisplayMember = "Tên chuyên mục";
            cmbParent.ValueMember = "Mã chuyên mục";

            dgvCategoriesList.DataSource = dataHandleCopy;
            if (dgvCategoriesList.Columns.Contains("parent_id"))
            {
                dgvCategoriesList.Columns["parent_id"].Visible = false;
            }
        }

        public void LoadCmbParent1(DataTable dataHandle, DataTable dataTable, int parentID = -1, string space = "")
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

                    LoadCmbParent1(dataHandle,dataTable, temp, space + "   ");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            cmbParent.SelectedValue = -1;
            this.idCategory = -1;
            Load();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text.Trim() == "")
            {
                txtSearch.Text = "";
                MessageBox.Show("Bạn phải nhập dữ liệu để tìm kiếm");
            }
            else
            {
                string name = $"%{txtSearch.Text}%";

                DataTable data = CategoriesDAO.Instance.Search(name);

                dgvCategoriesList.DataSource = data;

                if(dgvCategoriesList.Columns.Contains("parent_id"))
                {
                    dgvCategoriesList.Columns["parent_id"].Visible = false;
                }
            }
        }

        private void dgvCategoriesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                if (int.TryParse(dgvCategoriesList.Rows[e.RowIndex].Cells[0].Value.ToString(), out int result))
                {
                    this.idCategory = result;
                    txtName.Text = dgvCategoriesList.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                    cmbParent.SelectedValue = (int)dgvCategoriesList.Rows[e.RowIndex].Cells[2].Value;
                }
                else
                {
                    this.idCategory = -1;
                }
                MessageBox.Show(this.idCategory.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.idCategory == -1)
            {
                MessageBox.Show("Bạn phải chọn 1 chuyên mục để xóa");
            }
            else
            {
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa chuyên mục có mã là: {this.idCategory} không?\nNếu chuyên mục này có chuyên mục con thì cũng sẽ bị xóa theo", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string timeNow = DateTime.Now.ToString();
                    if (CategoriesDAO.Instance.Delete(this.idCategory, timeNow))
                    {
                        MessageBox.Show("Xóa thành công");
                        this.idCategory = -1;
                        btnReset.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.idCategory == -1)
            {
                MessageBox.Show("Bạn phải chọn 1 chuyên mục để sửa");
            }
            else
            {

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

        private void thùngRácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrashUsers trashUsers = new TrashUsers(this.user);
            this.Hide();
            trashUsers.ShowDialog();
            this.Close();
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersList usersList = new UsersList(this.user);
            this.Hide();
            usersList.ShowDialog();
            this.Close();
        }
    }
}
