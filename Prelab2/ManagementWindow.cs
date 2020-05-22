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
using System.Net.Mail;
using System.Net;
using System.Threading;

namespace Prelab2
{
    public partial class ManagementWindow : Form
    {
        public ManagementWindow()
        {
            InitializeComponent();
        }

        private void ManagementWindow_Load(object sender, EventArgs e)
        {
            lblProcessing.Visible = false;
            progressBarEmail.Visible = false;
            for (int i = 0; i < User.userlist.Count; i++)
            {
                int index = gridManagment.Rows.Add();
                gridManagment.Rows[index].Cells[0].Value = User.userlist[i].Username;
                gridManagment.Rows[index].Cells[1].Value = User.userlist[i].Password;
                gridManagment.Rows[index].Cells[2].Value = User.userlist[i].Usertype;
                gridManagment.Rows[index].Cells[3].Value = User.userlist[i].Email;
            }
        }

        int indexRow;
        private void gridManagment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            lblProcessing.Visible = true;
            progressBarEmail.Visible = true;
            if (!backgroundProcess.IsBusy)
                backgroundProcess.RunWorkerAsync();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < User.userlist.Count(); i++)
            {
                if ((gridManagment.Rows[indexRow].Cells[0].Value == User.userlist[i].Username)  && (gridManagment.Rows[indexRow].Cells[1].Value == User.userlist[i].Password))
                {
                    User.userlist[i].Username=gridManagment.Rows[indexRow].Cells[0].Value.ToString();
                    User.userlist[i].Password = gridManagment.Rows[indexRow].Cells[1].Value.ToString();
                    User.userlist[i].Usertype = gridManagment.Rows[indexRow].Cells[2].Value.ToString();
                    User.userlist[i].Email = gridManagment.Rows[indexRow].Cells[3].Value.ToString();
                    Util.WriteCsv(User.userlist, @"Data.csv");
                }
            }  
        }

        private string GenerationRandomPassword() // gönderilecek sifre icin rastgele karakterler olusturuyor
        {
            Random rastgele = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 8; i++)
            {
                int ascii = rastgele.Next(32, 127);
                char karakter = Convert.ToChar(ascii);
                sb.Append(karakter);
            }
            return (sb.ToString());
        }

        private void backgroundProcess_DoWork(object sender, DoWorkEventArgs e)
        {
            string newPassword = GenerationRandomPassword();
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;
            sc.Credentials = new NetworkCredential(LoginedUser.getInstance().User.Email, "apk12345"); // email gönderenin yani adminin maili ve sifresi 
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(LoginedUser.getInstance().User.Email);
            mail.To.Add(gridManagment.Rows[indexRow].Cells[3].Value.ToString()); // sifre gönderilecek yani herhangi bir kullanıcının maili, gridden secilenin.
            mail.Subject = "Reset Email";
            mail.IsBodyHtml = true;
            mail.Body = newPassword;

            for (int i = 1; i <= 10; i++) 
            {
                if (backgroundProcess.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundProcess.ReportProgress(0);
                    return;
                }
                else
                {
                    Thread.Sleep(1000);
                    backgroundProcess.ReportProgress(i*10);
                }
            }
            sc.Send(mail);
        }

        private void backgroundProcess_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Cancelled) MessageBox.Show("Stopped.");
            else if (e.Error != null) MessageBox.Show(e.Error.Message);
            else MessageBox.Show("Your message has been sent.");
        }

        private void backgroundProcess_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarEmail.Value = e.ProgressPercentage;
            lblProcessing.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void ManagementWindow_FormClosing(object sender, FormClosingEventArgs e)
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

        private void progressBarEmail_Click(object sender, EventArgs e)
        {

        }

        private void gridManagment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblProcessing_Click(object sender, EventArgs e)
        {

        }
    }
}