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
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
        }

        int indexRow;
        private void gridNotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = gridNotes.Rows[indexRow];
            txtTitle.Text = row.Cells[0].Value.ToString();
            txtMessage.Text = row.Cells[1].Value.ToString();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string message = txtMessage.Text.Replace(Environment.NewLine, "\\\\n");
            string username = LoginedUser.getInstance().User.Username;

            int index = gridNotes.Rows.Add();
            gridNotes.Rows[index].Cells[0].Value = txtTitle.Text;
            gridNotes.Rows[index].Cells[1].Value = txtMessage.Text;
            User.noteList.Add(new ClassNotes(title, message, username));
            Util.WriteNotes(User.noteList, @"notes.csv");
        }

        private void Notes_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < User.noteList.Count; i++)
            {
                if (User.noteList[i].Username == LoginedUser.getInstance().User.Username)
                {
                    int index = gridNotes.Rows.Add();
                    gridNotes.Rows[index].Cells[0].Value = User.noteList[i].Title;
                    gridNotes.Rows[index].Cells[1].Value = User.noteList[i].Message;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < User.noteList.Count(); i++)
            {
                if ((gridNotes.Rows[indexRow].Cells[0].Value == User.noteList[i].Title) && (gridNotes.Rows[indexRow].Cells[1].Value == User.noteList[i].Message))
                {
                    gridNotes.Rows.RemoveAt(indexRow);
                    User.noteList.Remove(User.noteList[i]);
                    Util.WriteNotes(User.noteList, @"notes.csv");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < User.noteList.Count(); i++)
            {
                if ((gridNotes.Rows[indexRow].Cells[0].Value == User.noteList[i].Title) && (gridNotes.Rows[indexRow].Cells[1].Value == User.noteList[i].Message))
                {
                    gridNotes.Rows[indexRow].Cells[0].Value = User.noteList[i].Title = txtTitle.Text;
                    gridNotes.Rows[indexRow].Cells[1].Value = User.noteList[i].Message = txtMessage.Text.Replace(Environment.NewLine, "\\\\n");
                    Util.WriteNotes(User.noteList, @"notes.csv");
                }
            }
        }

        private void Notes_FormClosing(object sender, FormClosingEventArgs e)
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