using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMaverikStudio.DAO
{
    public class ProductsDAO
    {
        private static ProductsDAO instance;

        public static ProductsDAO Instance
        {
            get { if (instance == null) instance = new ProductsDAO(); return ProductsDAO.instance; }
            private set { ProductsDAO.instance = value; }
        }

        private ProductsDAO() { }

        public DataTable GetAllProductsSell()
        {
            string query = "select p.id as 'Mã sản phẩm', p.name as 'Tên sản phẩm', b.name as 'Thương hiệu', c.name as 'Chuyên mục', s.size, pd.quantity_ready as 'Số lượng', pd.price as 'Giá', pd.sale as 'Sale', pd.size_id " +
                "from products as p "+
                "inner join brands as b on p.brand_id = b.id "+
                "inner join categories as c on p.category_id = c.id " +
                "inner join product_details as pd on p.id = pd.product_id " +
                "inner join size as s on s.id = pd.size_id " +
                "where p.deleted_at is null and c.deleted_at is null";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public DataTable SearchAllProductsSell(string name, int brandId, DataTable categories, int categoryId)
        {
            string id = $"{categoryId.ToString()}";
            for(int i = 0; i<categories.Rows.Count; i++)
            {
                id = id + $",{categories.Rows[i]["Mã chuyên mục"].ToString()}";
            }
            int check = 0;
            if(id.Equals(""))
            {
                id = "-1";
                check = int.Parse(id);
            }
            string query = "select p.id as 'Mã sản phẩm', p.name as 'Tên sản phẩm', b.name as 'Thương hiệu', c.name as 'Chuyên mục', s.size, pd.quantity_ready as 'Số lượng', pd.price as 'Giá', pd.sale as 'Sale', pd.size_id " +
                "from products as p " +
                "inner join brands as b on p.brand_id = b.id " +
                "inner join categories as c on p.category_id = c.id " +
                "inner join product_details as pd on p.id = pd.product_id " +
                "inner join size as s on s.id = pd.size_id " +
                $"where p.name like @name and (-1 = @brand1 or p.brand_id = @brand2 ) and p.deleted_at is null and c.deleted_at is null and (-1 = @check or p.category_id in (select id from categories where id in ({id})))";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { name, brandId, brandId, check });

            return data;
        }

        public DataTable GetSellProduct(int productId, int sizeId)
        {
            string query = "select p.name, s.size, pd.quantity_ready "+
                "from product_details as pd "+
                "inner join products as p on p.id = pd.product_id "+
                "inner join size as s on s.id = pd.size_id "+
                "where pd.product_id = @productId and pd.size_id = @sizeId ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { productId, sizeId });

            return data;
        }

        public bool CheckQuantityReady(int productId, int sizeId, int quantity)
        {
            string query = "select * from product_details "+
                "where product_id = @productId and size_id = @sizeId and @quantity <= quantity_ready";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { productId, sizeId, quantity });

            if(data != null && data.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public bool ReduceQuantityReadyProduct(int productId, int sizeId, int quantity)
        {
            string query = "update product_details set quantity_ready = quantity_ready - @quantity where product_id = @product_id and size_id = @size_id ";

            int r = DataProvider.Instance.ExecuteNonQuery(query, new object[] { quantity,  productId, sizeId });

            if(r > 0)
            {
                return true;
            }
            return false;
        }

        public bool ReduceQuantityProduct(int productId, int sizeId, int quantity)
        {
            string query = "update product_details set quantity = quantity - @quantity where product_id = @product_id and size_id = @size_id ";

            int r = DataProvider.Instance.ExecuteNonQuery(query, new object[] { quantity, productId, sizeId });

            if (r > 0)
            {
                return true;
            }
            return false;
        }

        public bool IncreaseQuantityReadyProduct(int productId, int sizeId, int quantity)
        {
            string query = "update product_details set quantity_ready = quantity_ready + @quantity where product_id = @product_id and size_id = @size_id ";

            int r = DataProvider.Instance.ExecuteNonQuery(query, new object[] { quantity, productId, sizeId });

            if (r > 0)
            {
                return true;
            }
            return false;
        }
    }
}
