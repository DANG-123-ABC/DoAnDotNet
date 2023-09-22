using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMaverikStudio.Helper
{
    public class Storage
    {
        private static int idClient = -1;
        public static int IdClient { get => idClient; set => idClient = value; }

        private static string nameClient = "";
        public static string NameClient { get => nameClient; set => nameClient = value; }

        private static string phoneNumberClient = "";
        public static string PhoneNumberClient { get => phoneNumberClient; set => phoneNumberClient = value; }
        public static void ResetClient()
        {
            idClient = -1;
            nameClient = "";
            phoneNumberClient = "";
        }
    }
}
