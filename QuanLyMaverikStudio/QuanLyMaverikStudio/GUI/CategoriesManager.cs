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
            if(data != null)
            {
                DataTable dataHandle = data.Clone();
                LoadCmbParent(dataHandle, data, -1, "");

                DataTable dataHandleCopy = dataHandle.Copy();

                DataRow defaultRow = dataHandle.NewRow();
                defaultRow["Mã chuyên mục"] = -1;  // Giá trị id của tùy chọn mặc định
                defaultRow["Tên chuyên mục"] = "Không";  // Tên hiển thị của tùy chọn mặc định
                dataHandle.Rows.InsertAt(defaultRow, 0);

                cmbParent.DataSource = dataHandle;
                cmbParent.DisplayMember = "Tên chuyên mục";
                cmbParent.ValueMember = "Mã chuyên mục";

                DataTable dataHandleCopy2 = dataHandle.Copy();
                cmbParentInfo.DataSource = dataHandleCopy2;
                cmbParentInfo.DisplayMember = "Tên chuyên mục";
                cmbParentInfo.ValueMember = "Mã chuyên mục";

                dgvCategoriesList.DataSource = dataHandleCopy;
                if (dgvCategoriesList.Columns.Contains("parent_id"))
                {
                    dgvCategoriesList.Columns["parent_id"].Visible = false;
                }
            }
            else
            {
                List<object> list = new List<object>
                {
                    new { Name = "Không", Value = -1 }
                };
                cmbParent.DataSource = list;
                cmbParent.DisplayMember = "Name";
                cmbParent.ValueMember = "Value";

                List<object> list2 = new List<object>
                {
                    new { Name = "Không", Value = -1 }
                };
                cmbParentInfo.DataSource = list2;
                cmbParentInfo.DisplayMember = "Name";
                cmbParentInfo.ValueMember = "Value";
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

                    LoadCmbParent(dataHandle,dataTable, temp, space + "   ");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtNameInfo.Text = "";
            txtSearch.Text = "";
            cmbParent.SelectedValue = -1;
            cmbParentInfo.SelectedValue = -1;
            cbTime.Checked = false;
            dtpDateFrom.Value = DateTime.Now;
            dtpDateTo.Value = DateTime.Now;
            dgvCategoriesList.DataSource = null;
            Load();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = $"%{txtSearch.Text}%";
            DataTable data = new DataTable();
            if(cbTime.Checked == false)
            {
                data = CategoriesDAO.Instance.Search(name, "", "", "", "");

                if(data != null)
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
                if(rdoCreated.Checked == true)
                {
                    data = CategoriesDAO.Instance.Search(name, dtpDateFrom.Value.ToString("yyyy/MM/dd"), dtpDateTo.Value.ToString("yyyy/MM/dd"), "", "");

                    if(data != null)
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
                    data = CategoriesDAO.Instance.Search(name, "", "", dtpDateFrom.Value.ToString("yyyy/MM/dd"), dtpDateTo.Value.ToString("yyyy/MM/dd"));
                    if(data != null)
                    {
                        dgvCategoriesList.DataSource = data;

                        if (dgvCategoriesList.Columns.Contains("parent_id"))
                        {
                            dgvCategoriesList.Columns["parent_id"].Visible = false;
                        }
                    }
                }
            }
        }

        private void dgvCategoriesList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                txtID.Text = dgvCategoriesList.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNameInfo.Text = dgvCategoriesList.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
                if(int.TryParse(dgvCategoriesList.Rows[e.RowIndex].Cells[2].Value.ToString(), out int result))
                {
                    cmbParentInfo.SelectedValue = result;
                }
            }
        }

        public bool CheckChild(int id, int parent_id)
        {
            DataTable data = CategoriesDAO.Instance.getAllCategories();
            if(data != null)
            {
                DataTable dataHandle = data.Clone();
                LoadCmbParent(dataHandle, data, id, "");

                for (int i = 0; i < dataHandle.Rows.Count; i++)
                {
                    if ((int)dataHandle.Rows[i]["Mã chuyên mục"] == parent_id)
                    {
                        return true;
                    }
                }
            }

            return false;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải chọn 1 chuyên mục để xóa");
            }
            else if(int.TryParse(txtID.Text, out int id))
            {
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa chuyên mục có mã là: {id} không?\nNếu chuyên mục này có chuyên mục con thì cũng sẽ bị xóa theo", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string timeNow = DateTime.Now.ToString();
                    bool check = CategoriesDAO.Instance.Delete(id, timeNow);
                    DataTable data = CategoriesDAO.Instance.getAllCategories();
                    if(data != null)
                    {
                        DataTable dataHandle = data.Clone();
                        LoadCmbParent(dataHandle, data, id, "");
                        for (int i = 0; i < dataHandle.Rows.Count; i++)
                        {
                            CategoriesDAO.Instance.Delete((int)dataHandle.Rows[i]["Mã chuyên mục"], timeNow);
                        }
                    }
                    if(check)
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
        }

        public bool Validate(string txtName)
        {
            if(txtName.Trim().Equals(""))
            {
                MessageBox.Show("Tên chuyên mục không được để trống");
                return false;
            }
            else if(txtName.Length > 50)
            {
                MessageBox.Show("Tên chuyên mục phải nhỏ hơn 50 ký tự");
                return false;
            }
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                MessageBox.Show("Bạn phải chọn 1 chuyên mục");
            }
            else if(int.TryParse(txtID.Text, out int id) && Validate(txtNameInfo.Text))
            {
                if(id == (int)cmbParentInfo.SelectedValue)
                {
                    MessageBox.Show("Chuyên mục cha không thể là chính nó");
                }
                else
                {
                    DataTable data = CategoriesDAO.Instance.getAllCategories();
                    if (data != null)
                    {
                        bool test = true;
                        DataTable dataHandle = data.Clone();
                        LoadCmbParent(dataHandle, data, id, "");

                        for(int i=0;i<dataHandle.Rows.Count;i++)
                        {
                            if((int)cmbParentInfo.SelectedValue == (int)dataHandle.Rows[i]["Mã chuyên mục"])
                            {
                                test = false;
                                break;
                            }
                        }

                        if(test)
                        {
                            string timeNow = DateTime.Now.ToString();

                            if(CategoriesDAO.Instance.Update(id, (int)cmbParentInfo.SelectedValue, txtNameInfo.Text.Trim(), timeNow))
                            {
                                MessageBox.Show("Sửa thành công");
                                btnReset.PerformClick();
                            }
                            else
                            {
                                MessageBox.Show("Sửa thất bại");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Chuyên mục cha không thể là con của chuyên mục hiện tại");
                        }
                    }
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
            MessageBox.Show("Đó là trang hiện tại");
        }

        private void thùngRácToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TrashCategories trashCategories = new TrashCategories(this.user);
            this.Hide();
            trashCategories.ShowDialog();
            this.Close();
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

        private void cbTime_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTime.Checked == false)
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(Validate(txtName.Text))
            {
                string timeNow = DateTime.Now.ToString();
                if(CategoriesDAO.Instance.Insert(txtName.Text.Trim(), (int)cmbParent.SelectedValue, timeNow))
                {
                    MessageBox.Show("Thêm thành công");
                    btnReset.PerformClick();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }
    }
}
