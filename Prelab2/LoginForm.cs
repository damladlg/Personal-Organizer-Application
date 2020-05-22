using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.IO;

namespace Prelab2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            Util.ReadData(User.userlist, @"Data.csv");
            Util.ReadNotes(User.noteList, @"notes.csv");
            Util.ReadReminder(User.reminderList, @"reminder.csv");
            Util.ReadPhonebook(User.phonebookList, @"phone.csv");
            Util.ReadSalary(User.salaryInfoList, @"salaryInfo.csv");
        }

        public static string username;
        public static string password;
       
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            username = usernameBox.Text;
            password = passwordBox.Text;
            infolabel.Visible = true;
            if (remembercheckBox.Checked == true)
            {
                Properties.Settings.Default.username = usernameBox.Text;
                Properties.Settings.Default.password = passwordBox.Text;
                Properties.Settings.Default.Save();
            }
            if (remembercheckBox.Checked == false)
            {
                Properties.Settings.Default.username = "";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.Save();
            }

            for (int i = 0; i < User.userlist.Count(); i++)
            {
                User user_data = User.userlist[i];
                if (user_data.IsValid(username, password))
                {
                    LoginedUser.getInstance().User = user_data;
                    infolabel.ForeColor = Color.Green;
                    infolabel.Text = "Correct.";
                    remembercheckBox.Checked = false;
                    EntryTime.Enabled = true;
                    return;
                }
                
                infolabel.ForeColor = Color.Red;
                infolabel.Text = "Not Correct.If you are not a member, please register first.";
            }
            usernameBox.Clear();
            passwordBox.Clear();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.username != string.Empty)
            {
                usernameBox.Text = Properties.Settings.Default.username;
                passwordBox.Text = Properties.Settings.Default.password;
                remembercheckBox.Checked = true;
            }
        }

        private void EntryTime_Tick(object sender, EventArgs e)
        {
            PersonalOrganizer newuser = new PersonalOrganizer();
            newuser.Show();
            EntryTime.Enabled = false;
            this.Hide();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            SignUpForm frm = new SignUpForm();
            frm.Show();
            this.Hide();
        }

        private void usernameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only alphabetic characters.");
            }    
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show(this, "Really want to exit??", "Closing", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                }
            }
        }
    }
}