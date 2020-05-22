using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prelab2
{
    public class LoginedUser
    {
        private User user;
        private personalinformation personalInfo;
        private ClassReminder reminder;
        private static LoginedUser loginedUser;

        public User User { get => user; set =>user =value; }
        public personalinformation personalinformation { get => personalInfo; set => personalInfo = value; }
        public ClassReminder Reminder { get => reminder; set => reminder = value; }

        public static LoginedUser getInstance()
        {
            if (loginedUser == null)
            {
                loginedUser = new LoginedUser();
            }
            return loginedUser;
        }
    }
}