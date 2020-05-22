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
    public partial class PersonalInformation : Form
    {
        public PersonalInformation()
        {
            InitializeComponent();
        }

        LoginedUser lu = LoginedUser.getInstance();
        private void PersonalInformation_Load(object sender, EventArgs e)
        {
            txtName.Text = lu.User.Name;
            txtSurname.Text = lu.User.Surname;
            txtPhoneNumber.Text = lu.User.PhoneNumber;
            txtAddress.Text = lu.User.Address;
            txtEmail.Text = lu.User.Email;
            txtPassword.Text = LoginForm.password;
            pictureProfil.Image = Image.FromFile(@"Resources\ProfilePictures\" + LoginForm.username+".jpg");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < User.userlist.Count(); i++)
            {
                if (User.userlist[i].Username == lu.User.Username)
                {
                    User.userlist[i].Name = txtName.Text;
                    User.userlist[i].Surname = txtSurname.Text;
                    User.userlist[i].PhoneNumber = txtPhoneNumber.Text;
                    User.userlist[i].Address = txtAddress.Text;
                    User.userlist[i].Email = txtEmail.Text;
                    User.userlist[i].Password = Util.getHashSha256(txtPassword.Text);
                    Util.WriteCsv(User.userlist, @"data.csv");
                }
            }
        }

        Bitmap image;
        string base64Text;
        private void btnPhoto_Click(object sender, EventArgs e)
        {
            openFileDialogPicture.Multiselect = false;
            openFileDialogPicture.Filter = "All Files |*.png; *.jpeg;*.jpg| PNG Files (*.png)|*.png|JPEG Files (*.jpeg)|*.jpeg|JPG Files (*.jpg)|*.jpg";
            openFileDialogPicture.Title = "Select File";

            if (openFileDialogPicture.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(openFileDialogPicture.FileName);
                pictureProfil.Image = (Image)image;

                byte[] imageArray = System.IO.File.ReadAllBytes(openFileDialogPicture.FileName);
                base64Text = Convert.ToBase64String(imageArray);

                string destPath = Application.StartupPath + @"\Resources\ProfilePictures\" + LoginForm.username + ".jpg";
                Directory.CreateDirectory(Application.StartupPath + @"\Resources\ProfilePictures\");
                File.Copy(openFileDialogPicture.FileName, destPath, true);
            }

            string path = @"photo.csv";
            using (StreamWriter stream = File.CreateText(path))
            {
                stream.Write(base64Text);
            }
            txtPhoto.Text = openFileDialogPicture.FileName.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }

        private void PersonalInformation_FormClosing(object sender, FormClosingEventArgs e)
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