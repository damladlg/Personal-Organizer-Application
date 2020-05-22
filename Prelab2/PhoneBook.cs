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
using System.Text.RegularExpressions;

namespace Prelab2
{
    public partial class PhoneBook : Form
    {
        public PhoneBook()
        {
            InitializeComponent();
        }
        int indexRow = 0;
        private void gridPhonebk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex; // get the selected Row Index
            DataGridViewRow row = gridPhonebk.Rows[indexRow];
            NameBox.Text = row.Cells[0].Value.ToString();
            SurnameBox.Text = row.Cells[1].Value.ToString();
            PhoneNumBox.Text = row.Cells[2].Value.ToString();
            MailBox.Text = row.Cells[3].Value.ToString();
            AddressBox.Text = row.Cells[4].Value.ToString();
            DescriptionBox.Text = row.Cells[5].Value.ToString();
        }

        private void PhoneBook_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < User.phonebookList.Count(); i++)
            {
                if ((User.phonebookList[i].Username == LoginedUser.getInstance().User.Username))
                {
                    int index = gridPhonebk.Rows.Add();
                    gridPhonebk.Rows[index].Cells[0].Value = User.phonebookList[i].Name;
                    gridPhonebk.Rows[index].Cells[1].Value = User.phonebookList[i].Surname;
                    gridPhonebk.Rows[index].Cells[2].Value = User.phonebookList[i].Phonenumber;
                    gridPhonebk.Rows[index].Cells[3].Value = User.phonebookList[i].Email;
                    gridPhonebk.Rows[index].Cells[4].Value = User.phonebookList[i].Address;
                    gridPhonebk.Rows[index].Cells[5].Value = User.phonebookList[i].Description;
                }
            }
        }

        private void CreateBttn_Click(object sender, EventArgs e)
        {
            string phonenumber = PhoneNumBox.Text;
            string name = NameBox.Text;
            string surname = SurnameBox.Text;
            string email = MailBox.Text;
            string address = AddressBox.Text;
            string description = DescriptionBox.Text;
            string username = LoginedUser.getInstance().User.Username;

            int index = gridPhonebk.Rows.Add();
            gridPhonebk.Rows[index].Cells[0].Value = name;
            gridPhonebk.Rows[index].Cells[1].Value = surname;
            gridPhonebk.Rows[index].Cells[2].Value = phonenumber;
            gridPhonebk.Rows[index].Cells[3].Value = email;
            gridPhonebk.Rows[index].Cells[4].Value = address;
            gridPhonebk.Rows[index].Cells[5].Value = description;

            User.phonebookList.Add(new ClassPhonebook( name, surname, phonenumber, email, address, description, username));
            Util.WritePhonebook(User.phonebookList, @"phone.csv");
        }

        private void UpdateBttn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < User.phonebookList.Count(); i++)
            {
                if ((gridPhonebk.Rows[indexRow].Cells[0].Value == User.phonebookList[i].Name) && (gridPhonebk.Rows[indexRow].Cells[1].Value == User.phonebookList[i].Surname) && (gridPhonebk.Rows[indexRow].Cells[2].Value == User.phonebookList[i].Phonenumber) && (gridPhonebk.Rows[indexRow].Cells[3].Value == User.phonebookList[i].Email) && (gridPhonebk.Rows[indexRow].Cells[4].Value == User.phonebookList[i].Address) && (gridPhonebk.Rows[indexRow].Cells[5].Value == User.phonebookList[i].Description) && (User.phonebookList[i].Username == LoginedUser.getInstance().User.Username))
                {
                    gridPhonebk.Rows[indexRow].Cells[0].Value = User.phonebookList[i].Name = NameBox.Text;
                    gridPhonebk.Rows[indexRow].Cells[1].Value = User.phonebookList[i].Surname = SurnameBox.Text;
                    gridPhonebk.Rows[indexRow].Cells[2].Value = User.phonebookList[i].Phonenumber = PhoneNumBox.Text;
                    gridPhonebk.Rows[indexRow].Cells[3].Value = User.phonebookList[i].Email = MailBox.Text;
                    gridPhonebk.Rows[indexRow].Cells[4].Value = User.phonebookList[i].Address = AddressBox.Text;
                    gridPhonebk.Rows[indexRow].Cells[5].Value = User.phonebookList[i].Description = DescriptionBox.Text;
                    Util.WritePhonebook(User.phonebookList, @"phone.csv");
                }
            }
        }

        private void DeleteBttn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < User.phonebookList.Count(); i++)
            {
                if ((gridPhonebk.Rows[indexRow].Cells[0].Value == User.phonebookList[i].Name) && (gridPhonebk.Rows[indexRow].Cells[1].Value == User.phonebookList[i].Surname) && (gridPhonebk.Rows[indexRow].Cells[2].Value == User.phonebookList[i].Phonenumber) && (gridPhonebk.Rows[indexRow].Cells[3].Value == User.phonebookList[i].Email) && (gridPhonebk.Rows[indexRow].Cells[4].Value == User.phonebookList[i].Address) && (gridPhonebk.Rows[indexRow].Cells[5].Value == User.phonebookList[i].Description) && (User.phonebookList[i].Username == LoginedUser.getInstance().User.Username))
                {

                    gridPhonebk.Rows.RemoveAt(indexRow);
                    User.phonebookList.Remove(User.phonebookList[i]);
                    Util.WritePhonebook(User.phonebookList, @"phone.csv");
                }
            }
            if (gridPhonebk.CurrentRow.Cells[0].Value != null)
            {
                gridPhonebk.Rows.RemoveAt(gridPhonebk.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Please select the line to be deleted.");
            }
        }

        private void PhoneNumBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers");
            }
        }

        private bool IsValidEmail(string strIn)
        {
            return Regex.IsMatch(strIn, "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$");
        }

        private void MailBox_Leave(object sender, EventArgs e)
        {
            if (!IsValidEmail(MailBox.Text))
            {
                MessageBox.Show("Please enter a valid email.");
            }
        }

        private void PhoneBook_FormClosing(object sender, FormClosingEventArgs e)
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