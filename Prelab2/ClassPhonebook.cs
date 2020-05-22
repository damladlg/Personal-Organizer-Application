using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prelab2
{
    public class ClassPhonebook
    {
        private string phonenumber;
        private string name;
        private string surname;
        private string email;
        private string address;
        private string description;
        private string username;

        public ClassPhonebook() { }

        public ClassPhonebook( String name, String surname, String phonenumber, String email, String address, String description, String username)
        {
            this.Phonenumber = phonenumber;
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.Address = address;
            this.Description = description;
            this.Username = username;
        }

        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public string Description { get => description; set => description = value; }
        public string Username { get => username; set => username = value; }

        public override string ToString()
        {
            return  Name + ";" + Surname + ";" + Phonenumber + ";" + Email + ";" + Address + ";" + Description + ";" + Username;
        }
    }
}