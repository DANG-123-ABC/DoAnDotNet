using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMaverikStudio.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        private string connectStr = "Data Source = PC\\TAVANTHANHHUNG; Initial Catalog = QuanLyMaverikStudio; Integrated Security = SSPI";
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; } 
            private set { DataProvider.instance = value; }
        }

        private DataProvider()
        {
            
        }

        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            try
            {
                DataTable data = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectStr))
                {
                    // Mở kết nối
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    if(parameters != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach(string item in listPara)
                        {
                            if(item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameters[i]);
                                i++;
                            }
                        }    
                    }    

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                    dataAdapter.Fill(data);

                    connection.Close();

                    return data;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public int ExecuteNonQuery(string query, object[] parameters = null)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectStr))
                {
                    // Mở kết nối
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    if (parameters != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameters[i]);
                                i++;
                            }
                        }
                    }
                    int r = command.ExecuteNonQuery();

                    connection.Close();

                    return r;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
    }
}
