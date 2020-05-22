using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Prelab2
{
    public class User
    {
        private String username;
        private String password;
        private String usertype;
        private String name;
        private String surname;
        private String phoneNumber;
        private String address;
        private String email;
        public static List<ClassPhonebook> phonebookList = new List<ClassPhonebook>();
        public static List<ClassNotes> noteList = new List<ClassNotes>();
        public static List<personalinformation> personalInfoList = new List<personalinformation>();
        public static List<ClassSalaryCalc> salaryInfoList = new List<ClassSalaryCalc>();
        public static List<ClassReminder> reminderList = new List<ClassReminder>();
        public static List<User> userlist = new List<User>();

        public User()
        {
        }

        public User(String username, String password,String usertype, String name, String surname, String phoneNumber, String address, String email)
        {
            this.Username = username;
            this.Password = password;
            this.Usertype = usertype;
            this.Name = name;
            this.Surname = surname;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this.Email = email;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Usertype { get => usertype; set => usertype = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }

        public bool IsValid(string username, string password)
        {
            return this.Username.Equals(username) && this.Password.Equals(Util.getHashSha256(password));
        }

        public override string ToString()
        {
            return Username + ";" + Password + ";" + Usertype+";"+ Name + ";" + Surname + ";" + PhoneNumber + ";" + Address + ";" + Email;
        }
    }
}