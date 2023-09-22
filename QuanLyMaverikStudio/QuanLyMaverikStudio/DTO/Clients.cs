using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMaverikStudio.DTO
{
    public class Clients
    {
        public Clients(
            string name,
            string address,
            string gender,
            string email,
            string phonenumber,
            string account,
            string password,
            string dateOfBirth,
            string createdAt
        )
        {
            this.Name = name;
            this.Address = address;
            this.Gender = gender;
            this.Email = email;
            this.Phonenumber = phonenumber;
            this.Account = account;
            this.Password = password;
            this.DateOfBirth = dateOfBirth;
            this.CreatedAt = createdAt;
        }

        private int iD;
        public int ID { get => iD; set => iD = value; }

        private string name;
        public string Name { get => name; set => name = value; }

        private string gender;
        public string Gender { get => gender; set => gender = value; }

        private string address;
        public string Address { get => address; set => address = value; }

        private string email;
        public string Email { get => email; set => email = value; }

        private string phonenumber;
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }

        private string account;
        public string Account { get => account; set => account = value; }

        private string password;
        public string Password { get => password; set => password = value; }

        private string dateOfBirth;
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }

        private string createdAt;
        public string CreatedAt { get => createdAt; set => createdAt = value; }

        private string updatedAt;
        public string UpdatedAt { get => updatedAt; set => updatedAt = value; }

        private string deletedAt;
        public string DeletedAt { get => deletedAt; set => deletedAt = value; }
    }
}
