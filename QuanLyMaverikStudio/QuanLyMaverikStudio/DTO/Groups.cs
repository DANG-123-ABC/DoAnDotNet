using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMaverikStudio.DTO
{
    public class Groups
    {
        public Groups(
            int id,
            string name,
            string permission,
            string createdAt,
            string updatedAt,
            string deletedAt
        )
        {
            this.ID = id;
            this.Name = name;
            this.Permission = permission;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.DeletedAt = deletedAt;
        }
        private int iD;
        public int ID { get => iD; set => iD = value; }

        private string name;
        public string Name { get => name; set => name = value; }

        private string permission;
        public string Permission { get => permission; set => permission = value; }

        private string createdAt;
        public string CreatedAt { get => createdAt; set => createdAt = value; }

        private string updatedAt;
        public string UpdatedAt { get => updatedAt; set => updatedAt = value; }

        private string deletedAt;
        public string DeletedAt { get => deletedAt; set => deletedAt = value; }
    }
}
