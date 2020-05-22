using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Drawing;

namespace Prelab2
{
    public class personalinformation
    {
        private String name;
        private String surname;
        private String phoneNumber;
        private String address;
        private String email;

        public void SetMemento(MementoPersonalInfo memento)
        {
            Name = memento.Name;
            Surname = memento.Surname;
            PhoneNumber = memento.PhoneNumber;
            Address = memento.Address;
            Email = memento.Email;
        }

        public MementoPersonalInfo CreateMemento()
        {
            return new MementoPersonalInfo(name, surname, phoneNumber, address, email);
        }

        public personalinformation(String name, String surname, String phoneNumber, String address, String email)
        {
            this.name = name;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.email = email;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }

        public string ToString()
        {
            return Name + ";" + Surname + ";" + PhoneNumber + ";" + Address + ";" + Email;
        }
    }
}