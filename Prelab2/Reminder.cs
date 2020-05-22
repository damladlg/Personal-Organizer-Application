using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Prelab2
{
    public partial class Reminder : Form
    {
        public Reminder()
        {
            InitializeComponent();
        }
        private void timerTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString() + "\n" + DateTime.Now.ToLongDateString();
            lblTime.Visible = true;
            //Shake(ActiveForm);
        }

        private static void Shake(Form form)
        {
            int shakecount = 0;
            if (shakecount >= 2000)
            {
                shakecount = 0;
            }
            for (int i = 0; i < 2000; i++)
            {
                form.Left -= 4;
                form.Left += 4;
            }
        }
        
        private void Reminder_Load(object sender, EventArgs e)
        {
            grpDetails.Visible = false;
            for (int i = 0; i < User.reminderList.Count; i++)
            {
                if (User.reminderList[i].Username == LoginedUser.getInstance().User.Username)
                {
                    int index = gridReminder.Rows.Add();
                    gridReminder.Rows[index].Cells[0].Value = User.reminderList[i].Date;
                    gridReminder.Rows[index].Cells[1].Value = User.reminderList[i].Instruction;
                    gridReminder.Rows[index].Cells[2].Value = User.reminderList[i].Type;
                    gridReminder.Rows[index].Cells[3].Value = User.reminderList[i].Time;
                }
            }
        }

        private void btnAddRem_Click(object sender, EventArgs e)
        {
            AddReminder addReminder = new AddReminder();
            addReminder.Show();
            this.Hide();
        }

        int indexRow;
        private void gridReminder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grpDetails.Visible = true;
            string[] values;
            indexRow = e.RowIndex;
            DataGridViewRow row = gridReminder.Rows[indexRow];
            dateTimePicker.Text = row.Cells[0].Value.ToString();
            txtInstruction.Text = row.Cells[1].Value.ToString();
            cmbBoxType.Text = row.Cells[2].Value.ToString();
            values = row.Cells[3].Value.ToString().ToString().Split(':');
            cmbBoxHour.Text = values[0].ToString();
            cmbBxMinute.Text = values[1].ToString();
        }
        private void gridReminder_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < User.reminderList.Count(); i++)
            {
                if ((gridReminder.Rows[indexRow].Cells[0].Value == User.reminderList[i].Date) && (gridReminder.Rows[indexRow].Cells[1].Value == User.reminderList[i].Instruction) && (gridReminder.Rows[indexRow].Cells[2].Value == User.reminderList[i].Type))
                {
                    gridReminder.Rows[indexRow].Cells[0].Value = User.reminderList[i].Date = dateTimePicker.Text;
                    gridReminder.Rows[indexRow].Cells[1].Value = User.reminderList[i].Instruction = txtInstruction.Text;
                    gridReminder.Rows[indexRow].Cells[2].Value = User.reminderList[i].Type = cmbBoxType.Text;
                    gridReminder.Rows[indexRow].Cells[3].Value = User.reminderList[i].Time = cmbBoxHour.Text + ":" + cmbBxMinute.Text;
                    Util.WriteReminder(User.reminderList, @"reminder.csv");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < User.reminderList.Count(); i++)
            {
                if ((gridReminder.Rows[indexRow].Cells[0].Value == User.reminderList[i].Date) && (gridReminder.Rows[indexRow].Cells[1].Value == User.reminderList[i].Instruction) && (gridReminder.Rows[indexRow].Cells[2].Value == User.reminderList[i].Type))
                {
                    gridReminder.Rows.RemoveAt(indexRow);
                    User.reminderList.Remove(User.reminderList[i]);
                    Util.WriteReminder(User.reminderList, @"reminder.csv");
                }
            }
        }

        private void Reminder_FormClosing(object sender, FormClosingEventArgs e)
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
                    PersonalOrganizer personalOrganizer = new PersonalOrganizer();
                    personalOrganizer.Show();
                }
            }
        }
    }
}