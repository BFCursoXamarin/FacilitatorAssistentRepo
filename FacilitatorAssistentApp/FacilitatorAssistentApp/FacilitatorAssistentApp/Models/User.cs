using System;
using SQLite;

namespace FacilitatorAssistentApp.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int idUser { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string age { get; set; }

        public DateTime dateCreation { get; set; }
    }
}

