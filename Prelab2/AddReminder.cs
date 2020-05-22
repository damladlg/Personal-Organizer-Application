using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prelab2
{
    public partial class AddReminder : Form
    {
        public AddReminder()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string type = cmbBoxType.Text;
            string date = dateTimePicker.Text;
            string time = cmbBoxHour.Text + ":" + cmbBxMinute.Text;
            string instruction = txtInstruction.Text;
            string username = LoginedUser.getInstance().User.Username;
            User.reminderList.Add(new ClassReminder(instruction, date, time, type, username));
            Util.WriteReminder(User.reminderList, @"reminder.csv");

            this.Close();
            Reminder reminder = new Reminder();
            reminder.Show();
        }
    }
}