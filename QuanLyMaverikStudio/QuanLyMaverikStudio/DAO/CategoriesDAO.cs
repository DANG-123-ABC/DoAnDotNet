using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QuanLyMaverikStudio.DAO
{
    public class CategoriesDAO
    {
        private static CategoriesDAO instance;

        public static CategoriesDAO Instance
        {
            get { if (instance == null) instance = new CategoriesDAO(); return CategoriesDAO.instance; }
            private set { CategoriesDAO.instance = value; }
        }

        private CategoriesDAO() { }

        public DataTable getAllCategories()
        {
            string query = "select id as 'Mã chuyên mục', name as 'Tên chuyên mục', parent_id, created_at as 'Thời gian tạo', updated_at as 'Thời gian sửa' from dbo.categories where deleted_at is null";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if(data.Rows.Count > 0 )
            {
                return data;
            }
            return null;
        }

        public DataTable getAllCategoriesDeleted()
        {
            string query = "select id as 'Mã chuyên mục', name as 'Tên chuyên mục', parent_id, created_at as 'Thời gian tạo', updated_at as 'Thời gian sửa' from dbo.categories where deleted_at is not null";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                return data;
            }
            return null;
        }

        public DataTable Search(string search, string dateFrom1, string dateTo1, string dateFrom2, string dateTo2)
        {
            string query = "select id as 'Mã chuyên mục', name as 'Tên chuyên mục', parent_id, created_at as 'Thời gian tạo', updated_at as 'Thời gian cập nhật' "+
                "from dbo.categories " +
                "where name like @name and ( '' = @dateFrom1 or CONVERT(date, created_at) >= @dateFrom2 ) and ( '' = @dateTo1 or CONVERT(date, created_at) <= @dateTo2 ) and ( '' = @dateFrom3 or CONVERT(date, updated_at) >= @dateFrom4 ) and ( '' = @dateTo3 or CONVERT(date, created_at) <= @dateTo4 ) and deleted_at is null ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { search, dateFrom1, dateFrom1, dateTo1, dateTo1, dateFrom2, dateFrom2, dateTo2, dateTo2 });

            if (data.Rows.Count > 0)
            {
                return data;
            }
            else
            {
                return null;
            }
        }

        public DataTable SearchDeleted(string search, string dateFrom, string dateTo)
        {
            string query = "select id as 'Mã chuyên mục', name as 'Tên chuyên mục', parent_id, created_at as 'Thời gian tạo', updated_at as 'Thời gian cập nhật' " +
                "from dbo.categories " +
                "where name like @name and ( '' = @dateFrom1 or CONVERT(date, deleted_at) >= @dateFrom2 ) and ( '' = @dateTo1 or CONVERT(date, deleted_at) <= @dateTo2 ) and deleted_at is not null ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { search, dateFrom, dateFrom, dateTo, dateTo });

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
            string query = "update dbo.categories set deleted_at = @timeNow where id = @id ";

            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { timeNow, id }) > 0)
            {
                return true;
            }

            return false;
        }

        public bool Restore(int id, int parentID)
        {
            string query = "update dbo.categories set deleted_at = null, parent_id = @parentID where id = @id ";

            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { parentID, id }) > 0)
            {
                return true;
            }

            return false;
        }

        public bool Update(int id, int parentID, string name, string timeNow)
        {
            string query = "update dbo.categories set name = @name , parent_id = @parentID , updated_at = @updatedAt where id = @id ";
            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, parentID, timeNow, id }) > 0)
            {
                return true;
            }

            return false;
        }

        public bool Insert(string name, int parentID, string timeNow)
        {
            string query = "insert into dbo.categories (name, parent_id, created_at) values ( @name , @parentID , @timeNow )";

            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, parentID, timeNow }) > 0)
            {
                return true;
            }

            return false;
        }

        public bool CheckDestroy(int id)
        {
            string query = "select id from dbo.products where category_id = @id ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {id});

            if(data.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }

        public bool Destroy(int id)
        {
            string query = "delete from dbo.categories where id = @id ";

            if (DataProvider.Instance.ExecuteNonQuery(query, new object[] { id }) > 0)
            {
                return true;
            }

            return false;
        }
    }
}
