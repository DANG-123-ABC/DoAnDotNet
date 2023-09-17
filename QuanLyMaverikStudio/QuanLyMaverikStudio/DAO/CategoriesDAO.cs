using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public DataTable Search(string search)
        {
            string query = "select id as 'Mã chuyên mục', name as 'Tên chuyên mục', parent_id, created_at as 'Thời gian tạo', updated_at as 'Thời gian cập nhật' "+
                "from dbo.categories " +
                "where ( name like @search2 or CONVERT(date, created_at) like @search3 or CONVERT(date, updated_at) like @search4 ) and deleted_at is null ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { search, search, search });

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
    }
}
