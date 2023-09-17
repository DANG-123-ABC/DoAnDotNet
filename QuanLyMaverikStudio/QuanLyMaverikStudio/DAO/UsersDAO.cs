using QuanLyMaverikStudio.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace QuanLyMaverikStudio.DAO
{
    public class UsersDAO
    {
        private static UsersDAO instance;

        public static UsersDAO Instance
        {
            get { if (instance == null) instance = new UsersDAO(); return UsersDAO.instance; }
            private set { UsersDAO.instance = value; }
        }

        private UsersDAO() { }

        public DataTable GetUser(int id)
        {
            string query = "select u.id as 'Mã nhân viên', u.name as 'Tên nhân viên', u.account as 'Tài khoản', u.address as 'Địa chỉ', u.salary as 'Lương', g.name as 'Quyền', u.email, u.phone_number, u.date_of_birth, u.group_id " +
                "from dbo.users as u " +
                "inner join dbo.groups as g on u.group_id = g.id " +
                "where u.id = @id and u.deleted_at is null ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });

            if (data.Rows.Count > 0)
            {
                return data;
            }
            else
            {
                return null;
            }
        }

        public DataTable Login(string account, string password)
        {
            string query = "select u.id as 'Mã nhân viên', u.name as 'Tên nhân viên', u.account as 'Tài khoản', u.address as 'Địa chỉ', u.salary as 'Lương', g.name as 'Quyền', u.email, u.phone_number, u.date_of_birth, u.group_id " +
                "from dbo.users as u "+
                "inner join dbo.groups as g on u.group_id = g.id "+
                "where u.account = @account and u.password = @password and u.deleted_at is null ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { account, password });

            if (data.Rows.Count > 0)
            {
                return data;
            }
            else
            {
                return null;
            }
        }

        public bool changePassword(int id, string password, string newPassword)
        {
            string query = "update users set password = @newPassword where id = @id and password = @password ";

            int r = DataProvider.Instance.ExecuteNonQuery(query, new object[] { newPassword, id, password });

            if (r > 0)
            {
                return true;
            }

            return false;
        }

        public DataTable GetAllUsers()
        {
            string query = "select u.id as 'Mã nhân viên', u.name as 'Tên nhân viên', u.account as 'Tài khoản', u.address as 'Địa chỉ', u.salary as 'Lương', g.name as 'Quyền', u.created_at as 'Thời gian tạo', u.updated_at as 'Thời gian cập nhật', u.email, u.phone_number, u.date_of_birth, u.group_id "+
                "from dbo.users as u "+
                "inner join dbo.groups as g on u.group_id = g.id where u.deleted_at is null "+
                "order by u.created_at desc";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                return data;
            }
            else
            {
                return null;
            }
        }

        public DataTable GetAllUsersDeleted()
        {
            string query = "select u.id as 'Mã nhân viên', u.name as 'Tên nhân viên', u.account as 'Tài khoản', u.address as 'Địa chỉ', u.salary as 'Lương', g.name as 'Quyền', u.email as 'Email', u.phone_number as 'Số điện thoại', u.date_of_birth as 'Ngày sinh', u.group_id, u.deleted_at as 'Thời gian xóa' " +
                "from dbo.users as u " +
                "inner join dbo.groups as g on u.group_id = g.id where u.deleted_at is not null " +
                "order by u.deleted_at desc";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                return data;
            }
            else
            {
                return null;
            }
        }

        public DataTable Search(string search, int group_id, string dateFrom, string dateTo, string dateFrom2, string dateTo2)
        {
            string query = "select u.id as 'Mã nhân viên', u.name as 'Tên nhân viên', u.account as 'Tài khoản', u.address as 'Địa chỉ', u.salary as 'Lương', g.name as 'Quyền', u.created_at as 'Thời gian tạo', u.updated_at as 'Thời gian cập nhật', u.email, u.phone_number, u.date_of_birth, u.group_id " +
                "from dbo.users as u " +
                "inner join dbo.groups as g on u.group_id = g.id " +
                "where ((u.name like @name ) or (u.account like @account ) or (u.address like @address )) and (-1 = @group_id1 or u.group_id = @group_id2 ) and ('' = @dateFrom1 or CONVERT(date, u.created_at) >= @dateFrom2 ) and ('' = @dateTo1 or CONVERT(date, u.created_at) <= @dateTo2 ) and ('' = @dateFrom3 or CONVERT(date, u.updated_at) >= @dateFrom4 ) and ('' = @dateTo3 or CONVERT(date, u.updated_at) <= @dateTo4 ) and u.deleted_at is null " +
                "order by u.created_at desc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { search, search, search, group_id, group_id, dateFrom, dateFrom, dateTo, dateTo, dateFrom2, dateFrom2, dateTo2, dateTo2 });

            if (data.Rows.Count > 0)
            {
                return data;
            }
            else
            {
                return null;
            }
        }

        public DataTable SearchDeleted(string search, int group_id, string dateFrom, string dateTo)
        {
            string query = "select u.id as 'Mã nhân viên', u.name as 'Tên nhân viên', u.account as 'Tài khoản', u.address as 'Địa chỉ', u.salary as 'Lương', g.name as 'Quyền', u.email as 'Email', u.phone_number as 'Số điện thoại', u.date_of_birth as 'Ngày sinh', u.group_id, u.deleted_at as 'Thời gian xóa' " +
                "from dbo.users as u " +
                "inner join dbo.groups as g on u.group_id = g.id " +
                "where ((u.name like @name ) or (u.account like @account ) or (u.address like @address )) and (-1 = @group_id1 or u.group_id = @group_id2 ) and (('' = @dateFrom1 or CONVERT(date, u.deleted_at) >= @dateFrom2 ) and ('' = @dateTo1 or CONVERT(date, u.deleted_at) <= @dateTo2 )) and u.deleted_at is not null " +
                "order by u.deleted_at desc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { search, search, search, group_id, group_id, dateFrom, dateFrom, dateTo, dateTo });

            if (data.Rows.Count > 0)
            {
                return data;
            }
            else
            {
                return null;
            }
        }

        public bool Delete(int id, string timeNow)
        {
            string query = "update dbo.users set deleted_at = @timeNow where id = @id and group_id <> 1";

            if(DataProvider.Instance.ExecuteNonQuery(query, new object[] { timeNow, id }) > 0) {
                return true;
            }

            return false;
        }

        public bool Restore(int id)
        {
            string query = "update dbo.users set deleted_at = null where id = @id ";

            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { id }) > 0)
            {
                return true;
            }

            return false;
        }

        public bool Destroy(int id)
        {
            string query = "delete from dbo.users where id = @id ";

            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { id }) > 0)
            {
                return true;
            }

            return false;
        }

        public bool CheckExistAccount(string account, int id = -1)
        {
            string query = "select * from dbo.users where account = @admin ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { account });

            if(data.Rows.Count > 0)
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

        public bool InsertData(Users user)
        {
            string query = "insert into dbo.users (name, address, email, phone_number, account, password, salary, date_of_birth, group_id, created_at) " +
                "values ( @name , @address , @email , @phone_number , @account , @password , @salary , @date_of_birth , @group_id , @created_at )";

            int r = DataProvider.Instance.ExecuteNonQuery(query, new object[] { user.Name, user.Address, user.Email, user.Phonenumber, user.Account, user.Password, user.Salary, user.DateOfBirth, user.GroupID, user.CreatedAt});
            
            if(r > 0)
            {
                return true;
            }

            return false;
        }

        public bool UpdateData(Users user)
        {
            string query = "update dbo.users set name = @name , address = @address , account = @account , email = @email , password = @password , group_id = @group_id , salary = @salary , date_of_birth = @date_of_birth , phone_number = @phone_number , updated_at = @updated_at " +
                "where id = @id ";
            if (user.Password.Equals(""))
            {
                query = "update dbo.users set name = @name , address = @address , account = @account , email = @email , group_id = @group_id , salary = @salary , date_of_birth = @date_of_birth , phone_number = @phone_number , updated_at = @updated_at " +
                "where id = @id ";

                int row = DataProvider.Instance.ExecuteNonQuery(query, new object[] { user.Name, user.Address, user.Account, user.Email, user.GroupID, user.Salary, user.DateOfBirth, user.Phonenumber, user.UpdatedAt, user.ID });

                if (row > 0)
                {
                    return true;
                }

                return false;
            }
            else
            {
                int r = DataProvider.Instance.ExecuteNonQuery(query, new object[] { user.Name, user.Address, user.Account, user.Email, user.Password, user.GroupID, user.Salary, user.DateOfBirth, user.Phonenumber, user.UpdatedAt, user.ID });

                if (r > 0)
                {
                    return true;
                }

                return false;
            }
        }
    }
}
