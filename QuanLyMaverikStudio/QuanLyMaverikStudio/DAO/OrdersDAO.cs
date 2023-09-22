using QuanLyMaverikStudio.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMaverikStudio.DAO
{
    public class OrdersDAO
    {
        private static OrdersDAO instance;

        public static OrdersDAO Instance
        {
            get { if (instance == null) instance = new OrdersDAO(); return OrdersDAO.instance; }
            private set { OrdersDAO.instance = value; }
        }

        private OrdersDAO() { }

        public DataTable CreateOrder(int idClient, int idUser, string address, int status, string note, string phoneNumber, string timeNow)
        {
            string query = "insert into dbo.orders (client_id, user_id, address, status_id, note, phone_number, created_at) "+
                "values ( @clientId , @userId , @address , @statusId , @note , @phoneNumber , @createdAt ) " +
                " SELECT * FROM orders WHERE id = SCOPE_IDENTITY()";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { idClient, idUser, address, status, note, phoneNumber, timeNow });

            return data;
        }

        public bool DestroyOrder(int id)
        {
            string query = "delete from dbo.orders where id = @id ";

            int r = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });

            if(r>0)
            {
                return true;
            }

            return false;
        }

        public DataTable GetFirstDetailOrder(int id)
        {
            string query = "select p.name as 'Tên sản phẩm', s.size as 'Size', od.quantity as 'Số lượng', od.total_money as 'Thành tiền', od.product_id, od.size_id "+
                "from orders as o "+
                "inner join order_details as od on o.id = od.order_id "+
                "inner join products as p on od.product_id = p.id "+
                "inner join size as s on od.size_id = s.id "+
                "where o.id = @id ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });

            return data;
        }

        public bool InsertDetailOrder(int orderId, int productId, int sizeId, int quantity, string timeNow)
        {
            string query = "insert into order_details (order_id, product_id, size_id, quantity, created_at) "+
                "values ( @order_id , @product_id , @size_id , @quantity , @created_at )";

            int r = DataProvider.Instance.ExecuteNonQuery(query, new object[] { orderId, productId, sizeId, quantity, timeNow });

            if(r>0)
            {
                return true;
            }
            return false;
        }

        public DataTable GetTotalMoneyOrder(int id)
        {
            string query = "select total_money from orders where id = @id ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });

            return data;
        }

        public bool DestroyDetailOrder(int orderId, int productId, int sizeId)
        {
            string query = "delete from order_details where order_id = @order_id and product_id = @product_id and size_id = @size_id ";

            int r = DataProvider.Instance.ExecuteNonQuery(query, new object[] { orderId, productId, sizeId });
            if(r>0)
            {
                return true;
            }
            return false;
        }

        public bool CheckDetailOrderExist(int orderId, int productId, int sizeId)
        {
            string query = "select * from order_details where order_id = @order_id and product_id = @product_id and size_id = @size_id ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { orderId, productId, sizeId });

            if(data.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateDetailOrder(int orderId, int productId, int sizeId, int quantity)
        {
            string query = "update order_details set quantity = quantity + @quantity where order_id = @order_id and product_id = @product_id and size_id = @size_id ";

            int r = DataProvider.Instance.ExecuteNonQuery(query, new object[] { quantity, orderId, productId, sizeId });

            if (r > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateOrder(int id, int clientId, string address, int statusId, string note, string phoneNumber)
        {
            string query = "update orders set client_id = @clientId , address = @address , status_id = @statusId , note = @note , phone_number = @phoneNumber where id = @id ";

            int r = DataProvider.Instance.ExecuteNonQuery(query, new object[] { clientId, address, statusId, note, phoneNumber, id });

            if (r > 0)
            {
                return true;
            }
            return false;
        }
    }
}
