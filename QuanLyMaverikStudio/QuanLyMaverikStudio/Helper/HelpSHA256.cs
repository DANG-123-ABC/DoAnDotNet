using QuanLyMaverikStudio.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace QuanLyMaverikStudio.Helper
{
    public class HelpSHA256
    {
        private static HelpSHA256 instance;

        public static HelpSHA256 Instance
        {
            get { if (instance == null) instance = new HelpSHA256(); return HelpSHA256.instance; }
            private set { HelpSHA256.instance = value; }
        }

        private HelpSHA256() { }

        public string Hash(string input, string salt = "")
        {
            // Tạo đối tượng SHA-256
            using (SHA256 sha256 = SHA256.Create())
            {
                // Chuyển đổi chuỗi thành mảng byte
                byte[] bytes = Encoding.UTF8.GetBytes(input + salt);

                // Tính toán giá trị băm
                byte[] hashBytes = sha256.ComputeHash(bytes);

                // Chuyển đổi giá trị băm thành chuỗi hex
                StringBuilder hashBuilder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    hashBuilder.Append(hashBytes[i].ToString("x2"));
                }

                return hashBuilder.ToString();
            }
        }
    }
}
