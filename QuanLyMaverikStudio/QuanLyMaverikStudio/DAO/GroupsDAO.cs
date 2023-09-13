using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMaverikStudio.DAO
{
    public class GroupsDAO
    {
        private static GroupsDAO instance;

        public static GroupsDAO Instance
        {
            get { if (instance == null) instance = new GroupsDAO(); return GroupsDAO.instance; }
            private set { GroupsDAO.instance = value; }
        }

        private GroupsDAO() { }

        public DataTable GetAllGroups()
        {
            string query = "select * from dbo.groups where deleted_at is null";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if(data.Rows.Count > 0)
            {
                return data;
            }
            else
            {
                return null;
            }
        }
    }
}
