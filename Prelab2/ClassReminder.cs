using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prelab2
{
    public class ClassReminder
    {
        private string type;
        private string instruction;
        private string date;
        private string time;
        private string username;

        public ClassReminder() { }

        public ClassReminder( String instruction,  String date, String time, String type, String username)
        {
            this.Instruction = instruction;
            this.Date = date;
            this.Time = time;
            this.type = type;
            this.Username = username;
        }

        public string Type { get => type; set => type = value; }
        public string Date { get => date; set => date = value; }
        public string Time { get => time; set => time = value; }
        public string Instruction { get => instruction; set => instruction = value; }
        public string Username { get => username; set => username = value; }

        public override string ToString()
        {
            return Instruction + ";"  + Date + ";" + Time + ";" + Type + ";" + Username;
        }
    }
}