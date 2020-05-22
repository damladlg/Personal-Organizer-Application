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
using System.Collections;

namespace Prelab2
{
    public partial class PersonalOrganizer : Form
    {
        public PersonalOrganizer()
        {
            InitializeComponent();
        }

        private void PersonalOrganizer_Load(object sender, EventArgs e)
        {
            
            if (LoginedUser.getInstance().User.Usertype == "admin")
            {
                btnAdmin.Visible = true;
                pictureManagement.Visible = true;
            }
            else
            {
                btnAdmin.Visible = false;
                pictureManagement.Visible = false;
            }
        }

        private void Save_asBtn_Click_(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "TSV Dosyası|*.tsv";
            save.OverwritePrompt = true;
            save.CreatePrompt = true;
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter File = new StreamWriter(save.FileName);
                foreach (User user in User.userlist)
                {
                    File.WriteLine(user.ToString());
                }
                File.Close();
            }
        }

        private void PhoneBookBtn_Click(object sender, EventArgs e)
        {
            PhoneBook frm = new PhoneBook();
            frm.Show();
            this.Hide();
        }

        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            if (LoginedUser.getInstance().User.Usertype == "admin")
            {
                ManagementWindow newadmin = new ManagementWindow();
                newadmin.Show();
                this.Hide();
            }
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            Notes notes = new Notes();
            notes.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonalInformation newForm = new PersonalInformation();
            newForm.Show();
            this.Hide();
        }

        private void btnSalaryCalculator_Click(object sender, EventArgs e)
        {
            SalaryCalculator newForm = new SalaryCalculator();
            newForm.Show();
            this.Hide();
        }

        private void btnReminder_Click(object sender, EventArgs e)
        {
            Reminder reminder = new Reminder();
            reminder.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["username"] = "";
            Properties.Settings.Default["sifre"] = "";
            LoginForm.username = "";
            LoginForm.password = "";
            Properties.Settings.Default.Save();
            this.Hide();
        }

        private void PersonalOrganizer_FormClosing(object sender, FormClosingEventArgs e)
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
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                }
            }
        }
    }
}