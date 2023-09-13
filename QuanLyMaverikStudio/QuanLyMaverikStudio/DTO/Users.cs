using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMaverikStudio.DTO
{
    public class Users
    {
        public Users(
            int id, 
            string name, 
            string address, 
            string email, 
            string phonenumber, 
            string account, 
            string password, 
            double salary, 
            string dateOfBirth, 
            int groupID,
            string createdAt,
            string updatedAt,
            string deletedAt
        ) {
            this.ID= id;
            this.Name= name;
            this.Address= address;
            this.Email= email;
            this.Phonenumber = phonenumber;
            this.Account= account;
            this.Password= password;
            this.Salary= salary;
            this.DateOfBirth= dateOfBirth;
            this.GroupID = groupID;
            this.CreatedAt= createdAt;
            this.UpdatedAt= updatedAt;
            this.DeletedAt= deletedAt;
        }
        public Users(
            string name,
            string address,
            string email,
            string phonenumber,
            string account,
            string password,
            double salary,
            string dateOfBirth,
            int groupID,
            string createdAt
        )
        {
            this.Name = name;
            this.Address = address;
            this.Email = email;
            this.Phonenumber = phonenumber;
            this.Account = account;
            this.Password = password;
            this.Salary = salary;
            this.DateOfBirth = dateOfBirth;
            this.GroupID = groupID;
            this.CreatedAt = createdAt;
        }
        public Users(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Address = row["address"].ToString();
            this.Email = row["email"].ToString();
            this.Phonenumber = row["phone_number"].ToString();
            this.Account = row["account"].ToString();
            this.Password = row["password"].ToString();
            this.Salary = (double)row["salary"];
            DateTime dateFromDataTable = (DateTime)row["date_of_birth"];
            this.DateOfBirth = dateFromDataTable.ToString("dd/MM/yyyy");
            this.GroupID = (int)row["group_id"];
            this.CreatedAt = row["created_at"].ToString();
            this.UpdatedAt = row["updated_at"].ToString();
            this.DeletedAt = row["deleted_at"].ToString();
        }

        private int iD;
        public int ID { get => iD; set => iD = value; }

        private string name;
        public string Name { get => name; set => name = value; }

        private string address;
        public string Address { get => address;set => address = value; }

        private string email;
        public string Email { get => email; set=> email = value; }
        
        private string phonenumber;
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }

        private string account;
        public string Account { get => account; set => account = value; }

        private string password;
        public string Password { get => password; set => password = value; }

        private double salary;
        public double Salary { get => salary; set => salary = value; }

        private string dateOfBirth;
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }

        private int groupID;
        public int GroupID { get => groupID; set => groupID = value; }

        private string createdAt;
        public string CreatedAt { get => createdAt; set => createdAt = value; }

        private string updatedAt;
        public string UpdatedAt { get => updatedAt; set => updatedAt = value; }

        private string deletedAt;
        public string DeletedAt { get => deletedAt; set => deletedAt = value; }
    }
}
