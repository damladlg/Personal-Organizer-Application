using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prelab2
{
    public class ClassNotes
    {
        private string title;
        private string message;
        private string username;

        public ClassNotes()
        {
        }
   
        public ClassNotes(String title, String message, String username)
        {
            this.Username = username;
            this.Title = title;
            this.Message = message;

        }

        public string Username { get => username; set => username = value; }
        public string Title { get => title; set => title = value; }
        public string Message { get => message; set => message = value; }

        public override string ToString()
        {
            return Title + ";" + Message + ";" + Username;
        }
    }
}