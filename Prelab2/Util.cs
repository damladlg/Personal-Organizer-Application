using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Prelab2
{
    public static class Util
    {
        public static string getHashSha256(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }

        public static void ReadData(List<User> users, string csvpath)
        {
            var fileStream = new FileStream(csvpath, FileMode.OpenOrCreate, FileAccess.Read);
            using (var reader = new StreamReader(fileStream))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if(line!=null)
                    {
                        var values = line.Split(';');
                        string username = values[0];
                        string password = values[1];
                        string usertype = values[2];
                        string name = values[3];
                        string surname = values[4];
                        string phonenumber = values[5];
                        string address = values[6];
                        string email = values[7];
                        users.Add(new User(username, password, usertype, name, surname, phonenumber, address, email));

                    }
                }

                reader.Close();
            }
        }
        /*data.csv ye yazma*/
        public static void WriteCsv(List<User> users, string csvpath)
        {
            using (var writer = new StreamWriter(csvpath))
            {
                foreach (var wuser in users)
                {

                    writer.WriteLine(wuser.ToString());
                }
                writer.Close();
            }
        }

        /*reminder.csv ye yazma*/
        public static void WriteReminder(List<ClassReminder> reminder, string csvpath)
        {
            using (var writer = new StreamWriter(csvpath))
            {
                foreach (var reminders in reminder)
                {
                    writer.WriteLine(reminders.ToString());
                }
                writer.Close();
            }
        }

        /*reminder.csv den okuma*/
        public static void ReadReminder(List<ClassReminder> reminder, string csvpath)
        {
            var fileStream = new FileStream(csvpath, FileMode.OpenOrCreate, FileAccess.Read);
            using (var reader = new StreamReader(fileStream))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (line != null)
                    {
                        var values = line.Split(';');
                        string instruction = values[0];
                        string date = values[1];
                        string time = values[2];
                        string type = values[3];
                        string username = values[4];
                        reminder.Add(new ClassReminder(instruction, date, time, type, username));
                    }   
                }
                reader.Close();
            }
        }

        /*notes.csv ye yazma*/
        public static void WriteNotes(List<ClassNotes> notes, string csvpath)
        {
            using (var writer = new StreamWriter(csvpath))
            {
                foreach (var note in notes)
                {
                    writer.WriteLine(note.ToString());
                }
                writer.Close();
            }
        }

        /*notes.csv den okuma*/
        public static void ReadNotes(List<ClassNotes> notes, string csvpath)
        {
            var fileStream = new FileStream(csvpath, FileMode.OpenOrCreate, FileAccess.Read);
            using (var reader = new StreamReader(fileStream))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (line != null)
                    {
                        var values = line.Split(';');
                        string title = values[0];
                        string message = values[1].Replace("\\\\n", Environment.NewLine);
                        string username = values[2];
                        notes.Add(new ClassNotes(title, message, username));
                    }   
                }
                reader.Close();
            }
        }

        /*phonebook.csv ye yazma*/
        public static void WritePhonebook(List<ClassPhonebook> phonebooks, string csvpath)
        {
            using (var writer = new StreamWriter(csvpath))
            {
                foreach (var phonebook in phonebooks)
                {
                    writer.WriteLine(phonebook.ToString());
                }
                writer.Close();
            }
        }

        /*phonebook.csv den okuma*/
        public static void ReadPhonebook(List<ClassPhonebook> phonebooks, string csvpath)
        {
            var fileStream = new FileStream(csvpath, FileMode.OpenOrCreate, FileAccess.Read);
            using (var reader = new StreamReader(fileStream))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if(line!=null)
                    {
                        var values = line.Split(';');
                        string name = values[0];
                        string surname = values[1];
                        string phonenumber = values[2];
                        string email = values[3];
                        string address = values[4];
                        string description = values[5];
                        string username = values[6];
                        phonebooks.Add(new ClassPhonebook(name, surname, phonenumber, email, address, description, username));

                    }
                }
                reader.Close();
            }
        }

        /*salary.csv ye yazma*/
        public static void WriteSalary(List<ClassSalaryCalc> salaryCalcs, string csvpath)
        {
            using (var writer = new StreamWriter(csvpath))
            {
                foreach (var salaryCalc in salaryCalcs)
                {
                    writer.WriteLine(salaryCalc.ToString());
                }
                writer.Close();
            }
        }

        /*salary.csv den okuma*/
        public static void ReadSalary(List<ClassSalaryCalc> salaryCalcs, string csvpath)
        {
            var fileStream = new FileStream(csvpath, FileMode.OpenOrCreate, FileAccess.Read);
            using (var reader = new StreamReader(fileStream))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if(line!=null)
                    {
                        var values = line.Split(';');
                        string experience = values[0];
                        string province = values[1];
                        string education = values[2];
                        string foreignLanguage = values[3];
                        string managmentTask = values[4];
                        string familyStatus = values[5];
                        string username = values[6];
                        salaryCalcs.Add(new ClassSalaryCalc(experience, province, education, foreignLanguage, managmentTask, familyStatus, username));
                    
                    }
                }
                reader.Close();
            }
        }
    } 
}