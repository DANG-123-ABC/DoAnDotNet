using QuanLyMaverikStudio.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMaverikStudio.DAO
{
    public class ClientsDAO
    {
        private static ClientsDAO instance;

        public static ClientsDAO Instance
        {
            get { if (instance == null) instance = new ClientsDAO(); return ClientsDAO.instance; }
            private set { ClientsDAO.instance = value; }
        }

        private ClientsDAO() { }

        public DataTable GetAllClientForSell()
        {
            string query = "select id as 'Mã khách hàng', name as 'Tên khách hàng', gender as 'Giới tính', account as 'Tài khoản', phone_number as 'Số điện thoại', date_of_birth as 'Ngày sinh' "+
                "from clients where deleted_at is null";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public DataTable SearchAllClientForSell(string search, int id = -1)
        {
            string query;
            if(id != -1)
            {
                query = "select id as 'Mã khách hàng', name as 'Tên khách hàng', gender as 'Giới tính', account as 'Tài khoản', phone_number as 'Số điện thoại', date_of_birth as 'Ngày sinh' " +
                "from clients " +
                "where ( id = @search1 ) and deleted_at is null";

                DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });

                return data;
            }
            else
            {
                query = "select id as 'Mã khách hàng', name as 'Tên khách hàng', gender as 'Giới tính', account as 'Tài khoản', phone_number as 'Số điện thoại', date_of_birth as 'Ngày sinh' " +
                "from clients " +
                "where ( name like @search2 or account like @search3 or phone_number like @search4 ) and deleted_at is null";

                DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { search, search, search });

                return data;
            }
        }

        public bool CheckExistAccount(string account, int id = -1)
        {
            string query = "select * from clients where account = @admin ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { account });

            if (data.Rows.Count > 0)
            {
                if ((int)data.Rows[0]["id"] == id)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        public DataTable InsertData(Clients client)
        {
            string query = "insert into dbo.clients (name, address, gender, email, phone_number, account, password, date_of_birth, created_at) " +
                "values ( @name , @address , @gender , @email , @phone_number , @account , @password , @date_of_birth , @created_at )";

            string query2 = " SELECT id, name, phone_number FROM clients WHERE id = SCOPE_IDENTITY()";

            query = query + query2;

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { client.Name, client.Address, client.Gender, client.Email, client.Phonenumber, client.Account, client.Password, client.DateOfBirth, client.CreatedAt });

            return data;
        }
    }
}
