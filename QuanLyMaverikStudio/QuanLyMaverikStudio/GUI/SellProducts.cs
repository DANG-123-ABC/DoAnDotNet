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
    public partial class SellProducts : Form
    {
        private int orderId;
        private int productId;
        private int sizeId;
        public SellProducts(int orderId, int productId, int sizeId)
        {
            InitializeComponent();
            this.orderId = orderId;
            this.productId = productId;
            this.sizeId = sizeId;

            Load();
        }

        public void Load()
        {
            DataTable data = ProductsDAO.Instance.GetSellProduct(this.productId, this.sizeId);

            if(data != null && data.Rows.Count > 0)
            {
                txtNameProduct.Text = data.Rows[0]["name"].ToString();
                txtSize.Text = data.Rows[0]["size"].ToString();
                txtQuantity.Text = data.Rows[0]["quantity_ready"].ToString();
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtQuantityWantSell.Text, out int quantityWantSell))
            {
                if(ProductsDAO.Instance.CheckQuantityReady(this.productId, this.sizeId, quantityWantSell))
                {
                    if(OrdersDAO.Instance.CheckDetailOrderExist(this.orderId, this.productId, this.sizeId))
                    {
                        if (OrdersDAO.Instance.UpdateDetailOrder(this.orderId, this.productId, this.sizeId, quantityWantSell))
                        {
                            if (ProductsDAO.Instance.ReduceQuantityReadyProduct(this.productId, this.sizeId, quantityWantSell))
                            {
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        if (OrdersDAO.Instance.InsertDetailOrder(this.orderId, this.productId, this.sizeId, quantityWantSell, DateTime.Now.ToString()))
                        {
                            if (ProductsDAO.Instance.ReduceQuantityReadyProduct(this.productId, this.sizeId, quantityWantSell))
                            {
                                this.Close();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Số lượng sản phẩm không đủ để đáp ứng");
                }
            }
            else
            {
                MessageBox.Show("Bạn phải nhập số lượng sản phẩm muốn bán và phải là số nguyên");
            }
        }
    }
}
