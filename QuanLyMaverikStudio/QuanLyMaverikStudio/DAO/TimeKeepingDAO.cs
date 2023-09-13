using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMaverikStudio.DAO
{
    public class TimeKeepingDAO
    {
        private static TimeKeepingDAO instance;

        public static TimeKeepingDAO Instance
        {
            get { if (instance == null) instance = new TimeKeepingDAO(); return TimeKeepingDAO.instance; }
            private set { TimeKeepingDAO.instance = value; }
        }

        private TimeKeepingDAO() { }

        public bool CheckDiemDanh(int id, string time)
        {
            string query = "select * from dbo.timekeeping where user_id = @user_id and CONVERT(date, created_at) = @created_at ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id, time });

            if(data.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public bool DiemDanh(int id, string time)
        {
            string query = "insert into dbo.timekeeping (user_id, created_at) values ( @user_id , @created_at )";

            int r = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, time });

            if(r>0)
            {
                return true;
            }

            return false;
        }
    }
}
