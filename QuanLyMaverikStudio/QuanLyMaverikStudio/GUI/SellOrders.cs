using QuanLyMaverikStudio.DAO;
using QuanLyMaverikStudio.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyMaverikStudio.GUI
{
    public partial class SellOrders : Form
    {
        private DataTable user;
        private int productId = -1;
        private int sizeId = -1;

        private int productIdDetail = -1;
        private int sizeIdDetail = -1;
        private int quantityDetail = 0;
        private string nameDetail = "";
        public SellOrders(DataTable user)
        {
            InitializeComponent();
            this.user = user;

            Load();
        }

        public void Load()
        {
            LoadCmbBrands();

            LoadCmbCategories();

            DataTable data = ProductsDAO.Instance.GetAllProductsSell();
            if(data != null)
            {
                dgvListProductSell.DataSource = data;
                dgvListProductSell.Columns["size_id"].Visible = false;
            }

            lbNameUser.Text = $"Tên nhân viên: {this.user.Rows[0]["Tên nhân viên"]}";
        }

        public void LoadCmbBrands()
        {
            DataTable data = BrandsDAO.Instance.GetAllBrandsForCmb();

            DataRow dataRow = data.NewRow();
            dataRow["id"] = -1;
            dataRow["name"] = "Tất cả";
            data.Rows.InsertAt(dataRow, 0);

            cmbBrands.DataSource = data;
            cmbBrands.DisplayMember = "name";
            cmbBrands.ValueMember = "id";
        }

        public void LoadCmbCategories()
        {
            DataTable dataCategories = CategoriesDAO.Instance.getAllCategories();
            
            DataTable dataHandle = dataCategories.Clone();
            LoadCmbParent(dataHandle, dataCategories, -1, "");

            DataRow defaultRow = dataHandle.NewRow();
            defaultRow["Mã chuyên mục"] = -1;  // Giá trị id của tùy chọn mặc định
            defaultRow["Tên chuyên mục"] = "Tất cả";  // Tên hiển thị của tùy chọn mặc định
            dataHandle.Rows.InsertAt(defaultRow, 0);

            cmbCategories.DataSource = dataHandle;
            cmbCategories.DisplayMember = "Tên chuyên mục";
            cmbCategories.ValueMember = "Mã chuyên mục";
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

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đó là trang hiện tại");
        }

        private void homePageMenuItem_Click(object sender, EventArgs e)
        {
            if(!lbIdValue.Text.Equals(""))
            {
                btnCancel_Click(sender, e);
            }
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

        private void thùngRácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrashUsers trashUsers = new TrashUsers(this.user);
            this.Hide();
            trashUsers.ShowDialog();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name = $"%{txtSearch.Text.Trim()}%";

            int categoryId = -1;
            if (cmbCategories.SelectedValue != null)
            {
                categoryId = (int)cmbCategories.SelectedValue;
            }

            DataTable dataCategories = CategoriesDAO.Instance.getAllCategories();

            DataTable dataHandle = dataCategories.Clone();
            LoadCmbParent(dataHandle, dataCategories, categoryId, "");

            DataTable data = ProductsDAO.Instance.SearchAllProductsSell(name, (int)cmbBrands.SelectedValue, dataHandle, categoryId);

            dgvListProductSell.DataSource = data;
        }

        private void btnInsertProduct_Click(object sender, EventArgs e)
        {
            if(lbIdValue.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa tạo đơn hàng");
            }
            else if(this.productId == -1)
            {
                MessageBox.Show("Bạn phải chọn 1 sản phẩm");
            }
            else
            {
                SellProducts sellProducts = new SellProducts(int.Parse(lbIdValue.Text), this.productId, this.sizeId);
                sellProducts.ShowDialog();
                
                dgvListDetailOrder.DataSource = OrdersDAO.Instance.GetFirstDetailOrder(int.Parse(lbIdValue.Text));
                dgvListDetailOrder.Columns[4].Visible = false;
                dgvListDetailOrder.Columns[5].Visible = false;

                DataTable data = ProductsDAO.Instance.GetAllProductsSell();
                if (data != null)
                {
                    dgvListProductSell.DataSource = data;
                    dgvListProductSell.Columns["size_id"].Visible = false;
                }

                DataTable dataTotalMoney = OrdersDAO.Instance.GetTotalMoneyOrder(int.Parse(lbIdValue.Text));
                if(dataTotalMoney != null && dataTotalMoney.Rows.Count > 0)
                {
                    txtTotalMoney.Text = dataTotalMoney.Rows[0]["total_money"].ToString();
                }

                this.productId = -1;
                this.sizeId = -1;
            }
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = $"%{txtSearch.Text.Trim()}%";
            int brandId = -1;
            if (int.TryParse(cmbBrands.SelectedValue.ToString(), out int result))
            {
                brandId = result;
            }

            int categoryId = -1;
            if (cmbCategories.SelectedValue != null && int.TryParse(cmbCategories.SelectedValue.ToString(), out int result1))
            {
                categoryId = result1;
            }

            DataTable dataCategories = CategoriesDAO.Instance.getAllCategories();

            DataTable dataHandle = dataCategories.Clone();
            LoadCmbParent(dataHandle, dataCategories, categoryId, "");

            DataTable data = ProductsDAO.Instance.SearchAllProductsSell(name, brandId, dataHandle, categoryId);

            dgvListProductSell.DataSource = data;
        }

        private void cmbBrands_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = $"%{txtSearch.Text.Trim()}%";
            int brandId = -1;
            if (int.TryParse(cmbBrands.SelectedValue.ToString(), out int result))
            {
                brandId = result;
            }

            int categoryId = -1;
            if (cmbCategories.SelectedValue != null)
            {
                categoryId = (int)cmbCategories.SelectedValue;
            }

            DataTable dataCategories = CategoriesDAO.Instance.getAllCategories();

            DataTable dataHandle = dataCategories.Clone();
            LoadCmbParent(dataHandle, dataCategories, categoryId, "");

            DataTable data = ProductsDAO.Instance.SearchAllProductsSell(name, brandId, dataHandle, categoryId);

            dgvListProductSell.DataSource = data;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(lbIdValue.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa tạo đơn");
            }
            else 
            {
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn hủy đơn có mã là: {lbIdValue.Text} không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    SubDeleteAll();
                    if (OrdersDAO.Instance.DestroyOrder(int.Parse(lbIdValue.Text)))
                    {
                        lbIdValue.Text = "";
                        txtIDClient.Text = "";
                        txtNameClient.Text = "";
                        txtTotalMoney.Text = "";
                        txtAddress.Text = "";
                        txtPhoneNumber.Text = "";
                        txtNote.Text = "";
                        dgvListDetailOrder.DataSource = null;
                    }
                    else
                    {
                        MessageBox.Show("Hủy thất bại");
                    }
                }
                else
                {
                    btnHoldOn.PerformClick();
                }
            }
        }

        private void btnSelectClient_Click(object sender, EventArgs e)
        {
            ChooseClientWhenSell chooseClientWhenSell = new ChooseClientWhenSell();
            chooseClientWhenSell.ShowDialog();
            if(Storage.IdClient != -1)
            {
                txtIDClient.Text = Storage.IdClient.ToString();
                txtNameClient.Text = Storage.NameClient;
                txtPhoneNumber.Text = Storage.PhoneNumberClient;
                Storage.ResetClient();
            }
        }

        private void rdoOffline_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoOffline.Checked == true)
            {
                txtAddress.ReadOnly = true;
                txtPhoneNumber.ReadOnly = true;
                txtNote.ReadOnly = true;
                txtNote.Text = "Bán trực tiếp";
                txtAddress.Text = "Bán trực tiếp";
            }
        }

        private void rdoOnline_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoOnline.Checked == true)
            {
                txtAddress.ReadOnly = false;
                txtPhoneNumber.ReadOnly = false;
                txtNote.ReadOnly = false;
                txtNote.Text = "";
                txtAddress.Text = "";
            }
        }

        public bool Validate(int id = -1, bool noNullPass = true)
        {
            if (txtAddress.Text.Length > 250 || txtAddress.Text == "")
            {
                MessageBox.Show("Địa chỉ phải nhỏ hơn 250 ký tự và không được để trống");
                return false;
            }
            else if (txtPhoneNumber.Text == "" || !Regex.IsMatch(txtPhoneNumber.Text, @"^0[0-9]{9,10}$"))
            {
                MessageBox.Show("Số điện thoại không được để trống và phải đúng định dạng");
                return false;
            }
            return true;
        }

        private void btnInsertOrder_Click(object sender, EventArgs e)
        {
            if(txtIDClient.Text.Equals(""))
            {
                MessageBox.Show("bạn phải chọn 1 khách hàng để tạo đơn hàng");
            }
            else if(lbIdValue.Text.Equals(""))
            {
                if(rdoOffline.Checked == true)
                {
                    if(Validate())
                    {
                        DataTable data = OrdersDAO.Instance.CreateOrder(int.Parse(txtIDClient.Text), (int)this.user.Rows[0]["Mã nhân viên"], "Bán trực tiếp", 1, "Bán trực tiếp", txtPhoneNumber.Text, DateTime.Now.ToString());

                        if (data != null && data.Rows.Count > 0)
                        {
                            MessageBox.Show("Tạo thành công");

                            lbIdValue.Text = data.Rows[0]["id"].ToString();
                            txtTotalMoney.Text = data.Rows[0]["total_money"].ToString();

                            dgvListDetailOrder.DataSource = OrdersDAO.Instance.GetFirstDetailOrder((int)data.Rows[0]["id"]);
                            dgvListDetailOrder.Columns[4].Visible = false;
                            dgvListDetailOrder.Columns[5].Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Tạo thất bại");
                        }
                    }
                }
                else if(rdoOnline.Checked == true)
                {
                    if(Validate())
                    {
                        DataTable data = OrdersDAO.Instance.CreateOrder(int.Parse(txtIDClient.Text), (int)this.user.Rows[0]["Mã nhân viên"], txtAddress.Text, 1, txtNote.Text, txtPhoneNumber.Text, DateTime.Now.ToString());

                        if (data != null && data.Rows.Count > 0)
                        {
                            MessageBox.Show("Tạo thành công");

                            lbIdValue.Text = data.Rows[0]["id"].ToString();
                            txtTotalMoney.Text = data.Rows[0]["total_money"].ToString();

                            dgvListDetailOrder.DataSource = OrdersDAO.Instance.GetFirstDetailOrder((int)data.Rows[0]["id"]);
                            dgvListDetailOrder.Columns[4].Visible = false;
                            dgvListDetailOrder.Columns[5].Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Tạo thất bại");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn phải xóa đơn này mới được tạo đơn mới");
            }
        }

        private void SellOrders_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!lbIdValue.Text.Equals(""))
            {
                btnCancel_Click(sender, e);
            }
        }

        private void dgvListProductSell_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                this.productId = (int)dgvListProductSell.Rows[e.RowIndex].Cells[0].Value;
                this.sizeId = (int)dgvListProductSell.Rows[e.RowIndex].Cells[8].Value;
            }
            else
            {
                this.productId = -1;
                this.sizeId = -1;
            }
        }

        private void dgvListDetailOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                this.productIdDetail = (int)dgvListDetailOrder.Rows[e.RowIndex].Cells["product_id"].Value;
                this.sizeIdDetail = (int)dgvListDetailOrder.Rows[e.RowIndex].Cells["size_id"].Value;
                this.quantityDetail = (int)dgvListDetailOrder.Rows[e.RowIndex].Cells["Số lượng"].Value;
                this.nameDetail = dgvListDetailOrder.Rows[e.RowIndex].Cells["Tên sản phẩm"].Value.ToString();
            }
            else
            {
                this.productIdDetail = -1;
                this.sizeIdDetail = -1;
                this.quantityDetail = 0;
                this.nameDetail = "";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(this.productIdDetail == -1)
            {
                MessageBox.Show("Bạn phải chọn 1 chi tiết sản phẩm để xóa");
            }
            else
            {
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm '{this.nameDetail}' khỏi đơn không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if(OrdersDAO.Instance.DestroyDetailOrder(int.Parse(lbIdValue.Text), this.productIdDetail, this.sizeIdDetail))
                    {
                        if (ProductsDAO.Instance.IncreaseQuantityReadyProduct(this.productIdDetail, this.sizeIdDetail, this.quantityDetail))
                        {
                            dgvListDetailOrder.DataSource = OrdersDAO.Instance.GetFirstDetailOrder(int.Parse(lbIdValue.Text));
                            dgvListDetailOrder.Columns[4].Visible = false;
                            dgvListDetailOrder.Columns[5].Visible = false;

                            DataTable data = ProductsDAO.Instance.GetAllProductsSell();
                            if (data != null)
                            {
                                dgvListProductSell.DataSource = data;
                                dgvListProductSell.Columns["size_id"].Visible = false;
                            }

                            DataTable dataTotalMoney = OrdersDAO.Instance.GetTotalMoneyOrder(int.Parse(lbIdValue.Text));
                            if (dataTotalMoney != null && dataTotalMoney.Rows.Count > 0)
                            {
                                txtTotalMoney.Text = dataTotalMoney.Rows[0]["total_money"].ToString();
                            }

                            this.productIdDetail = -1;
                            this.sizeIdDetail = -1;
                            this.quantityDetail = 0;
                            this.nameDetail = "";
                        }
                    }
                }
            }
        }

        public void SubDeleteAll()
        {
            foreach (DataGridViewRow row in dgvListDetailOrder.Rows)
            {
                if (OrdersDAO.Instance.DestroyDetailOrder(int.Parse(lbIdValue.Text), (int)row.Cells["product_id"].Value, (int)row.Cells["size_id"].Value))
                {
                    ProductsDAO.Instance.IncreaseQuantityReadyProduct((int)row.Cells["product_id"].Value, (int)row.Cells["size_id"].Value, (int)row.Cells["Số lượng"].Value);
                }
            }

            dgvListDetailOrder.DataSource = OrdersDAO.Instance.GetFirstDetailOrder(int.Parse(lbIdValue.Text));
            dgvListDetailOrder.Columns[4].Visible = false;
            dgvListDetailOrder.Columns[5].Visible = false;

            DataTable data = ProductsDAO.Instance.GetAllProductsSell();
            if (data != null)
            {
                dgvListProductSell.DataSource = data;
                dgvListProductSell.Columns["size_id"].Visible = false;
            }

            DataTable dataTotalMoney = OrdersDAO.Instance.GetTotalMoneyOrder(int.Parse(lbIdValue.Text));
            if (dataTotalMoney != null && dataTotalMoney.Rows.Count > 0)
            {
                txtTotalMoney.Text = dataTotalMoney.Rows[0]["total_money"].ToString();
            }
        }
        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (dgvListDetailOrder.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa tất cả sản phẩm khỏi đơn không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    SubDeleteAll();
                }
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if(lbIdValue.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa tạo đơn hàng");
            }
            else
            {
                if(rdoOffline.Checked == true && Validate())
                {
                    if(OrdersDAO.Instance.UpdateOrder(int.Parse(lbIdValue.Text), int.Parse(txtIDClient.Text), txtAddress.Text, 4, txtNote.Text, txtPhoneNumber.Text))
                    {
                        foreach (DataGridViewRow row in dgvListDetailOrder.Rows)
                        {
                            ProductsDAO.Instance.ReduceQuantityProduct((int)row.Cells["product_id"].Value, (int)row.Cells["size_id"].Value, (int)row.Cells["Số lượng"].Value);
                        }
                        //Xử lý xuất file tại đây

                        //end xuất
                        MessageBox.Show("Thành công");
                        lbIdValue.Text = "";
                        txtIDClient.Text = "";
                        txtNameClient.Text = "";
                        txtTotalMoney.Text = "";
                        rdoOffline.Checked = true;
                        txtPhoneNumber.Text = "";
                        dgvListDetailOrder.DataSource = null;
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
                else if(rdoOnline.Checked == true && Validate())
                {
                    if (OrdersDAO.Instance.UpdateOrder(int.Parse(lbIdValue.Text), int.Parse(txtIDClient.Text), txtAddress.Text, 2, txtNote.Text, txtPhoneNumber.Text))
                    {
                        MessageBox.Show("Thành công");
                        lbIdValue.Text = "";
                        txtIDClient.Text = "";
                        txtNameClient.Text = "";
                        txtTotalMoney.Text = "";
                        rdoOffline.Checked = true;
                        txtPhoneNumber.Text = "";
                        dgvListDetailOrder.DataSource = null;
                    }
                    else
                    {
                        MessageBox.Show("Thất bại");
                    }
                }
            }
        }
    }
}
