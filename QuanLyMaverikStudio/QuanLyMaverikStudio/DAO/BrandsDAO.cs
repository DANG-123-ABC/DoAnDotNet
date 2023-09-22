using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMaverikStudio.DAO
{
    public class BrandsDAO
    {
        private static BrandsDAO instance;

        public static BrandsDAO Instance
        {
            get { if (instance == null) instance = new BrandsDAO(); return BrandsDAO.instance; }
            private set { BrandsDAO.instance = value; }
        }

        private BrandsDAO() { }

        public DataTable GetAllBrandsForCmb()
        {
            string query = "select id, name from dbo.brands";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
    }
}
